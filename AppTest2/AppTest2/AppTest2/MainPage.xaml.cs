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

        }

        private void Button1_OnClicked(object sender, EventArgs e)
        {
            Label1.Text = Entry1.Text;
            Entry1.Text = " ";
        }

        private void Button2_OnClicked(object sender, EventArgs e)
        {
            Entry1.Text = " ";
            Entry2.Text = " ";
        }
    }
}
