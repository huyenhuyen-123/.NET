using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhapHang.Utils
{
    internal class DatabaseHelper
    {

    public static SqlConnection GetConnection()
        {
            return new SqlConnection("Server=LAPTOP-QGBKFEJQ\\SQLEXPRESS;Database=KHOHANG;User Name=sa;Password=123456");

        }
    }
}

