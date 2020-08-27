using MTShop.Core.Services.Interfaces;
using MTShop.DataLayer.Context;
using MTShop.DataLayer.Models.Permissions;
using MTShop.DataLayer.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace MTShop.Core.Services
{
    public class PermissionService : IPermissionService
    {
        private MTShopContext _context;

        public PermissionService(MTShopContext context)
        {
            _context = context;
        }

        public List<Role> GetAllRoles()
        {
            return _context.Roles.ToList();
        }
        public int AddRole(Role role)
        {
            _context.Roles.Add(role);
            _context.SaveChanges();
            return role.RoleId;
        }

        public Role GetRoleById(int roleId)
        {
            return _context.Roles.Find(roleId);
        }
             
        public void AddRolesToUser(List<int> roleid, int userId)
        {
            foreach (int roleId in roleid)
            {
                _context.UserRoles.Add(new UserRole()
                {
                    RoleId = roleId,
                    UserId = userId
                });
            }
        }

        public void EditRolesUser(int userId, List<int> rolesid)
        {
            _context.UserRoles.Where(r => r.UserId == userId).ToList().ForEach(r => _context.UserRoles.Remove(r));
            AddRolesToUser(rolesid, userId);
        }

        public List<Permission> GetAllPermission()
        {

            return _context.Permissions.ToList();

        }

        public void AddPermissionToRole(int roleId, List<int> permission)
        {
            foreach (var p in permission)
            {
                _context.RolePermissions.Add(new RolePermission()
                {
                    PermissionId = p,
                    RoleId = roleId
                });
            }
        }

        public List<int> PermissionRole(int roleId)
        {
            return _context.RolePermissions
               .Where(r => r.RoleId == roleId)
               .Select(r => r.PermissionId).ToList();
        }

        public void UpdatePermissionRole(int roleId, List<int> permission)
        {
            _context.RolePermissions.Where(p => p.RoleId == roleId)
                .ToList().ForEach(p => _context.RolePermissions.Remove(p));

            AddPermissionToRole(roleId, permission);
        }

        public bool CheckPermission(int permissionId, string userName)
        {
            int userId = _context.Users.Single(u => u.UserName == userName).UserId;

            List<int> UserRoles = _context.UserRoles
                .Where(r => r.UserId == userId).Select(r => r.RoleId).ToList();

            if (!UserRoles.Any())
                return false;

            List<int> RolePermission = _context.RolePermissions
                .Where(p => p.PermissionId == permissionId)
                .Select(p => p.RoleId).ToList();

            return RolePermission.Any(p => UserRoles.Contains(p));
        }
       
    }
}
