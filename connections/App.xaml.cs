using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Plugin.Connectivity.Abstractions;
using Plugin.Connectivity;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace connections
{
    public partial class App : Application
    {
        

        public App()
        {
            InitializeComponent();



            if(CrossConnectivity.Current.IsConnected) {
                MainPage = new NavigationPage(new NetworkViewPage());
                
            }
            else{

                MainPage = new NavigationPage(new NoNetworkPage());
            }

          
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            //base.OnStart();
          
            //CrossConnectivity.Current.ConnectivityChanged += HandleConnectivityChanged;
        }
        //void HandleConnectivityChanged(object sender, ConnectivityChangedEventArgs e)
        //{
        //    Type currentPage = this.MainPage.GetType();
        //    if (e.IsConnected && currentPage != typeof(NetworkViewPage))
        //        this.MainPage = new NetworkViewPage();
        //    else if (!e.IsConnected && currentPage != typeof(NoNetworkPage))
        //        this.MainPage = new NoNetworkPage();
        //}

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
