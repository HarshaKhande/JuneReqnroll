using System;
using System.Drawing;
using Allure.Net.Commons;
using Allure.NUnit;
using Allure.NUnit.Attributes;
using NUnit.Framework;
using OpenQA.Selenium;
using Reqnroll;
using Reqnroll.UnitTestProvider;
using ReqnrollProject.Pages;
using ReqnrollProject.Utilities;

namespace ReqnrollProject.StepDefinitions
{


    [AllureNUnit]
    [AllureSuite("Login Feature")]
    [Binding]
    public class LoginStepDefinitions
    {


        private readonly LoginPage _loginPage;

        public LoginStepDefinitions(LoginPage loginPage)
        {
            _loginPage = loginPage;
        }

        [Test]
        [AllureSeverity(SeverityLevel.normal)]
        [AllureSuite("Login Feature")]
        [Given("User is on the orangehrm login page")]
        public void GivenUserIsOnTheOrangehrmLoginPage()
        {
            Log.Info("Opening the application in the browser");
            _loginPage.launchbrowser();
            Thread.Sleep(2000);
        }

        [Test]
        [AllureSeverity(SeverityLevel.normal)]
        [AllureSuite("Login Feature")]
        [When("User enters the username {string} and password {string} in the text fields")]
        public void WhenUserEntersTheUsernameAndPasswordInTheTextFields(string username, string password)
        {

            Log.Info("Entering the username nd password");
            _loginPage.enterusernamepass(username, password);
        }

        [Test]
        [AllureSeverity(SeverityLevel.normal)]
        [AllureSuite("Login Feature")]
        [When("User clicks on submit button")]
        public void WhenUserClicksOnSubmitButton()
        {
            _loginPage.submit();
        }

        [Test]
        [AllureSeverity(SeverityLevel.normal)]
        [AllureSuite("Login Feature")]
        [Then("User is navigated to home page")]
        public void ThenUserIsNavigatedToHomePage()
        {
            _loginPage.homepagedisplay();
        }

        [Test]
        [AllureSeverity(SeverityLevel.normal)]
        [AllureSuite("Login Feature")]
        [When("User enters the {string} and {string} in the input fields")]
        public void WhenUserEntersTheAndInTheInputFields(string admin, string p1)
        {
            Console.WriteLine("User enters the username and the password");

        }

        [Test]
        [AllureSeverity(SeverityLevel.normal)]
        [AllureSuite("Login Feature")]
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
