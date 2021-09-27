using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using OpenQA.Selenium;

namespace stage2_task1
{
    public class ElementsList : BaseElement
    {
        IReadOnlyList<IWebElement> elements;
        public ElementsList(By uniqLocator, By listLocator, string name) : base(uniqLocator, name)
        {
            elements = BrowserFactory.GetDriver().FindElements(listLocator);
        }
        public int CountElements
        {
            get => elements.Count;
        }
        public IWebElement this[int index]
        {
            get
            {
                if (elements[index] == null)
                {
                    throw new IndexOutOfRangeException("The index is out of the Web Elements List");
                }
                return elements[index];
            }
        }
        public IWebElement SelectElement(string text)
        {
            for (int i = 0; i < elements.Count; i++)
            {
                if (elements[i].Text == text)
                    return elements[i];
            }
            throw new Exception($"Element with text: {text} is not found");
        }
    }
}

