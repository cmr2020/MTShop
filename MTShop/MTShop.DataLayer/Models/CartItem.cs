using System;
using System.Collections.Generic;
using System.Text;

namespace MTShop.DataLayer.Models
{
    public class CartItem
    {
        public CartItem()
        {
            
        }

        public int Id { get; set; }

        public Item Item { get; set; }

        public int Quantity { get; set; }

        public decimal getTotalPrice()
        {
            return Item.Price * Quantity;
        }


    }
}
