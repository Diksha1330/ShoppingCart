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
    public class RegisterViewModel:BaseViewModel
    {
        

        public RegisterViewModel(ContentPage ResgisterView)
        {
            m_view = ResgisterView;
        }

        #region properties
        private string username;

        public string Username
        {
            get { return username; }
            set { username = value; RaisePropertyChanged(() => Username); }
        }

        private string emailid;

        public string EmailId
        {
            get { return emailid; }
            set { emailid = value; RaisePropertyChanged(() => EmailId); }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; RaisePropertyChanged(() => Password); }
        }

        private string confirmpassword;

        public string ConfirmPassword
        {
            get { return confirmpassword; }
            set { confirmpassword = value; RaisePropertyChanged(() => ConfirmPassword); }
        }



        #endregion

        #region

        public ICommand RegisterButtonCommand { get { return new Command(async () => await RegisterButtonCommandAction()); } }

        private async Task RegisterButtonCommandAction()
        {
            try
            {
                await m_view.Navigation.PopAsync();
                RegisterModel login = new RegisterModel();
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
