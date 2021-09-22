using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Configuration;
using NLog;

namespace task3
{
    public static class Browser
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private static string lang;
        private static string Lang
        {
            get
            {
                logger.Info($"Received lang-localization: {lang}");
                lang = ConfigurationManager.AppSettings.Get("lang");
                return lang;
            }
        }
        private static IWebDriver GetChromeDriver()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument(Lang);
            return new ChromeDriver(options);
        }
        private static IWebDriver GetFirefoxDriver()
        {
            FirefoxOptions options = new FirefoxOptions();
            options.AddArgument(Lang);
            return new FirefoxDriver(options);
        }
        public static IWebDriver InitDriver(string name)
        {
            switch(name)
            {
                case "chrome":
                    logger.Info("Selected Chrome Browser");
                    return GetChromeDriver();
                case "firefox":
                    logger.Info("Selected Firefox Browser");
                    return GetFirefoxDriver();
                default:
                    logger.Error($"Browser with name: {name} is not found");
                    throw new WebDriverException();
            }
        }
    }
            
}
       
