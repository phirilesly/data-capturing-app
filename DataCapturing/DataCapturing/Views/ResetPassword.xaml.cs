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
    public partial class ResetPassword : ContentPage
    {
        public ResetPassword()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var users = await App.Database.GetUsersAsync();
            var user = users.FirstOrDefault(x => x.UserName == EntUserName.Text && x.Phone == EntPhone.Text);
            if(user != null)
            {
                if (EntNewPassword.Text == EntConfirmPassword.Text)
                {
                    var updatedPassword = new User
                    {
                        Id = user.Id,
                        FirstName = user.FirstName,
                        LastName = user.LastName,
                        UserName = user.UserName,
                        Email = user.Email,
                        Province = user.Province,
                        Ward = user.Ward,
                        District = user.District,
                        Address = user.Address,
                        Town = user.Town,
                        Password = EntNewPassword.Text,
                        Phone = EntPhone.Text,
                        Role = user.Role
                    };

                    await App.Database.UpdateUser(updatedPassword);

                    EntUserName.Text = string.Empty;
                    EntPhone.Text = string.Empty;
                    EntNewPassword.Text = string.Empty;
                    EntConfirmPassword.Text = string.Empty;
                   

                    var messageOptions = new MessageOptions
                    {
                        Message = " Password changed Successfully",
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

                    await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
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
            else
            {
                var messageOptions = new MessageOptions
                {
                    Message = "Invalid credentials contact admin",
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

        protected override bool OnBackButtonPressed()
        {
            Navigation.PushAsync(new LoginPage(), true);
            return true;
        }
    }
}