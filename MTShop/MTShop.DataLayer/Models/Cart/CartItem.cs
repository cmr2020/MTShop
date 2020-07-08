using MTShop.DataLayer.Models.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTShop.DataLayer.Models.Cart2
{
   public class CartItem
    {
        public CartItem()
        {

        }

        public int Id { get; set; }

        public int Quantity { get; set; }

        public decimal getTotalPrice()
        {
            return Item.Price * Quantity;
        }

        #region Relations
        public Item Item { get; set; }
        #endregion
    }
}
