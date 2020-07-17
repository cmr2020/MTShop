using System;
using System.Collections.Generic;
using System.Text;
using MTShop.DataLayer.Models.User;
namespace MTShop.DataLayer.Models.Cart
{
    public class Order
    {
        public int OrderId { get; set; }

        public int UserId { get; set; }

        public DateTime CreateDate { get; set; }

        public bool IsFinaly { get; set; }


        #region Relations
       // public USe User { get; set; }
        #endregion
    }
}
