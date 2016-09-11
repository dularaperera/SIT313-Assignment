using System;
using System.IO;
using Xamarin.Forms;
using SIT313_Assignment2.iOS;

[assembly: Dependency(typeof(Products_SQLite_iOS))]
namespace SIT313_Assignment2.iOS
{
    public class Products_SQLite_iOS : IProducts
    {
        public SQLite.Net.SQLiteConnection GetConnection()
        {
            var fileName = "Products.db";
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var libraryPath = Path.Combine(documentsPath, "..", "Library");
            var path = Path.Combine(libraryPath, fileName);

            var platform = new SQLite.Net.Platform.XamarinIOS.SQLitePlatformIOS();
            var connection = new SQLite.Net.SQLiteConnection(platform, path);

            return connection;
        }
    }
}