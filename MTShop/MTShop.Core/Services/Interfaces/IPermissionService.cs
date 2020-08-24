using MTShop.DataLayer.Models.Permissions;
using MTShop.DataLayer.Models.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTShop.Core.Services.Interfaces
{
   public interface IPermissionService
    {

        List<Role> GetAllRoles();
        int AddRole(Role role);
        Role GetRoleById(int roleId);
        void UpdateRole(Role role);
        void DeleteRole(Role role);
        void AddRolesToUser(List<int> roleIds, int userId);
        void EditRolesUser(int userId, List<int> rolesid);

        List<Permission> GetAllPermission();
        void AddPermissionToRole(int roleId,List<int> permission);
        List<int> PermissionRole(int roleId);
        void UpdatePermissionRole(int roleId, List<int> Permission);

        bool CheckPermission(int permissionId, string userName);

    }
}
