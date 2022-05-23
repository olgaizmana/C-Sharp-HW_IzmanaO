using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace POM_ProjectPlan.POM
{
    public class HomePage
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;
        
        public HomePage(IWebDriver driver, WebDriverWait wait)
        {
            _driver = driver;
            _wait = wait;
        }

        private string projectName;
        private IWebElement _projectsButton => _driver.FindElement(By.Id("projects-tab"));
        private By _projectsSearchBox => By.XPath("//input[@type='text']");
        private By _searchedProjectFound => By.XPath($"//span[contains(text(),\"A{projectName}\")]");
        public void AssertUserName(string userName)
        {
            string actualUserName = _driver.FindElement(By.ClassName("user-name")).Text;
            Assert.AreEqual(actualUserName, userName);
        }

        public void AssertLogo()
        {

        }

        
        public void PressProjectsButton()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(_projectsButton)).Click();
        }

        public void SearchProject(string projectName)
        {
            _wait.Until(ExpectedConditions.ElementExists(_projectsSearchBox)).SendKeys(projectName);
        }

        public void AssertSearchResult(string projectName)
        {
            Assert.That(projectName, Is.EqualTo(_driver.FindElement(_searchedProjectFound).Text));
        }

        public void GoToProjectPage(string projectName)
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(_searchedProjectFound)).Click();
        }
    }
}
