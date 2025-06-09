using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using ReqnrollProject.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Reqnroll.BoDi;


namespace ReqnrollProject.Hooks
{
    [Binding]
    public  class Hooks
    {

        // private readonly ScenarioContext _scenarioContext;

        // private readonly DriverContext _context;

        // public Hooks(DriverContext context)
        // {
        //   _context = context;
        // }

        private readonly IObjectContainer _container;
        private IWebDriver _driver;

        public Hooks(IObjectContainer container)
        {
            _container = container;
        }


        [BeforeScenario]
        public void Setup()
        {

            Console.WriteLine("Running before every scenario");
            new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
            // IWebDriver driver = new FirefoxDriver();
            // _context["WebDriver"] = driver;

            var options = new EdgeOptions();
            options.AddArgument("--headless=new");
            options.AddArgument("--no-sandbox");
            options.AddArgument("--disable-dev-shm-usage");

            _driver = new EdgeDriver(options);

            _driver.Manage().Window.Maximize();

        }

        [AfterScenario]
        public void TearDown()
        {

            _driver.Quit();
        }

        [BeforeTestRun]
        public static void BeforeTestRun()
        {

            TestContext.Progress.WriteLine("Running before TestRun for login functionality");

        }



        [AfterTestRun]
        public static void AfterTestRun()
        {


            TestContext.Progress.WriteLine("Running after TestRun for login functionality");


        }

        [BeforeStep]
        public void BeforeStep()
        {

            Console.WriteLine("Running before step");

        }



        [AfterStep]
        public void AfterStep()
        {

            Console.WriteLine("Running after step");

        }

        [BeforeScenario]
        public void BeforeScenario()
        {

            Console.WriteLine("Running before every scenario ");

        }



        [AfterScenario]
        public void AfterScenario()
        {

            Console.WriteLine("Running after every scenario");

        }


    }

}
