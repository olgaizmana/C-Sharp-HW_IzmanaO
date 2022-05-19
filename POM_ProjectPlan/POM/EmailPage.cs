using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace POM_ProjectPlan.POM
{
    public class EmailPage
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;
        public EmailPage(IWebDriver driver, WebDriverWait wait)
        {
            _driver = driver;
            _wait = wait;
        }

        private IWebElement _usernameField => _driver.FindElement(By.XPath("//input[@type='email']"));
        private IWebElement _nextButton => _driver.FindElement(By.XPath("//input[@type='submit']"));
        private IWebElement _identity => _driver.FindElement(By.ClassName("identity"));
        private IWebElement _checkBox => _driver.FindElement(By.Id("KmsiCheckboxField"));

        private IWebElement _submitButton => _driver.FindElement(By.ClassName("button_primary"));

        public void WriteUserName(string username)
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(_usernameField)).SendKeys(username);
        }

        public void PressNextButton()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(_nextButton)).Click();
        }

        public void AssertUsernameCorrect(string username)
        {
            string actualUsername = _wait.Until(ExpectedConditions.ElementToBeClickable(_identity)).Text;
            Assert.AreEqual(actualUsername, username);
        }

        public void CheckBox()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(_checkBox)).Click();
        }

        public void PressSubmitButton()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(_submitButton)).Click();
        }
        
        

        Thread.Sleep(2000);
            string actualUserName = _driver.FindElement(By.ClassName("user-name")).Text;
        Assert.AreEqual(actualUserName, "Automation tests");
    }
}
