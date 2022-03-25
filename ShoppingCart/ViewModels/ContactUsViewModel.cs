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
    public class ContactUsViewModel:BaseViewModel
    {
        

        public ContactUsViewModel(ContentPage ContactUsView)
        {
            m_view = ContactUsView;
        }

        #region properties
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; RaisePropertyChanged(() => Name); }
        }

        private string emailid;

        public string EmailId
        {
            get { return emailid; }
            set { emailid = value; RaisePropertyChanged(() => EmailId); }
        }
        private string message;

        public string Message
        {
            get { return message; }
            set { message = value; }
        }



        #endregion

        #region Command 

        public ICommand SendButtonCommand { get { return new Command(async () => await SendButtonCommandAction()); } }

        private async Task SendButtonCommandAction()
        {
            try
            {
                await m_view.Navigation.PopAsync();
                ContactUsModel login = new ContactUsModel();
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
