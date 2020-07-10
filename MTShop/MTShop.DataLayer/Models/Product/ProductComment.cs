using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MTShop.DataLayer.Models.Product
{
    public class ProductComment
    {
        public ProductComment()
        {

        }
        [Key]
        public int CommentId { get; set; }

        public int UserId { get; set; }

        public int ProductId { get; set; }

        [Display(Name = "متن پیام")]
        [Required(ErrorMessage = "لطفا متن پیام را وارد کنید.")]
        [MaxLength(1500, ErrorMessage = "پیام نمی تواند بیشتر از 1500 کاراکتر باشد.")]
        public string Comment { get; set; }

        [Display(Name = "تاریخ ایجاد")]
        public DateTime CreateDate { get; set; }

        public bool IsDelete { get; set; }

        public int? ParentId { get; set; }

        #region Relations

        public Product Product { get; set; }

        public User.User User { get; set; }

        [ForeignKey("ParentId")]
        public List<ProductComment> ProductComments { get; set; }

        #endregion
    }
}
