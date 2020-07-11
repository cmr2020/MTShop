using MTShop.DataLayer.Models.Product;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MTShop.DataLayer.Models.Product
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        #region Relations

        public ICollection<CategoryToProduct> CategoryToProducts { get; set; }

        #endregion
    }
}
