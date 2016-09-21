using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace SIT313_Assignment2.Views
{
    public partial class ThankYou : ContentPage
    {
        public ThankYou()
        {
            InitializeComponent();
            this.BackgroundColor = Color.White;
        }
        public void Menu_btn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainMenu());

        }
    }
}
