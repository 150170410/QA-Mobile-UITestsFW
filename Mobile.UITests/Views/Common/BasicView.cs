﻿using Xamarin.UITest;

namespace Mobile.UITests.Views.Common
{
    public abstract class BasicView
    {
        protected BasicView(AppUser appUser)
        {
            AppUser = appUser;
        }

        public AppUser AppUser { get; }

        public IApp App => AppUser.App;

    }
}
