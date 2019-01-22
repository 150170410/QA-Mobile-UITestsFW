using System;
using System.Configuration;
using Mobile.UITests.Views;
using Xamarin.UITest;

namespace Mobile.UITests
{
    public class AppUser
    {
        public AppUser()
        {
            Platform = GetSelectedPlatform();
            App = AppInitializer.StartApp(Platform);
        }

        public Platform Platform { get; }

        public IApp App { get; }

        public HomeView VisitHomeView() => new HomeView(this);

        private Platform GetSelectedPlatform()
        {
            if (!Enum.TryParse(ConfigurationManager.AppSettings["platform"], true, out Platform platform))
                throw new Exception("A platform must be specified in App.config");
            return platform;
        }
    }
}
