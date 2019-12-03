using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
        By letterTradelize = By.LinkText("Confirm email");
        By part = By.PartialLinkText("Confirm email");
        public void OpenYopmail()
        {
            driver.Navigate().GoToUrl("http://www.yopmail.com/");
            driver.Manage().Window.Maximize();

            Click(sbut);

            Thread.Sleep(2000);

            IWebElement iframe = driver.FindElement(By.Id("ifmail"));


            driver.SwitchTo().Frame(iframe);

            driver.Navigate().GoToUrl("http://www.yopmail.com/en/m.php?b=target2&id=me_ZGxkZwNlZGZjBGD0ZQNjAGH0AmRlAD==");

            Click(part);

            Thread.Sleep(2000);
        }
    }
}
