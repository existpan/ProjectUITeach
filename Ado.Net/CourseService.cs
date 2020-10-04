using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
