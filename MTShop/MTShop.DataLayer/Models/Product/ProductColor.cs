using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MTShop.DataLayer.Models.Product
{
    public class ProductColor
    {

        [Key]
        public int Id { get; set; }

        [Display(Name = "آبی")]
        [MaxLength(100)]
        public string Blue { get; set; }

        [Display(Name = "قرمز")]
        [MaxLength(100)]
        public string Red { get; set; }

        [Display(Name = "مشکی")]
        [MaxLength(100)]
        public string Black { get; set; }

        [Display(Name = "سفید")]
        [MaxLength(100)]
        public string White { get; set; }

        [Display(Name = "صورتی")]
        [MaxLength(100)]
        public string Pink { get; set; }

        [Display(Name = "زرد")]
        [MaxLength(100)]
        public string Yellow { get; set; }

        [Display(Name = "طلایی")]
        [MaxLength(100)]
        public string Golden { get; set; }

        #region Relations
        public virtual Product Product { get; set; }

        #endregion



    }
}
