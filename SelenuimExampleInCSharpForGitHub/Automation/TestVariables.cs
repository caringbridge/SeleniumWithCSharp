using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Automation
{
    public static class TestVariables
    {
        private static IWebDriver _browser;
        public static IWebDriver Browser
        {
            get
            {
                if (_browser == null)
                {
                    ChromeDriverService services = ChromeDriverService.CreateDefaultService();
                    services.HideCommandPromptWindow = true;
                    _browser = new ChromeDriver(services, new ChromeOptions());
                }

                return _browser;
            }

            set
            {
                _browser = value;
            }
        }
    }
}
