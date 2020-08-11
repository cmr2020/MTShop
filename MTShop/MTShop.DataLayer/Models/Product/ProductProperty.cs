using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MTShop.DataLayer.Models.Product
{
    public class ProductProperty
    {
        [Key]
        public int Id { get; set; }

        public int ProductId { get; set; }

        public int CategoryId { get; set; }

        [Display(Name = "نام ویژگی")]
        [MaxLength(50, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string PropertyName { get; set; }

        [Display(Name = "مقدار ویژگی")]
        [MaxLength(100, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string PropertyValue { get; set; }

        #region Relations

        public virtual Product Product { get; set; }

        public virtual Category Category { get; set; }

        #endregion

    }
}
