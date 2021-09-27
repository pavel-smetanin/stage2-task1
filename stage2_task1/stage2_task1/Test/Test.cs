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
            int num1, num2, num3;
            string password, email, domain;
            int indexDomain;
            TestData.TestDataCard1(out password, out email, out domain, out indexDomain);
            TestData.TestDataCard2(out num1, out num2, out num3);
            //Открытие Welcome (Main) Page
            driver.Navigate().GoToUrl(url);
            mainPage.WaitForOpen();
            Assert.IsTrue(mainPage.IsDisplayed(), "The Main Page is displayed");
            //Открытие Game (Auth) Page
            mainPage.FollowingGame();
            AuthPage authPage = new AuthPage();
            authPage.WaitForOpen();
            Assert.IsTrue(authPage.IsDisplayedCard1(), "Card 1 with authorization is displayed");
            authPage.StepCard1(password, email, domain, indexDomain);
            //Открытие Card 2
            Assert.IsTrue(authPage.IsDisplayedCard2(), "Card 2 with interests and avatar is displayed");
            authPage.StepCard2(0, 1, 2);
            Assert.IsTrue(authPage.IsDisplayedCard3(), "Card 3 with personal details is displayed");
        }
        [Test]
        public void TestCase2()
        {
            driver.Navigate().GoToUrl(url);
            mainPage.WaitForOpen();
            Assert.IsTrue(mainPage.IsDisplayed(), "The Main Page is displayed");
            mainPage.FollowingGame();
            AuthPage authPage = new AuthPage();
            authPage.StepCard4();
            Assert.IsTrue(authPage.IsDisplayedCard4(), "The HelpForm is hidden");
        }
        [Test]
        public void TestCase3()
        {
            driver.Navigate().GoToUrl(url);
            mainPage.WaitForOpen();
            Assert.IsTrue(mainPage.IsDisplayed(), "The Main Page is displayed");
            mainPage.FollowingGame();
            AuthPage authPage = new AuthPage();
            authPage.StepCard5();
            Assert.IsFalse(authPage.IsDisplayedCard5(), "The Cookies Form is not displayed (hidden)");
        }
        [Test]
        public void TestCase4()
        {
            driver.Navigate().GoToUrl(url);
            mainPage.WaitForOpen();
            mainPage.FollowingGame();
            AuthPage authPage = new AuthPage();
            Assert.IsTrue(authPage.TimerIsZero(), "Value of timer is zero 00:00:00");
        }
    }
}
