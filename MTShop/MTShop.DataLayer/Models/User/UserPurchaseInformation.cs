using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MTShop.DataLayer.Models.User
{
    public class UserPurchaseInformation
    {
        public UserPurchaseInformation()
        {

        }

        [Display(Name = "شماره موبایل (اختیاری)")]
        [MaxLength(20, ErrorMessage = "شماره موبایل نمی تواند بیشتر از 20 کاراکتر باشد.")]
        public string Mobile { get; set; }

        [Display(Name = "کد پستی")]
        [Required(ErrorMessage = "لطفا کد پستی را وارد کنید.")]
        [MaxLength(30, ErrorMessage = "کد پستی نمی تواند بیشتر از 30 کاراکتر باشد.")]
        public string PostalCode { get; set; }

        [Display(Name = "آدرس کامل")]
        [Required(ErrorMessage = "لطفا آدرس محل تحویل را وارد کنید.")]
        [MaxLength(200, ErrorMessage = "آدرس نمی تواند بیشتر از 200 کاراکتر باشد.")]
        public string Address { get; set; }


        #region Relations

        public virtual User User { get; set; }

        #endregion

    }
}
