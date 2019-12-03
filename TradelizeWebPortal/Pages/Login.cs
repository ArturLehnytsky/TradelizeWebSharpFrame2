using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradelizeWebPortal.Pages
{
    public class Login : Base 
    {
        //создать ексельку и тянуть юзеров оттуда
        //string login = "tqav3";
        string userEmail = "tqav3@yopmail.com";
        string password = "12345";
        public Login(IWebDriver driver) : base(driver)
        {

        }

       

        // Login Page
        By userLogin = By.CssSelector("input[formcontrolname='login']");
        By userPassword = By.CssSelector("input[formcontrolname='password']");
        By welcomeBtn = By.ClassName("welcome-btn");
        By forgotPassword = By.LinkText("FORGOT PASSWORD?");
        By registerNowlink = By.LinkText("OR REGISTER NOW");

        //Forgot Password
        By recoveryByEmail = By.CssSelector("input[formcontrolname='email']");
        By recoveryBtn = By.ClassName("welcome-btn");
        By rememberPass = By.LinkText("REMEMBER PASSWORD?");

        //The Score page is open If registration is succesful. Find H1 tag with "TRADALIZE TOP SCORE TRADES" 
        By logoTitle = By.ClassName("logo-title");


        public void OpenLoginPage()
        {
            driver.Navigate().GoToUrl("https://qa-portal.tradelize.com/auth");
            driver.Manage().Window.Maximize();
        }

        public void SignInByLogin()
        {
            WriteText(userLogin, userEmail.Substring(0,userEmail.IndexOf("@")));
            WriteText(userPassword, password);
            Click(welcomeBtn);
            
        }

        public void SignInByEmail()
        {
            WriteText(userLogin, userEmail);
            WriteText(userPassword, password);
            Click(welcomeBtn);
        }

        public void ForgotPassword()
        {
            Click(forgotPassword);
            WriteText(recoveryBtn, userEmail);
            Click(recoveryBtn);
        }

        public void CheckAuthorizetion()
        {
            bool actual = driver.FindElement(logoTitle).Displayed;
            

            if (actual)
            {
                Console.WriteLine("Authorizetion test is PASSED");
            }

            else
            {
                Console.WriteLine("Authorizetion test is FAILED");
            }
        }

    }
}
