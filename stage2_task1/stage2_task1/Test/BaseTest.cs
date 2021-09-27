using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using NUnit.Framework;
using OpenQA.Selenium;

namespace stage2_task1
{
    public abstract class BaseTest
    {
        protected IWebDriver driver;
        protected MainPage mainPage;
        protected string url = ConfigurationManager.AppSettings.Get("url");
        [SetUp]
        protected void SetUp()
        {
            driver = BrowserFactory.GetDriver();
            driver.Manage().Window.Maximize();
            mainPage = new MainPage();
        }
        [TearDown]
        protected void TearDown()
        {
            driver.Quit();
        }
    }
}
