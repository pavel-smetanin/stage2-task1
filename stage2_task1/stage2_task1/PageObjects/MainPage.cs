using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace stage2_task1
{
    public class MainPage : BaseForm
    {
        private Link startLink = new Link(By.XPath("//a[@class='start__link']"), "StartLink");
        public MainPage():base("MainPageUI", new Div(By.XPath("//div[@class='logo__icon']"), "Logo"))
        {
            
        }
        public void FollowingGame()
        {
            startLink.Click();
        }
    }
}
