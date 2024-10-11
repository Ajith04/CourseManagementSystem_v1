using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace CourseManagementSystem_v1
{
    internal class Course
    {
        public static int TotalCourses { get; set; }
        public string CourseId;
        public string Title;
        public string Duration;
        public decimal Price;

        public Course(string courseId, string title, string duration, decimal price)
        {
            CourseId = courseId;
            Title = title;
            Duration = duration;
            Price = price;
            TotalCourses++;
        }

        public override string ToString()
        {
            return $"Course Id: {CourseId}, Title: {Title}, Duration: {Duration}, Price: {Price}";
        }

        public virtual string DisplayCourseInfo()
        {
            return $"Course Id: {CourseId}\n Title: {Title}\n Duration: {Duration}, Price: {Price}";
        }
    }

   
}
