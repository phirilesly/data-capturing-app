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
    public partial class NewDonation : ContentPage
    {
        public NewDonation()
        {
            InitializeComponent();
        }

        private async void btnSave_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(EntName.Text))
                {
                    await DisplayAlert("Invalid", "Blank or WhiteSpace", "OK");
                }
                else
                {
                    AddDonation();


                    var messageOptions = new MessageOptions
                    {
                        Message = "Your record has beed added successfully",
                        Foreground = Color.White,
                        Font = Font.SystemFontOfSize(16),
                        Padding = new Thickness(20),
                    };

                    var options = new ToastOptions
                    {
                        MessageOptions = messageOptions,

                        BackgroundColor = Color.FromHex("#34da6f")
                    };
                    await this.DisplayToastAsync(options);

                    await Shell.Current.GoToAsync($"//{nameof(DonorHome)}");

                }

            }
            catch
            {

            }



        }

        async void AddDonation()
        {
            var type = PickerType.Items[PickerType.SelectedIndex];
         
            var newDonation = new Donation
            {
                Name = EntName.Text,    
                 Beneficiary = type,
                 Location = EntLocation.Text,
                 Proof = EntProof.Text,
                 Type = EntType.Text,
                
            };
            await App.Database.SaveDonationAsync(newDonation);

            EntName.Text = string.Empty;
            EntLocation.Text = string.Empty;
            EntProof.Text = string.Empty;
            EntType.Text = string.Empty;
         


        }

        private void btnClear_Clicked(object sender, EventArgs e)
        {
            EntName.Text = string.Empty;
            EntLocation.Text = string.Empty;
            EntProof.Text = string.Empty;
            EntType.Text = string.Empty;
        }

        protected override bool OnBackButtonPressed()
        {
            Navigation.PushAsync(new DonorHome(), true);
            return true;
        }
    }
}