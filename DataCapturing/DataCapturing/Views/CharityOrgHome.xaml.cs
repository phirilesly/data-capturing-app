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
    public partial class CharityOrgHome : ContentPage
    {
        public CharityOrgHome()
        {
            InitializeComponent();
        }

        private async void DonorListImageButton_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"//{nameof(CharityOrgDonation)}");
        }

        private async void Donation_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"//{nameof(CharityOrgDonorList)}");
        }
        private async void CapturerListImageButton_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"//{nameof(DataCaptureHome)}");
        }

        private async void HelpImageButton_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"//{nameof(AboutPage)}");
        }

    }
}