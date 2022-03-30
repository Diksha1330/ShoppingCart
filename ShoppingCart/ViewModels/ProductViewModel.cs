using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace ShoppingCart.ViewModels
{
    public class ProductViewModel:BaseViewModel
    {
        #region Properties
        private ObservableCollection<ProductModel> products;

        public ObservableCollection<ProductModel> Products
        {
            get { return products; }
            set { products = value; RaisePropertyChanged(() => Products); }
        }
        #endregion
        public ProductViewModel(ContentPage view)
        {
            m_view = view;
            Products= new ObservableCollection<ProductModel>();
            Products.Add(new ProductModel { Name = "Shirt", PreviewImage = "ic_jeans.jpg", ActualPrice = 550 ,IsFavourite=true});  
            Products.Add(new ProductModel { Name = "Shirt", PreviewImage = "ic_jeans.jpg", ActualPrice = 550,OverallRating=5,DiscountPercent=10,TotalQuantity=550 });  
            Products.Add(new ProductModel { Name = "Shirt", PreviewImage = "ic_jeans.jpg", ActualPrice = 550 });  
            Products.Add(new ProductModel { Name = "Shirt", PreviewImage = "ic_jeans.jpg", ActualPrice = 550 });  
            Products.Add(new ProductModel { Name = "Shirt", PreviewImage = "ic_jeans.jpg", ActualPrice = 550 });  
            Products.Add(new ProductModel { Name = "Shirt", PreviewImage = "ic_jeans.jpg", ActualPrice = 550 });  
            Products.Add(new ProductModel { Name = "Shirt", PreviewImage = "ic_jeans.jpg", ActualPrice = 550 });  
            Products.Add(new ProductModel { Name = "Shirt", PreviewImage = "ic_jeans.jpg", ActualPrice = 550 });  
        }
    }
}
