using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradelizeWebPortal.Pages
{
    public class Score : Base
    {
        public Score(IWebDriver driver) : base(driver)
        {

        }

        By tabTraders = By.CssSelector("a[aria-controls='app-score-top-traders']");
        By tabPaidChanel = By.CssSelector("a[aria-controls='app-score-top-paid-channel']");
        By tabMirroring = By.CssSelector("a[aria-controls='app-score-top-mirroring']");
        By tableTraders = By.Id("app-score-top-traders");
        By tablePaidChanel = By.Id("app-score-top-paid-channel");
        By tableMirroring = By.Id("app-score-top-mirroring");
        By scoreLink = By.LinkText("SCORE");

        public void OpenScorePage()
        {
            driver.FindElement(scoreLink).Click();
        }
        public void SelectMirroringTab()
        {
            //TODO implement this method

            //driver.FindElement(tabMirroring).Click();
            //Assert.IsTrue(driver.FindElement(By.Id("app-score-top-mirroring")).Selected);
        }

        public void GetMirroringTraderList()
        {
            //TODO implement this method

            //List<String> traders = new List<string>();
            //ReadOnlyCollection<IWebElement> traderLists = driver.FindElements(By.CssSelector("div[class='tab-pane active']"));

        }
    }
}
