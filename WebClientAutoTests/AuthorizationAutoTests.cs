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
    public class AuthorizationAutoTests<TWebDriver> where TWebDriver : IWebDriver, new()
    {
        public static IWebDriver Driver { get; set; }
        public WebDriverWait Wait { get; set; }
        public PomAuthorizationPage AuthorizationPage { get; set; }

        [OneTimeSetUp]
        public void InitDriver()
        {
            Driver = new TWebDriver();
            AuthorizationPage = new PomAuthorizationPage(Driver);
            AuthorizationPage.Navigate();
        }

        [OneTimeTearDown]
        public static void TearDown()
        {
            Driver.Quit();
        }

        [Test]
        [TestCase("FieldLogin")]
        [TestCase("FieldPassword")]
        [TestCase("BtnSubmit")]
        public void LobbyElementsDisplayed(string webElement)
        {
            Assert.AreEqual(true, AuthorizationPage[webElement].Displayed);
        }

        [TestCase("BtnSubmit", "Submit")]
        public void LobbyElementsClicked(string webElement, string exp)
        {
            AuthorizationPage[webElement].Click();
            string res = AuthorizationPage[webElement].Text;
            Assert.AreEqual(exp, res);
        }
    }
}
