namespace Microsoft.Extensions.DependencyInjection
{
    using Evolution.Textkernel;
    using Microsoft.Extensions.Logging;

    public static class TextkernelParserExtension
    {
        /// <summary>Add Textkernel as a CV parsing service.</summary>
        /// <param name="services">The services to extend.</param>
        /// <param name="account">The Textkernel account name.</param>
        /// <param name="username">The Textkernel user.</param>
        /// <param name="password">The password for the Textkernel user.</param>
        /// <returns>The extended service.</returns>
        public static IServiceCollection AddTextkernelParser(this IServiceCollection services, string account, string username, string password)
        {
            // Add Companies House API service
            return services.AddSingleton<ITextkernelParser>(
                sp => new TextkernelParser(sp.GetService<ILoggerFactory>(), account, username, password));
        }
    }
}