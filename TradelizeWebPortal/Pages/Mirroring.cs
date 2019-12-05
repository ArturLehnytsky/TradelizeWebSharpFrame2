using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradelizeWebPortal.Pages
{
    public class Mirroring : Base
    {
        public Mirroring(IWebDriver driver) : base(driver)
        {

        }

        By editBtn = By.ClassName("edit");
        By costOn = By.CssSelector("option[value='true']");
        By costOff = By.CssSelector("option[value='false']");
        By updateBtn = By.ClassName("btn-big");


        public void OpenMirroringPage()
        {
            driver.Navigate().GoToUrl("https://qa-portal.tradelize.com/create-mirror");
        }
        public void CurrentOffersON()
        {
            try
            {

                bool elementCondition = driver.FindElement(editBtn).Displayed;

                if (elementCondition)
                {
                    driver.FindElement(editBtn).Click();
                    driver.FindElement(costOn).Click();
                    driver.FindElement(editBtn).Click();
                    driver.FindElement(updateBtn).Click();
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e);   
            }

            

            
            

        }
    }
}
