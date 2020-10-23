using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MTShop.DataLayer.Models.Product
{
    public class Product
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public int CategoryId { get; set; }

        public int? SubGroup { get; set; }

        [Display(Name = "نام محصول")]
        [Required(ErrorMessage = "لطفا نام محصول را وارد کنید.")]
        [MaxLength(100, ErrorMessage = "نام محصول نمی تواند بیشتر از 100 کاراکتر باشد.")]
        public string ProductName { get; set; }

        [Display(Name = "توضیحات")]
        public string Description { get; set; }

        [Display(Name = "عکس اصلی")]
        [MaxLength(50)]
        public string ImageName { get; set; }

        [Display(Name = "حذف شده؟")]
        public bool IsDelete { get; set; }

        [Display(Name = "موجود است؟")]
        public bool IsExist { get; set; }

        [Display(Name = "قیمت")]
        [Required(ErrorMessage = "لطفا قیمت محصول را وارد کنید.")]
        public decimal Price { get; set; }

        [Display(Name = "در اسلایدر نمایش داده شود؟")]
        public bool InSlider { get; set; }

        [Display(Name = "عکس")]
        public string ImageSlider { get; set; }

        [Required(ErrorMessage = "لطفا گارانتی محصول را وارد بکنید.")]
        [Display(Name = "گارانتی")]
        public string Warranty { get; set; }

        [Required(ErrorMessage = "لطفا برچسب ها را وارد بکنید.")]
        [Display(Name = "برچسب ها")]
        public string Tags { get; set; }

        [Display(Name = "امتیاز خریداران")]
        public float Score { get; set; }  

        #region Relations

        [ForeignKey("Id")]
        public Category Category { get; set; }

        [ForeignKey("SubGroup")]
        public Category Group { get; set; }

        public ICollection<Category> Categories { get; set; }

        public virtual List<ProductComment> ProductComments { get; set; }

        public virtual List<ProductImage> ProductImages { get; set; }

        public virtual List<ProductColor> ProductColors { get; set; }

        public virtual List<ProductProperty> ProductProperties { get; set; }

        public virtual List<ProductRating> ProductRatings { get; set; }

        #endregion

    }
}
