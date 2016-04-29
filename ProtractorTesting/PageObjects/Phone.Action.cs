using System.Linq;

namespace ProtractorTesting.PageObjects
{
    public partial class Phone
    {
        public void LaunchUrl(string url)
        {
            ngDriver.Navigate().GoToUrl(url);
        }

        public int PhoneResultCount()
        {
            return PhoneResults.Count();
        }

        public void SearchByName(string phoneName)
        {
            Search.Clear();
            Search.SendKeys(phoneName);
        }

        public void SortByAlphabets()
        {
            SortByAlphabetical.Click();
        }

        public void SortByNewest()
        {
            SortNewest.Click();
        }

        public string GetPhoneNames(int index)
        {
            return PhoneResults.ElementAt(index).Evaluate("phone.name") as string;
        }

    }
}
