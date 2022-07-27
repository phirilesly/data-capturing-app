using DataCapturing.ViewModels;
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
    public partial class RecipientsPage : ContentPage
    {
     
        public RecipientsPage()
        {
            InitializeComponent();
      
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
          
        }

        protected override bool OnBackButtonPressed()
        {
            Navigation.PushAsync(new HomePage(), true);
            return true;
        }


        private async void TapOrphans_OnTapped(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"//{nameof(NewOrphanPage)}");
        }

        private async void TapElderly_OnTapped(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"//{nameof(OrphansPage)}");
        }

     

        private async void TapOthers_OnTapped(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"//{nameof(AboutPage)}");
        }

        private async void TapSearch_Tapped(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"//{nameof(SearchPage)}");
        }
    }
}