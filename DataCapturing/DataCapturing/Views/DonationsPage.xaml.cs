using DataCapturing.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DataCapturing.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DonationsPage : ContentPage
    {
        public DonationsPage()
        {
            
            InitializeComponent();
            //listView.ItemsSource = new AssignmentModel().Get();
        }

        protected override bool OnBackButtonPressed()
        {
            Navigation.PushAsync(new HomePage(), true);
            return true;
        }

        private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //if (listView.SelectedItem != null)
            //{
            //    listView.SelectedItem = null;
            //}
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
    }
}