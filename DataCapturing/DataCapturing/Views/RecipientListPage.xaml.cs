using DataCapturing.Models;
using DataCapturing.ViewModels;
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
    public partial class OrphansPage : ContentPage
    {
  
        public OrphansPage()
        {
            InitializeComponent();
           
        }
        protected override async void OnAppearing()
        {
            try
            {
                base.OnAppearing();
                myCollectionView.ItemsSource = await App.Database.GetRecipientsAsync();
            }
            catch
            {

            }


        }

       

        private async void btnAddProduct_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"//{nameof(NewOrphanPage)}");
        }


        private async void btnDeleteProduct_Clicked(object sender, EventArgs e)
        {
            try
            {
                string Id = (sender as Button).CommandParameter.ToString();
                if (!string.IsNullOrWhiteSpace(Id))
                {
                    var products = await App.Database.GetRecipientsAsync();
                    var product = products.Where(x => x.Id.ToString() == Id);
                    var result = await DisplayAlert("Confirm", "Do you want to delete Recipient:" + product.FirstOrDefault().FirstName + "?", "Yes", "No");
                    if (result)
                        await App.Database.DeleteRecipient(product.FirstOrDefault());
                }

            }
            catch (Exception ex)
            {

            }

    


    }

        protected override bool OnBackButtonPressed()
        {
            Navigation.PushAsync(new DataCaptureHome(), true);
            return true;
        }

    }
}