using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradelizeWebPortal.Pages
{
    public class Funds : Base
    {
        public Funds(IWebDriver driver) : base (driver)
        {

        }

        By navTabs = By.ClassName("nav-tabs");
        By navItem = By.ClassName("nav-item");
        By filterMenu = By.ClassName("filter-menu");
        By apiKeyTable = By.TagName("app-funds-exchanges-api-keys");
        By fundsTable = By.TagName("app-funds-exchanges-balance");
        
       
     
    }
}
