using System.IO;
using System.Linq;
using GAssist;
using Tizen.System;
using Tizen.Wearable.CircularUI.Forms;
using Xamarin.Forms;

namespace Tizen_Webview_Playground
{
    public class App : Application
    {
        private static readonly string _othersFileDir =
            StorageManager.Storages.First().GetAbsolutePath(DirectoryType.Others);

        private readonly string _htmlFilePath = Path.Combine(_othersFileDir, "test.html");

        public App()
        {
            Tizen.Log.Debug("PATH", _htmlFilePath);

            //Load file and set the file contents as HtmlWebViewSource object property
            var htmlSource = new HtmlWebViewSource();

            //html file contents to play with via c# code
            string html = File.ReadAllText(_htmlFilePath);

            //my html parser approach
            string parsed = HtmlResponseParser.ParseHtmlResponse(html);

            //setting htmlsource html as the html string readed from file
            if (File.Exists(_htmlFilePath)) htmlSource.Html = parsed;


            // Create new page and add WebView with htmlSource as source
            MainPage = new CirclePage
            {
                Content = new WebView
                {
                    Source = htmlSource,
                    HeightRequest = 360, //You can play with different values here
                    WidthRequest = 360 //Scale does work bad because it does not only resizes the content but the whole frame as well
                }
            };
        }

        protected override void OnStart()
        {
            PermissionChecker.CheckAndRequestPermission(PermissionChecker.mediaStoragePermission);
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}