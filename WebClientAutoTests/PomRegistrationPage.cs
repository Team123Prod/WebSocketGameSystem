using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebClientAutoTests
{
    public class PomRegistrationPage
    {
        private readonly IWebDriver driver;

        private readonly string url = @"../../../WebClient/registration.html";

        public IWebElement this[string propertyName] => (IWebElement)this.GetType().GetProperty(propertyName).GetValue(this, null);

        public PomRegistrationPage(IWebDriver browser)
        {
            this.driver = browser;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "email")]
        public IWebElement FieldEmail { get; set; }

        [FindsBy(How = How.Id, Using = "login")]
        public IWebElement FieldLogin { get; set; }

        [FindsBy(How = How.Id, Using = "pwd1")]
        public IWebElement FieldPassword { get; set; }

        [FindsBy(How = How.Id, Using = "pwd2")]
        public IWebElement FieldPasswordRepeat { get; set; }

        [FindsBy(How = How.Id, Using = "submit")]
        public IWebElement BtnSave { get; set; }

        public void Navigate()
        {
            string url = System.AppDomain.CurrentDomain.BaseDirectory + this.url;
            driver.Navigate().GoToUrl(url);
        }
    }
}
