using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MTShop.DataLayer.Models.User
{
    public class UserRole
    {
        public UserRole()
        {
            
        }

        [Key]
        public int UserRole_Id { get; set; }

        public int RoleId { get; set; }

        public int UserId { get; set; }


        #region Relations

        public User User { get; set; }
        public Role Role { get; set; }

        #endregion

    }
}
