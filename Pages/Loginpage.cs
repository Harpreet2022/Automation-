using ConsoleApp2.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Pages
{
    class Loginpage
    {
        public object CommonDriver { get; private set; }

        public void loginsteps()
        {
            

            //launch the url
            CommerDriver.driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login?");
            CommerDriver.driver.Manage().Window.Maximize();

            //enter valid username
            IWebElement username = CommerDriver.driver.FindElement(By.Id("UserName"));
            username.SendKeys("hari");

            //enter valid password
            IWebElement password = CommerDriver.driver.FindElement(By.Id("Password"));
            password.SendKeys("123123");
            //click on login button
            IWebElement loginButton = CommerDriver.driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
            loginButton.Click();

            //Verify if you are on home page

            //Identify"hello hari"
            IWebElement homepage = CommerDriver.driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));

            if (homepage.Text == "Hello hari!")
            {
                Console.WriteLine("Hello Hari displayed, Test Passed");

            }
            else
            {
                Console.WriteLine("Text didnt match, Test Failed");

            }
        }
    }
}
