using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModernUI
{
    class Selenium
    {
        //attributes
        private string address;
        private string username;
        private string password;
        private string userID;
        private string passID;
        private string loginID;

        //get/set
        public string Address { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string UserID { get; set; }
        public string PassID { get; set; }
        public string LoginID { get; set; }

        //overloaded constructor
        public Selenium(string address, string username, string password, string userID, string passID, string loginID)
        {
            this.address = address;
            this.username = username;
            this.password = password;
            this.userID = userID;
            this.passID = passID;
            this.loginID = loginID;
        }

        //default constructor
        public Selenium()
        {
            this.address = "";
            this.password = "";
            this.username = "";
            this.userID = "";
            this.passID = "";
            this.loginID = "";
        }

        //login call
        public void Login()
        {
            //Selenium Login Logic
            IWebDriver driver = new ChromeDriver("C://Users/travi/source/repos/selenium-dotnet-3.14.0/dist");
            driver.Navigate().GoToUrl(address);
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Id(userID)).SendKeys(username);
            driver.FindElement(By.Id(passID)).SendKeys(password);
            driver.FindElement(By.Name(loginID)).Click();

            string output = driver.FindElement(By.XPath(".//*[@id='tab-general']/div/div[2]/div[1]/div[2]/div/strong")).Text;

            if (output != null)
            {
                MessageBox.Show("Test Passed :)  ");
                Console.WriteLine("Test Passed :) ");
            }
            else
            {
                MessageBox.Show("Test Failed");
                Console.WriteLine("Test Failed");
            }
        }
    }
}
