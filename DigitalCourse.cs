using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem_v1
{
    internal class DigitalCourse : Course
    {

        public string CourseLink { get; set; }
        public string FileSize { get; set; }
        public DigitalCourse(string courseId, string title, string duration, decimal price) : base(courseId, title, duration, price)
        {
            
        }

        public override void DisplayCourseInfo()
        {
            Console.WriteLine($"Course Id: {CourseId}\n Title: {Title}\n Duration: {Duration}\n Price: {Price}\n Course Link: {CourseLink}\n File Size: {FileSize}");
        }
    }

    
}
