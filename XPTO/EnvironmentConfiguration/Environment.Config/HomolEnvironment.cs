using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.AzureAppConfiguration;
using System;

namespace Environment.Config
{
    public class HomolEnvironment : EnvironmentConfigBase
    {
        public HomolEnvironment()
        {
            NextEnvironment = new DevEnvironment();
        }

        public override IConfigurationBuilder Configure()
        {
            string homolEnvironment = GetEnvironmentVariable(EnvironmentVariableKey.APPLICATION_ENVIRONMENT);

            if (!string.IsNullOrWhiteSpace(homolEnvironment) && homolEnvironment == EnvironmentVariableValue.HOMOL)
            {
                string homolConfig = GetEnvironmentVariable(EnvironmentVariableKey.HOMOL_CONFIG);

                var builder = new ConfigurationBuilder();

                builder.AddAzureAppConfiguration(homolConfig);

                return builder;
            }

            return NextEnvironment.Configure();
        }
    }
}
