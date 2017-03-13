using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SynergiesFW;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestInitialize]
        public void inicio()
        {
            Page.HomePage.GoTo();
        }
        
        [TestMethod]
        public void TestMethod1()
        {
            Page.HomePage.ContactPage();
            ContactPage.Form();
            ContactPage.waitAndApply();
            //Browser.switchTab();
            ApplyPage.form();
        }

        //.........
        //.........
    }
}
