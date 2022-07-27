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
   
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
           
        }

        private async void TapRecipients_OnTapped(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"//{nameof(RecipientsPage)}");
        }

        private async void TapDonations_OnTapped(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"//{nameof(AdminDonationList)}");
        }

        private async void TapMyTask_OnTapped(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"//{nameof(MyTaskPage)}");
        }

        private async void TapAbout_OnTapped(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"//{nameof(AboutPage)}");
        }

        private async void Beneficiaries_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"//{nameof(AdminBeneficiaryList)}");
        }
        private async void Donors_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"//{nameof(AdminDonorList)}");
        }
        private async void Organizations_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"//{nameof(AdminOrganizationList)}");
        }
        private async void Donations_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"//{nameof(AdminDonationList)}");
        }
        private async void Officials_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"//{nameof(AdminOfficialList)}");
        }
        private async void Provinces_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"//{nameof(AdminCalender)}");
        }
        private async void Users_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"//{nameof(UsersList)}");
        }
        private async void Reports_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"//{nameof(ReportsPage)}");
        }
        private async void About_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"//{nameof(AboutPage)}");
        }
    }
}