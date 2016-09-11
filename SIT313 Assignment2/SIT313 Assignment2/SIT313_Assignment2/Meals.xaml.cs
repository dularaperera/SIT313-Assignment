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
            ObservableCollection<data> myList = new ObservableCollection<data>();

         

            //----------------------------------------------------------------------------------------------------------------------------

            
        
           ProductsQuery newProduct = new ProductsQuery();

            ProductsDB product = new ProductsDB();
            product.Image = "food.png";
            product.Name = "Rice";
            product.Description = "This is rice";
            product.Price = "10";
            product.Date = "4/8/216";            
            newProduct.InsertDetails(product);



            ProductsQuery pq = new ProductsQuery();
            listView.ItemsSource = pq.GetProductList();

            //----------------------------------------------------------------------------------------------------------------------------

           // listView.ItemsSource = myList;

            //for (int x = 0; x < 20; x++)
            //{
            //   // myList.Add(new data() {Image= "Info.png", Name = "Kottu", Price = "10", Description = "This is a nice food!" });

            //}
        


            DoSomeDataAccess();

        }




        public static void DoSomeDataAccess()
        {
        }

        public void Add_btn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Details());
        }
    }
}
