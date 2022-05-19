using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace POM_ProjectPlan.POM
{
    class PasswordPage
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;
        public PasswordPage(IWebDriver driver, WebDriverWait wait)
        {
            _driver = driver;
            _wait = wait;
        }

        private IWebElement _passwordField => _driver.FindElement(By.Name("passwd"));
        private IWebElement _signInButton => _driver.FindElement(By.CssSelector("div .win-button"));
        public void WritePassword(string password)
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(_passwordField)).SendKeys(password);
        }

        public void PressSugnInButton()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(_signInButton)).Click();
        }
    }
}
