using SIT313_Assignment2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;


namespace SIT313_Assignment2
{
    public partial class SignUp : ContentPage
    {
        public CustomerQuery _CustomerQuery;
        public CustomersDB _CustomerDB;

        public SignUp()
        {
            InitializeComponent();
            this.BackgroundImage = "background.png";
            this.Title = "Sign up";
            _CustomerDB = new CustomersDB();
            _CustomerQuery = new CustomerQuery();



            var fullname = new Entry { Placeholder = "full name", HorizontalOptions = LayoutOptions.FillAndExpand };
            var usname = new Entry { Placeholder = "Username" };
            var pw = new Entry { IsPassword = true, Placeholder = "Password" };
            var repw = new Entry { IsPassword = true, Placeholder = "Re type Password" };
            var add = new Entry { Placeholder = "Enter Address" };

            var signup = new Button { Text = "signup", HorizontalOptions = LayoutOptions.FillAndExpand };

            signup.Clicked += (object sender, EventArgs e) =>
            {

                try
                {
                    if (fullname.Text == null || usname.Text == null || pw.Text == null || repw.Text == null || add.Text == null)
                    {
                        DisplayAlert("Alert", "Please Fill All the Fields", "OK");
                    }
                    else
                    {
                        if (pw.Text == repw.Text)
                        {
                            InsertData(fullname.Text.ToString(), usname.Text.ToString(), pw.Text.ToString(), add.Text.ToString());
                            DisplayAlert("Alert", "Saved Succesfully.", "OK");
                            Navigation.PushAsync(new Login());
                        }
                        else
                        {
                            DisplayAlert("Alert", "Please check whether the password and the re typed password is correct", "OK");
                        }
                    }
                }
                catch (Exception ex)
                {
                    string error = ex.ToString();
                    DisplayAlert("Sorry...", "Something went wrong. Try after sometime.", "OK");
                    // Navigation.PushAsync(new HomePage());
                }
            };


            var btnStack = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Children = {
                    signup
                }
            };

            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Children = { fullname, usname, pw, repw, add, btnStack }
            };


        }

        public void InsertData(string name, string uname, string password, string address)
        {
            _CustomerDB.Name = name;
            _CustomerDB.Username = uname;
            _CustomerDB.Password = password;
            _CustomerDB.Address = address;
            _CustomerQuery.InsertDetails(_CustomerDB);

        }
    }
}
