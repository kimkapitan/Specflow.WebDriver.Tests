using OpenQA.Selenium;

namespace Specflow.WebDriver.Tests.Hooks
{
    public static class Constants
    {
        public static Dictionary<string, By> Paths = new Dictionary<string, By>
        {
            {
                "LoginFormField",
                By.XPath(".//div/span[translate(normalize-space(text()), 'L', 'l')='login']/parent::*/mat-form-field/div/div/div[3]/input")
            },
            {
                "PasswordFormField",
                By.XPath(".//div/span[translate(normalize-space(text()), 'P', 'p')='password']/parent::*/mat-form-field/div/div/div[3]/input")
            },
            {
                "LoginButton",
                By.XPath(".//mat-card-actions/button")
            }
        };
    }
}
