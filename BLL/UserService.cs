using Quanlythuvien.DAL;
using Quanlythuvien.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlythuvien.BLL
{
    public class UserService
    {
        private UserRepo _userRepo;
        public UserService()
        {
            _userRepo = new UserRepo();
        }
        public User AuthenticatedUser(string username, string password)
        {
            User user = _userRepo.GetUserByUsername(username);
            if (user == null)
            {
                return null; //không tồn tại người dùng
            }
            if (password == user.PasswordHash)
            {
                return user;
            }
            else
            {
                return null;
            }
        }
    }
}
