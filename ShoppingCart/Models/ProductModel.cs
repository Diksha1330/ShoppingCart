using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Models
{
    public class ProductModel
    {

        public int ID { get; set; }

        public string Name { get; set; }

        public string Summary { get; set; }

        public string Description { get; set; }

        public double ActualPrice { get; set; }

        public double DiscountPercent { get; set; }

        public double OverallRating { get; set; }

        public int TotalQuantity { get; set; }

        public int SubCategoryId { get; set; }

        public List<Review> Reviews { get; set; }
        public string PreviewImage { get; set; }
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
