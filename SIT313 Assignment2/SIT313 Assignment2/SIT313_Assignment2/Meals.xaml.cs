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

           listView.ItemsSource = myList;

            for (int x = 0; x < 20; x++)
            {
                myList.Add(new data() { Name = "Kottu", Price = "10", Description = "This is a nice food!" });

            }
           // listView.ItemTemplate = new DataTemplate(typeof(CustomCell));


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
