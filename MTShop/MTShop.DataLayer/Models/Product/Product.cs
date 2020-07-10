using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MTShop.DataLayer.Models.Product
{
    public class Product
    {
       
        [Key]
        public int Id { get; set; }

        [Display(Name = "نام محصول")]
        [Required(ErrorMessage = "لطفا نام محصول را وارد کنید.")]
        [MaxLength(100, ErrorMessage = "نام محصول نمی تواند بیشتر از 100 کاراکتر باشد.")]
        public string ProductName { get; set; }

        [Display(Name = "توضیحات")]
        public string Description { get; set; }

        [MaxLength(50)]
        public string ImageName { get; set; }

        [Display(Name = "حذف شده؟")]
        public bool IsDelete { get; set; }

        [Display(Name = "موجود است؟")]
        public bool IsExist { get; set; }

        [Display(Name = "قیمت")]
        [Required(ErrorMessage = "لطفا قیمت محصول را وارد کنید.")]
        public decimal Price { get; set; }

        #region Relations

        public ICollection<CategoryToProduct> CategoryToProducts { get; set; }

        public virtual List<ProductComment> ProductComments{ get; set; }

        #endregion

    }
}
