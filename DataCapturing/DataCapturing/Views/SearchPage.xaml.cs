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
    public partial class SearchPage : ContentPage
    {
        public SearchPage()
        {
            InitializeComponent();
        }

      async  void OnTextChanged(object sender, EventArgs e)
        {
            SearchBar searchBar = (SearchBar)sender;
            var recipients = await  App.Database.GetRecipientsAsync();
            var results= recipients.Where(s => s.Equals(searchBar));
            searchResults.ItemsSource = results;
        }

        private async void btnDeleteRecipient_Clicked(object sender, EventArgs e)
        {
            try
            {
                string Id = (sender as Button).CommandParameter.ToString();
                if (!string.IsNullOrWhiteSpace(Id))
                {
                    var recipients = await App.Database.GetRecipientsAsync();
                    var recipient= recipients.Where(x => x.Id.ToString() == Id);
                    var result = await DisplayAlert("Confirm", "Do you want to delete Recipient:" + recipient.FirstOrDefault().FirstName + "?", "Yes", "No");
                    if (result)
                        await App.Database.DeleteRecipient(recipient.FirstOrDefault());
                }

            }
            catch (Exception ex)
            {

            }


        }

        protected override bool OnBackButtonPressed()
        {
            Navigation.PushAsync(new RecipientsPage(), true);
            return true;
        }
    }
}