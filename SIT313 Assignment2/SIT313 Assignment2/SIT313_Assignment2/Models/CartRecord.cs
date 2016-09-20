using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace SIT313_Assignment2.Models
{
    public class CartRecord
    {
        [PrimaryKey, AutoIncrement, Column("ID")]
        public int Id { get; set; }

        [MaxLength(500)]
        public string Name { get; set; }
        public string Price { get; set; }
        public string Qty { get; set; }
        public string Total { get; set; }
        public string Image { get; set; }
        public CartRecord()
        {
        }
    }
}
