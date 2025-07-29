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
using NUnit.Framework.Internal;
using AventStack.ExtentReports.Model;

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
            Thread.Sleep(1000);

            loginPage.credintials("standard_user", "secret_sauce");
            Thread.Sleep(1000);

            loginPage.LoginFunctionality();
            Thread.Sleep(1000);

            loginPage.Propass();
            Thread.Sleep(1000);

            loginPage.addtocart();
            Thread.Sleep(1000);

            loginPage.cartcheck();
            Thread.Sleep(1000);

            loginPage.cartcrossverify();
            Thread.Sleep(1000);

            loginPage.addtocartremove1();
            Thread.Sleep(1000);

            loginPage.cartcrossverify2();
            Thread.Sleep(1000);

            loginPage.cartclickall();
            Thread.Sleep(1000);

            loginPage.crossverifyall();
            Thread.Sleep(1000);

            loginPage.cartunclickall();
            Thread.Sleep(1000);

            loginPage.GetProductPrice();
            Thread.Sleep(1000);

            loginPage.clickascending();
            Thread.Sleep(1000);

            loginPage.AtoZ();
            Thread.Sleep(1000);

            loginPage.ZtoA();
            Thread.Sleep(1000);

            loginPage.LowtoHigh();
            Thread.Sleep(1000);

            loginPage.HightoLow();
            Thread.Sleep(1000);

            loginPage.Access();
            Thread.Sleep(1000);
            
           






    }


}
}

