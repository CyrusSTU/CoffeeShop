using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CoffeeShop
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private async void espressoButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EspressoPage());
        }

        private async void hotdrinksButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HotDrinks());
        }

        private async void colddrinksButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ColdDrinks());
        }

        private async void quickbitesButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new QuickBites());
        }
    }
}