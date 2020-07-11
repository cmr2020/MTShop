using System;
using System.Collections.Generic;
using System.Text;

namespace MTShop.DataLayer.Models.Product
{
    public class ProductImage
    {

        public string ImageName { get; set; }


        #region Relations

        public Product Product { get; set; }

        #endregion

    }
}
