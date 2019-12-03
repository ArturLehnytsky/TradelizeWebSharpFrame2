using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradelizeWebPortal.Pages;

namespace TradelizeWebPortal.DisposableMailServices
{
    public class Yopmail : Base
    {
        public Yopmail(IWebDriver driver) : base(driver)
        {

        }

        By emailNameYopmail = By.Id("login");
        By sbut = By.ClassName("sbut");
        //By letterTradelize = By.LinkText

        public void OpenYopmail()
        {
            driver.Navigate().GoToUrl("http://www.yopmail.com/");
            driver.Manage().Window.Maximize();
        }
    }
}
