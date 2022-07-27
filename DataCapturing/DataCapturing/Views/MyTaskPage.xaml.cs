using DataCapturing.Models;
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
    public partial class MyTaskPage : ContentPage
    {
        public MyTaskPage()
        {
            InitializeComponent();
            listView.ItemsSource = new TrackActivityModel().GetTask();
        }

        protected override bool OnBackButtonPressed()
        {
            Navigation.PushAsync(new DataCaptureHome(), true);
            return true;
        }

        private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (listView.SelectedItem != null)
                listView.SelectedItem = null;
        }

        private void btnRecent_Clicked(object sender, EventArgs e)
        {
            ChangeButtonAppearance((Button)sender);
            listView.IsVisible = true;
            listView1.IsVisible = false;
            listView.ItemsSource = new TrackActivityModel().GetTask();
        }

        private void btnToday_Clicked(object sender, EventArgs e)
        {
            ChangeButtonAppearance((Button)sender);
            listView1.IsVisible = true;
            listView.IsVisible = false;
            listView1.ItemsSource = new TrackActivityModel().GetTask();
        }

        private void ChangeButtonAppearance(Button btn)
        {
            if (btn.Text == "Recent")
            {
                ChangeButtonColor(btnRecent, true);
                ChangeButtonColor(btnToday, false);
                ChangeButtonColor(btnUpcoming, false);
            }
            else if (btn.Text == "Today")
            {
                ChangeButtonColor(btnRecent, false);
                ChangeButtonColor(btnToday, true);
                ChangeButtonColor(btnUpcoming, false);
            }
            else if (btn.Text == "Upcoming")
            {
                ChangeButtonColor(btnRecent, false);
                ChangeButtonColor(btnToday, false);
                ChangeButtonColor(btnUpcoming, true);
            }
        }

        private void ChangeButtonColor(Button btn, bool isSelected)
        {
            if (isSelected)
            {
                btn.BackgroundColor = Color.FromHex("#0C1F4B");
                btn.TextColor = Color.White;
            }
            else
            {
                btn.BackgroundColor = Color.White;
                btn.TextColor = Color.FromHex("#0C1F4B");
            }
        }
    }
}