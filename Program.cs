using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace ConsoleApp2
{
    class Program
    {
        public static object MaterialButton { get; private set; }

        static void Main(string[] args)
        {
            //open up chrome browser
            IWebDriver driver = new ChromeDriver();

            //launch the url
            driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login?");
            driver.Manage().Window.Maximize();

            //enter valid username
            IWebElement username = driver.FindElement(By.Id("UserName"));
            username.SendKeys("hari");

            //enter valid password
            IWebElement password = driver.FindElement(By.Id("Password"));
            password.SendKeys("123123");
            //click on login button
            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
            loginButton.Click();

            //Verify if you are on home page

            //Identify"hello hari"
            IWebElement homepage = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));

            if (homepage.Text == "Hello hari!")
            {
                Console.WriteLine("Hello Hari displayed, Test Passed");

            }
            else
            {
                Console.WriteLine("Text didnt match, Test Failed");
                
            }

            //Click on adminstration drop down
            IWebElement AdmistrationDropDown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            AdmistrationDropDown.Click();

            //select time & material option
            IWebElement timematerialButton = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            timematerialButton.Click();

            Thread.Sleep(1000);

            //verify if you are on Time& matreial page
             
            //Identify Create new button
            IWebElement timematerialpage = driver.FindElement(By.XPath("//*[@id='container']/p/a"));

            //if (timematerialpage.Text == "Create New")
            //{
            //    Console.WriteLine("Create New displayed,Test Passed");
            //}
            //else
            //{
            //    Console.WriteLine("Text didnt match, Test Failed");
            //}

            //click on create new button
            IWebElement Createnew = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            Createnew.Click();
            Thread.Sleep(1000);


            //Click on typecode  dropdown
            IWebElement Typecodedropdown = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/label"));
            Typecodedropdown.Click();
            Thread.Sleep(1000);


            //Select time or material option from typecode dropdown
            IWebElement TimeButton = driver.FindElement(By.ClassName("k-input"));
            TimeButton.Click();
            Thread.Sleep(1000);


            //Enter a valid code
            IWebElement Code = driver.FindElement(By.Id("Code"));
             Code.SendKeys("Code2345");
            Thread.Sleep(1000);


            //Enter a valid description
            IWebElement Description = driver.FindElement(By.Id ("Description"));
            Description.SendKeys("AUtomation Testing 1234");
            Thread.Sleep(1000);

            IWebElement PPU = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            PPU.SendKeys("1500");
            Thread.Sleep(1000);


            //click on save button
            IWebElement savebutton = driver.FindElement(By.XPath("//*[@id='SaveButton']"));
            savebutton.Click();
            Thread.Sleep(1000);


            //Navigates to the last page
            IWebElement lastpage = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]"));



            //IWebElement TMpage = driver.FindElement(By.XPath(""));

            //if (TMpage.Text == "")
            //{
            //    Console.WriteLine("Morgan123 displayed, Test Passed");
            //}

            //else

            //{
            //    Console.WriteLine("Text didn't match, Test Failed");

            //}

        }



        private static void Maximize()
        {
            throw new NotImplementedException();
        }
    }
}
