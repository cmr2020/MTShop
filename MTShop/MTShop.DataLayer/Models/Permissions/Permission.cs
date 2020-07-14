﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MTShop.DataLayer.Models.Permissions
{
    public class Permission
    {

        [Key]
        public int PermissionId { get; set; }

        [Display(Name = "")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string PermissionTitle { get; set; }

        public int? ParentID { get; set; }

        #region Relations

        [ForeignKey("ParentID")]
        public List<Permission> Permissions { get; set; }

        public List<RolePermission> RolePermissions { get; set; }

        #endregion

    }
}