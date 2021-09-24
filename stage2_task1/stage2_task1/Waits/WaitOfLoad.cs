using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using NLog;

namespace stage2_task1
{
    //Статический класс Ожиданий
    public static class WaitsOfLoads
    {
        /*
         * Содержит статические методы, для работы с ожиданиями
         */
        //Ожидание загрузки страницы по url
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private static int secondOfWait = Convert.ToInt32(ConfigurationManager.AppSettings.Get("secondOfWait"));
        public static void WaitLoadByUrl(IWebDriver driver, string url)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(secondOfWait));
                wait.Until(ExpectedConditions.UrlContains(url));
            }
            catch(Exception ex)
            {
                logger.Error($"Timeout expired: {secondOfWait} s. {ex.Message}");
                throw new WebDriverTimeoutException();
            }
        }
        //Ожидание загрузки страницы по видимости элемента
        public static void WaitLoadByLocator(IWebDriver driver, By locator)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(secondOfWait));
                wait.Until(ExpectedConditions.ElementIsVisible(locator));
            }
            catch(Exception ex)
            {
                logger.Error($"Timeout expired: {secondOfWait} s. {ex.Message}");
                throw new WebDriverTimeoutException();
            }
        }
        public static void WaitOfAllert(IWebDriver driver)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(secondOfWait));
                wait.Until(ExpectedConditions.AlertState(true));
            }
            catch(Exception ex)
            {
                logger.Error($"Timeout expired: {secondOfWait} s. {ex.Message}");
                throw new WebDriverTimeoutException();
            }
        }

    }
}