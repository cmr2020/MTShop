﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MTShop.DataLayer.Models.Product
{
    public class ProductColor
    {

        [Key]
        public int Id { get; set; }

        public int ProductId { get; set; }

        [Display(Name ="نام رنگ")]
        public string ColorName { get; set; }

        #region Relations
        public virtual Product Product { get; set; }

        #endregion



    }
}
