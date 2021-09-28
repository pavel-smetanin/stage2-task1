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
        HelpForm helpForm = new HelpForm();
        CookiesForm cookiesForm = new CookiesForm();
        TimerForm timerForm = new TimerForm();
        public AuthPage() : base("GameAuthPage", new Div(By.XPath("//div[@class='logo__icon']"), "Logo"))
        { }
        public void StepCard1(string password, string email, string domain, int indexDomain)
        {
            authCard.WaitForOpen();
            authCard.EmailAndPasswordAuth(password, email, domain, indexDomain);
        }
        public void StepCard2(int num1, int num2, int num3)
        {
            interestsAndAvatarCard.WaitForOpen();
            interestsAndAvatarCard.ChoseInterestsAndImage(num1, num2, num3);
            personalCard.WaitForOpen();
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
        
        public void StepCard4()
        {
            helpForm.WaitForOpen();
            helpForm.RemoveHelpForm();
        }
        public bool IsDisplayedCard4()
        {
            return helpForm.IsDisplayed();
        }

        public void StepCard5()
        {
            cookiesForm.WaitForOpen();
            cookiesForm.CookiesAccept();
        }
        public bool IsDisplayedCard5()
        {
            return cookiesForm.IsDisplayed();
        }

        public bool TimerIsZero()
        {
            string time = timerForm.TimeText;
            if (time == "00:00:00")
                return true;
            logger.Warn("Value of timer is not zero: " + time);
            return false;
        }
    }
}
