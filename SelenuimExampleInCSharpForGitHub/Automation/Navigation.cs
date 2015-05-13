using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation
{
    public static class Navigation
    {
        public static void GoTo(string url)
        {
            TestVariables.Browser.Navigate().GoToUrl(url);
        }

        public static string GetUrl()
        {
            return TestVariables.Browser.Url;
        }
    }
}
