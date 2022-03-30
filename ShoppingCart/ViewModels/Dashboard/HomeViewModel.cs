using ShoppingCart.Models;
using ShoppingCart.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ShoppingCart.ViewModels.Dashboard
{
    public class HomeViewModel:BaseViewModel
    {
        #region Properties
        
        private ObservableCollection<ProductModel> newArrivalProduts;

        public ObservableCollection<ProductModel> NewArrivalProducts
        {
            get { return newArrivalProduts; }
            set { newArrivalProduts = value; RaisePropertyChanged(() => NewArrivalProducts); }
        }
        private ObservableCollection<ProductModel> offerProducts;

        public ObservableCollection<ProductModel> OfferProducts
        {
            get { return offerProducts; }
            set { offerProducts = value; RaisePropertyChanged(() => OfferProducts); }
        }

        private ObservableCollection<ProductModel> recommendedProducts;

        public ObservableCollection<ProductModel> RecommendedProducts
        {
            get { return recommendedProducts; }
            set { recommendedProducts = value; RaisePropertyChanged(() => RecommendedProducts); }
        }
        private bool isRecentProductExists=true;

        public bool IsRecentProductExists
        {
            get { return isRecentProductExists; }
            set { isRecentProductExists = value; RaisePropertyChanged(() => IsRecentProductExists); }
        }


        #endregion
        public HomeViewModel(ContentPage view)
        {
            m_view = view;
            RecommendedProducts = new ObservableCollection<ProductModel>();
            RecommendedProducts.Add(new ProductModel { Name = "Men's wear", PreviewImage="ic_jeans.jpg", IsFavourite=true });
            RecommendedProducts.Add(new ProductModel { Name = "Women's wear", PreviewImage = "ic_imagedashboard.jpg" });

            OfferProducts = new ObservableCollection<ProductModel>();
            OfferProducts.Add(new ProductModel { Name = "Children's wear", OverallRating = 5 ,PreviewImage="ic_jeans.jpg"});

            NewArrivalProducts =new ObservableCollection<ProductModel>();
            NewArrivalProducts.Add(new ProductModel { Name = "Women's wear" ,PreviewImage="ic_imagedashboard.jpg",IsFavourite=true});
            NewArrivalProducts.Add(new ProductModel { Name = "Men's wear", PreviewImage = "ic_jeans.jpg" });
        }
        #region Command
        public ICommand NewArrivalTappedCommand { get { return new Command(async () => await NewArrivalTappedCommandEvent()); } }
        private async Task NewArrivalTappedCommandEvent()
        {
            try
            {
                PushContentPage(new ProductsListing());
            }
            catch (Exception)
            {

            }
        }
        #endregion
    }
}
