using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace My_Bank
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Create_Account : ContentPage
	{
		public Create_Account ()
		{
			InitializeComponent ();
		}

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Home_Screen());
        }
    }
}