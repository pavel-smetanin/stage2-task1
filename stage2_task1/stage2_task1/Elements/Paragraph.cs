using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace stage2_task1
{
    public class Paragraph : BaseElement
    {
        public Paragraph(By locator, string name):base(locator, name)
        {}
        public string GetText()
        {
            logger.Info($"Getting text from element {name}");
            string text = BrowserFactory.GetDriver().FindElement(locator).Text;
            return text;
        }
    }
}
