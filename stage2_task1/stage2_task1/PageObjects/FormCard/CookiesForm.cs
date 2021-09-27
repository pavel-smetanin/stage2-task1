using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace stage2_task1
{
    public class CookiesForm : BaseForm
    {
        Button butAccept = new Button(By.XPath("//button[@name='button']"), "CookiesButton");
        public CookiesForm():base("CookiesForm", new Div(By.XPath("//div[@class='cookies']"), "Cookies"))
        { }
        public void CookiesAccept()
        {
            butAccept.Click();
        }
    }
}
