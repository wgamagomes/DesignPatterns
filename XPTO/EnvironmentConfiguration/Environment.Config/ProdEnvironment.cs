using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.AzureAppConfiguration;

namespace Environment.Config
{
    public class ProdEnvironment : EnvironmentConfigBase
    {
        public ProdEnvironment()
        {
            NextEnvironment = new HomolEnvironment();
        }
        public override IConfigurationBuilder Configure()
        {
            string prodEnvironment = GetEnvironmentVariable(EnvironmentVariableKey.APPLICATION_ENVIRONMENT);

            if (!string.IsNullOrWhiteSpace(prodEnvironment) && prodEnvironment == EnvironmentVariableValue.PROD)
            {
                string prodConfig = GetEnvironmentVariable(EnvironmentVariableKey.PROD_CONFIG);

                var builder = new ConfigurationBuilder();

                builder.AddAzureAppConfiguration(prodConfig);

                return builder;
            }

            return NextEnvironment.Configure();
        }
    }
}
