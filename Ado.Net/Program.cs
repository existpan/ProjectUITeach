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
            //ConnectDB();
            //Console.WriteLine($"执行插入数据操作，受影响的返回行数是{Insert()}");
            Console.WriteLine($"执行修改数据操作，受影响的返回行数是{Update()}");
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
        /// <summary>
        /// 插入数据操作
        /// </summary>
        /// <returns></returns>
        static int Insert()
        {
            string constr = "Server=DESKTOP-KV2R00L\\SQLEXPRESS;DataBase=CourseManageDB;Uid=sa;Pwd=123456";
            SqlConnection sqlConnection = new SqlConnection(constr);
            string Insertsql = "insert into Course(CourseName,CourseContent,ClassHour,Credit,CategoryId,TeacherId) ";
            Insertsql += "values('全栈预科', '第01章【全栈预科】快速入门语法、OOP精华、SQL基础ADO.NET与分层项目', 200, 10, 10, 1003)";
            SqlCommand sqlCommand = new SqlCommand(Insertsql,sqlConnection);
            sqlConnection.Open();
            if (sqlConnection.State==ConnectionState.Open)
            {
                Console.WriteLine("数据库连接成功！");
            }
            else
            {
                Console.WriteLine("数据库连接失败！");
            }
            int result= sqlCommand.ExecuteNonQuery();
            return result;
        }
        
        /// <summary>
        /// 修改数据操作
        /// </summary>
        /// <returns></returns>
        static int Update()
        {
            string constr = "Server=DESKTOP-KV2R00L\\SQLEXPRESS;DataBase=CourseManageDB;Uid=sa;Pwd=123456";
            SqlConnection sqlConnection = new SqlConnection(constr);
            string Insertsql = "update Teacher set LoginPwd='123456' where TeacherId=1002";
            SqlCommand sqlCommand = new SqlCommand(Insertsql, sqlConnection);
            sqlConnection.Open();
            if (sqlConnection.State == ConnectionState.Open)
            {
                Console.WriteLine("数据库连接成功！");
            }
            else
            {
                Console.WriteLine("数据库连接失败！");
            }
            int result = sqlCommand.ExecuteNonQuery();
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        static int Delete()
        {
            string constr = "Server=DESKTOP-KV2R00L\\SQLEXPRESS;DataBase=CourseManageDB;Uid=sa;Pwd=123456";
            SqlConnection sqlConnection = new SqlConnection(constr);
            string Insertsql = "delete Course where CourseId=1004";
            SqlCommand sqlCommand = new SqlCommand(Insertsql, sqlConnection);
            sqlConnection.Open();
            if (sqlConnection.State == ConnectionState.Open)
            {
                Console.WriteLine("数据库连接成功！");
            }
            else
            {
                Console.WriteLine("数据库连接失败！");
            }
            int result = sqlCommand.ExecuteNonQuery();
            return result;
        }
    }
}
