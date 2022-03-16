using GoogleLoginTest.Drivers;
using GoogleLoginTest.Functions;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace GoogleLoginTest.StepDefinitions
{
    [Binding]
    public class LoginEmailGoogleStepDefinitions
    {
        private readonly FunctionsForLoginGoogle _functionsForLoginGoogle;

        public LoginEmailGoogleStepDefinitions(BrowserDriver browserDriver)
        {
            _functionsForLoginGoogle = new FunctionsForLoginGoogle(browserDriver.Current);
        }

        [Given(@"open the Google website")]
        public void GivenOpenTheGoogleWebsite()
        {
            _functionsForLoginGoogle.Open_Google();
        }

        [When(@"enter the ""([^""]*)"" ""([^""]*)""")]
        public void WhenEnterThe(string data, string field)
        {
            _functionsForLoginGoogle.Enter_Field(data, field);
        }

        [When(@"click the ""([^""]*)"" button")]
        public void WhenClickTheButton(string button)
        {
            _functionsForLoginGoogle.Press_Button(button);
        }

        [Then(@"expected result is opened")]
        public void ThenExpectedResultIsOpened()
        {
            bool result = _functionsForLoginGoogle.Open_Mail();
            Assert.IsTrue(result);
        
        }

        [Then(@"next page doesn't open")]
        public void ThenNextPageDoesntOpen()
        {
            bool result = _functionsForLoginGoogle.Dont_Open_Password_Page();
            Assert.IsTrue(result);
        }

        [Then(@"expected result isn't opened")]
        public void ThenExpectedResultIsntOpened()
        {
            bool result = _functionsForLoginGoogle.Dont_Open_Mail();
            Assert.IsTrue(result);
        }
    }
}
