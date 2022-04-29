using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace ShoppingCart.ViewModels.Dashboard
{
    public class WishlistViewModel:BaseViewModel
    {
        #region Properties
        private ObservableCollection<ProductModel> cartSource;

        public ObservableCollection<ProductModel> CartSource
        {
            get { return cartSource; }
            set { cartSource = value; RaisePropertyChanged(() => CartSource); }
        }
        private ObservableCollection<string> quantityCountSource;

        public ObservableCollection<string> QuantityCountSource
        {
            get { return quantityCountSource; }
            set { quantityCountSource = value; RaisePropertyChanged(() => QuantityCountSource); }
        }



        #endregion
        public WishlistViewModel(ContentPage view)
        {
           try
            {
                m_view = view;
            
               
                CartSource = new ObservableCollection<ProductModel>();
                CartSource.Add(new ProductModel { Name = "Shirt", PreviewImage = "ic_jeans.jpg", ActualPrice = 550, Description = "Fiind some exclusive styles", IsFavourite = true, OverallRating = 5, RatingCount = 584 });
                CartSource.Add(new ProductModel { Name = "Shirt", PreviewImage = "ic_jeans.jpg", ActualPrice = 550, Description = "Fiind some exclusive styles", IsFavourite = true, OverallRating = 5, RatingCount = 584});
                CartSource.Add(new ProductModel { Name = "Shirt", PreviewImage = "ic_jeans.jpg", ActualPrice = 550, Description = "Fiind some exclusive styles", IsFavourite = true, OverallRating = 5, RatingCount = 584 });
                CartSource.Add(new ProductModel { Name = "Men's wear", PreviewImage = "ic_jeans.jpg", IsFavourite = true, ActualPrice = 540, Description = "Fiind some exclusive styles", DiscountPercent = 10, OverallRating = 5, TotalQuantity = 540 });
                CartSource.Add(new ProductModel { Name = "Men's wear", PreviewImage = "ic_jeans.jpg", IsFavourite = true, ActualPrice = 540, Description = "Fiind some exclusive styles", DiscountPercent = 10, OverallRating = 5, TotalQuantity = 540});
                CartSource.Add(new ProductModel { Name = "Men's wear", PreviewImage = "ic_jeans.jpg", IsFavourite = true, ActualPrice = 540, Description = "Fiind some exclusive styles", DiscountPercent = 10, OverallRating = 5, TotalQuantity = 540});
                CartSource.Add(new ProductModel { Name = "Shirt", PreviewImage = "ic_jeans.jpg", ActualPrice = 550, OverallRating = 5, DiscountPercent = 10, TotalQuantity = 550});              

            }
            catch (Exception)
            {

                
            }  
        }
    }
}
