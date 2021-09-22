using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace task3
{
    public class Link : BaseElement
    {
        public Link(By locator, string name) : base(locator, name)
        { }
    }
}
