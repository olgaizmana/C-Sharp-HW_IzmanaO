using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Threading;


namespace POM_ProjectPlan.POM
{
    public class LogInPage
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;
        public LogInPage(IWebDriver driver, WebDriverWait wait) 
        {
            _driver = driver;
            _wait = wait;
        }

        private IWebElement _loginButton => _driver.FindElement(By.XPath("//div[@class='button']/span"));
        public void ClickLogInButton()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(_loginButton)).Click();

        }
    }
}
