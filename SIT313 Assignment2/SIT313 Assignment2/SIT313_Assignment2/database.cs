using System;
using System.IO;
using SQLite;

namespace SIT313_Assignment2.Droid
{
    class database
    {

        public static void DoSomeDataAccess()
        {
            Console.WriteLine("Creating database, if it doesn't already exist");
            string dbPath = Path.Combine(
                 Environment.GetFolderPath(Environment.SpecialFolder.Personal),
                 "ormdemo.db3");
            var db = new SQLiteConnection(dbPath);
            db.CreateTable<Products>();
            if (db.Table<Products>().Count() == 0)
            {
                // only insert the data if it doesn't already exist
                var newStock = new Products();
                newStock.Symbol = "AAPL";
                db.Insert(newStock);
                newStock = new Products();
                newStock.Symbol = "GOOG";
                db.Insert(newStock);
                newStock = new Products();
                newStock.Symbol = "MSFT";
                db.Insert(newStock);
            }
            Console.WriteLine("Reading data");
            var table = db.Table<Products>();
            foreach (var s in table)
            {
                 Console.WriteLine(s.Id + " " + s.Symbol);
            }
        }

    }
}