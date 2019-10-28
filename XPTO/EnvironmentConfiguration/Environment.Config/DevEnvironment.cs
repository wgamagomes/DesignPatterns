using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace Environment.Config
{
    public class DevEnvironment : EnvironmentConfigBase
    {
        public override IConfigurationBuilder Configure()
        {
            string homolEnvironment = GetEnvironmentVariable(EnvironmentVariableKey.APPLICATION_ENVIRONMENT);

            if (!string.IsNullOrWhiteSpace(homolEnvironment) && homolEnvironment == EnvironmentVariableValue.DEV)
            {

                var builder = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

                return builder;
            }

            throw new Exception("Unable find  Environment Variable.");
        }
    }

}
