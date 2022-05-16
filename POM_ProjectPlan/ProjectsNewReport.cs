using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace POM_ProjectPlan
{

    public class ProjectsNewReport
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
        }

        [Test]

        public void ProjectsSuccesfullNewReportTest()
        {
            Thread.Sleep(2000);
            string initialactualNumberOfReports = _driver.FindElement(By.ClassName("mat-paginator-range-label")).Text;
            string initialnumberOfReports = initialactualNumberOfReports.Substring(initialactualNumberOfReports.Length - 2);
            int intinitialNrOfReports = int.Parse(initialnumberOfReports);

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

            Thread.Sleep(2000);
            _driver.FindElement(By.XPath("//div[@class='block-icons']/div[1]/i")).Click();

            Thread.Sleep(2000);
            string actualSummary = _driver.FindElement(By.CssSelector("div.html-section.ng-star-inserted p")).Text;
            Assert.AreEqual(actualSummary, "Some text here for new report creation test");

            _driver.FindElement(By.XPath("//button/span[contains(text(),'Cancel')]")).Click();

            string finalactualNumberOfReports = _driver.FindElement(By.ClassName("mat-paginator-range-label")).Text;
            string finalnumberOfReports = finalactualNumberOfReports.Substring(finalactualNumberOfReports.Length - 2);
            int intfinalNrOfReports = int.Parse(finalnumberOfReports);

            Assert.AreEqual(intinitialNrOfReports + 1, intfinalNrOfReports);

            Thread.Sleep(2000);
            _driver.FindElement(By.XPath("//div[@class='item-container'][1]//h5[@class='ng-star-inserted']")).Click();

            Thread.Sleep(2000);
            _driver.FindElement(By.XPath("//mat-row[1]/mat-cell/div[@class='block-icons']/div[3]/i")).Click();
            Thread.Sleep(2000);

            _driver.FindElement(By.XPath("//mat-dialog-actions/button[1]/span")).Click();
            Thread.Sleep(2000);

            _driver.Close();
            _driver.Quit();
        }

        [Test]
        public void ProjectsNoMandatoryDataNewReportTest()
        {
            Thread.Sleep(2000);
            string initialactualNumberOfReports = _driver.FindElement(By.ClassName("mat-paginator-range-label")).Text;
            string initialnumberOfReports = initialactualNumberOfReports.Substring(initialactualNumberOfReports.Length - 2);
            int intinitialNrOfReports = int.Parse(initialnumberOfReports);

            _driver.FindElement(By.XPath("//div[@class='block-right']//span[contains(text(),'New Report')]")).Click();

            Thread.Sleep(2000);


            Assert.IsFalse(_driver.FindElement(By.XPath("//button[1]/span[contains(text(),'Save')]")).Enabled);
            Thread.Sleep(2000);


            Thread.Sleep(2000);
            _driver.Navigate().Refresh();


            string finalactualNumberOfReports = _driver.FindElement(By.ClassName("mat-paginator-range-label")).Text;
            string finalnumberOfReports = finalactualNumberOfReports.Substring(finalactualNumberOfReports.Length - 2);
            int intfinalNrOfReports = int.Parse(finalnumberOfReports);

            Assert.AreEqual(intinitialNrOfReports, intfinalNrOfReports);


            _driver.Close();
            _driver.Quit();
        }

        [Test]
        public void ProjectsReportSummaryErrorMessageTest()
        {
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
            _driver.FindElement(By.ClassName("ql-blank")).SendKeys("Nam quis nulla. Integer malesuada. In in enim a arcu imperdiet malesuada. Sed vel lectus. Donec odio urna, tempus molestie, porttitor ut, iaculis quis, sem. Phasellus rhoncus. Aenean id metus id velit ullamcorper pulvinar. Vestibulum fermentum tortor id mi. Pellentesque ipsum. Nulla non arcu lacinia neque faucibus fringilla. Nulla non lectus sed nisl molestie malesuada. Proin in tellus sit amet nibh dignissim sagittis. Vivamus luctus egestas leo. Maecenas sollicitudin. Nullam rhoncus aliquam metus. Etiam egestas wisi a erat. Lorem ipsum dolor sit amet, consectetuer adipiscing elit.Nullam feugiat, turpis at pulvinar vulputate, erat libero tristique tellus, nec bibendum odio risus sit amet ante.Aliquam erat volutpat.Nunc auctor.Mauris pretium quam et urna.Fusce nibh.Duis risus.Curabitur sagittis hendrerit ante.Aliquam erat volutpat.Vestibulum erat nulla, ullamcorper nec, rutrum non, nonummy ac, erat.Duis condimentum augue id magna semper rutrum.Nullam justo enim, consectetuer nec, ullamcorper ac, vestibulum in, elit.Proin pede metus, vulputate nec, fermentum fringilla, vehicula vitae, justo.Fusce consectetuer risus a nunc.Aliquam ornare wisi eu metus.Integer pellentesque quam vel velit.Duis pulvinar. Lorem ipsum dolor sit amet, consectetuer adipiscing elit.Morbi gravida libero nec velit.Morbi scelerisque luctus velit.Etiam dui sem, fermentum vitae, sagittis id, malesuada in, quam.Proin mattis lacinia justo.Vestibulum facilisis auctor urna.Aliquam in lorem sit amet leo accumsan lacinia.Integer rutrum, orci vestibulum ullamcorper ultricies, lacus quam ultricies odio, vitae placerat pede sem sit amet enim.Phasellus et lorem id felis nonummy placerat.Fusce dui leo, imperdiet in, aliquam sit amet, feugiat eu, orci.Aenean vel massa quis mauris vehicula lacinia.Quisque tincidunt scelerisque libero.Maecenas libero.Etiam dictum tincidunt diam.Donec ipsum massa, ullamcorper in, auctor et, scelerisque sed, est.Suspendisse nisl.Sed convallis magna eu sem.Cras pede libero, dapibus nec, pretium sit amet, tempor quis, urna. Etiam posuere quam ac quam.Maecenas aliquet accumsan leo.Nullam dapibus fermentum ipsum.Etiam quis quam.Integer lacinia.Nulla est.Nulla turpis magna, cursus sit amet, suscipit a, interdum id, felis.Integer vulputate sem a nibh rutrum consequat.Maecenas lorem.Pellentesque pretium lectus id turpis.Etiam sapien elit, consequat eget, tristique non, venenatis quis, ante.Fusce wisi.Phasellus faucibus molestie nisl.Fusce eget urna.Curabitur vitae diam non enim vestibulum interdum.Nulla quis diam.Ut tempus purus at lorem. In sem justo, commodo ut, suscipit at, pharetra vitae, orci.Duis sapien nunc, commodo et, interdum suscipit, sollicitudin et, dolor.Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas.Aliquam id dolor.Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos hymenaeos.Mauris dictum facilisis augue.Fusce tellus.Pr");

            Thread.Sleep(2000);
            string _maxLengthErrorMessage = "Summary maximum length is 3000 characters";
            Assert.AreEqual(_maxLengthErrorMessage, _driver.FindElement(By.TagName("mat-error")));
            Thread.Sleep(2000);
            Assert.IsFalse(_driver.FindElement(By.XPath("//button[1]/span[contains(text(),'Save')]")).Enabled);


            _driver.Close();
            _driver.Quit();
        }
    }           
}


   




