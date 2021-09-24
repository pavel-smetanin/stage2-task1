using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace stage2_task1
{
    public class AuthPage : BaseForm
    {
        private TextField password = new TextField(By.XPath("//input[@placeholder='Choose Password']"), "ChoosePassword");
        private TextField mailName = new TextField(By.XPath("//input[@placeholder='Your email']"), "YourEmail");
        private TextField domain = new TextField(By.XPath("//input[@placeholder='Domain']"), "Domain");
        private Button nextBut = new Button(By.XPath("//a[@class='button--secondary']"), "ButtonNext");
        private CheckBox acceptTerms = new CheckBox(By.XPath("//span[@class='checkbox__box']"), "CheckAccept");
        private ElementsList extDomains = new ElementsList(By.CssSelector(".dropdown__header"), By.CssSelector(".dropdown__field"), "ExtensionDomain");
        private ElementsList checkBoxList;
        public AuthPage() : base("GameAuthPage", new Div(By.XPath("//div[@class='logo__icon']"), "Logo"))
        { }
        public void EmailAndPasswordAuth(string password, string email, string domain, string extDomain)
        {
            this.password.SendText(password);
            this.mailName.SendText(email);
            this.domain.SendText(domain);
            acceptTerms.Click();
            extDomains.Click();
            extDomains.SelectElement(extDomain).Click();
            nextBut.Click();
        }
        public void ChoseInterestsAndImage(int[] numsInterest)
        {
            checkBoxList = new ElementsList(By.CssSelector(".avatar-and-interests__interests-list"),
            By.CssSelector(".checkbox__box"), "InterestsList");
            for (int i = 0; i < numsInterest.Length; i++)
                checkBoxList[numsInterest[i]].Click();

        }
    }
}
