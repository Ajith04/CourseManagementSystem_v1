using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem_v1
{
    internal class CourseManager
    {
        List<Course> courses = new List<Course>();

        public void CreateCourse(Course course)
        {
            courses.Add(course);
            Console.WriteLine("Course successfully added.");
        }

        public void ReadCourses()
        {
            if (courses.Count == 0)
            {
                Console.WriteLine("There are no any courses.");
            }
            else
            {
                Console.WriteLine("All courses");
                foreach (var course in courses)
                {
                    Console.WriteLine(course);
                }
            }
        }

        public void UpdateCourse(Course course)
        {
            var updateCourse = courses.SingleOrDefault(r => r.CourseId == course.CourseId);

            if (updateCourse != null)
            {
                Console.WriteLine("There is no such record.");
            }
            else
            {
                courses.Remove(updateCourse);
                courses.Add(updateCourse);
                Console.WriteLine("Course successfully updated.");
            }
        }

        public void DeleteCourse(string courseId)
        {
            var deleteCourse = courses.SingleOrDefault(r => r.CourseId == courseId);

            if (deleteCourse == null)
            {
                Console.WriteLine("There is no such record.");
            }
            else
            {
                courses.Remove(deleteCourse);
                Console.WriteLine("Course successfully deleted.");
            }
        }
    }
}
