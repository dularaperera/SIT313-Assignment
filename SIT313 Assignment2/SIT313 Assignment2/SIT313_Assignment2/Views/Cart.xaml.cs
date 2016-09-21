using SIT313_Assignment2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace SIT313_Assignment2
{
    public partial class Cart : ContentPage
    {
        public Cart()
        {
            InitializeComponent();

            CartQuery c = new CartQuery();
       

            cart.ItemsSource = c.GetList();
           
           
        }
    }
}
