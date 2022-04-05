using ShoppingCart.Models;
using ShoppingCart.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
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
            try
            {
                m_view = view;
                Products = new ObservableCollection<ProductModel>();

                Products.Add(new ProductModel { Name = "Shirt", PreviewImage = "ic_jeans.jpg", ActualPrice = 550, Description = "Fiind some exclusive styles",IsFavourite = true,OverallRating=5,RatingCount=584});
                Products.Add(new ProductModel { Name = "Shirt", PreviewImage = "ic_jeans.jpg", ActualPrice = 550, Description = "Fiind some exclusive styles",IsFavourite = true,OverallRating=5,RatingCount=584});
                Products.Add(new ProductModel { Name = "Shirt", PreviewImage = "ic_jeans.jpg", ActualPrice = 550, Description = "Fiind some exclusive styles",IsFavourite = true,OverallRating=5,RatingCount=584});
                Products.Add(new ProductModel { Name = "Men's wear", PreviewImage = "ic_jeans.jpg", IsFavourite = true, ActualPrice = 540, Description = "Fiind some exclusive styles", DiscountPercent = 10, OverallRating = 5, TotalQuantity = 540 });
                Products.Add(new ProductModel { Name = "Men's wear", PreviewImage = "ic_jeans.jpg", IsFavourite = true, ActualPrice = 540, Description = "Fiind some exclusive styles", DiscountPercent = 10, OverallRating = 5, TotalQuantity = 540 });
                Products.Add(new ProductModel { Name = "Men's wear", PreviewImage = "ic_jeans.jpg", IsFavourite = true, ActualPrice = 540, Description = "Fiind some exclusive styles", DiscountPercent = 10, OverallRating = 5, TotalQuantity = 540 });
                Products.Add(new ProductModel { Name = "Shirt", PreviewImage = "ic_jeans.jpg", ActualPrice = 550, OverallRating = 5, DiscountPercent = 10, TotalQuantity = 550 });
                Products.Add(new ProductModel { Name = "Shirt", PreviewImage = "ic_jeans.jpg", ActualPrice = 550 });
                Products.Add(new ProductModel { Name = "Shirt", PreviewImage = "ic_jeans.jpg", ActualPrice = 550 });
                Products.Add(new ProductModel { Name = "Shirt", PreviewImage = "ic_jeans.jpg", ActualPrice = 550 });
                Products.Add(new ProductModel { Name = "Shirt", PreviewImage = "ic_jeans.jpg", ActualPrice = 550 });
                Products.Add(new ProductModel { Name = "Shirt", PreviewImage = "ic_jeans.jpg", ActualPrice = 550 });
                Products.Add(new ProductModel { Name = "Shirt", PreviewImage = "ic_jeans.jpg", ActualPrice = 550 });
                foreach (var item in Products)
                {
                    item.PreviewImages = new List<PreviewImage>();
                    item.PreviewImages.Add(new PreviewImage { Image = "ic_imagedashboard.jpg" });
                    item.PreviewImages.Add(new PreviewImage { Image = "ic_jeans.jpg" });
                    item.PreviewImages.Add(new PreviewImage { Image = "ic_imagedashboard.jpg" });
                    item.PreviewImages.Add(new PreviewImage { Image = "ic_jeans.jpg" });
                }
            }
            catch (Exception ex)
            {

               
            }
           
        }
        #region Command
        public ICommand ProductsTappedCommand { get { return new Command<ProductModel>(async(productmodel) => await ProductsTappedCommandEvent(productmodel)); } }
        private async Task ProductsTappedCommandEvent(ProductModel productModel)
        {
            try
            {
                await Application.Current.MainPage.Navigation.PushAsync(new ProductDetails(productModel));
                //Application.Current.MainPage=new NavigationPage(new ProductDetails(productModel));
                //PushContentPage(new ProductDetails(productModel));
            }
            catch (Exception ex)
            {

            }
        }
        #endregion
    }
}
