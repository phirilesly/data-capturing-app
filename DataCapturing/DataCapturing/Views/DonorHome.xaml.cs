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
    public partial class DonorHome : ContentPage
    {
        public DonorHome()
        {
            InitializeComponent();
        }

        private async void MakeDonation_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"//{nameof(NewDonation)}");
        }


        private async void BeneficiaryButton_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"//{nameof(AboutPage)}");
        }
    }
}