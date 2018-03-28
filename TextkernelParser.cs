namespace Evolution.Textkernel
{
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

    class TextkernelParser : ITextkernelParser
    {
        readonly ILogger logger;

        string account;
        string username;
        string password;
        string environment;

        Extract.entry[] entries = new Extract.entry[0];

        public TextkernelParser(ILoggerFactory logger, string account, string username, string password)
        {
            this.logger = logger.CreateLogger<TextkernelParser>();

            this.account = account;
            this.username = username;
            this.password = password;
        }

        async Task<string> ITextkernelParser.Parse(byte[] file)
        {
            this.logger.LogInformation("Parsing {FileLength} Bytes", file.Length);

            var extractService = new ExtractInterfaceClient();

            var sw = new Stopwatch();
            sw.Start();
            var result = await extractService.extractAdvancedAsync(this.account, this.username, this.password, this.entries, null, file, null, null, null);
            sw.Stop();
            string rawResult = result.@return;
            this.logger.LogInformation("Textkernel Extract Response {Chars}chars in {Duration}ms", rawResult.Length, sw.ElapsedMilliseconds);

            return rawResult;
        }
    }
}