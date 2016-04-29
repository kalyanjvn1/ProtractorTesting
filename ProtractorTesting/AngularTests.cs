using NUnit.Framework;
using ProtractorTesting.PageObjects;

namespace ProtractorTesting
{
    [TestFixture]
    public class AngularTests:TestBase
    {
        
        [SetUp]
        public override void Setup()
        {
            IntialiseDriverAndLaunchUrl();
        }

        [TearDown]
        public  void TestTearDown()
        {
            TearDown();
        }

        [Test]
        public void FilterBasedOnSearchCriteria()
        {
            Phone phoneInstance = new Phone(this);
            Assert.AreEqual(20, phoneInstance.PhoneResultCount(), "Phone result Count did not matched.");

            phoneInstance.SearchByName("nexus");
            Assert.AreEqual(1, phoneInstance.PhoneResultCount(), "Nexus phone count did not matched.");

            phoneInstance.SearchByName("motorola");
            Assert.AreEqual(8, phoneInstance.PhoneResultCount(), "motorola phone count did not matched.");

        }

        [Test]
        public void SortPhoneResultsBasedOnFilter()
        {
            Phone phoneInstance = new Phone(this);
            phoneInstance.SearchByName("tablet");
            Assert.AreEqual(2, phoneInstance.PhoneResultCount(), "Tablet result did not matched.");

            phoneInstance.SortByAlphabets();
            Assert.AreEqual("MOTOROLA XOOM™", phoneInstance.GetPhoneNames(0), "Result is not sorted in alphanetical order");
            Assert.AreEqual("Motorola XOOM™ with Wi-Fi",phoneInstance.GetPhoneNames(1),"Result is not sorted in alphanetical order");
        }

    }
}
