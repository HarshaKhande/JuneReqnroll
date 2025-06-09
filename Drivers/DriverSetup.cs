using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using Reqnroll.BoDi;


namespace ReqnrollProject.Drivers
{
    [Binding]
    public  class DriverSetup
    {

 
       
            private readonly IObjectContainer _container;
            private IWebDriver _driver;

            public DriverSetup(IObjectContainer container)
            {
                _container = container;
            }

            [BeforeScenario]
            public void InitializeWebDriver()
            {
                _driver = new ChromeDriver();
                _driver.Manage().Window.Maximize();
                _container.RegisterInstanceAs<IWebDriver>(_driver);
            }

            [AfterScenario]
            public void TearDownWebDriver()
            {
                _driver?.Quit();
            }
        }
    }

