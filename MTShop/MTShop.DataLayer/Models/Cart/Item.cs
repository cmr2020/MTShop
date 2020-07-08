using System;
using System.Collections.Generic;
using System.Text;

namespace MTShop.DataLayer.Models
{
    public class Item
    {
        public Item()
        {
            
        }

        public int Id { get; set; }

        public Product Product { get; set; }

        public decimal Price { get; set; }

        public int QuantityInStock { get; set; }
    }
}
