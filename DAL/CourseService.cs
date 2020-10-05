using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace DAL
{
    public class CourseService
    {

        /// <summary>
        /// 新增课程
        /// </summary>
        /// <param name="course"></param>
        /// <returns></returns>
        public int AddCourse(Course course)
        {
            string sql = "insert into Course(CourseName,CourseContent,ClassHour,Credit,CategoryId,TeacherId) ";
            sql += $"values('{course.CourseName}', '{course.CourseContent}', {course.ClassHour}, {course.Credit}, {course.CategoryId}, {course.TeacherId})";
            return SQLHelper.ExcuteNonQuery(sql);
        }

        /// <summary>
        /// 根据ID删除课程
        /// </summary>
        /// <param name="course"></param>
        /// <returns></returns>
        public int DeleteCourse(Course course)
        {
            string sql = $"delete from Course where CourseId={course.CourseId}";
            return SQLHelper.ExcuteNonQuery(sql);
        }

        /// <summary>
        /// 根据ID修改课程名称和内容
        /// </summary>
        /// <param name="course"></param>
        /// <returns></returns>
        public int UpdateCourse(Course course)
        {
            string sql = $"update Course set CourseContent='{course.CourseContent}',CourseName='{course.CourseName}' where CourseId={course.CourseId}";
            return SQLHelper.ExcuteNonQuery(sql);
        }

        /// <summary>
        /// 根据ID查询课程返回结果集
        /// </summary>
        /// <param name="course"></param>
        /// <returns></returns>
        public List<Course> ExecuteReaderCourse(Course course)
        {
            string sql = $"select * from Course where CourseId < {course.CourseId}";
            SqlDataReader reader = SQLHelper.ExecuteReader(sql);
            List<Course> courses = new List<Course>();
            while (reader.Read())
            {
                courses.Add
                    (
                    new Course
                    {
                        CourseId = Convert.ToInt32(reader["CourseId"]),
                        ClassHour= Convert.ToInt32(reader["ClassHour"]),
                        Credit= Convert.ToInt32(reader["Credit"]),
                        CategoryId= Convert.ToInt32(reader["CategoryId"]),
                        TeacherId= Convert.ToInt32(reader["TeacherId"]),
                        CourseName =reader["CourseName"].ToString(),
                        CourseContent=reader["CourseContent"].ToString()
                    });
            }
            reader.Close();
            return courses;
        }
    }
}
