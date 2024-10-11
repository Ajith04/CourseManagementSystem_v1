using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem_v1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Course course1 = new Course("C_001", "python for beginners", "3 months", 10);
            Console.WriteLine(course1);
            Console.ReadKey();
        }
    }
}
