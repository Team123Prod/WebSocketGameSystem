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
    public class LobbyAutoTests<TWebDriver> where TWebDriver : IWebDriver, new()
    {
        public static IWebDriver Driver { get; set; }
        public WebDriverWait Wait { get; set; }
        public PomLobbyPage LobbyPage { get; set; }

        [OneTimeSetUp]
        public void InitDriver()
        {
            Driver = new TWebDriver();
            LobbyPage = new PomLobbyPage(Driver);
            LobbyPage.Navigate();
        }

        [OneTimeTearDown]
        public static void TearDown()
        {
            Driver.Quit();
        }

        [Test]
        [TestCase("RefSignin")]
        [TestCase("RefRegistration")]
        [TestCase("ListGames")]
        [TestCase("Chbox")]
        [TestCase("BtnCreateRoom1")]
        [TestCase("BtnCreateRoom2")]
        [TestCase("BtnCreateRoom3")]
        [TestCase("BtnJoin")]
        [TestCase("ListFreePlayers")]
        [TestCase("PanelGamesOpened")]
        [TestCase("TableTictactoe")]
        [TestCase("TictactoeUserLogin")]
        [TestCase("TictactoeUserRate")]
        [TestCase("TictactoeUserWins")]
        [TestCase("TictactoeUserDefeats")]

        public void LobbyElementsDisplayed(string webElement)
        {
            Assert.AreEqual(true, LobbyPage[webElement].Displayed);
        }

        [TestCase("RefSignin", "Sign in")]
        [TestCase("RefRegistration", "Registration")]
        [TestCase("BtnCreateRoom2", "Create room")]
        [TestCase("BtnCreateRoom3", "Create room")]
        [TestCase("BtnJoin", "JOIN")]
        public void LobbyElementsClicked(string webElement, string exp)
        {
            LobbyPage[webElement].Click();
            string res = LobbyPage[webElement].Text;
            Assert.AreEqual(exp, res);
        }
    }
}
