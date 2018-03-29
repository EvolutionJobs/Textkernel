namespace Evolution.Textkernel
{
    using Evolution.Textkernel.Models;
    using Extract;
    using Microsoft.Extensions.Logging;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.ServiceModel;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml.Serialization;

    class TextkernelParser : ITextkernelParser
    {
        readonly ILogger logger;

        string account;
        string username;
        string password;
        string environment;

        entry[] entries = new entry[0];

        XmlSerializer serializer = new XmlSerializer(typeof(Profile));

        public TextkernelParser(ILoggerFactory logger, string account, string username, string password)
        {
            this.logger = logger.CreateLogger<TextkernelParser>();

            this.account = account;
            this.username = username;
            this.password = password;

            this.serializer.UnknownElement += this.UnknownElement;
            this.serializer.UnknownAttribute += this.UnknownAttribute;
            this.serializer.UnknownNode += this.UnknownNode;
            this.serializer.UnreferencedObject += this.UnreferencedObject;
        }

        void UnreferencedObject(object sender, UnreferencedObjectEventArgs e) => 
            this.logger.LogWarning("Unreferenced Object: {ID} {Object}", e.UnreferencedId, e.UnreferencedObject);

        void UnknownNode(object sender, XmlNodeEventArgs e) => 
            this.logger.LogWarning("Unknown Node - n:{LineNumber}/p:{LinePosition}, {Node}", e.LineNumber, e.LinePosition, e.Name);

        void UnknownAttribute(object sender, XmlAttributeEventArgs e) =>
            this.logger.LogWarning("Unknown Attribute - n:{LineNumber}/p:{LinePosition}, {Attr}", e.LineNumber, e.LinePosition, e.Attr);

        void UnknownElement(object sender, XmlElementEventArgs e) =>
            this.logger.LogWarning("Unknown Element - n:{LineNumber}/p:{LinePosition}, {Element}", e.LineNumber, e.LinePosition, e.Element);

        async Task<Profile> ITextkernelParser.Parse(byte[] file)
        {
            this.logger.LogInformation("Parsing {FileLength} Bytes", file.Length);

            var extractService = new ExtractInterfaceClient();

            var sw = new Stopwatch();
            sw.Start();
            var result = await extractService.extractAdvancedAsync(this.account, this.username, this.password, this.entries, null, file, null, null, null);
            sw.Stop();
            string rawResult = result.@return;
            this.logger.LogInformation("Textkernel Extract Response {Chars}chars in {Duration}ms", rawResult.Length, sw.ElapsedMilliseconds);


            sw.Restart();
            Profile p;

            using (var stream = new MemoryStream())
            using (var writer = new StreamWriter(stream))
            {
                writer.Write(rawResult);
                writer.Flush();
                stream.Position = 0;

                p = this.serializer.Deserialize(stream) as Profile;
            }
            sw.Stop();
            this.logger.LogInformation("Textkernel Parsed: {CurrentJob} in {Duration}ms", p?.Summary?.CurrentJob, sw.ElapsedMilliseconds);

            return p;
        }
    }
}