using System;
using System.Linq;
using Mobile.UITests.Views.Common;
using NUnit.Framework;

namespace Mobile.UITests.Views.Product
{
    public class ProductViewChecker : BasicViewChecker
    {
        public ProductViewLocator Locate = new ProductViewLocator();

        public ProductViewChecker(AppUser appUser) : base(appUser) { }

        public ProductViewChecker DeliveryTextIsShown()
        {
            App.WaitForElement(Locate.DeliveryText, $"Timed out waiting for element {Locate.DeliveryText}", TimeSpan.FromSeconds(60));
            Assert.IsTrue(App.Query(Locate.DeliveryText).First().Enabled);
            return this;
        }

        public ProductViewChecker BuyItNowButtonIsShown()
        {
            App.WaitForElement(Locate.BuyItNow, $"Timed out waiting for element {Locate.BuyItNow}", TimeSpan.FromSeconds(60));
            Assert.IsTrue(App.Query(Locate.BuyItNow).First().Enabled);
            return this;
        }

    }
}
