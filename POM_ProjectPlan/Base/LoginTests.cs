using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace POM_ProjectPlan.Base
{
    public class LoginTests
    {
        private IWebDriver _driver;
        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl("https://projectplanappweb-stage.azurewebsites.net/login");
            
        }

        [Test]
        public void SuccesfullLogin()
        {
            string username = "automation.pp@amdaris.com";            

            Thread.Sleep(2000);
            _driver.FindElement(By.XPath("//div[@class='button']/span")).Click();

            Thread.Sleep(2000);
            _driver.FindElement(By.XPath("//input[@type='email']")).SendKeys(username);

            Thread.Sleep(2000);
            _driver.FindElement(By.XPath("//input[@type='submit']")).Click();

            Thread.Sleep(2000);
            _driver.FindElement(By.Name("passwd")).SendKeys("10704-observe-MODERN-products-STRAIGHT-69112");

            Thread.Sleep(2000);
            _driver.FindElement(By.CssSelector("div .win-button")).Click();

            Thread.Sleep(2000);
            string actualUsername = _driver.FindElement(By.ClassName("identity")).Text;
            Assert.AreEqual(actualUsername, username);

            Thread.Sleep(2000);
            _driver.FindElement(By.Id("KmsiCheckboxField")).Click();
            _driver.FindElement(By.ClassName("button_primary")).Click();

            Thread.Sleep(2000);
            string actualUserName = _driver.FindElement(By.ClassName("user-name")).Text;
            Assert.AreEqual(actualUserName, "Automation tests");
        }

        [Test]
        public void LoginWrongUsernameTest()
        {
            string username = "automatio.pp@amdaris.com";

            Thread.Sleep(2000);
            _driver.FindElement(By.XPath("//div[@class='button']/span")).Click();

            Thread.Sleep(2000);
            _driver.FindElement(By.XPath("//input[@type='email']")).SendKeys(username);

            Thread.Sleep(2000);
            _driver.FindElement(By.XPath("//input[@type='submit']")).Click();

            Thread.Sleep(2000);
            string actualWrongUsernameMessage = _driver.FindElement(By.Id("usernameError")).Text;
            Assert.AreEqual(actualWrongUsernameMessage, "This username may be incorrect. Make sure you typed it correctly. Otherwise, contact your admin.");
         }

        [Test]
        public void LoginWrongPasswordTest()
        {
            string username = "automation.pp@amdaris.com";
            Thread.Sleep(2000);
            _driver.FindElement(By.XPath("//div[@class='button']/span")).Click();

            Thread.Sleep(2000);
            _driver.FindElement(By.XPath("//input[@type='email']")).SendKeys(username);

            Thread.Sleep(2000);
            _driver.FindElement(By.XPath("//input[@type='submit']")).Click();

            Thread.Sleep(2000);
            _driver.FindElement(By.Name("passwd")).SendKeys("10704-observe-MODERN-products-STRAIGHT-69113");

            Thread.Sleep(2000);
            _driver.FindElement(By.CssSelector("div .win-button")).Click();

            Thread.Sleep(2000);
            string actualWrongUsernameMessage = _driver.FindElement(By.Id("passwordError")).Text;
            Assert.AreEqual(actualWrongUsernameMessage, "Your account or password is incorrect. If you don't remember your password, reset it now.");
        }

        [TearDown]

        public void TearDown()
        {
            _driver.Close();
            _driver.Quit();
        }
    }
}