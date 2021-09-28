using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace stage2_task1
{
    public class Button : BaseElement
    {
        public Button(By locator, string name) :
            base(locator, name)
        { }

    }
}
