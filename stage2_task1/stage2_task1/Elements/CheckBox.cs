using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace stage2_task1
{
    public class CheckBox : BaseElement
    {
        bool value;
        public CheckBox(By locator, string name) : base(locator, name)
        {
            value = FindElement().Selected;
        }

    }
}
