﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
        [ForeignKey("UserId")]
        public User.User Users { get; set; }
        #endregion
    }
}
