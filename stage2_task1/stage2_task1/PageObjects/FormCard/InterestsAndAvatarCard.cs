using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using WindowsInput;
using WindowsInput.Native;
using OpenQA.Selenium;

namespace stage2_task1
{
    public class InterestsAndAvatarCard : BaseForm
    {
        private ElementsList checkBoxList = new ElementsList(By.CssSelector(".avatar-and-interests__interests-list"),
            By.CssSelector(".checkbox__box"), "InterestsList");
        private Button uploadImg = new Button(By.XPath("//a[@class='avatar-and-interests__upload-button']"), "UploadBut");
        private Button nextBut = new Button(By.XPath("//button[@class='button button--stroked button--white button--fluid']"), "NextBut");
        public InterestsAndAvatarCard() : base("InterestsCard", new Div(By.XPath("//div[@class='avatar-and-interests__form']"), "AvatarAndInterestsForm"))
        { }
        public void ChoseInterestsAndImage(int num1, int num2, int num3)
        {
            string fileName = ConfigurationManager.AppSettings.Get("avatarFile");
            int timeSleep = int.Parse(ConfigurationManager.AppSettings.Get("timeSleep"));
            checkBoxList = new ElementsList(By.CssSelector(".avatar-and-interests__interests-list"),
            By.CssSelector(".checkbox__box"), "InterestsList");
            ElementsList interests = new ElementsList(By.CssSelector(".avatar-and-interests__interests-list"),
                By.CssSelector(".checkbox__label"), "InterestsList");
            interests[interests.CountElements - 1].Click();
            interests[num1].Click();
            interests[num2].Click();
            interests[num3].Click();
            uploadImg.Click();
            InputSimulator input = new InputSimulator();
            input.Keyboard.Sleep(timeSleep).TextEntry(fileName).KeyPress(VirtualKeyCode.RETURN);
            nextBut.Click();
        }
    }
}
