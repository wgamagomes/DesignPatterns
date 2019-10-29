using Microsoft.Extensions.Configuration;
using System;

namespace Environment.Config
{
    public abstract class EnvironmentConfigBase
    {
        protected EnvironmentConfigBase NextEnvironment { get; set; }

        public abstract IConfigurationBuilder Configure();

        public string GetEnvironmentVariable(string variable)
        {
            return System.Environment.GetEnvironmentVariable(variable);
        }
    }
}
