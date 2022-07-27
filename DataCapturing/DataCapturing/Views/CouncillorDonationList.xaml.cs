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
    public partial class CouncillorDonationList : ContentPage
    {
        public CouncillorDonationList()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            try
            {
                base.OnAppearing();
             
            }
            catch
            {

            }


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

        private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }

        protected override bool OnBackButtonPressed()
        {
            Navigation.PushAsync(new CouncillorHome(), true);
            return true;
        }
    }
}