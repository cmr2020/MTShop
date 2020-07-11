using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MTShop.DataLayer.Models.Product
{
    public class CategoryToProduct
    {


        [Key]
        public int CP_Id { get; set; }

        public int CategoryId { get; set; }
        public int ProductId { get; set; }

        #region Relations
        public Category Category { get; set; }
        public Product Product { get; set; }
        #endregion
    }
}
