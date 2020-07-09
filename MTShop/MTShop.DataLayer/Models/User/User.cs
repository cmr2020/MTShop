using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MTShop.DataLayer.Models.User
{

    public class User
    {
        public User()
        {

        }

        [Key]
        public int UserId { get; set; }

        [Display(Name = "نام کاربری")]
        [Required(ErrorMessage = "لطفا نام کاربری را وارد کنید.")]
        [MaxLength(100, ErrorMessage = "نام کاربری نمی تواند بیشتر از 100 کاراکتر باشد.")]
        public string UserName { get; set; }

        [Display(Name = "ایمیل")]
        [Required(ErrorMessage = "لطفا ایمیل خود را وارد کنید.")]
        [MaxLength(100, ErrorMessage = "ایمیل نمی تواند بیشتر از 100 کاراکتر باشد.")]
        public string Email { get; set; }

        [Display(Name = "رمز عبور")]
        [Required(ErrorMessage = "لطفا رمز عبور را وارد کنید.")]
        [MaxLength(50, ErrorMessage = "رمز عبور نمی تواند بیشتر از 50 کاراکتر باشد.")]
        public string Password { get; set; }

        [Display(Name = "تاریخ ثبت نام")]
        public DateTime RegisterDate { get; set; }

        [Display(Name = "وضعیت")]
        public bool IsActive { get; set; }

        [Display(Name = "کد فعال سازی ")]
        [MaxLength(50)]
        public string ActivationCode { get; set; }

        [Display(Name = "حذف شده؟")]
        public bool IsDelete { get; set; }


        #region Relations

        public virtual List<UserRole> UserRoles { get; set; }

        #endregion

    }
}
