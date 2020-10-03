using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Ado.Net
{
    class Program
    {
        static void Main(string[] args)
        {
            ConnectDB();
            Console.ReadKey();
        }
        static void ConnectDB()
        {
            string constr = "Server=DESKTOP-KV2R00L\\SQLEXPRESS;DataBase=CourseManageDB;Uid=sa;Pwd=123456";
            SqlConnection sqlConnection = new SqlConnection(constr);
            sqlConnection.Open();
            if (sqlConnection.State==ConnectionState.Open)
            {
                Console.WriteLine("连接成功！");
            }
            else
            {
                Console.WriteLine("连接失败！");
            }
            sqlConnection.Close();
        }
    }
}
