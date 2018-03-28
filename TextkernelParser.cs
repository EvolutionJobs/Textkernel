namespace Evolution.Textkernel
{
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

        public TextkernelParser(ILoggerFactory logger, string account, string username, string password, string environment)
        {
            this.logger = logger.CreateLogger<TextkernelParser>();
            this.account = account;
            this.username = username;
            this.password = password;
            this.environment = environment;
        }

        async Task<string> ITextkernelParser.Parse(byte[] file)
        {
            //var accessTokenService = new RequestAccessToken.RequestAccessTokenServiceClient();

            //var token = await accessTokenService.getTokenAsync(this.account, this.username, this.password, this.environment);

            var extractService = new Extract.ExtractInterfaceClient();
            var result = await extractService.extractAdvancedAsync(this.account, this.username, this.password, this.entries, null, file, null, null, null);

            return result.@return;
        }
    }
}