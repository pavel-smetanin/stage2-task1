using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace stage2_task1
{
    public class HelpForm : BaseForm
    {
        Button SendBut = new Button(By.XPath("//div[@class='align__cell u-right']/button"), "SendButton");
        public HelpForm():base("HelpForm", new Div(By.XPath("//div[@class='help-form__container']"), "HelpFormContainer"))
        { }
        public void RemoveHelpForm()
        {
            logger.Info("Click on button for remove Help form");
            SendBut.Click();
        }
    }
}
