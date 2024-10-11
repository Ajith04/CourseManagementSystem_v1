using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem_v1
{
    internal class Course
    {
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
        }

        public override string ToString()
        {
            return $"Course Id: {CourseId}, Title: {Title}, Duration: {Duration}, Price: {Price}";
        }

        public virtual void DisplayCourseInfo()
        {
            Console.WriteLine($"Course Id: {CourseId}\n Title: {Title}\n Duration: {Duration}, Price: {Price}");
        }
    }

   
}
