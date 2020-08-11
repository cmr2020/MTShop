using MTShop.DataLayer.Models.Product;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MTShop.DataLayer.Models.Product
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = ("عنوان گروه"))]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(150, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string Name { get; set; }

        [Display(Name = "حذف شده؟")]
        public bool IsDelete { get; set; }

        [Display(Name = "گروه اصلی")]
        public int? ParentId { get; set; }


        #region Relations

        [InverseProperty("Category")]
        public List<Product> Products { get; set; }

        [InverseProperty("Group")]
        public List<Product> SubGroup { get; set; }

        [ForeignKey("ParentId")]
        public List<Category> Categories { get; set; }

        public List<ProductProperty> ProductProperties { get; set; }

        #endregion
    }
}
