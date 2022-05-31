using DLToolkit.Forms.Controls;
using ShoppingCart.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShoppingCart
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            FlowListView.Init();
            // MainPage = new NavigationPage(new Login());
            MainPage = new NavigationPage(new MasterDetailScreen());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
