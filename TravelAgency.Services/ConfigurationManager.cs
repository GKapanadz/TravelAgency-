using Microsoft.Extensions.Configuration;

namespace TravelAgency.Services
{
    public static class ConfigurationManager
    {
        public static IConfiguration Configuration { get; } = new ConfigurationBuilder()
         .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
         .Build();

        public static string ConnectionString => Configuration.GetConnectionString("Default")!;
    }
}
