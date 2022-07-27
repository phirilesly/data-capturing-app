using DataCapturing.Models;
using DataCapturing.ViewModels;
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
    public partial class NewOrphanPage : ContentPage
    {

        public NewOrphanPage()
        {
            InitializeComponent();

        }



        async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(EntFirstName.Text))
                {
                    await DisplayAlert("Invalid", "Blank or WhiteSpace", "OK");
                }
                else
                {
                    AddRecipient();
                  

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

                    await Shell.Current.GoToAsync($"//{nameof(RecipientsPage)}");

                }

            }
            catch
            {
                
            }

         

        }

        async void AddRecipient()
        {
            var gender = PickerGender.Items[PickerGender.SelectedIndex];
            var status = PickerStatus.Items[PickerStatus.SelectedIndex];

            var newRecipient = new Recipient
            {
                FirstName = EntFirstName.Text,
                LastName = EntLastName.Text,
                Gender = gender,
                Status = status,
                NationalId = EntIDNumber.Text,
                Phone = EntPhone.Text,
                Province = EntProvince.Text,
                Village = EntVillage.Text,
            };
            await App.Database.SaveRecipientAsync(newRecipient);

            EntFirstName.Text = string.Empty;
            EntLastName.Text = string.Empty;
            EntIDNumber.Text = string.Empty;
            EntPhone.Text = string.Empty;
            EntVillage.Text = string.Empty;
            EntProvince.Text = string.Empty;
            
        }

    
        private void btnClear_Clicked(object sender, EventArgs e)
        {
            EntFirstName.Text = string.Empty;
            EntLastName.Text = string.Empty;
            EntIDNumber.Text = string.Empty;
            EntPhone.Text = string.Empty;
            EntVillage.Text = string.Empty;
            EntProvince.Text = string.Empty;
        }



        protected override bool OnBackButtonPressed()
        {
            Navigation.PushAsync(new DataCaptureHome(), true);
            return true;
        }
    }
}