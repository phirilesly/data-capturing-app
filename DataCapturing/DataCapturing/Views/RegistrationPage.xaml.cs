using DataCapturing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.CommunityToolkit.UI.Views.Options;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DataCapturing.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrationPage : ContentPage
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

      

        protected override bool OnBackButtonPressed()
        {
            Navigation.PushAsync(new LoginPage(), true);
            return true;
        }

        private async void DataCaptureButton_Clicked(object sender, EventArgs e)
        {
            //var button = (Button)sender;
            //button.BackgroundColor = Color.Green;
            await Shell.Current.GoToAsync($"//{nameof(DataCaptureRegistration)}");
        }

        private async void CouncillorButton_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"//{nameof(CouncillorRegistration)}");
        }

        private async void CharityOrgButton_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"//{nameof(CharityOrgRegistration)}");
        }

        private async void DonorButton_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"//{nameof(DonorRegistration)}");
        }

        private async void AdminButton_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"//{nameof(AdminRegistration)}");
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}