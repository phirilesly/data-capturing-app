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
    public partial class CharityOrgDonorList : ContentPage
    {
        public CharityOrgDonorList()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            try
            {
                base.OnAppearing();
                var users = await App.Database.GetUsersAsync();
                var userList = users.Where(x => x.Role == "Donor").ToList();
                myCollectionView.ItemsSource = userList;

            }
            catch
            {

            }


        }

        protected override bool OnBackButtonPressed()
        {
            Navigation.PushAsync(new CharityOrgHome(), true);
            return true;
        }

        private async void btnDeleteProduct_Clicked(object sender, EventArgs e)
        {
            try
            {
                string Id = (sender as Button).CommandParameter.ToString();
                if (!string.IsNullOrWhiteSpace(Id))
                {
                    var products = await App.Database.GetUsersAsync();
                    var product = products.Where(x => x.Id.ToString() == Id);
                    var result = await DisplayAlert("Confirm", "Do you want to delete Donor:" + product.FirstOrDefault().FirstName + "?", "Yes", "No");
                    if (result)
                        await App.Database.DeleteUser(product.FirstOrDefault());
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