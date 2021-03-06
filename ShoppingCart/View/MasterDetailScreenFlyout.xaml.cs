using ShoppingCart.View.DashboardScreens;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShoppingCart.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailScreenFlyout : ContentPage
    {
        public ListView ListView;

        public MasterDetailScreenFlyout()
        {
            InitializeComponent();

            BindingContext = new MasterDetailScreenFlyoutViewModel();
            ListView = MenuItemsListView;
        }

        private class MasterDetailScreenFlyoutViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MasterDetailScreenFlyoutMenuItem> MenuItems { get; set; }

            public MasterDetailScreenFlyoutViewModel()
            {
                MenuItems = new ObservableCollection<MasterDetailScreenFlyoutMenuItem>(new[]
                {
                    new MasterDetailScreenFlyoutMenuItem { Id = 0, Title = "Edit Profile",TitleImage="ic_profile.png" , TargetType=typeof(EditProfile) },
                    new MasterDetailScreenFlyoutMenuItem { Id = 1, Title = "Wishlist" ,TitleImage="ic_wishlist.png", TargetType=typeof(Wishlist) },
                    new MasterDetailScreenFlyoutMenuItem { Id = 2, Title = "Order History",TitleImage="ic_orderhistory.png", TargetType=typeof(OrderHistory) },
                    new MasterDetailScreenFlyoutMenuItem { Id = 3, Title = "Notifications",TitleImage="ic_notification.png", TargetType=typeof(Notifications) },
                   
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}