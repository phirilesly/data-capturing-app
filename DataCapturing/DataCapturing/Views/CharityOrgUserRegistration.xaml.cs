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
    public partial class CharityOrgRegistration : ContentPage
    {
        public CharityOrgRegistration()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(EntFirstName.Text) && string.IsNullOrWhiteSpace(EntLastName.Text) && string.IsNullOrWhiteSpace(EntEmail.Text) &&
                    string.IsNullOrWhiteSpace(EntPassword.Text))
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
                    if (EntPassword.Text == EntCPassword.Text)
                    {
                        AddUser();
                    }
                    else
                    {
                        var messageOptions = new MessageOptions
                        {
                            Message = "Password do not match",
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

                }

            }
            catch
            {

            }


        }
        async void AddUser()
        {
            var newUser = new User
            {
                FirstName = EntFirstName.Text,
                LastName = EntLastName.Text,
                UserName = EntEmail.Text,
                Password = EntPassword.Text,
                Phone = EntPhone.Text,
                Role = "CharityOrganization"



            };

            var users = await App.Database.GetUsersAsync();
            var user = users.Where(x => x.UserName == newUser.UserName && x.FirstName == newUser.FirstName).FirstOrDefault();
            if (user != null)
            {
                var messageOptions = new MessageOptions
                {
                    Message = "Invalid check your username",
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
                await App.Database.SaveUserAsync(newUser);

                EntFirstName.Text = string.Empty;
                EntLastName.Text = string.Empty;
                EntPassword.Text = string.Empty;
                EntCPassword.Text = string.Empty;
                EntEmail.Text = string.Empty;



                var messageOptions = new MessageOptions
                {
                    Message = "Registred user account successfully",
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
                await Shell.Current.GoToAsync($"//{nameof(RegisterCharityOrganization)}");
            }


        }

        protected override bool OnBackButtonPressed()
        {
            Navigation.PushAsync(new RegistrationPage(), true);
            return true;
        }
    }
}