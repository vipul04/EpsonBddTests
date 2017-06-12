using System.Configuration;
using System.Collections.Specialized;

namespace Selenium.Automation.Drivers.Configuration
{
    public static class ApplicationSettings
    {
        public static string GetLocalBrowser
        {
            get
            {
                var section = ConfigurationManager.GetSection("localBrowser") as NameValueCollection;
                return section != null ? section["localBrowser"] : null;
            }
        }

        public static string GetEnvironmentBaseUrl()
        {
            return GetSettingValue("EnvironmentBaseUrl");
        }

        private static string GetSettingValue(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }
    }
}
