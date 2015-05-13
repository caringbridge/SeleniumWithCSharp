using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;

namespace Automation
{
    public static class Control
    {
        public static IWebElement FindById(string id)
        {
            return TestVariables.Browser.FindElement(By.Id(id));
        }

        public static IWebElement FindByValue(string value)
        {
            return TestVariables.Browser.FindElement(By.XPath("//*[@value='" + value + "']"));
        }

        public static IWebElement FindByPartialLink(string partialLinkText)
        {
            return TestVariables.Browser.FindElement(By.CssSelector("[href*='" + partialLinkText + "']"));
        }

        public static IWebElement FindByPartialLinkText(string partialLinkText)
        {
            return TestVariables.Browser.FindElement(By.PartialLinkText(partialLinkText));
        }
    }
}
