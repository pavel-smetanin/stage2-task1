using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace stage2_task1
{
    public class Test : BaseTest
    {
        [Test]
        public void TestCase1()
        {
            //Открытие Welcome (Main) Page
            driver.Navigate().GoToUrl(url);
            mainPage.WaitForOpen();
            Assert.IsTrue(mainPage.IsDisplayed(), "The Main Page is displayed");
            //Открытие Game (Auth) Page
            mainPage.FollowingGame();
            AuthPage authPage = new AuthPage();
            Assert.IsTrue(authPage.IsDisplayedCard1(), "Card 1 with authorization is displayed");
            authPage.Step1("123qwErкаr", "qwedsa", "mail", ".org");
            //Открытие Card 2
            Assert.IsTrue(authPage.IsDisplayedCard2(), "Card 2 with interests and avatar is displayed");
            authPage.Step2(0, 1, 2);
            Assert.IsTrue(authPage.IsDisplayedCard3(), "Card 3 with personal details is displayed");
        }
        
    }
}
