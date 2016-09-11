using System;
using SQLite;

namespace SIT313_Assignment2
{
    public class ProductsDB
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(500)]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string Date { get; set; }
        public string Image { get; set; }
        public ProductsDB()
        {
        }
    }
}
