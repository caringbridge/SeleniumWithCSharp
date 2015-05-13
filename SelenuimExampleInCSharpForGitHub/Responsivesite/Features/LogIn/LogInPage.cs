using Automation;
using OpenQA.Selenium;
using ResponsiveSite.Features.LogIn.Details;

namespace ResponsiveSite.Features.LogIn
{
    public static class LogInPage
    {
        public static IWebElement EmailField
        {
            get
            {
                return Control.FindById(LogInIds.EmailFieldId);
            }
        }

        public static IWebElement PasswordField
        {
            get
            {
                return Control.FindById(LogInIds.PasswordFieldId);
            }
        }

        public static IWebElement LogInButton
        {
            get
            {
                return Control.FindById(LogInIds.LogInButtonId);
            }
        }

        public static IWebElement RememberMeCheckbox
        {
            get
            {
                return Control.FindById(LogInIds.RememberMeCheckboxId);
            }
        }
    }
}
