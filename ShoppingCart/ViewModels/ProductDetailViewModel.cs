using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ShoppingCart.ViewModels
{
    public class ProductDetailViewModel:BaseViewModel
    {
        #region Properties
        private ProductModel productModel;

        public ProductModel ProductModel
        {
            get { return productModel; }
            set { productModel = value; RaisePropertyChanged(() => ProductModel); }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; RaisePropertyChanged(() => Name); }
        }

        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; RaisePropertyChanged(() => Description); }
        }
        public int RatingCount { get; set; }
        private string ratingCountValues;

        public string RatingCountValues
        {
            get { return ratingCountValues; }
            set
            {
                ratingCountValues = value;         
                
                RaisePropertyChanged(() => RatingCountValues);
            }
        }
        private bool isRated;

        public bool IsRated
        {
            get { return isRated; }
            set { isRated = value;RaisePropertyChanged(() => IsRated); }
        }

        private string actualPrice;

        public string ActualPrice
        {
            get { return actualPrice; }
            set { actualPrice = value; RaisePropertyChanged(() => ActualPrice); }
        }


        public double OverallRating { get; set; }
        private string rating;

        public string Rating
        {
            get { return rating; }
            set
            {
                rating = value;               
               
                RaisePropertyChanged(() => Rating);
            }
        }

        private List<PreviewImage> previewImages;

        public List<PreviewImage> PreviewImages
        {
            get { return previewImages; }
            set { previewImages = value;RaisePropertyChanged(() => PreviewImages); }
        }

        #endregion
        public ProductDetailViewModel(ContentPage view,ProductModel _productmodel)
        {
            try
            {
                m_view = view;
                ProductModel = _productmodel;
                Name = _productmodel.Name;
                Description = _productmodel.Description;
                ActualPrice = "₹ " + Convert.ToString(_productmodel.ActualPrice);
                RatingCount = _productmodel.RatingCount;
                if (RatingCount > 0)
                {
                    RatingCountValues = RatingCount + " ratings";
                }
               
                OverallRating = _productmodel.OverallRating;
                if (OverallRating > 0)
                {
                    Rating = Convert.ToString(OverallRating) + " *";
                    IsRated = true;
                }
                else
                {
                    IsRated = false;
                }

               
                
                PreviewImages = new List<PreviewImage>(_productmodel.PreviewImages);
                
            }
            catch (Exception ex)
            {

             
            }
        }
    }
}
