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
    public partial class AdminCalender : ContentPage
    {
        public AdminCalender()
        {
            InitializeComponent();
        }

        protected override bool OnBackButtonPressed()
        {
            Navigation.PushAsync(new HomePage(), true);
            return true;
        }
    }
}