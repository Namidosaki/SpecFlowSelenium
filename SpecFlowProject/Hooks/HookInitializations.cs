using TechTalk.SpecFlow;
using BoDi;
using GoogleLoginTest.Drivers;

namespace GoogleLoginTest.Hooks
{
    [Binding]
    public sealed class HookInitializations
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks
        [Binding]
        public class SharedBrowserHooks
        {
            /*[BeforeScenario]
            public static void BeforeTestRun(ObjectContainer testThreadContainer)
            {
                //Initialize a shared BrowserDriver in the global container
                testThreadContainer.BaseContainer.Resolve<BrowserDriver>();
            }*/
        }
    }
}