using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebClientAutoTests
{
    [TestFixture(typeof(ChromeDriver))]
    public class RegistrationAutoTests<TWebDriver> where TWebDriver : IWebDriver, new()
    {
        public static IWebDriver Driver { get; set; }
        public WebDriverWait Wait { get; set; }
        public PomRegistrationPage RegistrationPage { get; set; }

        [OneTimeSetUp]
        public void InitDriver()
        {
            Driver = new TWebDriver();
            RegistrationPage = new PomRegistrationPage(Driver);
            RegistrationPage.Navigate();
        }

        [OneTimeTearDown]
        public static void TearDown()
        {
            Driver.Quit();
        }

        [Test]
        [TestCase("FieldEmail")]
        [TestCase("FieldLogin")]
        [TestCase("FieldPassword")]
        [TestCase("FieldPasswordRepeat")]
        [TestCase("BtnSave")]
        public void LobbyElementsDisplayed(string webElement)
        {
            Assert.AreEqual(true, RegistrationPage[webElement].Displayed);
        }

        [TestCase("BtnSave", "Save")]
        public void LobbyElementsClicked(string webElement, string exp)
        {
            RegistrationPage[webElement].Click();
            string res = RegistrationPage[webElement].Text;
            Assert.AreEqual(exp, res);
        }
    }
}
