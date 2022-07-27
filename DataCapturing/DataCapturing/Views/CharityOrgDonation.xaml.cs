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
    public partial class CharityOrgDonation : ContentPage
    {
        public CharityOrgDonation()
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

        protected override bool OnBackButtonPressed()
        {
            Navigation.PushAsync(new CharityOrgHome(), true);
            return true;
        }

        private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }

        private void listView_ItemSelected_1(object sender, SelectedItemChangedEventArgs e)
        {

        }
    }
}