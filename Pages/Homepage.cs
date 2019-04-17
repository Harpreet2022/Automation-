using ConsoleApp2.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp2.Pages
{
    class Homepage
    {
        public void navigatesTM()
        {

            //Click on adminstration drop down
            CommerDriver.driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a")).Click();
            

            //select time & material option
            IWebElement timematerialButton = CommerDriver.driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            timematerialButton.Click();

            Thread.Sleep(1000);
        }
    }
}
