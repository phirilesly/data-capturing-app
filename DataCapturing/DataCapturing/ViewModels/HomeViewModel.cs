using DataCapturing.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace DataCapturing.ViewModels
{
    public partial class HomeViewModel : BaseViewModel
    {
        public Command LoginCommand { get; }
        public HomeViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
            Title = "Home";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
        }

        private async void OnLoginClicked(object obj)
        {
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
        }
        public ICommand OpenWebCommand { get; }
    }
}
