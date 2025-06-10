using Allure.Net.Commons;
using Allure.NUnit;
using Allure.NUnit.Attributes;
using NUnit.Framework;
using OpenQA.Selenium;
using ReqnrollProject.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReqnrollProject.Pages
{

    [TestFixture]
    public class LoginPage
    {


        // locators and the methods or the tests to be performed on the page 

        //  private IWebDriver driver;

        private readonly IWebDriver _driver;
 

        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
        }

       

        // locators on the login page 


        By usernameField = By.XPath("//input[@name = 'username']");
        By passwordField = By.XPath("//input[@name = 'password']");
        By loginFormLocator = By.XPath("//button[@type = 'submit']");
        By homepagedisplayed = By.XPath("(//a[@class = 'oxd-main-menu-item'])[1]");

        // laucnh browser 

        public void launchbrowser()
        {

            _driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com");
            
        }



        // enter username and password 
   
        public void enterusernamepass(String username, String password)
        {

            _driver.FindElement(usernameField).SendKeys(username);
            _driver.FindElement(passwordField).SendKeys(password);

        }


        // submit method 
  
        public void submit()
        {
            _driver.FindElement(loginFormLocator).Click();
        }

        // home page is displayed 
    
        public void homepagedisplay()
        {

            Thread.Sleep(3000);
            IWebElement homepage = _driver.FindElement(homepagedisplayed);

            if (homepage.Displayed)
            {
                Console.WriteLine("Home page is displayed");
            }
            else
            {

                Console.WriteLine("Home page is not displayed");
            }




        }
    }

}
