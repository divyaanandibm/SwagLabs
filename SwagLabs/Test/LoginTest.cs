using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Constraints;
using SwagLabAutomation.Pages;
using SwagLabAutomation.Tests; 

namespace SwagLabAutomation.Tests
{
    [TestFixture]
    public class LoginTests : BaseClass
    {
        [Test]
        public void TestLoginWithCredentials()
        {
            LoginPage loginPage = new LoginPage();
            loginPage.driver = this.driver;
            loginPage.CheckTitle();
            loginPage.credintials("standard_user", "secret_sauce");
            loginPage.LoginFunctionality();
            loginPage.Propass();
            loginPage.addtocart();
            loginPage.cartcheck();
            
        }
       
        
    }
}

