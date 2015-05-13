using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ResponsiveSite.Features.LogIn;
using ResponsiveSite;
using Automation;

namespace ResponsiveSiteTestCases
{
    [TestClass]
    public class ExampleTest
    {
        [TestInitialize]
        public void Initialize()
        {
            ResponsiveSiteTestVariables.Environment = "qa3";
        }

        [TestCleanup]
        public void CleanUp()
        {
            TestVariables.Browser.Close();
            TestVariables.Browser = null;
        }

        [TestMethod]
        public void LogIn()
        {
            ResponsiveSiteNavigation.GoTo(ResponsiveSiteUrls.LogIn);
            ResponsiveSiteSharedSteps.LogIn(email: "automationexampleaccount4cb@mailinator.com", password: "test123");

            Assert.AreEqual(expected: ResponsiveSiteUrls.ProfileHomePage, actual: ResponsiveSiteNavigation.GetUrl());
        }
    }
}
