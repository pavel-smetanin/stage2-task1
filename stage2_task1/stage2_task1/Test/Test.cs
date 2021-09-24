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
            driver.Navigate().GoToUrl(url);
            mainPage.WaitForOpen();
            Assert.IsTrue(mainPage.IsDisplayed(), "The Main Page is displayed");
            mainPage.FollowingGame();

        }
        
    }
}
