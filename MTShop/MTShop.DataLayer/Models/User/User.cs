﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MTShop.DataLayer.Models.User
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [MaxLength(300)]
        public string Email { get; set; }

        [Required]
        [MaxLength(50)]
        public string Password { get; set; }

        [Required]
        public DateTime RegisterDate { get; set; }


        #region Relations

        public List<UserRole> UserRoles { get; set; }

        #endregion

    }
}
