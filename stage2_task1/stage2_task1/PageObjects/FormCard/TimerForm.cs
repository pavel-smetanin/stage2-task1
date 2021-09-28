using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace stage2_task1
{
    public class TimerForm : BaseForm
    {
        public TimerForm():base("TimerForm", new Div(By.XPath("//div[@class='timer timer--white timer--center']"), "Timer"))
        { }
        public string TimeText
        {
            get
            {
                return unElement.Text;
            }
        }
    }
}
