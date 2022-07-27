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
    public partial class CouncillorHome : ContentPage
    {
        public CouncillorHome()
        {
            InitializeComponent();
        }

        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"//{nameof(CouncillorDonationList)}");
        }

        private async void ImageButton_Clicked_1(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"//{nameof(AboutPage)}");
        }

   
    }
}