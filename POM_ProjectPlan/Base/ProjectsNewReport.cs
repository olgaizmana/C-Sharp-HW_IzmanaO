using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Threading;

namespace POM_ProjectPlan.Base
{

    public class ProjectsNewReport : LoginTests
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;


        [SetUp]
        public void Setup()
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

        [Test]

        public void ProjectsSuccesfullNewReportTest()
        {
            Thread.Sleep(2000);
            string initialactualNumberOfReports = _wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("mat-paginator-range-label"))).Text;
            string initialnumberOfReports = initialactualNumberOfReports.Substring(initialactualNumberOfReports.Length - 2);
            int intinitialNrOfReports = int.Parse(initialnumberOfReports);


            _wait.Until(ExpectedConditions.ElementToBeClickable(_driver.FindElement(By.XPath("//div[@class='block-right']//span[contains(text(),'New Report')]")))).Click();

            _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//div[@class='ng-scroll-content']/app-project-rag-status-item[1]/div[@class='project-rag-status-select-option']//mat-select"))).Click();
            _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[contains(text(),'Amber')]"))).Click();

            _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//div[@class='ng-scroll-content']/app-project-rag-status-item[2]/div[@class='project-rag-status-select-option']//mat-select"))).Click();
            Thread.Sleep(2000);
            _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//mat-option//span[contains(text(),'Green')]"))).Click();

            _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//div[@class='ng-scroll-content']/app-project-rag-status-item[3]/div[@class='project-rag-status-select-option']//mat-select"))).Click();
            Thread.Sleep(2000);
            _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//mat-option//span[contains(text(),'Amber')]"))).Click();

            _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//div[@class='ng-scroll-content']/app-project-rag-status-item[4]/div[@class='project-rag-status-select-option']//mat-select"))).Click();
            Thread.Sleep(2000);
            _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//mat-option//span[contains(text(),'Red')]"))).Click();
            _wait.Until(ExpectedConditions.ElementToBeClickable(By.ClassName("ql-blank"))).SendKeys("Some text here for new report creation test");

            _wait.Until(ExpectedConditions.ElementToBeClickable(_driver.FindElement(By.XPath("//button[1]/span[contains(text(),'Save')]")))).Click();


            _driver.Navigate().Refresh();

            _wait.Until(ExpectedConditions.ElementToBeClickable(_driver.FindElement(By.XPath("//div[@class='block-icons']/div[1]/i")))).Click();


            string actualSummary = _wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("div.html-section.ng-star-inserted p"))).Text;
            Assert.AreEqual(actualSummary, "Some text here for new report creation test");

            _wait.Until(ExpectedConditions.ElementToBeClickable(_driver.FindElement(By.XPath("//button/span[contains(text(),'Cancel')]")))).Click();

            string finalactualNumberOfReports = _wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("mat-paginator-range-label"))).Text;
            string finalnumberOfReports = finalactualNumberOfReports.Substring(finalactualNumberOfReports.Length - 2);
            int intfinalNrOfReports = int.Parse(finalnumberOfReports);

            Assert.AreEqual(intinitialNrOfReports + 1, intfinalNrOfReports);
        }



        [Test]
        public void ProjectsNoMandatoryDataNewReportTest()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(_driver.FindElement(By.XPath("//div[@class='block-right']//span[contains(text(),'New Report')]")))).Click();
            //_wait.Until(ExpectedConditions.AlertIsPresent());
            //_wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[1]/span[contains(text(),'Save')]"))).Click();
            Assert.IsTrue(_wait.Until(ExpectedConditions.ElementExists(By.XPath("//button[1]/span[contains(text(),'Save')]"))).Enabled);
        }

        [Test]
        public void ProjectsReportSummaryErrorMessageTest()
        {
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(100));
            _wait.Until(ExpectedConditions.ElementToBeClickable(_driver.FindElement(By.XPath("//div[@class='block-right']//span[contains(text(),'New Report')]")))).Click();

            _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//div[@class='ng-scroll-content']/app-project-rag-status-item[1]/div[@class='project-rag-status-select-option']//mat-select"))).Click();
            _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[contains(text(),'Amber')]"))).Click();

            _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//div[@class='ng-scroll-content']/app-project-rag-status-item[2]/div[@class='project-rag-status-select-option']//mat-select"))).Click();
            //_wait.Until(ExpectedConditions.TextToBePresentInElementLocated(By.XPath("//mat-option//span[contains(text(),'Green')]"),"Green"));
            TimeSpan(2000);
            _wait.Until(ExpectedConditions.ElementExists(By.XPath("//span[contains(text(),'Green')]")));
            _driver.FindElement(By.XPath("//span[contains(text(),'Green')]")).Click();

            _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//div[@class='ng-scroll-content']/app-project-rag-status-item[3]/div[@class='project-rag-status-select-option']//mat-select"))).Click();
            _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//mat-option//span[contains(text(),'Amber')]")));
            _driver.FindElement(By.XPath("//mat-option//span[contains(text(),'Amber')]")).Click();

            _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//div[@class='ng-scroll-content']/app-project-rag-status-item[4]/div[@class='project-rag-status-select-option']//mat-select"))).Click();
            _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//mat-option//span[contains(text(),'Red')]")));
            _driver.FindElement(By.XPath("//mat-option//span[contains(text(),'Red')]")).Click();

            _wait.Until(ExpectedConditions.ElementToBeClickable(By.ClassName("ql-blank")));
            _driver.FindElement(By.ClassName("ql-blank")).SendKeys("Nam quis nulla. Integer malesuada. In in enim a arcu imperdiet malesuada. Sed vel lectus. Donec odio urna, tempus molestie, porttitor ut, iaculis quis, sem. Phasellus rhoncus. Aenean id metus id velit ullamcorper pulvinar. Vestibulum fermentum tortor id mi. Pellentesque ipsum. Nulla non arcu lacinia neque faucibus fringilla. Nulla non lectus sed nisl molestie malesuada. Proin in tellus sit amet nibh dignissim sagittis. Vivamus luctus egestas leo. Maecenas sollicitudin. Nullam rhoncus aliquam metus. Etiam egestas wisi a erat. Lorem ipsum dolor sit amet, consectetuer adipiscing elit.Nullam feugiat, turpis at pulvinar vulputate, erat libero tristique tellus, nec bibendum odio risus sit amet ante.Aliquam erat volutpat.Nunc auctor.Mauris pretium quam et urna.Fusce nibh.Duis risus.Curabitur sagittis hendrerit ante.Aliquam erat volutpat.Vestibulum erat nulla, ullamcorper nec, rutrum non, nonummy ac, erat.Duis condimentum augue id magna semper rutrum.Nullam justo enim, consectetuer nec, ullamcorper ac, vestibulum in, elit.Proin pede metus, vulputate nec, fermentum fringilla, vehicula vitae, justo.Fusce consectetuer risus a nunc.Aliquam ornare wisi eu metus.Integer pellentesque quam vel velit.Duis pulvinar. Lorem ipsum dolor sit amet, consectetuer adipiscing elit.Morbi gravida libero nec velit.Morbi scelerisque luctus velit.Etiam dui sem, fermentum vitae, sagittis id, malesuada in, quam.Proin mattis lacinia justo.Vestibulum facilisis auctor urna.Aliquam in lorem sit amet leo accumsan lacinia.Integer rutrum, orci vestibulum ullamcorper ultricies, lacus quam ultricies odio, vitae placerat pede sem sit amet enim.Phasellus et lorem id felis nonummy placerat.Fusce dui leo, imperdiet in, aliquam sit amet, feugiat eu, orci.Aenean vel massa quis mauris vehicula lacinia.Quisque tincidunt scelerisque libero.Maecenas libero.Etiam dictum tincidunt diam.Donec ipsum massa, ullamcorper in, auctor et, scelerisque sed, est.Suspendisse nisl.Sed convallis magna eu sem.Cras pede libero, dapibus nec, pretium sit amet, tempor quis, urna. Etiam posuere quam ac quam.Maecenas aliquet accumsan leo.Nullam dapibus fermentum ipsum.Etiam quis quam.Integer lacinia.Nulla est.Nulla turpis magna, cursus sit amet, suscipit a, interdum id, felis.Integer vulputate sem a nibh rutrum consequat.Maecenas lorem.Pellentesque pretium lectus id turpis.Etiam sapien elit, consequat eget, tristique non, venenatis quis, ante.Fusce wisi.Phasellus faucibus molestie nisl.Fusce eget urna.Curabitur vitae diam non enim vestibulum interdum.Nulla quis diam.Ut tempus purus at lorem. In sem justo, commodo ut, suscipit at, pharetra vitae, orci.Duis sapien nunc, commodo et, interdum suscipit, sollicitudin et, dolor.Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas.Aliquam id dolor.Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos hymenaeos.Mauris dictum facilisis augue.Fusce tellus.Problem Nam quis nulla.malesuada. In in enim a arcu imperdieti");

            string _maxLengthErrorMessage = "Summary maximum length is 3000 characters";
            Assert.AreEqual(_maxLengthErrorMessage, _wait.Until(ExpectedConditions.ElementIsVisible(By.TagName("mat-error"))).Text);

            Assert.IsFalse(_driver.FindElement(By.XPath("//button[1]/span[contains(text(),'Save')]")).Enabled);
        }

        [TearDown]

        public void TearDown()
        {
            _driver.Close();
            _driver.Quit();
        }
        // [OneTimeTearDown]

        //        public void OneTimeTearDown()
        //        {
        //            _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//mat-row[1]/mat-cell/div[@class='block-icons']/div[3]/i"))).Click();

        //            _wait.Until(ExpectedConditions.ElementToBeClickable(_driver.FindElement(By.XPath("//mat-dialog-actions/button[1]/span")))).Click();
        //        }
    }
}


   




