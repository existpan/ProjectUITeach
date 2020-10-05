using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Ado.Net
{
    class Program
    {
        static void Main(string[] args)
        {
            //AddCourse();
            //UpdateCourse();
            //DeleteCourse();
            QueryCourseId();
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

        static void ExecuteScalarByHelper()
        {
            string sql = "select count(*) as 课程总数 from Course";
            object result = SQLHelper.ExecuteScalar(sql);
            Console.WriteLine($"{result}");
        }
        
        /// <summary>
        /// 添加课程
        /// </summary>
        static void AddCourse()
        {
            Course course = new Course {CourseName= Console.ReadLine(),CourseContent= "测试数据",ClassHour=200,Credit=10,CategoryId=10,TeacherId=1003};
            int result = new CourseService().AddCourse(course);
            Console.WriteLine($"增加了{result}行");
        }

        static void UpdateCourse()
        {
            Course course = new Course { CourseContent = "不是测试数据，是真数据",CourseId=1005 };
            int result = new CourseService().Update(course);
            Console.WriteLine($"修改了{result}行");
        }

        static void DeleteCourse()
        {
            Course course = new Course { CourseId = 1006 };
            int result = new CourseService().Delete(course);
            Console.WriteLine($"删除了{result}行");
        }

        static void QueryCourseId()
        {
            Course course = new Course { CourseId = 1008 };
            List<Course> courses = new CourseService().QueryCourseId(course);
            foreach (var item in courses)
            {
                Console.WriteLine($"{item.CourseId}\t{item.CourseName}\t{item.CourseContent}\t{item.ClassHour}\t{item.Credit}");
            }

        }
    }
}
