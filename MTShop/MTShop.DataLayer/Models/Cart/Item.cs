﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MTShop.DataLayer.Models.Product
{
   public class Item
    {
        public int Id { get; set; }

        public decimal Price { get; set; }

        public int QuantityInStock { get; set; }

        #region Relations
        public Product Product { get; set; }
        #endregion
    }
}
