using System;
using Xamarin.UITest.Queries;

namespace Mobile.UITests.Views.Product
{
    public class ProductViewLocator
    {
        public Func<AppQuery, AppQuery> BuyItNow { get; } =
            new Func<AppQuery, AppQuery>(c => c.Id("button_bin"));
        public Func<AppQuery, AppQuery> DeliveryText { get; } =
            new Func<AppQuery, AppQuery>(c => c.Id("estimated_delivery_textview"));

    }
}
