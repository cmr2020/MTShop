using MTShop.Core.Services.Interfaces;
using MTShop.DataLayer.Context;
using MTShop.DataLayer.Models.Permissions;
using MTShop.DataLayer.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MTShop.DataLayer.Models.Permissions;

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
          return  _context.Roles.ToList();
        }
        public int AddRole(Role role)
        {
            _context.Roles.Add(role);
            _context.SaveChanges();
            return role.RoleId;
        }

        public Role GetRoleById(int roleId)
        {
          return  _context.Roles.Find(roleId);
        }
        public void UpdateRole(Role role)
        {
            _context.Roles.Update(role);
            _context.SaveChanges();
        }

        public void DeleteRole(Role role)
        {
            role.IsDelete = true;
            UpdateRole(role);
        }

        public void AddRolesToUser(List<int> roleid, int userId)
        {
           foreach(int roleId in roleid)
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
            return _context.Permission.ToList();
            throw new NotImplementedException();
        }


        public void AddPermissionToRole(int roleId, List<int> permission)
        {
            throw new NotImplementedException();
        }



        public List<int> PermissionRole(int roleId)
        {
            throw new NotImplementedException();
        }

        public bool CheckPermission(int permissionId, string userName)
        {
            throw new NotImplementedException();
        }


        public void UpdatePermissionRole(int roleId, List<int> Permission)
        {
            throw new NotImplementedException();
        }


    }
}
