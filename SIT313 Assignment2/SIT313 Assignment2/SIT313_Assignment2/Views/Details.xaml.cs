using SIT313_Assignment2.Models;
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
        string pimage;
        string pprice;

        public Details(String image, String name, String description, String price)
        {
            this.BackgroundImage = "background.png";
            this.Title = "Product Details";
            InitializeComponent();
            Name.Text = name;
            Description.Text = description;
            Price.Text = "$" + price;
            Image.Source = image;
            pimage = image;
            pprice = price;
        }


        public void Add_btn_Clicked(object sender, EventArgs e)
        {

            CartRecord pd = new CartRecord();
            int qty = Convert.ToInt16(Qty.Text);
            int total = Convert.ToInt32(pprice);
            pd.Name = Name.Text;
            pd.Price = Price.Text;
            pd.Total = (qty * total).ToString();
            pd.Qty = qty + "";
            pd.Image = pimage;
            CartQuery c = new CartQuery();
            c.InsertDetails(pd);
            Navigation.PushAsync(new Cart());

        }
    }
}
