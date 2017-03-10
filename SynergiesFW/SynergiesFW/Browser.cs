using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SynergiesFW
{
    public static class Browser
    {
        static IWebDriver driver = new ChromeDriver(@"C://Drivers");

        public static ISearchContext Driver
        {
            get
            {
                return driver;
            }
        }

        public static void GoTo(String url)
        {
            driver.Manage().Window.Maximize();
            driver.Url = url;
        }
        public static void wait()
        {
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
        }
        public static void close()
        {
            driver.Close();
        }
        public static void switchTab()
        {
            List<String> tabs2 = new List<String>(driver.WindowHandles);
            String currentHandle = driver.CurrentWindowHandle;
            int cant = tabs2.Count;
            for (int i = 0; i < cant; i++)
            {
                if (!tabs2.ElementAt(i).Equals(currentHandle))
                {
                    driver.SwitchTo().Window(tabs2.ElementAt(i++));
                }
            }


        }


    }
}
