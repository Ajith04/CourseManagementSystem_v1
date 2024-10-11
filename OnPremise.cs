using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem_v1
{
    internal class OnPremise : Course
    {

        public string Schedule {  get; set; }
        public string ClassroomCapacity { get; set; }
        public OnPremise(string courseId, string title, string duration, decimal price) : base(courseId, title, duration, price)
        {
        }
    }
}
