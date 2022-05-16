using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium.Support.UI;

namespace POM_ProjectPlan
{
    public class ProjectsDeleteReport
    {
        private static IWebDriver _driver;
        private static string _username = "automation.pp@amdaris.com";
        private static string _password = "10704-observe-MODERN-products-STRAIGHT-69112";
            
        [SetUp]
        public void Setup()
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
       
        [Test]
        public void ProjectsSuccesfullyDeleteReport()
        {
            Thread.Sleep(2000);
            string initialactualNumberOfReports = _driver.FindElement(By.ClassName("mat-paginator-range-label")).Text;
            string initialnumberOfReports = initialactualNumberOfReports.Substring(initialactualNumberOfReports.Length - 2);
            int intinitialNumberOfReports = int.Parse(initialactualNumberOfReports);
                        
            Thread.Sleep(2000);
            _driver.Navigate().Refresh();
            Thread.Sleep(2000);
            _driver.FindElement(By.XPath("//mat-row[1]/mat-cell/div[@class='block-icons']/div[3]/i")).Click();
            Thread.Sleep(2000);
            _driver.FindElement(By.XPath("//mat-dialog-actions/button[1]/span")).Click();
            Thread.Sleep(2000);

            Thread.Sleep(2000);
            string finalNumberOfReports = _driver.FindElement(By.ClassName("mat-paginator-range-label")).Text;
            string substrFinalnumberOfReports = finalNumberOfReports.Substring(finalNumberOfReports.Length - 2);
            int intfinalNumberOfReports = int.Parse(substrFinalnumberOfReports);

            Assert.AreEqual(intfinalNumberOfReports+1, initialnumberOfReports);

            _driver.Close();
            _driver.Quit();
        }

        [Test]
        public void ProjectsNoDeleteReport()
        {
            Thread.Sleep(2000);
            string initialactualNumberOfReports = _driver.FindElement(By.ClassName("mat-paginator-range-label")).Text;
            string initialnumberOfReports = initialactualNumberOfReports.Substring(initialactualNumberOfReports.Length - 2);
            int intinitialNumberOfReports = int.Parse(initialactualNumberOfReports);

            Thread.Sleep(2000);
            _driver.Navigate().Refresh();
            Thread.Sleep(2000);
            _driver.FindElement(By.XPath("//mat-row[1]/mat-cell/div[@class='block-icons']/div[3]/i")).Click();
            Thread.Sleep(2000);
            _driver.FindElement(By.XPath("//mat-dialog-actions/button[2]/span")).Click();
            Thread.Sleep(2000);

            Thread.Sleep(2000);
            string finalNumberOfReports = _driver.FindElement(By.ClassName("mat-paginator-range-label")).Text;
            string substrFinalnumberOfReports = finalNumberOfReports.Substring(finalNumberOfReports.Length - 2);
            int intfinalNumberOfReports = int.Parse(substrFinalnumberOfReports);

            Assert.AreEqual(intfinalNumberOfReports, initialnumberOfReports);

            _driver.Close();
            _driver.Quit();
        }
    }
}
