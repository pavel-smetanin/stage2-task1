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
            logger.Info("TestCase2 is started");
            int num1, num2, num3;
            string password, email, domain;
            int indexDomain;
            logger.Info("Getting test data");
            TestData.TestDataCard1(out password, out email, out domain, out indexDomain);
            TestData.TestDataCard2(out num1, out num2, out num3);
            //Открытие Welcome (Main) Page
            logger.Info("Go to url: " + url);
            driver.Navigate().GoToUrl(url);
            mainPage.WaitForOpen();
            Assert.IsTrue(mainPage.IsDisplayed(), "The Main Page is displayed");
            //Открытие Game (Auth) Page
            logger.Info("Follow to Game (Auth) page");
            mainPage.FollowingGame();
            AuthPage authPage = new AuthPage();
            authPage.WaitForOpen();
            Assert.IsTrue(authPage.IsDisplayedCard1(), "Card 1 with authorization is displayed");
            logger.Info("Step 1 of TestCase1");
            authPage.StepCard1(password, email, domain, indexDomain);
            //Открытие Card 2
            Assert.IsTrue(authPage.IsDisplayedCard2(), "Card 2 with interests and avatar is displayed");
            logger.Info("Step 2 of TestCase1");
            authPage.StepCard2(num1, num2, num3);
            Assert.IsTrue(authPage.IsDisplayedCard3(), "Card 3 with personal details is displayed");
            logger.Info("TestCase1 is finished");
        }
        [Test]
        public void TestCase2()
        {
            logger.Info("TestCase2 is started");
            logger.Info("Go to url: " + url);
            driver.Navigate().GoToUrl(url);
            mainPage.WaitForOpen();
            Assert.IsTrue(mainPage.IsDisplayed(), "The Main Page is displayed");
            logger.Info("Follow to Game (Auth) page");
            mainPage.FollowingGame();
            AuthPage authPage = new AuthPage();
            logger.Info("Step of TestCase2");
            authPage.StepCard4();
            Assert.IsTrue(authPage.IsDisplayedCard4(), "The HelpForm is hidden");
            logger.Info("TestCase2 is finished");
        }
        [Test]
        public void TestCase3()
        {
            logger.Info("TestCase3 is started");
            logger.Info("Go to url: " + url);
            driver.Navigate().GoToUrl(url);
            mainPage.WaitForOpen();
            Assert.IsTrue(mainPage.IsDisplayed(), "The Main Page is displayed");
            logger.Info("Follow to Game (Auth) page");
            mainPage.FollowingGame();
            AuthPage authPage = new AuthPage();
            logger.Info("Step of TestCase3");
            authPage.StepCard5();
            Assert.IsFalse(authPage.IsDisplayedCard5(), "The Cookies Form is not displayed (hidden)");
            logger.Info("TestCase3 is finished");
        }
        [Test]
        public void TestCase4()
        {
            logger.Info("TestCase3 is started");
            logger.Info("Go to url: " + url);
            driver.Navigate().GoToUrl(url);
            mainPage.WaitForOpen();
            logger.Info("Follow to Game (Auth) page");
            mainPage.FollowingGame();
            AuthPage authPage = new AuthPage();
            Assert.IsTrue(authPage.TimerIsZero(), "Value of timer is zero 00:00:00");
            logger.Info("TestCase3 is finished");
        }
    }
}
