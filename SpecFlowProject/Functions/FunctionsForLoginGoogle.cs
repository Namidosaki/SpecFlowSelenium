using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace GoogleLoginTest.Functions
{
    public class FunctionsForLoginGoogle
    {
        private IWebDriver _webDriver;

        public const int DefaultWaitInSeconds = 5;
        public WebDriverWait wait;

        public FunctionsForLoginGoogle(IWebDriver webDriver)
        {
            _webDriver = webDriver;
            wait = new WebDriverWait(_webDriver, TimeSpan.FromSeconds(DefaultWaitInSeconds));
        }

        private const string GoogleMailUrl = "https://mail.google.com";
        private const string ExpectedResult = "https://mail.google.com/mail/u/0/#inbox";

        private IWebElement LoginElement => _webDriver.FindElement(By.Id("identifierId"));
        private IWebElement ButtonLoginElement => _webDriver.FindElement(By.Id("identifierNext"));
        private IWebElement PasswordElement => _webDriver.FindElement(By.Name("password"));
        private IWebElement ButtonPasswordElement => _webDriver.FindElement(By.Id("passwordNext"));

        public void Open_Google()
        {
            _webDriver.Url = GoogleMailUrl;
            wait.Until(url => url.PageSource != null);
        }

        public void Enter_Field(string data, string field)
        {
            if (field == "login")
            {
                wait.Until(search => search.FindElement(By.Id("identifierId")).Displayed);
                LoginElement.Clear();
                LoginElement.SendKeys(data);
            }
            if (field == "password")
            {
                wait.Until(search => search.FindElement(By.Name("password")).Displayed);
                PasswordElement.Clear();
                PasswordElement.SendKeys(data);
            }
        }

        public void Press_Button(string button)
        {

            if (button == "login")
                ButtonLoginElement.Click();
            if (button == "password")
                ButtonPasswordElement.Click();

        }

        public bool Result()
        {
            return wait.Until(waiting => waiting.Url.Contains(ExpectedResult));
        }
    }
}
