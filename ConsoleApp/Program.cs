using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {

        static void Main(string[] args)
        {
            Course course = new Course {CourseId=1008 };
            List<Course> courses = new CourseManager().GetCourses(course);
            foreach (var item in courses)
            {
                Console.WriteLine($"{item.CourseId}\t{item.CourseName}\t{item.CourseContent}");
            }
            Console.ReadKey();
        }
    }
}
