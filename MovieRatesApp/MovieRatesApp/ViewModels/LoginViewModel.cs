using MovieRatesApp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MovieRatesApp.ViewModels
{
    class LoginViewModel : BaseViewModel
    {
        public LoginViewModel()
        {
            UserName = string.Empty;
            Password = string.Empty;
            Error = "Email or password are not correct";
            ShowError = false;
            SubmitCommand = new Command(Login);
        }
        #region properties
        private string userName;
        public string UserName
        {
            get { return userName; }
            set
            {
                if(userName != value)
                {
                    userName = value;
                    OnPropertyChanged();
                }
            }
        }
        private string password;
        public string Password
        {
            get { return password; }
            set
            {
                if (password != value)
                {
                    password = value;
                    OnPropertyChanged();
                }
            }
        }
        private string error;
        public string Error
        {
            get { return error; }
            set
            {
                if(error != value)
                {
                    error = value;
                    OnPropertyChanged();
                }
            }
        }
        private bool showError;
        public bool ShowError
        {
            get { return showError; }
            set
            {
                if(showError != value)
                {
                    showError = value;
                    OnPropertyChanged();
                }    
            }
        }
        #endregion
        #region commands
        public ICommand SubmitCommand { protected set; get; }
        #endregion
        #region functions
        private async void Login()
        {
            MovieRatesAPIProxy proxy = MovieRatesAPIProxy.CreateProxy();
            User user = await proxy.LoginAsync(UserName, Password);
            if (user == null)
                ShowError = true;
            else
            {
                App theApp = (App)App.Current;
                theApp.CurrentUser = user;
                Page p = new NavigationPage(new Views.ContactsList());
                App.Current.MainPage = p;
            }
        }
        #endregion

    }
}
