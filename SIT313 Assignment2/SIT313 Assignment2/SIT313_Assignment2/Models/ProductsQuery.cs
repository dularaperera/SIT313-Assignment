using System;
using System.Collections.Generic;
using System.Linq;

using SQLite.Net;
using Xamarin.Forms;

namespace SIT313_Assignment2
{
    public class ProductsQuery
    {
        static object locker = new object();

        SQLiteConnection sqlcon;

        //Getting connection and creating table
        public ProductsQuery()
        {
            sqlcon = DependencyService.Get<IProducts>().GetConnection();
            sqlcon.CreateTable<ProductsDB>();
          
        }

        //Insert Note
        public int InsertDetails(ProductsDB notesDB)
        {
            lock (locker)
            {
                return sqlcon.Insert(notesDB);
            }
        }

        //Update Note
        public int UpdateDetails(ProductsDB noteDB)
        {
            lock (locker)
            {
                return sqlcon.Update(noteDB);
            }
        }

        //Delete Note
        public int DeleteNote(int id)
        {
            lock (locker)
            {
                return sqlcon.Delete<ProductsDB>(id);
            }
        }

        //Get all Notes
        public IEnumerable<ProductsDB> GetProductList()
        {
            lock (locker)
            {
                return (from i in sqlcon.Table<ProductsDB>() select i).ToList();
            }
        }

        public int GetNoOfProducts()
        {
            lock (locker)
            { 
                return (from i in sqlcon.Table<ProductsDB>() select i).ToList().Count;
            }
        }


        //Get specific Note by ID
        public ProductsDB GetNote(int id)
        {
            lock (locker)
            {
                return sqlcon.Table<ProductsDB>().FirstOrDefault(t => t.Id == id);
            }
        }

        //Dispose
        public void Dispose()
        {
            sqlcon.Dispose();
        }

    }
}
