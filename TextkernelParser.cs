namespace Evolution.Textkernel
{
    using Extract;
    using Microsoft.Extensions.Logging;
    using Models;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Xml.Linq;
    using System.Xml.Serialization;

    class TextkernelParser : ITextkernelParser
    {
        const string ApiRoute = "/match/soap/extract";

        readonly ILogger logger;

        string address;
        string account;
        string username;
        string password;

        entry[] entries = new entry[0];

        XmlSerializer serializer = new XmlSerializer(typeof(Profile));

        public TextkernelParser(ILoggerFactory logger, string address, string account, string username, string password)
        {
            this.logger = logger.CreateLogger<TextkernelParser>();

            address = address.TrimEnd('/');
            if (address.EndsWith(ApiRoute))
                this.address = address;
            else
                this.address = address + ApiRoute;

            this.account = account;
            this.username = username;
            this.password = password;

            // Add warnings when we get unexpected XML content not in the serialisation model
            this.serializer.UnknownElement += (sender, e) =>
                this.logger.LogWarning("Unknown Element - n:{LineNumber}/p:{LinePosition}, {Element}", e.LineNumber, e.LinePosition, e.Element.Name);

            this.serializer.UnknownAttribute += (sender, e) =>
                this.logger.LogWarning("Unknown Attribute - n:{LineNumber}/p:{LinePosition}, {Attr}", e.LineNumber, e.LinePosition, e.Attr.Name);

            this.serializer.UnreferencedObject += (sender, e) =>
                this.logger.LogWarning("Unreferenced Object: {ID} {Object}", e.UnreferencedId, e.UnreferencedObject);
        }

        async Task<Profile> ITextkernelParser.Parse(byte[] file, string filename)
        {
            this.logger.LogInformation("Parsing {FileLength} Bytes", file.Length);

            var sw = new Stopwatch();
            sw.Start();

            // Create the auto-generated Extract service client, pointing to the configured address
            var extractService = new ExtractInterfaceClient(ExtractInterfaceClient.EndpointConfiguration.ExtractImplPort, this.address);

            // Call the WCF generated from the SOAP WSDL
            var result = await extractService.extractAdvancedAsync(this.account, this.username, this.password, this.entries, filename, file, null, null, null);
            sw.Stop();

            // Get the raw content result
            string rawResult = result.@return;
            this.logger.LogInformation("Textkernel Extract Response {Chars}chars in {ServiceDuration}ms", rawResult.Length, sw.ElapsedMilliseconds);

            sw.Restart();

            Profile p;

            // Load the string into a stream we can pass to the deseraliser
            using (var stream = new MemoryStream())
            using (var writer = new StreamWriter(stream))
            {
                writer.Write(rawResult);
                writer.Flush();
                stream.Position = 0;

                // Textkernel includes all empty nodes, which results in lots of serialised empty strings, 
                // strip empty nodes out first
                var cleaner = await XDocument.LoadAsync(stream, LoadOptions.None, CancellationToken.None);
                cleaner.Descendants().Where(e => string.IsNullOrEmpty(e.Value)).Remove();

                // Create a reader for the cleaned XML and deserialise
                using (var reader = cleaner.CreateReader())
                    p = this.serializer.Deserialize(reader) as Profile;
            }

            sw.Stop();
            this.logger.LogInformation("Textkernel Parsed: {CurrentJob} in {ParseDuration}ms", p?.Summary?.CurrentJob, sw.ElapsedMilliseconds);

            return p;
        }
    }
}