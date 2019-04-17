using ConsoleApp2.Helpers;
using ConsoleApp2.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace ConsoleApp2
{
    [TestFixture]
    class Program
    {

        static void Main(string[] args)
        {

        }

           [SetUp]
        public void setup()
        {
            //defining driver
            CommerDriver.driver = new ChromeDriver();

            //login object and logging into turnup
            Loginpage loginpage = new Loginpage();
            loginpage.loginsteps();

            //homepage object and navigates to TM page
            Homepage homepage = new Homepage();
            homepage.navigatesTM();
        }
         [Test]
         public void testcreateTM()
        {
            //TMpage object and create new record
            TMPage tmpage = new TMPage();
            tmpage.createTM();
        }
        
        [Test]
        public void testeditTM()
        {
            //TMpage object and editing an existing record
            TMPage tmpage = new TMPage();
            tmpage.editTM();
        }
        [Test]
        public void testdeleteTM()
        {
            //TMPage object and delete an existing record
            TMPage tmpage = new TMPage();
            tmpage.deleteTM();
        }
        [TearDown ]
        public void teardown()
        {
            CommerDriver.driver.Close();
        }


           




        }



       
        }
    
