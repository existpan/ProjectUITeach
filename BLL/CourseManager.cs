using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Models;

namespace BLL
{
    public class CourseManager
    {
        CourseService courseService = new CourseService();

        /// <summary>
        /// 增加课程
        /// </summary>
        /// <param name="course"></param>
        /// <returns></returns>
        public int AddCourse(Course course)
        {
            return courseService.AddCourse(course);
        }

        /// <summary>
        /// 删除课程
        /// </summary>
        /// <param name="course"></param>
        /// <returns></returns>
        public int DeleteCourse(Course course)
        {
            return courseService.DeleteCourse(course);
        }

        /// <summary>
        /// 修改课程
        /// </summary>
        /// <param name="course"></param>
        /// <returns></returns>
        public int UpdateCourse(Course course)
        {
            return courseService.UpdateCourse(course);
        }

        /// <summary>
        /// 查询课程
        /// </summary>
        /// <param name="course"></param>
        /// <returns></returns>
        public List<Course> GetCourses(Course course)
        {
            return courseService.ExecuteReaderCourse(course);
        }
    }
}
