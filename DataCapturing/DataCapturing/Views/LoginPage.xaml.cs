
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
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            
        }

   

        private async void Button_Clicked(object sender, EventArgs e)
        {

           
            if (string.IsNullOrEmpty(EntUserName.Text) || string.IsNullOrWhiteSpace(EntUserName.Text))
            {
                var messageOptions = new MessageOptions
                {
                    Message = "Invalid text field empty",
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
                var users = await App.Database.GetUsersAsync();

                var user = users.Where(x => x.UserName == EntUserName.Text && x.Password == EntPassword.Text).FirstOrDefault();
                if (user != null)
                {
                    if (user.Role == "Admin")
                    {
                        var messageOptions = new MessageOptions
                        {
                            Message = "Login Successfully",
                            Foreground = Color.White,
                            Font = Font.SystemFontOfSize(16),
                            Padding = new Thickness(20)
                        };

                        var options = new ToastOptions
                        {
                            MessageOptions = messageOptions,

                            BackgroundColor = Color.FromHex("#34da6f")
                        };
                        await this.DisplayToastAsync(options);

                        await Shell.Current.GoToAsync($"//{nameof(HomePage)}");
                    }
                    else if (user.Role == "CharityOrganization")
                    {
                        var messageOptions = new MessageOptions
                        {
                            Message = "Login Successfully",
                            Foreground = Color.White,
                            Font = Font.SystemFontOfSize(16),
                            Padding = new Thickness(20)
                        };

                        var options = new ToastOptions
                        {
                            MessageOptions = messageOptions,

                            BackgroundColor = Color.FromHex("#34da6f")
                        };
                        await this.DisplayToastAsync(options);

                        await Shell.Current.GoToAsync($"//{nameof(CharityOrgHome)}");
                    }
                    else if (user.Role == "Councillor")
                    {
                        var messageOptions = new MessageOptions
                        {
                            Message = "Login Successfully",
                            Foreground = Color.White,
                            Font = Font.SystemFontOfSize(16),
                            Padding = new Thickness(20)
                        };

                        var options = new ToastOptions
                        {
                            MessageOptions = messageOptions,

                            BackgroundColor = Color.FromHex("#34da6f")
                        };
                        await this.DisplayToastAsync(options);

                        await Shell.Current.GoToAsync($"//{nameof(CouncillorHome)}");
                    }
                    else if (user.Role == "DataCapturer")
                    {
                        var messageOptions = new MessageOptions
                        {
                            Message = "Login Successfully",
                            Foreground = Color.White,
                            Font = Font.SystemFontOfSize(16),
                            Padding = new Thickness(20)
                        };

                        var options = new ToastOptions
                        {
                            MessageOptions = messageOptions,

                            BackgroundColor = Color.FromHex("#34da6f")
                        };
                        await this.DisplayToastAsync(options);

                        await Shell.Current.GoToAsync($"//{nameof(DataCaptureHome)}");
                    }
                    else if (user.Role == "Donor")
                    {
                        var messageOptions = new MessageOptions
                        {
                            Message = "Login Successfully",
                            Foreground = Color.White,
                            Font = Font.SystemFontOfSize(16),
                            Padding = new Thickness(20)
                        };

                        var options = new ToastOptions
                        {
                            MessageOptions = messageOptions,

                            BackgroundColor = Color.FromHex("#34da6f")
                        };
                        await this.DisplayToastAsync(options);

                        await Shell.Current.GoToAsync($"//{nameof(DonorHome)}");
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
                else
                {

                    var messageOptions = new MessageOptions
                    {
                        Message = "Invalid username or password",
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

            private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"//{nameof(RegistrationPage)}");
        }

        private async void TapGestureRecognizer_ForgetPasswordTapped(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"//{nameof(ResetPassword)}");
        }
    }
}