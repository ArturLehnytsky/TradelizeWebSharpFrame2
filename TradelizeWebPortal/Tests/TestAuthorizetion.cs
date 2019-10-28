using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradelizeWebPortal.Settings;

namespace TradelizeWebPortal.Tests
{
   
    public class TestAuthorizetion : Browser
    {
          

        [Test]
        public void TestAuthorizationByLogin()
        {
            log.OpenLoginPage();
            log.SignInByEmail();    
            
        }
    }
}
