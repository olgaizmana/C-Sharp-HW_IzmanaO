using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace FirsttestsProject
{
    public class Tests

        
    {

        [Test]
        public void SuccesfullLogin()
        {
            string username = "automation.pp@amdaris.com";

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://projectplanappweb-stage.azurewebsites.net/login");

            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@class='button']/span")).Click();

            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//input[@type='email']")).SendKeys(username);

            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//input[@type='submit']")).Click();

            Thread.Sleep(2000);
            driver.FindElement(By.Name("passwd")).SendKeys("10704-observe-MODERN-products-STRAIGHT-69112");

            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector("div .win-button")).Click();

            Thread.Sleep(2000);
            string actualUsername = driver.FindElement(By.ClassName("identity")).Text;
            Assert.AreEqual(actualUsername, username);

            Thread.Sleep(2000);
            driver.FindElement(By.Id("KmsiCheckboxField")).Click();
            driver.FindElement(By.ClassName("button_primary")).Click();

            Thread.Sleep(2000);
            string actualUserName = driver.FindElement(By.ClassName("user-name")).Text;
            Assert.AreEqual(actualUserName, "Automation tests");

            driver.Close();
            driver.Quit();

        }

        [Test]
        public void LoginWrongUsernameTest()
        {
            string username = "automatio.pp@amdaris.com";

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://projectplanappweb-stage.azurewebsites.net/login");

            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@class='button']/span")).Click();

            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//input[@type='email']")).SendKeys(username);

            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//input[@type='submit']")).Click();
            
            Thread.Sleep(2000);
            string actualWrongUsernameMessage = driver.FindElement(By.Id("usernameError")).Text;            
            Assert.AreEqual(actualWrongUsernameMessage, "This username may be incorrect. Make sure you typed it correctly. Otherwise, contact your admin.");

            driver.Close();
            driver.Quit();
        }

        [Test]
        public void LoginWrongPasswordTest()
        {
            string username = "automation.pp@amdaris.com";

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://projectplanappweb-stage.azurewebsites.net/login");

            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@class='button']/span")).Click();

            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//input[@type='email']")).SendKeys(username);

            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//input[@type='submit']")).Click();

            Thread.Sleep(2000);
            driver.FindElement(By.Name("passwd")).SendKeys("10704-observe-MODERN-products-STRAIGHT-69113");

            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector("div .win-button")).Click();

            Thread.Sleep(2000);
            string actualWrongUsernameMessage = driver.FindElement(By.Id("passwordError")).Text;
            Assert.AreEqual(actualWrongUsernameMessage, "Your account or password is incorrect. If you don't remember your password, reset it now.");

            driver.Close();
            driver.Quit();

        }

        [Test]

        public void ProjectsNewReport()
        {
            string username = "automation.pp@amdaris.com";

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://projectplanappweb-stage.azurewebsites.net/login");
            driver.Manage().Window.Maximize();

            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@class='button']/span")).Click();

            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//input[@type='email']")).SendKeys(username);

            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//input[@type='submit']")).Click();

            Thread.Sleep(2000);
            driver.FindElement(By.Name("passwd")).SendKeys("10704-observe-MODERN-products-STRAIGHT-69112");

            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector("div .win-button")).Click();

            Thread.Sleep(2000);
            driver.FindElement(By.Id("KmsiCheckboxField")).Click();
            driver.FindElement(By.ClassName("button_primary")).Click();

            Thread.Sleep(2000);
            driver.FindElement(By.Id("projects-tab")).Click();

            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector("div.tab.ng-star-inserted:nth-child(4)")).Click();

            Thread.Sleep(2000);
            string projectName = "Test project ABC";
            driver.FindElement(By.XPath("//input[@type='text']")).SendKeys(projectName);


            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@class='item-container'][1]//h5[@class='ng-star-inserted']")).Click();

            Thread.Sleep(2000);
            string initialactualNumberOfReports = driver.FindElement(By.ClassName("mat-paginator-range-label")).Text;
            string initialnumberOfReports = initialactualNumberOfReports.Substring(initialactualNumberOfReports.Length - 2);
            int intinitialNrOfReports = int.Parse(initialnumberOfReports);

            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@class='block-right']//span[contains(text(),'New Report')]")).Click();

            Thread.Sleep(2000);
            driver.FindElement(By.ClassName("ng-tns-c112-18")).Click();
            driver.FindElement(By.XPath("//span[contains(text(),'Amber')]")).Click();

            Thread.Sleep(2000);
            driver.FindElement(By.ClassName("ng-tns-c116-21")).Click();
            driver.FindElement(By.XPath("//mat-option//span[contains(text(),'Green')]")).Click();

            Thread.Sleep(2000);
            driver.FindElement(By.ClassName("ng-tns-c116-23")).Click();
            driver.FindElement(By.XPath("//mat-option//span[contains(text(),'Amber')]")).Click();

            Thread.Sleep(2000);
            driver.FindElement(By.ClassName("ng-tns-c116-25")).Click();
            driver.FindElement(By.XPath("//mat-option//span[contains(text(),'Red')]")).Click();
            driver.FindElement(By.ClassName("ql-blank")).SendKeys("Some text here for new report creation test");

            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//button[1]/span[contains(text(),'Save')]")).Click();

            //Thread.Sleep(2000);
            //var infoReport = driver.FindElement(By.XPath("//div[@class='block-icons']/div[1]/i"));
            //infoReport.SendKeys(Keys.PageDown);
            Thread.Sleep(2000);
            driver.Navigate().Refresh();

            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@class='block-icons']/div[1]/i")).Click();

            Thread.Sleep(2000);
            string actualSummary = driver.FindElement(By.CssSelector("div.html-section.ng-star-inserted p")).Text;
            Assert.AreEqual(actualSummary, "Some text here for new report creation test");

            driver.FindElement(By.XPath("//button/span[contains(text(),'Cancel')]")).Click();

            string finalactualNumberOfReports = driver.FindElement(By.ClassName("mat-paginator-range-label")).Text;
            string finalnumberOfReports = finalactualNumberOfReports.Substring(finalactualNumberOfReports.Length - 2);
            int intfinalNrOfReports = int.Parse(finalnumberOfReports);
           

            Assert.AreEqual(intinitialNrOfReports+1, intfinalNrOfReports);

            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@class='item-container'][1]//h5[@class='ng-star-inserted']")).Click();

            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//mat-row[1]/mat-cell/div[@class='block-icons']/div[3]/i")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//mat-dialog-actions/button[1]/span")).Click();
            Thread.Sleep(2000);
            driver.Close();
            driver.Quit();
        }

        [Test]

        public void ProjectsEditReport()
        {
            string username = "automation.pp@amdaris.com";

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://projectplanappweb-stage.azurewebsites.net/login");
            driver.Manage().Window.Maximize();

            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@class='button']/span")).Click();

            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//input[@type='email']")).SendKeys(username);

            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//input[@type='submit']")).Click();

            Thread.Sleep(2000);
            driver.FindElement(By.Name("passwd")).SendKeys("10704-observe-MODERN-products-STRAIGHT-69112");

            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector("div .win-button")).Click();

            Thread.Sleep(2000);
            driver.FindElement(By.Id("KmsiCheckboxField")).Click();
            driver.FindElement(By.ClassName("button_primary")).Click();

            Thread.Sleep(2000);
            driver.FindElement(By.Id("projects-tab")).Click();

            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector("div.tab.ng-star-inserted:nth-child(4)")).Click();

            Thread.Sleep(2000);
            string projectName = "Test project ABC";
            driver.FindElement(By.XPath("//input[@type='text']")).SendKeys(projectName);

            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@class='item-container'][1]//h5[@class='ng-star-inserted']")).Click();

            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@class='block-right']//span[contains(text(),'New Report')]")).Click();

            Thread.Sleep(2000);
            driver.FindElement(By.ClassName("ng-tns-c112-18")).Click();
            driver.FindElement(By.XPath("//span[contains(text(),'Amber')]")).Click();

            Thread.Sleep(2000);
            driver.FindElement(By.ClassName("ng-tns-c116-21")).Click();
            driver.FindElement(By.XPath("//mat-option//span[contains(text(),'Green')]")).Click();

            Thread.Sleep(2000);
            driver.FindElement(By.ClassName("ng-tns-c116-23")).Click();
            driver.FindElement(By.XPath("//mat-option//span[contains(text(),'Amber')]")).Click();

            Thread.Sleep(2000);
            driver.FindElement(By.ClassName("ng-tns-c116-25")).Click();
            driver.FindElement(By.XPath("//mat-option//span[contains(text(),'Red')]")).Click();
            driver.FindElement(By.ClassName("ql-blank")).SendKeys("Some text here for new report creation test");

            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//button[1]/span[contains(text(),'Save')]")).Click();

            Thread.Sleep(2000);
            driver.Navigate().Refresh();

            Thread.Sleep(2000);
            driver.FindElement(By.Id("actionButton")).Click();

            Thread.Sleep(2000);
            driver.FindElement(By.ClassName("ql-editor")).SendKeys(", some editing done");

            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//button/span[contains(text(),'Save Changes')]")).Click();

            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@class='block-icons']/div[1]/i")).Click();

            Thread.Sleep(2000);
            string actualSummary = driver.FindElement(By.XPath("//div[1]/app-project-report-info/div[3]/p")).Text;
            Assert.AreEqual(actualSummary, "Some text here for new report creation test, some editing done");

            driver.FindElement(By.XPath("//button/span[contains(text(),'Cancel')]")).Click();

            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//mat-row[1]/mat-cell/div[@class='block-icons']/div[3]/i")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//mat-dialog-actions/button[1]/span")).Click();
            Thread.Sleep(2000);

            driver.Close();
            driver.Quit();
        }

        [Test]

        public void ProjectsDeleteReport()
        {
            string username = "automation.pp@amdaris.com";

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://projectplanappweb-stage.azurewebsites.net/login");
            driver.Manage().Window.Maximize();

            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@class='button']/span")).Click();

            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//input[@type='email']")).SendKeys(username);

            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//input[@type='submit']")).Click();

            Thread.Sleep(2000);
            driver.FindElement(By.Name("passwd")).SendKeys("10704-observe-MODERN-products-STRAIGHT-69112");

            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector("div .win-button")).Click();

            Thread.Sleep(2000);
            driver.FindElement(By.Id("KmsiCheckboxField")).Click();
            driver.FindElement(By.ClassName("button_primary")).Click();

            Thread.Sleep(2000);
            string actualUserName = driver.FindElement(By.ClassName("user-name")).Text;
            Assert.AreEqual(actualUserName, "Automation tests");

            driver.FindElement(By.Id("projects-tab")).Click();

            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector("div.tab.ng-star-inserted:nth-child(4)")).Click();

            Thread.Sleep(2000);
            string projectName = "Test project ABC";
            driver.FindElement(By.XPath("//input[@type='text']")).SendKeys(projectName);

            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@class='item-container'][1]//h5[@class='ng-star-inserted']")).Click();

            Thread.Sleep(2000);
            string initialactualNumberOfReports = driver.FindElement(By.ClassName("mat-paginator-range-label")).Text;
            string initialnumberOfReports = initialactualNumberOfReports.Substring(initialactualNumberOfReports.Length - 2);


            //Create New Report

            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@class='block-right']//span[contains(text(),'New Report')]")).Click();

            Thread.Sleep(2000);
            driver.FindElement(By.ClassName("ng-tns-c112-18")).Click();
            driver.FindElement(By.XPath("//span[contains(text(),'Amber')]")).Click();

            Thread.Sleep(2000);
            driver.FindElement(By.ClassName("ng-tns-c116-21")).Click();
            driver.FindElement(By.XPath("//mat-option//span[contains(text(),'Green')]")).Click();

            Thread.Sleep(2000);
            driver.FindElement(By.ClassName("ng-tns-c116-23")).Click();
            driver.FindElement(By.XPath("//mat-option//span[contains(text(),'Amber')]")).Click();

            Thread.Sleep(2000);
            driver.FindElement(By.ClassName("ng-tns-c116-25")).Click();
            driver.FindElement(By.XPath("//mat-option//span[contains(text(),'Red')]")).Click();
            driver.FindElement(By.ClassName("ql-blank")).SendKeys("Some text here for new report creation test");

            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//button[1]/span[contains(text(),'Save')]")).Click();

            //Delete Created Report

            Thread.Sleep(2000);
            driver.Navigate().Refresh();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//mat-row[1]/mat-cell/div[@class='block-icons']/div[3]/i")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//mat-dialog-actions/button[1]/span")).Click();
            Thread.Sleep(2000);

            Thread.Sleep(2000);
            string actualNumberOfReports = driver.FindElement(By.ClassName("mat-paginator-range-label")).Text;
            string numberOfReports = actualNumberOfReports.Substring(actualNumberOfReports.Length -2);
            
               
            Assert.AreEqual(numberOfReports, initialnumberOfReports);

            driver.Close();
            driver.Quit();
        }

       
    }
}