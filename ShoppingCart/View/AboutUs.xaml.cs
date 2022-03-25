using ShoppingCart.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace ShoppingCart.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    
    public partial class AboutUs : ContentPage
    {
        public AboutUs()
        {
            InitializeComponent();
            VersionTracking.Track();
            var currentVersion = VersionTracking.CurrentVersion;
            System.Console.WriteLine("Currentversion:"+ currentVersion);
            
            this.BindingContext = new AboutUsViewModel(this,currentVersion);
            

        }
    }
}