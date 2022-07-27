using DataCapturing.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace DataCapturing.ViewModels
{
    public partial class WelcomeViewModel : BaseViewModel
    {
        public Command LoginCommand { get; }

        public WelcomeViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
        }

        private async void OnLoginClicked(object obj)
        {
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
        }
    }
}
