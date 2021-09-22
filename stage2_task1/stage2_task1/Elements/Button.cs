using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace task3
{
    public class Button : BaseElement
    {
        public Button(By locator, string name) :
            base(locator, name)
        { }

    }
}
