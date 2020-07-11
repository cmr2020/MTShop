using System;
using System.Collections.Generic;
using System.Text;
using MTShop.Core.DTOs;
using MTShop.DataLayer.Models.User;

namespace MTShop.Core.Services.Interfaces
{
    public interface IUserService
    {
        bool AddUser(User user);

        User GetUserById(int userId);
        User GetUserByUserName(string userName);
        User GetUserByEmail(string email);
        User GetUserByActiveCode(string activationCode);
        int GetUserIdByUserName(string userName);

        bool DeleteUserByUserName(string userName);
        bool DeleteUserById(int userId);

        bool UpdateUser(User user);

        bool IsExistEmail(string email);
        bool IsExistUserName(string userName);

        bool ActiveAccount(string activationCode);
        User LoginUser(LoginViewModel login);

    }
}
