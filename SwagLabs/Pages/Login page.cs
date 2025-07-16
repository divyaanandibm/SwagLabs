using OpenQA.Selenium;
using SwagLabAutomation.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace SwagLabAutomation.Pages
{
    public class LoginPage : BaseClass
    {

        //Title check
        public string CheckTitle()
        {
            string txt1 = driver.FindElement(By.XPath("//div[@class='login_logo']")).Text;
            Console.WriteLine(txt1);
            Assert.That(txt1, Is.EqualTo("Swag Labs"), "Title does not match");
            return txt1;
        }

        //Credintials
        public void credintials(string username, string password)
        {
            driver.FindElement(By.Id("user-name")).SendKeys(username);
            driver.FindElement(By.Name("password")).SendKeys(password);
        }

        //Click Login
        public void LoginFunctionality()
        {
            driver.FindElement(By.Id("login-button")).Click();
        }

        // Title check ( Product )
       public string Propass()
        {
            string txt = driver.FindElement(By.XPath("//span[@class='title']")).Text;
            Console.WriteLine(txt);
            Assert.That(txt, Is.EqualTo("Products"), "Title does not match");
            return txt;

        }

        // add to cart button
        public void addtocart()
        {
            driver.FindElement(By.Id("add-to-cart-sauce-labs-bike-light")).Click();
        }

        // Cart check

        public string cartcheck()
        {
            string xpath = "//*[@data-test='shopping-cart-badge']";           
            string Atc = driver.FindElement(By.XPath(xpath)).Text;           
            Console.WriteLine(Atc);
            return Atc;
        }


    }
}
