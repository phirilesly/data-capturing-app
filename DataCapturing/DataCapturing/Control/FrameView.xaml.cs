using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DataCapturing.Control
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FrameView : ContentView
    {
        public FrameView()
        {
            InitializeComponent();
        }

        public string TextNo
        {
            get
            {
                return lblNo.Text;
            }
            set
            {
                lblNo.Text = value;
            }
        }

        public double FrameHeight
        {
            get
            {
                return frame.HeightRequest;
            }
            set
            {
                frame.HeightRequest = value;
            }
        }

        public string TextDesc
        {
            get
            {
                return lblDesc.Text;
            }
            set
            {
                lblDesc.Text = value;
            }
        }
    }
}