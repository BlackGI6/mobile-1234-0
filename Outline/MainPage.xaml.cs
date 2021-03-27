using System;
using Outline.Views.Forms;
using Xamarin.Forms;

namespace Outline
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SimpleLoginPage());
        }
    }
}
