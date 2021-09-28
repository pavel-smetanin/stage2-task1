using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace stage2_task1
{
    public class TextField : BaseElement
    {
        public TextField(By locator, string name) :
            base(locator, name)
        { }
        public void SendText(string text)
        {
            logger.Info($"Enter text for element {name}. Text: {text}");
            FindElement().SendKeys(text);
        }
    }
}
