using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MTShop.DataLayer.Models.Product.Filter
{
    public class FilterItem
    {

        [Key]
        public int Id { get; set; }

        public int FilterGroupId { get; set; }

        [Display(Name = "نام ایتم فیلتر")]
        [Required(ErrorMessage = "لطفا عنوان آیتم رو وارد کنید.")]
        [MaxLength(100, ErrorMessage = "عنوان آیتم نمی تواند بیشتر از 100 کاراکتر باشد.")]
        public string Name { get; set; }


        public FiltersGroup FiltersGroup { get; set; }

    }
}
