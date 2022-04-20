using ShoppingCart.ViewModels;
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
    public partial class Cart : ContentPage
    {
        public Cart()
        {
            InitializeComponent();
            this.BindingContext = new CartViewModel(this);
           
        }

        private void qua_ValueChanged(object sender, ValueChangedEventArgs e)
        {
           //lbl.Text = e.NewValue;
        }
    }
}