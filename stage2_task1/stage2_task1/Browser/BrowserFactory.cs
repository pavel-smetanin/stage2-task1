using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using System.Configuration;
using NLog;

namespace stage2_task1
{
    public static class BrowserFactory
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private static IWebDriver driver;
        private static string nameBrowser = ConfigurationManager.AppSettings.Get("browser");
        static BrowserFactory() 
        {
            logger.Info("Created Browser Factory");
            
            logger.Info($"Received Browse code: {nameBrowser}. Initialize web driver");
            driver = Browser.InitDriver(nameBrowser);
        }
        public static IWebDriver GetDriver()
        {
            if(driver == null)
            {
                logger.Warn("Driver is null. Recreating driver from BrowserFactory");
                driver = Browser.InitDriver(nameBrowser);
            }
            logger.Info("Getting driver from Browser Factory");
            return driver;
        }
    }
}
