using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace MTShop.DataLayer.Models.Product.Filter
{
    public class FiltersGroup
    {

        [Key]
        public int Id { get; set; }

        public int CategoryId { get; set; }

        public int ProductId { get; set; }

        public int SelectedItemId { get; set; }

        [Display(Name = "عنوان گروه فیلتر")]
        [MaxLength(100, ErrorMessage = "عنوان گروه نمی تواند بیشتر از 100 کاراکتر باشد.")]
        [Required(ErrorMessage = "لطفا عنوان گروه را وارد کنید.")]
        public string Title { get; set; }


        #region Relations

        public List<FilterItem> FilterItems { get; set; }

        public Category Category { get; set; }

        #endregion

    }
}
