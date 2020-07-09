using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MTShop.Core.Generator;
using MTShop.Core.Services.Interfaces;
using MTShop.DataLayer.Context;
using MTShop.DataLayer.Models.User;

namespace MTShop.Core.Services
{
    public class UserService : IUserService
    {
        private MTShopContext _context;

        public UserService(MTShopContext context)
        {
            _context = context;
        }

        public bool ActiveAccount(string activationCode)
        {
            var user = GetUserByActiveCode(activationCode);
            if (user == null || user.IsActive)
                return false;
            user.IsActive = true;
            user.ActivationCode = NameGenerator.GenerateUniqCode();
            UpdateUser(user);
            return true;
        }

        public bool AddUser(User user)
        {
            _context.Users.Add(user);
            try
            {
                _context.Users.Add(user);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteUserById(int userId)
        {
            try
            {
                var user = GetUserById(userId);
                user.IsDelete = true;
                _context.Users.Update(user);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteUserByUserName(string userName)
        {
            try
            {
                var user = GetUserById(GetUserIdByUserName(userName));
                user.IsDelete = true;
                _context.Users.Update(user);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public User GetUserByActiveCode(string activationCode)
        {
            return _context.Users.SingleOrDefault(u => u.ActivationCode == activationCode);
        }

        public User GetUserByEmail(string email)
        {
            return _context.Users.SingleOrDefault(u => u.Email == email);
        }

        public User GetUserById(int userId)
        {
            return _context.Users.Find(userId);
        }

        public User GetUserByUserName(string userName)
        {
            int userId = GetUserIdByUserName(userName);
            return _context.Users.Find(userId);
        }

        public int GetUserIdByUserName(string userName)
        {
            return _context.Users.Single(u => u.UserName == userName).UserId;
        }

        public bool IsExistEmail(string email)
        {
            return _context.Users.Any(u => u.Email == email);
        }

        public bool IsExistUserName(string userName)
        {
            return _context.Users.Any(u => u.UserName == userName);
        }

        public bool UpdateUser(User user)
        {
            try
            {
                _context.Users.Update(user);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
