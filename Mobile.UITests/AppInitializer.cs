using System;
using System.IO;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace Mobile.UITests
{
	public class AppInitializer
	{
		public static IApp StartApp(Platform platform)
		{
            switch (platform)
            {
                case Platform.Android:
                    const string apkRelativePath = "../../app/com.ebay.mobile_v5.27.1.2-145_Android-5.0.apk";
                    var apkPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, apkRelativePath);

                    return ConfigureApp
                        .Android
                        .ApkFile(apkPath)
                        .StartApp();
                case Platform.iOS:
                    const string appRelativePath = "../../../Mobile.UITests/bin/iPhoneSimulator/Debug/eBay.app";
                    var appPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, appRelativePath);

                    return ConfigureApp
                        .iOS
                        .Debug()
                        .AppBundle(appPath)
                        .StartApp();

                default:
                    throw new ArgumentOutOfRangeException(nameof(platform), platform, null);
            }
        }
	}
}