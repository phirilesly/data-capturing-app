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
    public partial class AdminOrganizationList : ContentPage
    {
        public AdminOrganizationList()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            try
            {
                base.OnAppearing();
                myCollectionView.ItemsSource = await App.Database.GetOrganizationsAsync();
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
                    var products = await App.Database.GetOrganizationsAsync();
                    var product = products.Where(x => x.Id.ToString() == Id);
                    var result = await DisplayAlert("Confirm", "Do you want to delete Charity Organization:" + product.FirstOrDefault().Name + "?", "Yes", "No");
                    if (result)
                        await App.Database.DeleteOrganization(product.FirstOrDefault());
                }

            }
            catch (Exception ex)
            {

            }


        }

        private async void btnAddProduct_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"//{nameof(RegisterCharityOrganization)}");
        }
    }
}