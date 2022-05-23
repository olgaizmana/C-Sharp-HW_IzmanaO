using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace POM_ProjectPlan.POM
{
    class ProjectStatusPage
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;

        public ProjectStatusPage(IWebDriver driver, WebDriverWait wait)
        {
            _driver = driver;
            _wait = wait;
        }

        private IWebElement _newReportButton;
        public void PressNewReportButton()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(_newReportButton)).Click();

        }

        public void PressInfoReportButton()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(_driver.FindElement(By.XPath("//div[@class='block-icons']/div[1]/i")))).Click();

        }

        public void PressEditReportButton()
        {
            _driver.FindElement(By.Id("actionButton")).Click();
        }

        public void PressDeleteReportButton()
        {
            _driver.FindElement(By.XPath("//mat-row[1]/mat-cell/div[@class='block-icons']/div[3]/i")).Click();
        }
    }
}
