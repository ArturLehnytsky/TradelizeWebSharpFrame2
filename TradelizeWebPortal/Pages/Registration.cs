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
        public Registration(IWebDriver driver) : base(driver)
        {

        }

        By userRegLogin = By.XPath("//input[@placeholder='LOGIN']");
        By userRegEmail = By.XPath("//input[@placeholder='EMAIL']");
        By retypeEmail = By.XPath("//input[@placeholder='RETYPE EMAIL']");
        By userRegPass = By.XPath("//input[@placeholder='PASSWORD']");
        By retypePass = By.XPath("//input[@placeholder='RETYPE PASSWORD']");
        By RefferalCode = By.XPath("//input[@placeholder='PRIVATE BETA INVITE CODE']");
        By checkBoxAgreement = By.XPath("//label[@class='custom-checkbox']//i");
        By signUpbtn = By.ClassName("welcome-btn");

        

        public void OpenRegPage()
        {
            driver.Navigate().GoToUrl("https://qa-portal.tradelize.com/auth/signup");
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
            WriteText(RefferalCode, "7faf1110-64df-458d-86f3-79f4c53c88a6");
            Click(checkBoxAgreement);
            
        }

        public void ClickRegButton()
        {
            Click(signUpbtn);
        }


    }
}
