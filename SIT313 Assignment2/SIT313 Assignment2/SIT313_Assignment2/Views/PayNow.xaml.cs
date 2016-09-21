using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace SIT313_Assignment2.Views
{
    public partial class PayNow : ContentPage
    {
        public PayNow()
        {
            InitializeComponent();
            this.Title = "Pay Now";
            this.BackgroundImage = "background.png";

        }
        public void PayNow_btn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ThankYou());

        }
    }
}
