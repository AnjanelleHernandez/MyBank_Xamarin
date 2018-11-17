using System;
using System.Collections.Generic;
using System.Text;
using My_Bank.Services;
using My_Bank.Models;
using System.Windows.Input;
using Xamarin.Forms;

namespace My_Bank.ViewModels
{
    class AuthViewModel
    {
        private AuthServices _authServices = new AuthServices();
        public User _user;
        public LoginUser _loginUser;

        public ICommand RegisterCommand => new Command(async() => 
        {
            await _authServices.Register(_user);
        }); 
    }
}
