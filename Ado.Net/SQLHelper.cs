using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Ado.Net
{
    /// <summary>
    /// 通用数据访问类
    /// </summary>
    public class SQLHelper
    {
        //从App.config文件中读取数据库连接字符串
        private static string constr = ConfigurationManager.ConnectionStrings["constr"].ToString();
        
        /// <summary>
        /// 通用非查询方法
        /// </summary>
        /// <returns></returns>
        public static int ExecuteNonQuery(string sql)
        {
            SqlConnection connection = new SqlConnection(constr);
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
    }
}
