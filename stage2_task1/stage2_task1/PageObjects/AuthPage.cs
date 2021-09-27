using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace stage2_task1
{
    public class AuthPage : BaseForm
    {
        AuthCard authCard = new AuthCard();
        InterestsAndAvatarCard interestsAndAvatarCard = new InterestsAndAvatarCard();
        PersonalCard personalCard = new PersonalCard();
        public AuthPage() : base("GameAuthPage", new Div(By.XPath("//div[@class='logo__icon']"), "Logo"))
        { }
        public void Step1(string password, string email, string domain, string extDomain)
        {
            authCard.EmailAndPasswordAuth(password, email, domain, extDomain);
        }
        public void Step2(int num1, int num2, int num3)
        {
            interestsAndAvatarCard.ChoseInterestsAndImage(num1, num2, num3);
        }
        public bool IsDisplayedCard1()
        {
            return authCard.IsDisplayed();
        }
        public bool IsDisplayedCard2()
        {
            return interestsAndAvatarCard.IsDisplayed();
        }
        public bool IsDisplayedCard3()
        {
            return personalCard.IsDisplayed();
        }
    }
}
