using System;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Ado.Net
{

    /// <summary>
    /// 通用数据访问类
    /// </summary>
    public class SQLHelper
    {
        //从App.config文件中读取数据库连接字符串
        private static string conStr = ConfigurationManager.ConnectionStrings["connString"].ToString();
        //private static string conStr1 = "Server=DESKTOP-KV2R00L\\SQLEXPRESS;DataBase=CourseManageDB;Uid=sa;Pwd=123456";
        //只有字符串的赋值的才需要使用\\进行转义 从App.config文件中读取是不需要'\'进行转义的

        /// <summary>
        /// 通用非查询方法
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string sql)
        {
            SqlConnection connection = new SqlConnection(conStr);
            SqlCommand command = new SqlCommand(sql,connection);
            try
            {
                connection.Open();
                return command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //捕获异常进行操作
                throw new Exception("执行public static int ExecuteNonQuery(string sql)发生异常："+ex.Message) ;
            }
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// 通用查询方法
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static object ExecuteScalar(string sql)
        {
            SqlConnection connection = new SqlConnection(conStr);
            SqlCommand command = new SqlCommand(sql, connection);
            try
            {
                connection.Open();
                return command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                //捕获异常进行操作
                throw new Exception("执行public static object ExecuteScalar(string sql)时发生异常" + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// 通用查询结果集方法
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static SqlDataReader ExecuteReader(string sql)
        {
            SqlConnection connection = new SqlConnection(conStr);
            SqlCommand command = new SqlCommand(sql, connection);
            try
            {
                connection.Open();
                return command.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                //捕获异常进行操作
                throw new Exception("public static object ExecuteScalar(string sql)" + ex.Message);
            }
            //finally
            //{
            //    connection.Close();
            //}
        }
    }
}
