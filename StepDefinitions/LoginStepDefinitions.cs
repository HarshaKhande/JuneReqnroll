using System;
using System.Drawing;
using Allure.Net.Commons;
using Allure.NUnit.Attributes;
using NUnit.Framework;
using OpenQA.Selenium;
using Reqnroll;
using Reqnroll.UnitTestProvider;
using ReqnrollProject.Pages;
using Allure.Commons;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;

namespace ReqnrollProject.StepDefinitions
{

    [AllureNUnit]
    [Allure.NUnit.Attributes.AllureSuite("Login Suite")]
    [Binding]
    public class LoginStepDefinitions
    {


        private readonly LoginPage lp;

        public LoginStepDefinitions(DriverContext context)
        {
            lp = new LoginPage(context.Driver);
        }

        
        [Test]
        [AllureSeverity(SeverityLevel.normal)]
        [Allure.NUnit.Attributes.AllureSuite("Login Suite")]
        [Given("User is on the orangehrm login page")]
        public void GivenUserIsOnTheOrangehrmLoginPage()
        {;
        
            lp.launchbrowser();
            Thread.Sleep(2000);
        }

        
        [Test]
        [AllureSeverity(SeverityLevel.normal)]
        [Allure.NUnit.Attributes.AllureSuite("Login Suite")]]
        [When("User enters the username {string} and password {string} in the text fields")]
        public void WhenUserEntersTheUsernameAndPasswordInTheTextFields(string username, string password)
        {

           
            lp.enterusernamepass(username, password);
        }


        
        [Test]
        [AllureSeverity(SeverityLevel.normal)]
        [Allure.NUnit.Attributes.AllureSuite("Login Suite")]
        [When("User clicks on submit button")]
        public void WhenUserClicksOnSubmitButton()
        {
           lp.submit();
        }

        
        [Test]
        [AllureSeverity(SeverityLevel.normal)]
        [Allure.NUnit.Attributes.AllureSuite("Login Suite")]        
        [Then("User is navigated to home page")]
        public void ThenUserIsNavigatedToHomePage()
        {
            lp.homepagedisplay();
        }


        
        [Test]
        [AllureSeverity(SeverityLevel.normal)]
        [Allure.NUnit.Attributes.AllureSuite("Login Suite")]
        [When("User enters the {string} and {string} in the input fields")]
        public void WhenUserEntersTheAndInTheInputFields(string admin, string p1)
        {
            Console.WriteLine("User enters the username and the password");

        }


        
        [Test]
        [AllureSeverity(SeverityLevel.normal)]
        [Allure.NUnit.Attributes.AllureSuite("Login Suite")]
        [Then("User selected city and country information")]
        public void ThenUserSelectedCityAndCountryInformation(DataTable dataTable)
        {
  


            foreach (var row in dataTable.Rows)
            { 
            string city = row["city"];
            string country = row["country"];
            Console.WriteLine(city + "," + country);
        }
        }


    }
}
