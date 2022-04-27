﻿using ShoppingCart.ViewModels;
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
    public partial class CheckOut : ContentPage
    {
        public CheckOut()
        {
            InitializeComponent();
            this.BindingContext = new CheckOutViewModel(this);
        }
    }
}