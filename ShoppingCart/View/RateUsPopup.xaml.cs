using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShoppingCart.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RateUsPopup : Rg.Plugins.Popup.Pages.PopupPage
    {
        public RateUsPopup()
        {
            InitializeComponent();
        }
    }
}