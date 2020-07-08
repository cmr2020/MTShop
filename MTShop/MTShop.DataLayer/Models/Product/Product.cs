using System;
using System.Collections.Generic;
using System.Text;

namespace MTShop.DataLayer.Models.Product
{
    public class Product
    {
        public Product()
        {
            Categories = new List<Category>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        #region Relations
        public List<Category> Categories { get; set; }
        #endregion

    }
}
