using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using NLog;


namespace stage2_task1
{
    public abstract class BaseElement
    {
        protected Logger logger = LogManager.GetCurrentClassLogger();
        protected By locator;
        protected string name;
        public By Locator
        {
            get => locator;
        }
        public BaseElement(By locator, string name)
        {
            logger.Info($"Create element with name {name}");
            this.locator = locator;
            this.name = name;
        }
        protected IWebElement FindElement()
        {
            logger.Info($"Create and find web element by locator with name {name}");
            IWebElement element = BrowserFactory.GetDriver().FindElement(locator);
            return element;
        }
        public void Click()
        {
            logger.Info($"Click on web element {name}");
            FindElement().Click();
        }
        public bool IsDisplayed()
        {
            IWebElement webElement = FindElement();
            return webElement.Displayed;
        }
    }
}
