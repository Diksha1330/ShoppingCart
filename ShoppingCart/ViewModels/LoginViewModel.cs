using ShoppingCart.Models;
using ShoppingCart.View;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ShoppingCart.ViewModels
{
    public class LoginViewModel:BaseViewModel
    {
        public LoginViewModel(ContentPage LoginView)
        {
            m_view = LoginView;

        }
        #region Properties
        private string username;

        public string Username
        {
            get { return username; }
            set { username = value; RaisePropertyChanged(() => Username); }
        }
        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; RaisePropertyChanged(() => Password); }
        }

        #endregion

        #region Command 

        public ICommand LoginButtonCommand { get { return new Command(async () => await LoginButtonCommandAction()); } }

        private async Task LoginButtonCommandAction()
        {
            try
            {
                await m_view.Navigation.PopAsync();
                LoginModel login = new LoginModel();
                //login.UserName;
                PushContentPage(new Detail());
            }
            catch (Exception ex)
            {

            }
        }
        #endregion
    }
}
