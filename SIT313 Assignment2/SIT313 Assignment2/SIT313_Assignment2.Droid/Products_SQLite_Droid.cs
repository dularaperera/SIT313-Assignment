using System;
using System.IO;
using Xamarin.Forms;
using SIT313_Assignment2.Droid;


[assembly: Dependency(typeof(Products_SQLite_Droid))]
namespace SIT313_Assignment2.Droid
{
    public class Products_SQLite_Droid : IProducts
    {
        public SQLite.Net.SQLiteConnection GetConnection()
        {
            var filename = "Products.db";
            var documentspath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentspath, filename);

            var platform = new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid();
            var connection = new SQLite.Net.SQLiteConnection(platform, path);
            return connection;
        }
    }
}