using Microsoft.Extensions.Configuration;

namespace Environment.Config
{
    public class AppEnviroment
    {
        public static IConfigurationBuilder GetEnviromentConfigurationSettings()
        {
            EnvironmentConfigBase environment = new ProdEnvironment();

            return environment.Configure();
        }
    }
}
