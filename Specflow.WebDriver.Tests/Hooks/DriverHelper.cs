using OpenQA.Selenium;

namespace Specflow.WebDriver.Tests.Hooks
{
    public static class DriverHelper
    {
        public static IWebElement WaitAndReturnElement(By by)
        {
            return HookInitialization.DriverWait.Until(drv => (drv.FindElements(by).Count > 0) ? drv.FindElement(by) : null)!;
        }

        public static void GoToUrl(string url)
        {
            HookInitialization.Driver.Navigate().GoToUrl(url);
        }

        public static string GetUrl()
        {
            return HookInitialization.Driver.Url;
        }
    }
}
