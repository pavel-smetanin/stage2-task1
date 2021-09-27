using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace stage2_task1
{
    public class PersonalCard : BaseForm
    {
        public PersonalCard() : base("PersonalCard", new Div(By.XPath("//div[@class='personal-details__form']"), "PersonalForm"))
        { }
    }
}
