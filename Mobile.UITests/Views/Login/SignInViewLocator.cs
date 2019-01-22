using System;
using Xamarin.UITest.Queries;

namespace Mobile.UITests.Views.Login
{
    public class SignInViewLocator
    {
        public Func<AppQuery, AppQuery> EmailField { get; } =
            new Func<AppQuery, AppQuery>(c => c.Id("edit_text_username"));
        public Func<AppQuery, AppQuery> PasswordField { get; } =
            new Func<AppQuery, AppQuery>(c => c.Id("view_ebay_password"));
        public Func<AppQuery, AppQuery> LoginBtn { get; } =
            new Func<AppQuery, AppQuery>(c => c.Id("button_sign_in"));
        public Func<AppQuery, AppQuery> UseEmailButton { get; } =
            new Func<AppQuery, AppQuery>(c => c.Id("button_classic"));
   
    }
}
