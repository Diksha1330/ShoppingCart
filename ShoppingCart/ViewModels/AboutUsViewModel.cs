using ShoppingCart.View;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ShoppingCart.ViewModels
{
    public class AboutUsViewModel : BaseViewModel
    {

        public string version;
        public AboutUsViewModel(ContentPage AboutUsView,string ver)
        {
            m_view = AboutUsView;
            version = "Version " + ver;
        }

        #region
        

        public string Version
        {
            get { return version; }
            set { version = value; }
        }

        private string productstring = "ATTIRES";

        public string ProductString
        {
            get { return productstring; }
            set { productstring = value; }
        }

        private string aboutproducts = "Clothe and cloth, are they the same both? No! No! Says the wise silk-moth, The shirt that you wear is the clothe, and the yarn that I make, you humans use to spin cloth. And thence stitch up the clothe!"   ;

        public string AboutProducts
        {
            get { return aboutproducts; }
            set { aboutproducts = value; }
        }



        #endregion
    }
}
