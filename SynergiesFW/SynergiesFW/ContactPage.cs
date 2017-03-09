using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SynergiesFW
{
    public class ContactPage
    {
      
        public static void Form()
        {
            IWebElement name = Browser.Driver.FindElement(By.Name("your-name"));
            IWebElement mail = Browser.Driver.FindElement(By.Name("your-email"));
            IWebElement Company = Browser.Driver.FindElement(By.Name("your-company"));
            
            name.SendKeys("John Wick");
            mail.SendKeys("john@gmail.com");
            Company.SendKeys("Synergies");
            new SelectElement(Browser.Driver.FindElement(By.Name("your-recipient"))).SelectByValue("I am considering outsourcing to or partnering with Synergies");
            IWebElement msj = Browser.Driver.FindElement(By.Name("your-message"));

            msj.SendKeys("testing");

        }

        public static void waitAndApply()
        {
            IWebElement btn = Browser.Driver.FindElement(By.CssSelector("html.csstransforms.csstransforms3d.csstransitions body.page-template-default.page.page-id-3697.default-header.transparent-header-w.t-dark-w div#wrap.syg-contact-us-wrap.colorskin- section#main-content.container.syg-contact-us-main div.row-wrapper-x div#wpcf7-f5364-p3697-o1.wpcf7 form.wpcf7-form p input.wpcf7-form-control.wpcf7-submit"));
            btn.Click();
            Browser.wait();
            IWebElement apply = Browser.Driver.FindElement(By.CssSelector("html.csstransforms.csstransforms3d.csstransitions body.page-template-default.page.page-id-3697.default-header.transparent-header-w.t-dark-w div#wrap.syg-contact-us-wrap.colorskin- section#main-content.container.syg-contact-us-main div.row-wrapper-x p a.button.green.medium"));
            apply.Click();
        }


    }
}
