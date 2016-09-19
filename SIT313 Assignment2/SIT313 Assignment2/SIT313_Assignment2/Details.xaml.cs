using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace SIT313_Assignment2
{
    public partial class Details : ContentPage
    {
        public Details(String image, String name, String description, String price)
        {
            this.BackgroundImage = "background.png";
            InitializeComponent();
            Name.Text = name;
            Description.Text = description;
            Price.Text = "$"+price;
            Image.Source = image;

        }
    }
}
