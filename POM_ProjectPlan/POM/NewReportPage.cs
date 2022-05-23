using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Linq;
using System.Threading;

namespace POM_ProjectPlan.POM
{
    class NewReportPage
    {

        private IWebDriver _driver;
        private WebDriverWait _wait;

        public NewReportPage(IWebDriver driver, WebDriverWait wait)
        {
            _driver = driver;
            _wait = wait;
        }

        public void SelectOption()
        {
            Thread.Sleep(2000);
            IWebElement field = _driver.FindElement(By.XPath("(//span[contains(text(),'Client')])[2]"));



            // Click to open the dropdown.
            field.Click();
            Thread.Sleep(2000);
            // Query for options in the DOM. These exist outside of the mat-select component.
            var options = _driver.FindElements(By.CssSelector("mat-option"));
            Thread.Sleep(2000);
            // Find the option with the text that matches the one you are looking for.
            options.First(element => element.Text == "Green")
                // Click it to select it.
                .Click();
            options.Second(element => element.Text == "Amber")
            .Click();
            options.Last(element => element.Text == "Red")
            .Click();


        }
    }
}

