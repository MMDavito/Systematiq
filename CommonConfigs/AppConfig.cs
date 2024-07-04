using Microsoft.Extensions.Configuration;

namespace CommonConfigs
{
    public class AppConfig
    {
        public AppConfig()
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                      .SetBasePath(Directory.GetCurrentDirectory())
                      .AddJsonFile("appsettings.json")
                      .Build();
            ConnectionString = configuration.GetConnectionString("connection_string");
        }
        public string ConnectionString { get; set; }

    }
}
