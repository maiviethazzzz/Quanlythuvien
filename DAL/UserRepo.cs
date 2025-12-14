using Microsoft.Data.SqlClient;
using Quanlythuvien.MODEL;
using Quanlythuvien.UTIL;

namespace Quanlythuvien.DAL
{
    public class UserRepo
    {
        public User GetUserByUsername(string username)
        {
            User user = null;
            string Sql = @"SELECT u.UserID , u.Username , u.PasswordHash , u.Fullname , u.RoleID , r.Rolename FROM Users u INNER JOIN Roles r ON u.RoleID = r.RoleID WHERE u.Username = @Username";
            using (SqlConnection connection = DBConnection.Getconnection())
            {
                using (SqlCommand command = new SqlCommand(Sql, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                user = new User
                                {
                                    UserID = reader.GetInt32(0),
                                    Username = reader.GetString(1),
                                    PasswordHash = reader.GetString(2),
                                    Fullname = reader.GetString(3),
                                    RoleID = reader.GetInt32(4),
                                    Rolename = reader.GetString(5),
                                };
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Lỗi truy vấn người dùng:\n" + ex.Message);
                    }
                }

                return user;
            }
        }
    }
}

                       
                           
