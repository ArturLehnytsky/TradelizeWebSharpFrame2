using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradelizeWebPortal.DisposableMailServices;
using TradelizeWebPortal.Pages;

namespace TradelizeWebPortal.Settings
{
    public class Browser
    {
        public IWebDriver driver;
        public Login log;
        public Registration reg;
        public Yopmail yop;

        [SetUp]
        public void Initialize()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            log = new Login(driver);
            reg = new Registration(driver);
            yop = new Yopmail(driver);
        }

        [TearDown]
        public void Tear()
        {
            driver.Quit();
        }

    }
}
