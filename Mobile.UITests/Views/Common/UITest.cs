using NUnit.Framework;

namespace Mobile.UITests
{
    public class UITest
    {
        public AppUser App { get; private set; }

        [SetUp]
        public void BaseSetUp()
        {
            App = new AppUser();
        }
    }
}
