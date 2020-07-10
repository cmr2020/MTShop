using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MTShop.DataLayer.Models.Product
{
   public class Item
    {
        [Key]
        public int Id { get; set; }

        public decimal Price { get; set; }

        public int QuantityInStock { get; set; }

        #region Relations

        

        #endregion
    }
}
