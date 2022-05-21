using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Specflow.WebDriver.Tests.Hooks
{
    [Binding]
    public static class HookInitialization
    {
        private const int WaitTimeoutSeconds = 30;
        private const int WaitPollingSeconds = 1;

        private static readonly Lazy<ChromeDriver> lazyDriver = new(() => new ChromeDriver());
        public static ChromeDriver Driver => lazyDriver.Value;

        private static readonly Lazy<WebDriverWait> lazyDriverWait =
            new(() => new WebDriverWait(Driver, TimeSpan.FromSeconds(WaitTimeoutSeconds))
            {
                PollingInterval = TimeSpan.FromSeconds(WaitPollingSeconds)
            });
        public static WebDriverWait DriverWait => lazyDriverWait.Value;

        [BeforeTestRun]
        public static void BeforeScenario()
        {
            Driver.Manage().Window.Maximize();
        }

        [AfterTestRun]
        public static void AfterScenario()
        {
            Driver.Quit();
        }
    }
}
