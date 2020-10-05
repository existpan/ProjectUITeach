using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;

namespace DAL
{
    public class SQLHelper
    {
        private static string ConString = ConfigurationManager.ConnectionStrings["connString"].ToString();

        #region 通用非查询方法
        public static int ExcuteNonQuery(string sql)
        {
            SqlConnection connection = new SqlConnection(ConString);
            SqlCommand command = new SqlCommand(sql, connection);
            try
            {
                connection.Open();
                return command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("执行public int ExcuteNonQuery(string sql)方法时发生：" + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        #endregion

        #region 通用查询返回单个结果方法
        public static object ExecuteScalar(string sql)
        {
            SqlConnection connection = new SqlConnection(ConString);
            SqlCommand command = new SqlCommand(sql, connection);
            try
            {
                connection.Open();
                return command.ExecuteScalar();
            }
            catch (Exception ex)
            {

                throw new Exception("执行public object ExecuteScalar(string sql)方法时发生：" + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        #endregion

        #region 通用查询返回结果集方法
        public static SqlDataReader ExecuteReader(string sql)
        {
            SqlConnection connection = new SqlConnection(ConString);
            SqlCommand command = new SqlCommand(sql, connection);
            try
            {
                connection.Open();
                return command.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {

                throw new Exception("执行public SqlDataReader ExecuteReader(string sql)方法时发生：" + ex.Message);
            }
        }
        #endregion

    }
}
