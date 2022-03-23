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
    public class ForgotPasswordViewModel:BaseViewModel
    {
        public ForgotPasswordViewModel(ContentPage ForgotPasswordView)
        {
            m_view = ForgotPasswordView;
        }
        #region
        private string emailid;

        public string EmailId
        {
            get { return emailid; }
            set { emailid = value; }
        }
        #endregion

        #region

        public ICommand ForgotPasswordButtonCommand { get { return new Command(async () => await ForgotPasswordButtonCommandAction()); } }

        private async Task ForgotPasswordButtonCommandAction()
        {
            try
            {
                await m_view.Navigation.PopAsync();
                ForgotPasswordModel login = new ForgotPasswordModel();
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
