using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace POM_ProjectPlan.POM
{
    public class StaySignedInPage
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;
        public StaySignedInPage(IWebDriver driver, WebDriverWait wait)
        {
            _driver = driver;
            _wait = wait;
        }

        private IWebElement _identity => _driver.FindElement(By.ClassName("identity"));
        private IWebElement _checkBox => _driver.FindElement(By.Id("KmsiCheckboxField"));

        private IWebElement _yesButton => _driver.FindElement(By.ClassName("button_primary"));

        public void AssertUsername(string username)
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
            _wait.Until(ExpectedConditions.ElementToBeClickable(_yesButton)).Click();
        }

       



        
            string actualUserName = _driver.FindElement(By.ClassName("user-name")).Text;
        Assert.AreEqual(actualUserName, "Automation tests");
    }
}
