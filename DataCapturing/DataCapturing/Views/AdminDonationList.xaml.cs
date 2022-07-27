using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DataCapturing.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AdminDonationList : ContentPage
    {
        public AdminDonationList()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            try
            {
                base.OnAppearing();
                myCollectionView.ItemsSource = await App.Database.GetDonationsAsync();
            }
            catch
            {

            }


        }



        private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }

        private async void AFCAButton_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"//{nameof(AFCAList)}");
        }

        private async void CareButton_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"//{nameof(CareList)}");
        }

        private async void UNICEFButton_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"//{nameof(UnisefList)}");
        }

        protected override bool OnBackButtonPressed()
        {
            Navigation.PushAsync(new HomePage(), true);
            return true;
        }
    }
}