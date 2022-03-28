using ShoppingCart.Models;
using ShoppingCart.View;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace ShoppingCart.ViewModels
{
    public class LoginViewModel:BaseViewModel
    {
        Entry emailIdEntry,passwordEntry;
        public LoginViewModel(ContentPage LoginView)
        {
            m_view = LoginView;
            emailIdEntry = m_view.FindByName<Entry>("EmailIdEntry");
            passwordEntry = m_view.FindByName<Entry>("PasswordEntry");

        }
        #region Properties
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

        #endregion
        
        #region Command 

        public ICommand LoginButtonCommand { get { return new Command(async () => await LoginButtonCommandAction()); } }

        private async Task LoginButtonCommandAction()
        {
            try
            {
                await m_view.Navigation.PopAsync();
                LoginModel login = new LoginModel();
                Regex EmailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                bool pattern = EmailRegex.IsMatch(emailIdEntry.Text);
       
                if ((string.IsNullOrEmpty(emailIdEntry.Text) || string.IsNullOrWhiteSpace(emailIdEntry.Text)) && (string.IsNullOrEmpty(passwordEntry.Text) || string.IsNullOrWhiteSpace(passwordEntry.Text)))
                {

                    emailIdEntry.PlaceholderColor = Color.Red;
                    emailIdEntry.Placeholder = "Email id is required!";
                    passwordEntry.PlaceholderColor = Color.Red;
                    passwordEntry.Placeholder = "Password id is required!";



                }
                else if (string.IsNullOrEmpty(emailIdEntry.Text) || string.IsNullOrWhiteSpace(emailIdEntry.Text))
                {
                    emailIdEntry.PlaceholderColor = Color.Red;
                    emailIdEntry.Placeholder = "Email id is required!";
                }
                else if (string.IsNullOrEmpty(passwordEntry.Text) || string.IsNullOrWhiteSpace(passwordEntry.Text))
                {
                    passwordEntry.PlaceholderColor = Color.Red;
                    passwordEntry.Placeholder = "Password id is required!";
                }
                else if (!pattern)
                {
                    emailIdEntry.Text = "";
                    emailIdEntry.PlaceholderColor = Color.Red;
                    emailIdEntry.Placeholder = "Valid Email id is required!";
                }
                else if (string.IsNullOrEmpty(passwordEntry.Text) || string.IsNullOrWhiteSpace(passwordEntry.Text))
                {
                    passwordEntry.PlaceholderColor = Color.Red;
                    passwordEntry.Placeholder = "Password id is required!";

                }

                else
                {
                    PushContentPage(new Detail());
                }
            }
            catch (Exception ex)
            {

            }
        }

        public ICommand RegisterNowCommand { get { return new Command(async () => await RegisterNowCommandAction()); } }

        private async Task RegisterNowCommandAction()
        {
            try
            {
                await m_view.Navigation.PopAsync();
                LoginModel login = new LoginModel();
                //login.UserName;
                PushContentPage(new Register());
            }
            catch (Exception ex)
            {

            }
        }

        public ICommand ForgotPasswordCommand { get { return new Command(async () => await ForgotPasswordCommandAction()); } }

        private async Task ForgotPasswordCommandAction()
        {
            try
            {
                await m_view.Navigation.PopAsync();
                LoginModel login = new LoginModel();
                //login.UserName;
                PushContentPage(new ForgotPassword());
            }
            catch (Exception ex)
            {

            }
        }
        #endregion
    }
}
