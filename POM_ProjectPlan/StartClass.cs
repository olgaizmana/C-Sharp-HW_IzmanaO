using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using POM_ProjectPlan.POM;
using POM_ProjectPlan.Base;


namespace POM_ProjectPlan 
{
    public class StartClass
    { 
        [Test]
        public void SuccesfullLoginTest()
        {
            LogInPage logInPage = new LogInPage(driver, wait);
            logInPage.ClickLogInButton();

            EmailPage emailPage = new EmailPage(driver, wait);
            emailPage.WriteUserName(username);
            emailPage.PressNextButton();
            
        }
    }
}
