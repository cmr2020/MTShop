using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MTShop.DataLayer.Models.Product
{
   public class ProductImage
    {
        [Key]
        public int  Id { get; set; }

        public int ProductId { get; set; }

        [MaxLength(50)]
        public string Images { get; set; }

        #region Relations

        public Product Product { get; set; }

        #endregion
    }
}
