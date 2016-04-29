using Protractor;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;

namespace ProtractorTesting
{
    public class AutomationTestBase 
    {

        public AutomationTestBase(TestBase testBase)
        {
            TestBaseInstance = testBase;
            driver = TestBaseInstance.webDriver;
            ngDriver = TestBaseInstance.ngWebDriver;
            scriptTimeout = TestBaseInstance.scriptLoadTime;
           
        }

        public TestBase TestBaseInstance { get; set; }
        public IWebDriver driver { get; set; }
        public NgWebDriver ngDriver { get; set; }

        public ITimeouts scriptTimeout { get; set; }
        
    }
}
