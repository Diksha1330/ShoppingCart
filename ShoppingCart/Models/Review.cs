using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Models
{
    public class Review
    {
        public int ID { get; set; }
        public string ProfileImage { get; set; }
        public string CustomerName { get; set; }
        public string Date { get; set; }        
        public DateTime ReviewedDate { get; set; }

        public string StringDate { get; set; }
        public double Rating { get; set; }
        public string Comment { get; set; }
         public List<PreviewImage> Images { get; set; }

        private string profileImage;

        private string reviewDate;
    }
}
