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
    public partial class AdminOfficialList : ContentPage
    {
        public AdminOfficialList()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            try
            {
                base.OnAppearing();
                var officials = await App.Database.GetUsersAsync();
                var official = officials.Where(x => x.Role == "Councillor").ToList();
                myCollectionView.ItemsSource = official;

            }
            catch
            {

            }


        }

        protected override bool OnBackButtonPressed()
        {
            Navigation.PushAsync(new HomePage(), true);
            return true;
        }

        private async void btnDeleteProduct_Clicked(object sender, EventArgs e)
        {
            try
            {
                string Id = (sender as Button).CommandParameter.ToString();
                if (!string.IsNullOrWhiteSpace(Id))
                {
                    var users = await App.Database.GetUsersAsync();
                    var user = users.Where(x => x.Id.ToString() == Id);
                    var result = await DisplayAlert("Confirm", "Do you want to delete Councollor:" + user.FirstOrDefault().FirstName + "?", "Yes", "No");
                    if (result)
                        await App.Database.DeleteUser(user.FirstOrDefault());
                }

            }
            catch (Exception ex)
            {

            }


        }

        private async void btnAddProduct_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"//{nameof(RegistrationPage)}");
        }
    }
}