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
    class TMPage
    {
        public void createTM()
        {

            //click on create new button
            IWebElement Createnew = CommerDriver.driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            Createnew.Click();
            Thread.Sleep(1000);


            //Click on typecode  dropdown
            IWebElement Typecodedropdown = CommerDriver.driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/label"));
            Typecodedropdown.Click();
            Thread.Sleep(1000);


            //Select time or material option from typecode dropdown
            IWebElement TimeButton = CommerDriver.driver.FindElement(By.ClassName("k-input"));
            TimeButton.Click();
            Thread.Sleep(1000);


            //Enter a valid code
            IWebElement Code = CommerDriver.driver.FindElement(By.Id("Code"));
            Code.SendKeys("Code123");
            Thread.Sleep(1000);


            //Enter a valid description
            IWebElement Description = CommerDriver.driver.FindElement(By.Id("Description"));
            Description.SendKeys("AUtomation Testing 1234");
            Thread.Sleep(1000);

            IWebElement PPU = CommerDriver.driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            PPU.SendKeys("1500");
            Thread.Sleep(1000);

            ////click on selectfiles button and upload a file
            //IWebElement selectfilesbutton = CommerDriver.driver.FindElement(By.XPath("//*[@id='files']"));
            //selectfilesbutton.Click();
            //Thread.Sleep(5000);
            //System.Windows.Forms.SendKeys.SendWait(@"C:\Testfile.jpg");
            //System.Windows.Forms.SendKeys.SendWait(@"{Enter}");


            //click on save button
            IWebElement savebutton = CommerDriver.driver.FindElement(By.XPath("//*[@id='SaveButton']"));
            savebutton.Click();
            Thread.Sleep(1000);


            //Navigates to the last page
            IWebElement lastpagebutton = CommerDriver.driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            lastpagebutton.Click();
            Thread.Sleep(1000);
            Thread.Sleep(1000);

            //Verify if the new record created successfully

            // Identify "Code123"
            IWebElement lastpage = CommerDriver.driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr/td[1]"));

            if (lastpage.Text == "Code123")
            {
                Console.WriteLine("Code123 displayed, Test Passed");
            }
            else
            {
                Console.WriteLine(" Text didnt match, Test Failed");
            }

        }
        public void editTM()
        {
            //Edit an existing Time and Material Record

            // Navigates to the first page 
            CommerDriver.driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[1]/span")).Click();
            Thread.Sleep(1000);

            // Click on Edit Button for any record
            IWebElement Editbutton = CommerDriver.driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[1]/td[5]/a[1]"));
            Editbutton.Click();
            Thread.Sleep(1000);

            // Edit/updated code in the "code" testbox for selected record
            CommerDriver.driver.FindElement(By.XPath("//*[@id='Code']")).Clear();
            CommerDriver.driver.FindElement(By.XPath("//*[@id='Code']")).SendKeys("T&M12");

            //Save the updated record
            CommerDriver.driver.FindElement(By.XPath("//*[@id='SaveButton']")).Click();
            Thread.Sleep(1000);
            Thread.Sleep(1000);

            //verify if the record updated successfully
            IWebElement actualcode = CommerDriver.driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[1]/td[1]"));

            if (actualcode.Text == "T&M12")
            {
                Console.WriteLine("TM  record edited succesfully , Test Passed");
            }
            else
            {
                Console.WriteLine("TM not edited successfully, Test Failed");
            }

        }
        public void deleteTM()
        {
            // Delete an existing Time & Material record

            //Click on delete button for any record on time & material page 
            CommerDriver.driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[1]/td[5]/a[2]")).Click();
            Thread.Sleep(1000);

            //click on Ok Button from popup to delete the selected record
            CommerDriver.driver.SwitchTo().Alert().Accept();
            Thread.Sleep(1000);

        }
    }
}
