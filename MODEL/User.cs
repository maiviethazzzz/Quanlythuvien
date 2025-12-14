     using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlythuvien.MODEL
{
    public class User
    {
        public int UserID { get; set; }
        public string Username { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public string Fullname { get; set; } = string.Empty;
        public int RoleID { get; set; }
        public string Rolename { get; set; } = string.Empty;//ktra và hiển thj thứ tự phân quyền
    }
}
