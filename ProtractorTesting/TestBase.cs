using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Protractor;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;

namespace ProtractorTesting
{
    public abstract class TestBase 
    {
        public IWebDriver webDriver;
        public NgWebDriver ngWebDriver;
        public ITimeouts scriptLoadTime;
        string baseUrl = "http://localhost:8000/app/index.html";

        public abstract void Setup();
        public void TearDown()
        {
            if (webDriver != null)
            {
                ngWebDriver.Quit();
            }
        }

        public void IntialiseDriverAndLaunchUrl()
        {
            webDriver = new FirefoxDriver();
            ngWebDriver = new NgWebDriver(webDriver);
            scriptLoadTime =  webDriver.Manage().Timeouts().SetScriptTimeout(TimeSpan.FromSeconds(5));
            ngWebDriver.Navigate().GoToUrl(baseUrl);
        }

    }
}
