using Mobile.UITests.Views.Common;

namespace Mobile.UITests.Views.Login
{
    public class SignInView : BasicView
    {
        public SignInViewLocator Locate = new SignInViewLocator();

        public SignInView(AppUser appUser) : base(appUser) { }

        public SignInView EnterEmail(string email = "quality@makingsense.com")
        {
            App.ClearText(Locate.EmailField);
            App.EnterText(Locate.EmailField, email);
            return this;
        }

        public SignInView EnterPassword(string password = "making1234")
        {
            App.ClearText(Locate.PasswordField);
            App.EnterText(Locate.PasswordField, password);
            return this;
        }


        public HomeView TapOnSignInAndGoToHome()
        {
            App.Tap(Locate.LoginBtn);
            return new HomeView(AppUser);
        }

        public SignInView TapOnUseEmailOrUsername()
        {
            App.Tap(Locate.UseEmailButton);
            return this;
        }
    }
}
