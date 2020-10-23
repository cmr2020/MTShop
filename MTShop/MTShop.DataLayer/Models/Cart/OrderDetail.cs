using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MTShop.DataLayer.Models.Cart
{
   public class OrderDetail
    {

        [Key]
        public int OrderId { get; set; }

        public int UserId { get; set; }

        public DateTime CreateDate { get; set; }

        public bool IsFinaly { get; set; }


        #region Permission

        [ForeignKey("UserId")]
        public User.User Users { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }

        #endregion
    }
}
