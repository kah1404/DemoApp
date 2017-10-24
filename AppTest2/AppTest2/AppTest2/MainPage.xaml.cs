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

            

            var button1 = new Button { Text = "Login", TextColor = Color.White, BackgroundColor = Color.Black };
            var entry1 = new Entry { Placeholder = "Username" };
            var entry2 = new Entry { Placeholder = "Password", IsPassword = true};
            var label1 = new Label{ Text = "Change Me"};

             Content = new StackLayout
            {
                Orientation = StackOrientation.Vertical,

                Children =
                {
                     entry1,
                     entry2,
                     button1,
                     label1

                }
                
            };

        }

    }
}
