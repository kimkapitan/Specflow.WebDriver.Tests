using OpenQA.Selenium;
using Specflow.WebDriver.Tests.Hooks;

namespace Specflow.WebDriver.Tests.StepDefinitions
{
    [Binding]
    public class SpecflowWebDriverStepDefinitions
    {
        [Given(@"Go To Url '([^']*)'")]
        public void GivenGoToUrlHttpsSolveway_ClubAuthSignin(string url)
        {
            HookInitialization.Driver.Navigate().GoToUrl(url);
        }

        [When(@"Click '([^']*)'")]
        public void WhenClick(string link)
        {
            HookInitialization.Driver.FindElement(By.LinkText(link)).Click();
        }

        [When(@"Click By Path '([^']*)'")]
        public void WhenClickByPath(string path)
        {
            HookInitialization.Driver.FindElement(Constants.Paths[path]).Click();
        }

        [Given(@"Wait (.*)")]
        [When(@"Wait (.*)")]
        [Then(@"Wait (.*)")]
        public void WhenWait(int ms)
        {
            Thread.Sleep(ms);
        }

        [When(@"Fill '([^']*)' by '([^']*)'")]
        public void WhenFillFieldBy(string pathName, string value)
        {
            var field = DriverHelper.WaitAndReturnElement(Constants.Paths[pathName]);
            field.Clear();
            field.SendKeys(value);
        }


        [Then(@"See '([^']*)'")]
        public void ThenSee(string text)
        {
            var body = HookInitialization.Driver.FindElement(By.TagName("body"));
            body.Text.Should().Contain(text);
        }

        //[Then(@"See Console Empty")]
        //public void ThenSeeConsoleEmpty()
        //{
        //    var res = GetBrowserError();

        //    res.Should().BeEmpty();
        //}

        //private List<string> GetBrowserError()
        //{
        //    ILogs logs = HookInitialization.Driver.Manage().Logs;
        //    var logEntries = logs.GetLog(LogType.Browser); // LogType: Browser, Server, Driver, Client and Profiler
        //    List<string> errorLogs = logEntries.Where(x => x.Level == LogLevel.Severe).Select(x => x.Message).ToList();
        //    return errorLogs;
        //}
    }
}
