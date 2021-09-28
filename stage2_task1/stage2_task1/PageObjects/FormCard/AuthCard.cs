using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace stage2_task1
{
    public class AuthCard : BaseForm
    {
        private TextField password = new TextField(By.XPath("//input[@placeholder='Choose Password']"), "ChoosePassword");
        private TextField mailName = new TextField(By.XPath("//input[@placeholder='Your email']"), "YourEmail");
        private TextField domain = new TextField(By.XPath("//input[@placeholder='Domain']"), "Domain");
        private Button nextBut = new Button(By.XPath("//a[@class='button--secondary']"), "ButtonNext");
        private CheckBox acceptTerms = new CheckBox(By.XPath("//label[@class='checkbox__label']"), "CheckAccept");
        private ElementsList extDomains = new ElementsList(By.CssSelector(".dropdown__header"), By.CssSelector(".dropdown__list-item"), "ExtensionDomain");
        public AuthCard() : base("AuthCard", new Div(By.XPath("//div[@class='login-form__container']"), "LoginForm"))
        { }
        public void EmailAndPasswordAuth(string password, string email, string domain, int indexDomain)
        {
            logger.Info("Input password, email and domain");
            this.password.Clear();
            this.password.Click();
            this.password.SendText(password);
            this.mailName.Clear();
            this.mailName.Click();
            this.mailName.SendText(email);
            this.domain.Clear();
            this.domain.Click();
            this.domain.SendText(domain);
            acceptTerms.Click();
            extDomains.Click();
            extDomains[indexDomain].Click();
            nextBut.Click();
        }
    }
}
