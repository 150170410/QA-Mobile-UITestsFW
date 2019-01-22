using System;
using System.Linq;
using Mobile.UITests.Views.Common;
using NUnit.Framework;

namespace Mobile.UITests.Views
{
    public class HomeViewChecker : BasicViewChecker
    {
        public HomeViewLocator Locate = new HomeViewLocator();

        public HomeViewChecker(AppUser appUser) : base(appUser) { }

        public HomeViewChecker YourRecentlyViewedIsShown()
        {
                App.WaitForElement(Locate.ViewedItems, $"Timed out waiting for element {Locate.ViewedItems}", TimeSpan.FromSeconds(60));
                Assert.IsTrue(App.Query(Locate.ViewedItems).First().Enabled);
                Assert.AreEqual("Your Recently Viewed Items", App.Query(Locate.ViewedItems).First().Text);
                return this;
        }

        public HomeViewChecker SignInButtonIsPresent()
        {
            App.WaitForElement(Locate.SignInBtn, $"Timed out waiting for element {Locate.SignInBtn}", TimeSpan.FromSeconds(60));
            Assert.IsTrue(App.Query(Locate.SignInBtn).First().Enabled);
            return this;
        }
    }
}
