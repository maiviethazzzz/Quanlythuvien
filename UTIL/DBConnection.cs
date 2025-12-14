using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlythuvien.UTIL
{
    public static class DBConnection
    {
        public static string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\Documents\Quanlythuvien.mdf;Integrated Security=True;Connect Timeout=30";//chuỗi kết nỗi
        public static SqlConnection Getconnection()
        {
            try
            {
                SqlConnection connection = new SqlConnection(ConnectionString);
                return connection;
            }
            catch (Exception ex)
            {
                throw new Exception("lỗi kết nối đến csdl:\n" + ex.Message);
            }
        }

    }
}
