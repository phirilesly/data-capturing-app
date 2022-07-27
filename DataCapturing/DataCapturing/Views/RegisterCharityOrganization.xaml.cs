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
    public partial class RegisterCharityOrganization : ContentPage
    {
        public RegisterCharityOrganization()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrWhiteSpace(EntName.Text) && string.IsNullOrWhiteSpace(EntEmail.Text) && string.IsNullOrWhiteSpace(EntContact.Text) &&
                    string.IsNullOrWhiteSpace(EntRegNumber.Text))
                {
                    var messageOptions = new MessageOptions
                    {
                        Message = "Invalid enter all required fields",
                        Foreground = Color.White,
                        Font = Font.SystemFontOfSize(16),
                        Padding = new Thickness(20)
                    };

                    var options = new ToastOptions
                    {
                        MessageOptions = messageOptions,

                        BackgroundColor = Color.FromHex("#e42241")
                    };

                    await this.DisplayToastAsync(options);
                }
                else
                {
                    RegisterOrganization();
                }
                
                  
                   

                

            }
            catch
            {

            }


        }
        async void RegisterOrganization()
        {
            var newOrg = new Organisaztion
            {
                Name = EntName.Text,
               Email = EntEmail.Text,
               Address = EntAddress.Text,
                Contact = EntContact.Text,
                DonationType = EntType.Text,
                HeadOfficeLocation = EntLocation.Text,
                RegistrationNumber = EntRegNumber.Text, 
               
            };

            var orgs = await App.Database.GetOrganizationsAsync();
            var org = orgs.Where(x => x.Name == newOrg.Name && x.RegistrationNumber == newOrg.RegistrationNumber).FirstOrDefault();
            if (org != null)
            {
                var messageOptions = new MessageOptions
                {
                    Message = "Organization with same name already exist",
                    Foreground = Color.White,
                    Font = Font.SystemFontOfSize(16),
                    Padding = new Thickness(20)
                };

                var options = new ToastOptions
                {
                    MessageOptions = messageOptions,

                    BackgroundColor = Color.FromHex("#CC0000")
                };

                await this.DisplayToastAsync(options);
            }
            else
            {
                await App.Database.SaveOrganizationAsync(newOrg);

                EntName.Text = string.Empty;
                EntEmail.Text = string.Empty;
                EntRegNumber.Text = string.Empty;
                EntAddress.Text = string.Empty;
                EntContact.Text = string.Empty;
                EntLocation.Text = string.Empty;
                EntType.Text = string.Empty;


                var messageOptions = new MessageOptions
                {
                    Message = "Organization Registered Successfully",
                    Foreground = Color.White,
                    Font = Font.SystemFontOfSize(16),
                    Padding = new Thickness(20)
                };

                var options = new ToastOptions
                {
                    MessageOptions = messageOptions,

                    BackgroundColor = Color.FromHex("#19cb1e")
                };

                await this.DisplayToastAsync(options);
                await Shell.Current.GoToAsync($"//{nameof(CharityOrgHome)}");
            }


        }

        protected override bool OnBackButtonPressed()
        {
            Navigation.PushAsync(new CharityOrgRegistration(), true);
            return true;
        }

    }
    }
