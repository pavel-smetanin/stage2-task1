using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using NUnit.Framework;
using OpenQA.Selenium;
using NLog;

namespace stage2_task1
{
    public abstract class BaseTest
    {
        protected Logger logger = LogManager.GetCurrentClassLogger();
        protected IWebDriver driver;
        protected MainPage mainPage;
        protected string url = ConfigurationManager.AppSettings.Get("url");
        [SetUp]
        protected void SetUp()
        {
            driver = BrowserFactory.GetDriver();
            driver.Manage().Window.Maximize();
            logger.Info("Create a MainPage");
            mainPage = new MainPage();
        }
        [TearDown]
        protected void TearDown()
        {
            logger.Info("Clear Browser");
            driver.Quit();
        }
    }
}
