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
            loginPage.credintials("standard_user", "secret_sauce");
            loginPage.LoginFunctionality();
            CheckTitle();
        }
        [Test]
        public void CheckTitle()
        {
            Assert.Equals(driver.Title, Is.EqualTo("Swag Labs"), "Page title does not match after login.");
        }
    }
}

