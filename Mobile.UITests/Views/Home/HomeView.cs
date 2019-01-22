using System;
using System.Linq;
using Mobile.UITests.Views.Common;
using Mobile.UITests.Views.Login;
using Mobile.UITests.Views.Product;


namespace Mobile.UITests.Views
{
    public class HomeView : BasicView
    {
        public HomeViewLocator Locate = new HomeViewLocator();

        public HomeView(AppUser appUser) : base(appUser) { }

        public SignInView TapOnSignInButton()
        {
            App.Tap(Locate.SignInBtn);
            return new SignInView(AppUser);
        }

        public HomeView TapOnSearchField()
        {
            App.Tap(Locate.SearchField);
            return this;
        }

        public HomeView SearchProduct(string productName)
        {
            App.WaitForElement(Locate.SearchText, $"Timed out waiting for element {Locate.SearchText}", TimeSpan.FromSeconds(60));
            App.ClearText(Locate.SearchText);
            App.EnterText(Locate.SearchText, productName);
            return this;
        }

        public HomeView TapOnFirstSuggestion()
        {
            App.WaitForElement(Locate.SuggestionText, $"Timed out waiting for element {Locate.SuggestionText}", TimeSpan.FromSeconds(60));
            var suggestions = App.Query(Locate.SuggestionText).ToList();
            App.Tap(suggestions.First().Id);
            return this;
        }

        public ProductView TapOnFirstProduct()
        {
            App.WaitForElement(Locate.ProductPrice, $"Timed out waiting for element {Locate.ProductPrice}", TimeSpan.FromSeconds(60));
            var products = App.Query(Locate.ProductPrice).ToList();
            App.Tap(products.First().Id);
            return new ProductView(AppUser);
        }

        public HomeView TapOnScreen()
        {
            App.WaitForElement(Locate.FilterBtn, $"Timed out waiting for element {Locate.FilterBtn}", TimeSpan.FromSeconds(60));
            App.Tap(Locate.FilterBtn);
            return this;
        }

        public HomeView TapOnMenuBar()
        {
            App.Tap(Locate.ToolBar);
            return this;
        }

        public HomeView TapOnMyProfile()
        {
            App.Tap(Locate.MyProfile);
            App.Tap(Locate.SignInStatus);
            return this;
        }

        public HomeView TapOnLogOut()
        {
            App.Tap(Locate.SignOut);
            App.Tap(Locate.Message);
            App.Tap(Locate.OkBtn);
            return this;
        }
        
        public HomeViewChecker Verify()
        {
            return new HomeViewChecker(AppUser);
        }
    }
}
