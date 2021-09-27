using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace stage2_task1
{
    public class InterestsAndAvatarCard : BaseForm
    {
        private AuthCard authCard = new AuthCard();
        private ElementsList checkBoxList = new ElementsList(By.CssSelector(".avatar-and-interests__interests-list"),
            By.CssSelector(".checkbox__box"), "InterestsList");
        private Button uploadImg = new Button(By.XPath("//a[@class='avatar-and-interests__upload-button']"), "UploadBut");
        private Div image = new Div(By.XPath("//div[@class='avatar-and-interests__avatar-image']"), "Avatar");
        public InterestsAndAvatarCard() : base("InterestsCard", new Div(By.XPath("//div[@class='avatar-and-interests__form']"), "AvatarAndInterestsForm"))
        { }
        public void ChoseInterestsAndImage(int num1, int num2, int num3)
        {
            checkBoxList = new ElementsList(By.CssSelector(".avatar-and-interests__interests-list"),
            By.CssSelector(".checkbox__box"), "InterestsList");
            ElementsList interests = new ElementsList(By.CssSelector(".avatar-and-interests__interests-list"),
                By.CssSelector(".checkbox__label"), "InterestsList");
            interests[interests.CountElements - 1].Click();
            interests[num1].Click();
            interests[num2].Click();
            interests[num3].Click();

        }
    }
}
