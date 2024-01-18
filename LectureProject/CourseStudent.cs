using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session12
{
    public class CourseStudent
    {
        string Name;
        int Id;
        public static string desc;

        public CourseStudent(string name, int id)
        {
            //It can be innitialized in non-static constructor.
            s = "A readonly value";

            Name = name;
            Id = id;
            desc = "Testing";
        }

        static CourseStudent()
        {
            //It can be innitialized in non-static constructor.
            //s = "A readonly value";
        }

        public CourseStudent()
        {
            Name = "Samia";
        }
            //it can only be declared as class member
            readonly string s;
        public void PrintStaticvalue()
        {
            const int a = 4;            
            //readonly string s; //compile-time error as readonly cannot be assigned in a method

            Console.WriteLine(Name + desc);
        }
    }
}
