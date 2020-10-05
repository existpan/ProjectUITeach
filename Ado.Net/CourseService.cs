using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Ado.Net
{
    public class CourseService
    {
        public int AddCourse(Course course)
        {
            string sql = "insert into Course(CourseName,CourseContent,ClassHour,Credit,CategoryId,TeacherId) ";
            sql += $"values('{course.CourseName}', '{course.CourseContent}', {course.ClassHour}, {course.Credit}, {course.CategoryId}, {course.TeacherId})";
            return SQLHelper.ExecuteNonQuery(sql);
        }

        public int Update(Course course)
        {
            string sql = $"update Course set CourseContent='{course.CourseContent}' where CourseId={course.CourseId}";
            return SQLHelper.ExecuteNonQuery(sql);
        }

        public int Delete(Course course)
        {
            string sql = $"delete from Course where CourseId={course.CourseId}";
            return SQLHelper.ExecuteNonQuery(sql);
        }

        public List<Course> QueryCourseId(Course course)
        {
            string sql = $"select * from Course where CourseId<{course.CourseId}";
            SqlDataReader reader = SQLHelper.ExecuteReader(sql);
            List<Course> courses = new List<Course>();
            while (reader.Read())
            {
                courses.Add(
                    new Course
                    {
                        CourseId = Convert.ToInt32(reader["CourseId"]),
                        CourseName = reader["CourseName"].ToString(),
                        CourseContent=reader["CourseContent"].ToString(),
                        ClassHour=Convert.ToInt32(reader["ClassHour"]),
                        Credit=Convert.ToInt32(reader["Credit"]),
                        CategoryId=Convert.ToInt32(reader["CategoryId"]),
                        TeacherId=Convert.ToInt32(reader["TeacherId"])
                    });
            }
            reader.Close();
            return courses;
        }
    }
}
