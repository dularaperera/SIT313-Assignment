using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.IO;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace SIT313_Assignment2
{
    public partial class meals : ContentPage
    {
        public meals()
        {
            InitializeComponent();
            this.BackgroundImage = "background.png";
            this.Title = "Meals";
            ObservableCollection<data> myList = new ObservableCollection<data>();



            //----------------------------------------------------------------------------------------------------------------------------


            ProductsQuery pq = new ProductsQuery();

            if (pq.GetNoOfProducts() < 1)
            {
                ProductsQuery newProduct = new ProductsQuery();
                ProductsDB product = new ProductsDB();
                product.Image = "ricencurry.png";
                product.Name = "Rice and Curry";
                product.Description = "Basmati rice with 3 veggie curries and 1 meat curry";
                product.Price = "10";
                product.Date = "4/8/216";
                newProduct.InsertDetails(product);

                ProductsDB product1 = new ProductsDB();
                product1.Image = "cfriedrice.png";
                product1.Name = "Fried Rice with Devilled Chicken";
                product1.Description = "Fried Rice with spicy chicken with tomato sauce";
                product1.Price = "12";
                product1.Date = "4/8/216";
                newProduct.InsertDetails(product1);

                ProductsDB product2 = new ProductsDB();
                product2.Image = "kottu.png";
                product2.Name = "Koththu Roti";
                product2.Description = "Chopped Roti with mixed gravy and vegetables";
                product2.Price = "12.5";
                product2.Date = "4/8/2016";
                newProduct.InsertDetails(product2);

                ProductsDB product3 = new ProductsDB();
                product3.Image = "polroti.png";
                product3.Name = "Coconut Roti";
                product3.Description = "Roti made out of coconut flour served with sambal";
                product3.Price = "8";
                product3.Date = "4/8/2016";
                newProduct.InsertDetails(product3);

                ProductsDB product4 = new ProductsDB();
                product4.Image = "kiribath.png";
                product4.Name = "Milk Rice";
                product4.Description = "Blocks of Rice mixed with milk served with chilli sambal";
                product4.Price = "9";
                product4.Date = "5/9/2016";
                newProduct.InsertDetails(product4);

                ProductsDB product5 = new ProductsDB();
                product5.Image = "cuttlefish.png";
                product5.Name = "Hot butter Cuttlefish";
                product5.Description = "Spicy calamari deep fried with a batter";
                product5.Price = "14";
                product5.Date = "18/8/2016";
                newProduct.InsertDetails(product5);

                ProductsDB product6 = new ProductsDB();
                product6.Image = "samosa.png";
                product6.Name = "Samosa";
                product6.Description = "A pastry made with spicy vegetables inside";
                product6.Price = "5";
                product6.Date = "8/9/2016";
                newProduct.InsertDetails(product6);


            }

            listview.ItemsSource = pq.GetProductList();

            //----------------------------------------------------------------------------------------------------------------------------

            //   listView.ItemsSource = myList;

            //for (int x = 0; x < 20; x++)
            //{
            //   // myList.Add(new data() {Image= "Info.png", Name = "Kottu", Price = "10", Description = "This is a nice food!" });

            //}



            DoSomeDataAccess();
            listview.ItemTapped += async (o, e) => {
                var mList = (ListView)o;
                var pro = (mList.SelectedItem as ProductsDB);
                await Navigation.PushAsync(new Details(pro.Image, pro.Name, pro.Description, pro.Price));
                mList.SelectedItem = null; // de-select the row
            };


        }




        public static void DoSomeDataAccess()
        {
        }

        public async void Add_btn_Clicked(object sender, EventArgs e)
        {

        }
    }
}
