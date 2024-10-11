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

            //Course course1 = new Course("C_001", "python for beginners", "3 months", 10);
            //Console.WriteLine(course1);
            //Console.ReadKey();

            bool repeat = false;
            while (!repeat)
            {
                Console.Clear();
                Console.WriteLine("Course Management System");
                Console.WriteLine();
                Console.WriteLine("1. Add a course");
                Console.WriteLine("2. View all courses");
                Console.WriteLine("3. Update a course");
                Console.WriteLine("4. Delete a course");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");
                string option = Console.ReadLine();

                switch (option) 
                {
                    case "1":
                        AddCourse();
                        break;
                    case "2": Console.Clear();
                        CourseManager coursemanager = new CourseManager();
                        coursemanager.ReadCourses();
                        Console.ReadKey();
                        break;
                    case "3":
                        EditCourse();
                        break;
                    case "4":
                        DeleteCourse();
                        break;
                    case "5": repeat = true;
                        break;
                    default: Console.WriteLine("Invalid input");
                    break;
                }

            }
        }

        public static void AddCourse()
        {
            Console.Clear();
            Console.WriteLine("Add course");
            Console.WriteLine();
            Console.Write("Enter course Id: ");
            string courseId = Console.ReadLine();
            Console.Write("Enter title: ");
            string title = Console.ReadLine();
            Console.Write("Enter duration: ");
            string duration = Console.ReadLine();
            Console.Write("Enter price: ");
            decimal price = int.Parse(Console.ReadLine());

            Course addCourse = new Course(courseId, title, duration, price);

            CourseManager courseManager = new CourseManager();
            courseManager.CreateCourse(addCourse);

            Console.ReadKey();
        }

        public static void EditCourse()
        {
            Console.Clear();
            Console.WriteLine("Update Course");
            Console.WriteLine();
            Console.Write("Enter course Id to update: ");
            string courseId = Console.ReadLine();
            Console.Write("Enter title: ");
            string title = Console.ReadLine();
            Console.Write("Enter duration: ");
            string duration = Console.ReadLine();
            Console.Write("Enter price: ");
            decimal price = decimal.Parse(Console.ReadLine());

            Course updateCourse = new Course(courseId, title, duration, price);

            CourseManager courseManager = new CourseManager();
            courseManager.UpdateCourse(updateCourse);

            Console.ReadKey();

        }


        public static void DeleteCourse()
        {
            Console.Clear();
            Console.WriteLine("Delete course");
            Console.WriteLine();
            Console.Write("Enter Course Id to delete: ");
            string courseId = Console.ReadLine();

            CourseManager coursemanager = new CourseManager();
            coursemanager.DeleteCourse(courseId);

            Console.ReadKey();

        }


    }
}
