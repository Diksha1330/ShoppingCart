using ShoppingCart.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ShoppingCart.Models
{
    public class ProductModel:BaseViewModel
    {

        public int ID { get; set; }

        public string Name { get; set; }

        public string Summary { get; set; }

        public string Description { get; set; }

        public double ActualPrice { get; set; }

        public double DiscountPercent { get; set; }
        public bool IsRated { get; set; } = true;

        public double OverallRating { get; set; }
        public int RatingCount { get; set; }
        private string ratingCountValues;

        public string RatingCountValues
        {
            get { return ratingCountValues; }
            set
            {
                ratingCountValues = value;
                RaisePropertyChanged(() => RatingCountValues);
                if (RatingCount > 0)
                {
                    RatingCountValues = RatingCount + " ratings";
                }
            }
        }

        private string rating;

        public string Rating
        {
            get { return rating; }
            set { rating = value;
                RaisePropertyChanged(() => Rating);
                if (OverallRating > 0)
                {
                    Rating = Convert.ToString(OverallRating) + "*";
                    IsRated = true;
                }
                else
                {
                    IsRated = false;
                }
            }
        }


        public int TotalQuantity { get; set; }

        public int SubCategoryId { get; set; }

        public List<Review> Reviews { get; set; }
        public string PreviewImage { get; set; }
        private int quantitySelected=1;

        public int QuantitySelected
        {
            get { return quantitySelected; }
            set { quantitySelected = value; RaisePropertyChanged(() => QuantitySelected); }
        }
        public ICommand AddQuantityCommand { get { return new Command<ProductModel>(async (ProductModel product) => await AddQuantityCommandAction(product)); } }

        private async Task AddQuantityCommandAction(ProductModel productModel)
        {
            try
            {
                productModel.QuantitySelected++;
            }
            catch (Exception ex)
            {


            }
        }

        public ICommand MinusQuantityCommand { get { return new Command<ProductModel>(async (ProductModel product) => await MinusQuantityCommandAction(product)); } }

        private async Task MinusQuantityCommandAction(ProductModel product)
        {
            try
            {
                if(quantitySelected > 1)
                    product.QuantitySelected--;
            }
            catch (Exception ex)
            {


            }
        }
        //public ObservableCollection<string> QuantitySource { get; set; }
        public List<PreviewImage> PreviewImages { get; set; }
        
        public string Category { get; set; }
        public double DiscountPrice => ActualPrice - ActualPrice * (DiscountPercent / 100);

        public bool IsFavourite { get; set; }
        
        public string Seller { get; set; }

        private List<object> quantities;

        public List<object> Quantities
        {
            get => quantities;
            set
            {
                quantities = value;
             
            }
        }

        public List<string> SizeVariants { get; set; }
    }
}
