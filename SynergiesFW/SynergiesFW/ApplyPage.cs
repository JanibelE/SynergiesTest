using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SynergiesFW
{
    public static class ApplyPage
    {
        public static void form()
        {
            IWebElement name = Browser.Driver.FindElement(By.Id("refer-name"));
            IWebElement mail = Browser.Driver.FindElement(By.Id("refer-email"));

            name.SendKeys("John");
            mail.SendKeys("john@gmail.com");

            new SelectElement(Browser.Driver.FindElement(By.Id("refer-state"))).SelectByValue("28");
            
        }

    }
}
