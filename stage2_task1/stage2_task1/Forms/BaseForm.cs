using System;
using System.Collections.Generic;
using System.Text;
using NLog;

namespace stage2_task1
{
    public abstract class BaseForm
    {
        protected Logger logger = LogManager.GetCurrentClassLogger();
        protected BaseElement unElement;
        protected string name;
        public BaseForm(string name, BaseElement unElement)
        {
            logger.Info("Create form with name: " + name);
            this.name = name;
            this.unElement = unElement;
        }
        public bool IsDisplayed()
        {
            return unElement.IsDisplayed();
        }
        public void WaitForOpen()
        {
            WaitsOfLoads.WaitLoadByLocator(BrowserFactory.GetDriver(), unElement.Locator);
        }
    }
}
