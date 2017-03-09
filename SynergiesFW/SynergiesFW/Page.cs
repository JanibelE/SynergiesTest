using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SynergiesFW
{
    public static class Page
    {

        public static HomePage HomePage
        {
            get
            {
                HomePage home = new HomePage();
                PageFactory.InitElements(Browser.Driver,home);
                return home;
            }
        }


    }


    public class HomePage
    {
        String url = "https://synergiesservices.com/";
        //     IWebElement contact = Browser.Driver.FindElement(By.LinkText("https://synergiesservices.com/contact-us/"));
        public void GoTo()
        {
            Browser.GoTo(url);
        }
        
        public void ContactPage()
        {
            IWebElement contact = Browser.Driver.FindElement(By.XPath("/html/body/div/header/div/nav/div[2]/ul/li[7]/a"));

            contact.Click();
        }

    
    }
}
