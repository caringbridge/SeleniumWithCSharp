using Automation;
using System;

namespace ResponsiveSite
{
    public static class ResponsiveSiteNavigation
    {
        public static void GoTo(string url)
        {
            Navigation.GoTo("http://" + ResponsiveSiteTestVariables.Environment + "." + url);
        }

        public static void GoTo(string url, string siteName)
        {
            url = url.Replace("*", siteName);

            Navigation.GoTo("http://" + ResponsiveSiteTestVariables.Environment + "." + url);
        }

        public static string GetUrl()
        {
            int index = Navigation.GetUrl().IndexOf(ResponsiveSiteTestVariables.Environment);
            return Navigation.GetUrl().Substring(index + ResponsiveSiteTestVariables.Environment.Length + 1);
        }

        public static bool WaitForUrl(string url, int millisecondTimeOut = 30000)
        {
            DateTime start = DateTime.Now;

            while ((GetUrl() != url) && ((DateTime.Now - start).TotalMilliseconds < millisecondTimeOut))
            {
                System.Threading.Thread.Sleep(100);
            }

            if (GetUrl() != url)
            {
                return false;
            }

            return true;
        }
    }
}
