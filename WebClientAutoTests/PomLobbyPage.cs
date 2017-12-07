using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebClientAutoTests
{
    public class PomLobbyPage
    {
        private readonly IWebDriver driver;
        
        private readonly string url = @"../../../WebClient/index.html";
       
        public IWebElement this[string propertyName] => (IWebElement)this.GetType().GetProperty(propertyName).GetValue(this, null);

        public PomLobbyPage(IWebDriver browser)
        {
            this.driver = browser;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "refSignin")]
        public IWebElement RefSignin { get; set; }

        [FindsBy(How = How.Id, Using = "refRegistration")]
        public IWebElement RefRegistration { get; set; }

        [FindsBy(How = How.Id, Using = "listGames")]
        public IWebElement ListGames { get; set; }

        [FindsBy(How = How.Id, Using = "chbox")]
        public IWebElement Chbox { get; set; }

        [FindsBy(How = How.Id, Using = "btnCreateRoom1")]
        public IWebElement BtnCreateRoom1 { get; set; }

        [FindsBy(How = How.Id, Using = "btnCreateRoom2")]
        public IWebElement BtnCreateRoom2 { get; set; }

        [FindsBy(How = How.Id, Using = "btnCreateRoom3")]
        public IWebElement BtnCreateRoom3 { get; set; }

        [FindsBy(How = How.Id, Using = "panelGamesOpened")]
        public IWebElement PanelGamesOpened { get; set; }

        [FindsBy(How = How.Id, Using = "tableTictactoe")]
        public IWebElement TableTictactoe { get; set; }

        [FindsBy(How = How.Id, Using = "tictactoeUserLogin")]
        public IWebElement TictactoeUserLogin { get; set; }

        [FindsBy(How = How.Id, Using = "tictactoeUserRate")]
        public IWebElement TictactoeUserRate { get; set; }

        [FindsBy(How = How.Id, Using = "tictactoeUserWins")]
        public IWebElement TictactoeUserWins { get; set; }

        [FindsBy(How = How.Id, Using = "tictactoeUserDefeats")]
        public IWebElement TictactoeUserDefeats { get; set; }

        [FindsBy(How = How.Id, Using = "btnJoin")]
        public IWebElement BtnJoin { get; set; }

        [FindsBy(How = How.Id, Using = "listFreePlayers")]
        public IWebElement ListFreePlayers { get; set; }

        public void Navigate()
        {
            string url = System.AppDomain.CurrentDomain.BaseDirectory + this.url;
            driver.Navigate().GoToUrl(url);
        }
    }
}
