using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Threading;


namespace POM_ProjectPlan
{
    public class Base
    {
        protected IWebDriver driver;
        protected WebDriverWait wait;
        
        public Base(IWebDriver driver, WebDriverWait wait)
        {
            this.driver = driver;
            this.wait = wait;
        }



        [SetUp]
        public void SetupProjectsNewReports()
        {
            string _username = "automation.pp@amdaris.com";
            string _password = "10704-observe-MODERN-products-STRAIGHT-69112";
            string projectName = "AutoTest";
            _driver = new ChromeDriver();
            //_driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(100);
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
            _driver.Manage().Window.Maximize();

            _driver.Navigate().GoToUrl("https://projectplanappweb-stage.azurewebsites.net/login");

            _wait.Until(ExpectedConditions.ElementToBeClickable(_driver.FindElement(By.XPath("//div[@class='button']/span")))).Click();

            _wait.Until(ExpectedConditions.ElementExists(By.XPath("//input[@type='email']"))).SendKeys(_username);
            _wait.Until(ExpectedConditions.ElementToBeClickable(_driver.FindElement(By.XPath("//input[@type='submit']")))).Click();
            _wait.Until(ExpectedConditions.ElementExists(By.Name("passwd"))).SendKeys(_password);

            Thread.Sleep(2000);
            _wait.Until(ExpectedConditions.ElementToBeClickable(_driver.FindElement(By.CssSelector("div .win-button")))).Click();

            _wait.Until(ExpectedConditions.ElementToBeClickable(_driver.FindElement(By.Id("KmsiCheckboxField")))).Click();
            _wait.Until(ExpectedConditions.ElementToBeClickable(_driver.FindElement(By.ClassName("button_primary")))).Click();

            _wait.Until(ExpectedConditions.ElementExists(By.Id("projects-tab")));
            _driver.FindElement(By.Id("projects-tab")).Click();



            _wait.Until(ExpectedConditions.ElementExists(By.XPath("//input[@type='text']")));
            _driver.FindElement(By.XPath("//input[@type='text']")).SendKeys(projectName);
            _wait.Until(ExpectedConditions.ElementExists(By.XPath("//span[contains(text(),\"AutoTest\")]")));

            _wait.Until(ExpectedConditions.ElementExists(By.XPath("//div[@class='item-container'][1]/app-project-item//h5[@class='ng-star-inserted']")));
            _driver.FindElement(By.XPath("//div[@class='item-container'][1]/app-project-item//h5[@class='ng-star-inserted']")).Click();


        }
        [SetUp]
        public void SetupDeleteReport()
        {
            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl("https://projectplanappweb-stage.azurewebsites.net/login");

            _driver.Manage().Window.Maximize();

            Thread.Sleep(2000);
            _driver.FindElement(By.XPath("//div[@class='button']/span")).Click();

            Thread.Sleep(2000);
            _driver.FindElement(By.XPath("//input[@type='email']")).SendKeys(_username);

            Thread.Sleep(2000);
            _driver.FindElement(By.XPath("//input[@type='submit']")).Click();

            Thread.Sleep(2000);
            _driver.FindElement(By.Name("passwd")).SendKeys(_password);

            Thread.Sleep(2000);
            _driver.FindElement(By.CssSelector("div .win-button")).Click();

            Thread.Sleep(2000);
            _driver.FindElement(By.Id("KmsiCheckboxField")).Click();
            _driver.FindElement(By.ClassName("button_primary")).Click();

            Thread.Sleep(2000);
            _driver.FindElement(By.Id("projects-tab")).Click();

            Thread.Sleep(2000);
            _driver.FindElement(By.CssSelector("div.tab.ng-star-inserted:nth-child(4)")).Click();

            Thread.Sleep(2000);
            string projectName = "Test project ABC";
            _driver.FindElement(By.XPath("//input[@type='text']")).SendKeys(projectName);

            Thread.Sleep(2000);
            _driver.FindElement(By.XPath("//div[@class='item-container'][1]//h5[@class='ng-star-inserted']")).Click();



            Thread.Sleep(2000);
            _driver.FindElement(By.XPath("//div[@class='block-right']//span[contains(text(),'New Report')]")).Click();

            Thread.Sleep(2000);
            _driver.FindElement(By.ClassName("ng-tns-c112-18")).Click();
            _driver.FindElement(By.XPath("//span[contains(text(),'Amber')]")).Click();

            Thread.Sleep(2000);
            _driver.FindElement(By.ClassName("ng-tns-c116-21")).Click();
            _driver.FindElement(By.XPath("//mat-option//span[contains(text(),'Green')]")).Click();

            Thread.Sleep(2000);
            _driver.FindElement(By.ClassName("ng-tns-c116-23")).Click();
            _driver.FindElement(By.XPath("//mat-option//span[contains(text(),'Amber')]")).Click();

            Thread.Sleep(2000);
            _driver.FindElement(By.ClassName("ng-tns-c116-25")).Click();
            _driver.FindElement(By.XPath("//mat-option//span[contains(text(),'Red')]")).Click();
            _driver.FindElement(By.ClassName("ql-blank")).SendKeys("Some text here for new report creation test");

            Thread.Sleep(2000);
            _driver.FindElement(By.XPath("//button[1]/span[contains(text(),'Save')]")).Click();

            Thread.Sleep(2000);
            _driver.Navigate().Refresh();
        }

    }

