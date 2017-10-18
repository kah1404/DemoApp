using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppTest2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            




//            var trulsmumrikken = new Label
//            {
//                Text = "bleh",
//                HorizontalOptions = LayoutOptions.Center,
//                VerticalOptions = LayoutOptions.Center,
//
//            };
//
//            Content = new StackLayout
//            {
//                Orientation = StackOrientation.Vertical,
//
//                Children =
//                {
//                    trulsmumrikken   
//                }
//
//                
//            };



        }

        private void Butters_OnClicked(object sender, EventArgs e)
        {
            ByttMeg.Text = Entry.Text;
        }
    }
}
