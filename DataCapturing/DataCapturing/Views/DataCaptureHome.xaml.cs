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
    public partial class DataCaptureHome : ContentPage
    {
        public DataCaptureHome()
        {
            InitializeComponent();
        }

        private async void NewBeneficiaries_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"//{nameof(NewOrphanPage)}");
        }

        private async void ListImageButton_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"//{nameof(OrphansPage)}");
        }

        private async void TaskImageButton_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"//{nameof(MyTaskPage)}");
        }

        private async void HelpImageButton_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"//{nameof(AboutPage)}");
        }

        protected override bool OnBackButtonPressed()
        {
            Navigation.PushAsync(new CharityOrgHome(), true);
            return true;
        }
    }
}