using System.Collections.Generic;
using OpenQA.Selenium;
using Protractor;

namespace ProtractorTesting.PageObjects
{
    public partial class Phone : AutomationTestBase
    {
        private readonly By search = NgBy.Model("query");
        private readonly By result = NgBy.Repeater("phone in phones");
        private readonly By sortBy = NgBy.Model("orderProp");
        private readonly By phoneName = NgBy.Binding("ng-binding");

        public Phone(TestBase testBase):base(testBase)
        { }

        public NgWebElement Search 
        {
            get { return ngDriver.FindElement(search); }
        }

        public IReadOnlyCollection<NgWebElement> PhoneResults
        {
            get { return ngDriver.FindElements(result); }
        }

        public NgWebElement SortBy 
        {
            get { return ngDriver.FindElement(sortBy); }
        }
        
        public NgWebElement SortNewest
        {
            get
            {
                return ngDriver.FindElement(sortBy)
                                  .FindElement(By.XPath("//option[@value='age']"));
            }
        }

        public NgWebElement SortByAlphabetical
        {
            get
            {
                return ngDriver.FindElement(sortBy)
                                  .FindElement(By.XPath("//option[@value='name']"));
            }
        }

       
    }
}
