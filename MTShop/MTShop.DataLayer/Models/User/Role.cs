using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MTShop.DataLayer.Models.User
{
    public class Role
    {
        public Role()
        {
            
        }
        
        [Key]
        public int RoleId { get; set; }

        [Display(Name = "عنوان نقش")]
        [Required(ErrorMessage = "لطفا عنوان نقش را وارد کنید.")]
        [MaxLength(150,ErrorMessage = "عنوان نقش نمی تواند بیشتر از 150 کاراکتر باشد.")]
        public string RoleTitle { get; set; }



        #region Relations

        public virtual List<UserRole> UserRoles { get; set; }

        #endregion
    }
}
