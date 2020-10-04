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
            //Console.WriteLine($"执行修改数据操作，受影响的返回行数是{Update()}");
            //Console.WriteLine($"执行修改数据操作，受影响的返回行数是{Delete()}");
            object result= ExecuteScalar();
            result.ToString();
            Console.WriteLine($"执行单个结果查询操作，返回的是{result}");
            ExecuteReader();
            Console.ReadKey();
        }

        /// <summary>
        /// 连接数据库基本操作
        /// </summary>
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
            sqlConnection.Close();
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
            sqlConnection.Close();
            return result;
        }

        /// <summary>
        /// 删除数据操作
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
            sqlConnection.Close();
            return result;
        }

        /// <summary>
        /// 通用单个结果查询方法
        /// </summary>
        /// <returns></returns>
        static object ExecuteScalar()
        {
            string constr = "Server=DESKTOP-KV2R00L\\SQLEXPRESS;DataBase=CourseManageDB;Uid=sa;Pwd=123456";
            SqlConnection sqlConnection = new SqlConnection(constr);
            string Insertsql = "select COUNT(*) as 课程总数 from Course";
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
            object objects = sqlCommand.ExecuteScalar();
            sqlConnection.Close();
            return objects;
        }
        
        /// <summary>
        /// 通用结果集查询方法
        /// </summary>
        /// <returns></returns>
        static void ExecuteReader()
        {
            string constr = "Server=DESKTOP-KV2R00L\\SQLEXPRESS;DataBase=CourseManageDB;Uid=sa;Pwd=123456";
            SqlConnection sqlConnection = new SqlConnection(constr);
            string Insertsql = "select TeacherName,PhoneNumber,NowAddress from Teacher";
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
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            while (dataReader.Read())
            {
                Console.WriteLine($"{dataReader[0]}\t{dataReader[1]}\t{dataReader[2]}");
            }
            sqlConnection.Close();
            if (sqlConnection.State==ConnectionState.Closed)
            {
                Console.WriteLine("数据库连接已关闭……");
            }
        }
    }
}
