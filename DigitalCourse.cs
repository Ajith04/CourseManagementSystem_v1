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
    }
}
