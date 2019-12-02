using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradelizeWebPortal.Pages
{
    public class Registration : Base
    {
        // select server to connect:
        // qa-portal = "https://qa-portal.tradelize.com/auth/signup"
        // qa-release-portal = "https://qa-release-portal.tradelize.com/auth/signup"
        // prod-portal = "https://portal.tradelize.com/auth/signup"

        string selectedServer = "https://qa-portal.tradelize.com/auth/signup";


        // select refferal:
        // QA = "7faf1110-64df-458d-86f3-79f4c53c88a6"
        // QA-release = "e2edb57a-6dec-41d2-a992-486d48d19de4"
        // Prod = "e2edb57a-6dec-41d2-a992-486d48d19de4"

        string refCode = "7faf1110-64df-458d-86f3-79f4c53c88a6";

        public Registration(IWebDriver driver) : base(driver)
        {

        }

        By userRegLogin = By.CssSelector("input[formcontrolname='login']");
        By userRegEmail = By.CssSelector("input[formcontrolname='email']");
        By retypeEmail = By.CssSelector("input[formcontrolname='re-email']");
        By userRegPass = By.CssSelector("input[formcontrolname='password']");
        By retypePass = By.CssSelector("input[formcontrolname='re-password']");
        By RefferalCode = By.CssSelector("input[formcontrolname='referral']");
        By checkBoxAgreement = By.CssSelector("input[formcontrolname='confirm']");
        By signUpbtn = By.ClassName("welcome-btn");

        

        public void OpenRegPage()
        {
            driver.Navigate().GoToUrl(selectedServer);
            driver.Manage().Window.Maximize();
        }

        public void InputSignUpData()
        {
            string mailLogin = GenerateMail();

           
            WriteText(userRegLogin, mailLogin.Substring(0, mailLogin.IndexOf('@')));
            WriteText(userRegEmail, mailLogin);
            WriteText(retypeEmail, mailLogin);
            WriteText(userRegPass, "Abcde12345");
            WriteText(retypePass, "Abcde12345");
            WriteText(RefferalCode, refCode);
            Click(checkBoxAgreement);
            
        }

        public void ClickRegButton()
        {
            Click(signUpbtn);
        }


    }
}
