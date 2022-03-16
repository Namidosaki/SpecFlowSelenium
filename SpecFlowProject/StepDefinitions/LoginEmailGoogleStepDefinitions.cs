using GoogleLoginTest.Drivers;
using GoogleLoginTest.Functions;
using GoogleLoginTest.Models;
using GoogleLoginTest.Storage;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace GoogleLoginTest.StepDefinitions
{
    [Binding]
    public class LoginEmailGoogleStepDefinitions
    {
        private readonly FunctionsForLoginGoogle _functionsForLoginGoogle;
        private readonly CredentionalStorage _credentionalStorage;

        public LoginEmailGoogleStepDefinitions(BrowserDriver browserDriver)
        {
            _functionsForLoginGoogle = new FunctionsForLoginGoogle(browserDriver.Current);
            _credentionalStorage = new CredentionalStorage();
        }

        [Given(@"open the Google website")]
        public void GivenOpenTheGoogleWebsite()
        {
            _functionsForLoginGoogle.Open_Google();
        }

        [When(@"enter the ""([^""]*)"" ""([^""]*)"" ""([^""]*)""")]
        public void WhenEnterThe(string state, int data, string field)
        {
            var cred = new CredentionalModel();
            if (state == "valid")
                cred = _credentionalStorage.Credentions.Valid[data];
            if (state == "invalid")
                cred = _credentionalStorage.Credentions.Invalid[data];
            

            _functionsForLoginGoogle.Enter_Field(cred, field);
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
            Assert.IsFalse(result);
        }
    }
}
