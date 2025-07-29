using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.BiDi.Script;
using OpenQA.Selenium.DevTools.V136.Overlay;
using SwagLabAutomation.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Model;
using NUnit.Framework.Interfaces;

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

        // Cart cross verify

        public string cartcrossverify()
        {
            string crossxpath = "//span[@class='shopping_cart_badge']";
            string Crosscart = driver.FindElement(By.XPath(crossxpath)).Text;
            Console.WriteLine(Crosscart);
            return Crosscart;
        }

        // Remove add to cart

        public void addtocartremove1()
        {
            driver.FindElement(By.Id("add-to-cart-sauce-labs-bike-light")).Click();
        }

        // Cart cross verify 2

        public void cartcrossverify2()
        {
            string actualText = "";
            Assert.That(actualText, Is.EqualTo(string.Empty), $"Expected: '{string.Empty}', but Actual: '{actualText}'");
        }

        // Cart click all

        public void cartclickall()
        {
            List<string> cartclickall = new List<string>
            {
             "//button[@id='add-to-cart-sauce-labs-backpack']",
             "//button[@id='add-to-cart-sauce-labs-bike-light']",
             "//button[@id='add-to-cart-sauce-labs-bolt-t-shirt']",
             "//button[@id='add-to-cart-sauce-labs-fleece-jacket']",
             "//button[@id='add-to-cart-sauce-labs-onesie']",
             "//button[@id='add-to-cart-test.allthethings()-t-shirt-(red)']",
            };

            foreach (string xpath in cartclickall)
            {
                IWebElement Atcbutton = driver.FindElement(By.XPath(xpath));
                Atcbutton.Click();
            }

        }

        //cross verify all

        public string crossverifyall()
        {
            string xpathall = "//span[@class='shopping_cart_badge']";
            string Atcall = driver.FindElement(By.XPath(xpathall)).Text;
            Console.WriteLine(Atcall);
            return Atcall;
        }

        // Cart Unclick all
        public void cartunclickall()
        {
            List<string> cartclickall = new List<string>
            {
             "//button[@id='add-to-cart-sauce-labs-backpack']",
             "//button[@id='add-to-cart-sauce-labs-bike-light']",
             "//button[@id='add-to-cart-sauce-labs-bolt-t-shirt']",
             "//button[@id='add-to-cart-sauce-labs-fleece-jacket']",
             "//button[@id='add-to-cart-sauce-labs-onesie']",
             "//button[@id='add-to-cart-test.allthethings()-t-shirt-(red)']",
            };

            foreach (string xpath in cartclickall)
            {
                IWebElement Atcbutton = driver.FindElement(By.XPath(xpath));
                Atcbutton.Click();
            }

        }

        //all product price

        //product details

        public List<string> productxpaths = new List<string>
        {
         "//div[contains(text(), 'Sauce Labs Backpack')]",
         "//div[contains(text(), 'Sauce Labs Bike Light')]",
         "//div[contains(text(), 'Sauce Labs Bolt T-Shirt')]",
         "//div[contains(text(), 'Sauce Labs Fleece Jacket')]",
         "//div[contains(text(), 'Sauce Labs Onesie')]",
         "//div[contains(text(), 'Test.allTheThings() T-Shirt (Red)')]"
        };

        //price details

        public List<string> pricexpaths = new List<string>
        {
          "//div[@class='inventory_item_price' and contains(., '$29.99')]",
          "//div[@class='inventory_item_price' and contains(., '$9.99')]",
          "//div[@class='inventory_item_price' and contains(., '$15.99')]",
          "//div[@class='inventory_item_price' and contains(., '$49.99')]",
          "//div[@class='inventory_item_price' and contains(., '$7.99')]",
          "//div[@class='inventory_item_price' and contains(., '$15.99')]"
        };

        public Dictionary<string, string> Allproductprice = new Dictionary<string, string>();
        public string GetProductPrice()
        {
            for (int a = 0; a < productxpaths.Count; a++)
            {
                try
                {
                    string productname = driver.FindElement(By.XPath(productxpaths[a])).Text;
                    string productprice = driver.FindElement(By.XPath(pricexpaths[a])).Text;

                    if (!Allproductprice.ContainsKey(productname))
                    {
                        Allproductprice.Add(productname, productprice);
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine($"Not found{a}");
                }
            }
            string producttitle = "Sauce Labs Onesie";
            return Allproductprice.ContainsKey(producttitle) ? Allproductprice[producttitle] : "Product not found";
        }
        [Test]
        public static void comapare()
        {
            var compareall = new LoginPage();
            Assert.Equals("$7.99", compareall.GetProductPrice());
            Assert.That(compareall, Is.Ordered.Ascending.By(""));
        }

        //Click A to Z

        public void clickascending()
        {
            driver.FindElement(By.XPath("//select[@class='product_sort_container']")).Click();
        }

        public bool AtoZ()
        {
            driver.FindElement(By.XPath("//option[@value='az']")).Click();
            var productelements = driver.FindElements(By.ClassName("inventory_item_name"));

            List<string> actualnames = productelements.Select(p => p.Text).ToList();
            List<string> expectednames = new List<string>();

            expectednames.Sort();
           
            return actualnames.SequenceEqual(expectednames);
        }

        public bool ZtoA()
        {
            driver.FindElement(By.XPath("//option[@value='za']")).Click();
            var productelement2 = driver.FindElements(By.ClassName("inventory_item_name"));

            List<string> actualnames = productelement2.Select(p => p.Text).ToList();
            List<string> expectednames = new List<string>();

            actualnames.Sort();
            expectednames.Reverse();

            return actualnames.SequenceEqual(expectednames);
        }

        public bool LowtoHigh()
        {
            driver.FindElement(By.XPath("//option[@value='lohi']")).Click();
            var productelement3 = driver.FindElements(By.ClassName("inventory_item_name"));

            List<string> actualprice = productelement3.Select(p => p.Text).ToList();
            List<string> expectedprice = new List<string>();

            actualprice.Sort();
            expectedprice.Reverse();

            return actualprice.SequenceEqual(expectedprice);
        }

        public bool HightoLow()
        {
            driver.FindElement(By.XPath("//option[@value='hilo']")).Click();
            var productelement4 = driver.FindElements(By.ClassName("inventory_item_name"));

            List<string> actualprice = productelement4.Select(p => p.Text).ToList();
            List<String> expectedprice = new List<string>();

            actualprice.Reverse();

            return actualprice.SequenceEqual(expectedprice);
        }

        public void Access()
        {
            string filepath = @"C:\Users\Vision\Downloads\c#\code\at\expectedfile.txt";
            try
            {

                string[] lines = File.ReadAllLines(filepath);
                string liness = File.ReadAllText(filepath);

                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (Exception)
            {
                Console.WriteLine($"Error reading file:");
            }  
        }


        // Report access 

        ExtentReports reports;
        ExtentTest testlog;

        [OneTimeSetUp]

        public void Reportaccess()
        {
            var htmlreport = new ExtentSparkReporter("C:\\Users\\Vision\\Downloads\\c#\\code\\at\\expectedfile.txt");
            reports = new ExtentReports();
            reports.AttachReporter(htmlreport);
        }

        public void ValidLoginTest()
        {

            testlog = reports.CreateTest("Starting login test").Info("Test started");

            var loginPage = new LoginPage();
            testlog.Log(Status.Info, ("driver initiated"));

            loginPage.credintials("standard_user", "secret_sauce");
            testlog.Log(Status.Info, ("Login Performed"));

            string txt = driver.FindElement(By.XPath("//span[@class='title']")).Text;
            Console.WriteLine(txt);
            Assert.That(txt, Is.EqualTo("Products"), "Title does not match");
            testlog.Log(Status.Info, ("Title compared"));

        }
        [TearDown]
        public void teardown()
        {
            testlog.Log(Status.Info, ("extend report completed"));
        }

        [OneTimeTearDown]

        public void OTTD()
        {
            reports.Flush();
        }



    }



}

    











