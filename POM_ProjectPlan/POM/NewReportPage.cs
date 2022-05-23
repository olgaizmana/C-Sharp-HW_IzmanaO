using System;
using System.Collections.Generic;
using System.Text;

namespace POM_ProjectPlan.POM
{
    class NewReportPage
    {
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
            options.First(element => element.Text == "AMX")
                // Click it to select it.
                .Click();



        }  
    }
}
