using System;
using Xamarin.UITest.Queries;

namespace Mobile.UITests.Views
{
    public class HomeViewLocator
    {
        public Func<AppQuery, AppQuery> SignInBtn { get; } =
            new Func<AppQuery, AppQuery>(c => c.Id("button_sign_in"));

        public Func<AppQuery, AppQuery> SearchField { get; } =
            new Func<AppQuery, AppQuery>(c => c.Id("search_box"));

        public Func<AppQuery, AppQuery> ProductPrice { get; } =
            new Func<AppQuery, AppQuery>(c => c.Id("textview_item_price"));

        public Func<AppQuery, AppQuery> SearchText { get; } =
            new Func<AppQuery, AppQuery>(c => c.Id("search_src_text"));

        public Func<AppQuery, AppQuery> SuggestionText { get; } =
            new Func<AppQuery, AppQuery>(c => c.Id("text"));

        public Func<AppQuery, AppQuery> FilterBtn { get; } =
            new Func<AppQuery, AppQuery>(c => c.Id("button_filter"));

        public Func<AppQuery, AppQuery> ToolBar { get; } =
            new Func<AppQuery, AppQuery>(c => c.Id("primary_toolbar"));

        public Func<AppQuery, AppQuery> MyProfile { get; } =
            new Func<AppQuery, AppQuery>(c => c.Id("home"));

        public Func<AppQuery, AppQuery> SignInStatus { get; } =
            new Func<AppQuery, AppQuery>(c => c.Id("textview_sign_in_status"));

        public Func<AppQuery, AppQuery> SignOut { get; } =
           new Func<AppQuery, AppQuery>(c => c.Id("menuitem_sign_out"));

        public Func<AppQuery, AppQuery> Message { get; } =
           new Func<AppQuery, AppQuery>(c => c.Id("message"));

        public Func<AppQuery, AppQuery> OkBtn { get; } =
          new Func<AppQuery, AppQuery>(c => c.Id("button1"));

         public Func<AppQuery, AppQuery> ViewedItems { get; } =
            new Func<AppQuery, AppQuery>(c => c.Id("textview_header_title"));

    }
}
