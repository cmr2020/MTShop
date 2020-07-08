using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MTShop.DataLayer.Models
{
    public class Cart
    {
        public Cart()
        {
            CartItems = new List<CartItem>();
        }

        public int OrderId { get; set; }

        #region Relations
        public List<CartItem> CartItems { get; set; }
        #endregion
 
    }
}