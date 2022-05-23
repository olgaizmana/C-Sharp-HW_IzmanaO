using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using POM_ProjectPlan.POM;



namespace POM_ProjectPlan 
{
    public class StartClass : Base
    {
        [Test]
        public void SuccesfullLoginTest()
        {
            LogInPage logInPage = new LogInPage(base.driver, base.wait);
            logInPage.ClickLogInButton();

            EmailPage emailPage = new EmailPage(base.driver, base.wait);
            emailPage.WriteUserName("automation.pp@amdaris.com");
            emailPage.PressNextButton();

            PasswordPage passwordPage = new PasswordPage(base.driver, base.wait);
            passwordPage.WritePassword("10704-observe-MODERN-products-STRAIGHT-69112");

            StaySignedInPage staySignedInPage = new StaySignedInPage(base.driver, base.wait);
            staySignedInPage.CheckBox();
            staySignedInPage.PressSubmitButton();

            HomePage homePage = new HomePage(base.driver, base.wait);
            homePage.AssertUserName("automation.pp@amdaris.com");
          

        }
    }
}
