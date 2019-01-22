using NUnit.Framework;

namespace Mobile.UITests
{
    [TestFixture]
    public class BasicTest : UITest
    {
        [Test]
        public void SignInTest()
        {
            App
                .VisitHomeView()
                .TapOnSignInButton()
                .TapOnUseEmailOrUsername()
                .EnterEmail()
                .EnterPassword()
                .TapOnSignInAndGoToHome()
                .Verify().YourRecentlyViewedIsShown();
        }

        [Test]
        public void SearchTest()
        {
            App
                .VisitHomeView()
                .TapOnSearchField()
                .SearchProduct("Mobile charger")
                .TapOnFirstSuggestion()
                .TapOnScreen()
                .TapOnFirstProduct()
                .ScrollDown()
                .Verify().BuyItNowButtonIsShown();     
        }

        [Test]
        public void SignOutTest()
        {
            App
                .VisitHomeView()
                .TapOnSignInButton()
                .TapOnUseEmailOrUsername()
                .EnterEmail()
                .EnterPassword()
                .TapOnSignInAndGoToHome()
                .TapOnMenuBar()
                .TapOnMyProfile()
                .TapOnLogOut()
                .Verify().SignInButtonIsPresent();
        }
    }
}
