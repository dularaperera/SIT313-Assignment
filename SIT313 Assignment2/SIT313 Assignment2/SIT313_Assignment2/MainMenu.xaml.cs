using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SIT313_Assignment2
{
    public partial class MainMenu : ContentPage
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        public void Login_btn_Clicked(object sender, EventArgs e) {
            Navigation.PushAsync(new Login());
        }

        public void Meals_btn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new meals());
        }

        public void About_btn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AboutUs());
        }

        private double width = 0;
        private double height = 0;

        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);
            if (width != this.width || height != this.height)
            {
                this.width = width;
                this.height = height;
                if (width > height)
                {
                    //outerstack.Orientation = StackOrientation.Horizontal;
                    //outerstack1.Orientation = StackOrientation.Horizontal;
                    outerstack2.Orientation = StackOrientation.Horizontal;
                    outerstack3.Orientation = StackOrientation.Horizontal;
                }
                else
                {
                    //outerstack.Orientation = StackOrientation.Vertical;
                    //outerstack1.Orientation = StackOrientation.Vertical;
                    outerstack2.Orientation = StackOrientation.Vertical;
                    outerstack3.Orientation = StackOrientation.Vertical;
                }
            }
        }
    }
}
