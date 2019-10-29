using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradelizeWebPortal.Pages
{
    public class Base
    {
        protected IWebDriver driver;
        public Base(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void WriteText(By element, string text)
        {
            driver.FindElement(element).SendKeys(text);
        }

        public void Click(By element)
        {
            driver.FindElement(element).Click();
        }

        public string GetText(By element)
        {
            string actual = driver.FindElement(element).Text;
            return actual;
        }

        public void CheckElementPresent(By element)
        {
            Assert.IsNotNull(element);
        }

        

        public string GenerateMail()
        {
            Random rnd = new Random();
            int nmb = rnd.Next(1, 1000);
            string MailService = "@yopmail.com";
            string Login = "tqautotest" + nmb;
            string Email = Login + MailService;
            return Email;
        }

                
    }
}
