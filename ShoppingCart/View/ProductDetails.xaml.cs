using ShoppingCart.Models;
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
    public partial class ProductDetails : ContentPage
    {
        public ProductDetails(ProductModel productModel)
        {
            InitializeComponent();
            this.BindingContext = new ProductDetailViewModel(this, productModel);
        }
    }
}