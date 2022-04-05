using ShoppingCart.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Models
{
    public class PreviewImage:BaseViewModel
    {
        private string image;

        public string Image
        {
            get { return image; }
            set { image = value; RaisePropertyChanged(() => Image); }
        }

    }
}
