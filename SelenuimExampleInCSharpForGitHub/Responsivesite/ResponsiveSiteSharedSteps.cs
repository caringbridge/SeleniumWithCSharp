using ResponsiveSite.Features.LogIn;

namespace ResponsiveSite
{
    public static class ResponsiveSiteSharedSteps
    {
        public static void LogIn(string email, string password)
        {
            LogInPage.EmailField.Clear();
            LogInPage.EmailField.SendKeys(email);
            LogInPage.PasswordField.Clear();
            LogInPage.PasswordField.SendKeys(password);
            LogInPage.LogInButton.Click();
        }
    }
}
