using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace My_Bank
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Login_Page : ContentPage
	{

        public Login_Page ()
		{
			InitializeComponent ();
        }

        private async void HomeScreenOnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Home_Screen());
        }

        private async void NavigateButton_CreateAccountOnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Create_Account());
        }
    }
}