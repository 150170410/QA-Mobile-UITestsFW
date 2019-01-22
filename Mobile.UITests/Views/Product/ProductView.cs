using Mobile.UITests.Views.Common;
using Xamarin.UITest;

namespace Mobile.UITests.Views.Product
{
    public class ProductView : BasicView
    {
        public ProductView(AppUser appUser) : base(appUser) { }

        public ProductView ScrollDown()
        {
            App.ScrollDown(strategy: ScrollStrategy.Gesture);
            return this;
        }

        public ProductViewChecker Verify()
        {
            return new ProductViewChecker(AppUser);
        }
    }
}
