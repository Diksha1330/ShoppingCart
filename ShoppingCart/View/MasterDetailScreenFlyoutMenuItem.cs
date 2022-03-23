using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ShoppingCart.View
{
    public class MasterDetailScreenFlyoutMenuItem
    {
        public MasterDetailScreenFlyoutMenuItem()
        {
            TargetType = typeof(MasterDetailScreenFlyoutMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public ImageSource TitleImage { get; set; }
        public Type TargetType { get; set; }
    }
}