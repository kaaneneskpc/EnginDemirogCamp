using System;

namespace ClassStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            Course c1 = new Course();
            c1.courseName = "C#";
            c1.instructor = "Engin Demirog";
            c1.rateOfWatch = 68;
            
            Course c2 = new Course();
            c2.courseName = "Kotlin";
            c2.instructor = "Ada";
            c2.rateOfWatch = 38;
            
            Course c3 = new Course();
            c3.courseName = "Python";
            c3.instructor = "Melih";
            c3.rateOfWatch = 74;

            Course[] courses = {c1,c2,c3};

            foreach(var course in courses)
            {
                Console.WriteLine(course.courseName +" : "+course.instructor+" = "+course.rateOfWatch);
            }
        }
    }

    class Course
    {
        public string courseName { get; set; }
        public string instructor { get; set; }
        public int rateOfWatch { get; set; }
    }
}
