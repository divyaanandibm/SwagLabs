using OpenQA.Selenium;
using SwagLabAutomation.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwagLabAutomation.Pages
{
    public class LoginPage : BaseClass
    {
        public void logintitcheck()
        {
            driver.FindElement(By.XPath("//div[@class='login_logo']"));
        }
        public void credintials(string username, string password)
        {
            driver.FindElement(By.Id("user-name")).SendKeys(username);
            driver.FindElement(By.Name("password")).SendKeys(password);
        }

        public void LoginFunctionality()
        {
            driver.FindElement(By.Id("login-button")).Click();
        }

        public void protitlecheck()
        {
            driver.FindElement(By.XPath("//span[@class='title']"));
        }

        
    }
}
