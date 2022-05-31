﻿using ShoppingCart.ViewModels.Dashboard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShoppingCart.View.DashboardScreens
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Wishlist : ContentPage
    {
        public Wishlist()
        {
            InitializeComponent();
            this.BindingContext = new WishlistViewModel(this);
        }
    }
}