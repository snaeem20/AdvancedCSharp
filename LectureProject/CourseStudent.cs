using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticVsReadOnlyVsConst
{
    /// <summary>
    /// This class explains the concepts of STATIC, READONLY members and CONST variables
    /// </summary>
    public class CourseStudent
    {
        string Name;
        
        //A CONST member
        private const int constInteger = 5;
        
        //A STATIC member
        private static string staticDescription;
        
        //A READONLY variable can only be declared as class member
        private readonly string readonlyString;

        /// <summary>
        /// A Static constructor
        /// </summary>
        /// <param name="name"></param>
        public CourseStudent(string name)
        {
            //READONLY can be innitialized in non-static constructor.
            readonlyString = "I am a readonly member and I am initialized in a non-static constructor.";

            Name = name;
        }

        /// <summary>
        /// 1. A static constructor is called only once when a class is first used and initializes static members. 
        /// 2. It can’t have an access modifier. 
        /// 3. Private constructors are used to control object instantiation and can only be called within the class.
        /// </summary>
        static CourseStudent()
        {
            //READONLY member cannot be innitialized in a static constructor.
            //readonlyString = "A readonly value";

            //STATIC member can be innitialized in static constructor.
            staticDescription = "I am a static member initialized in a static constructor, which is called automatically and only once";

            //A NON-STATIC member cannot be initialized in a STATIC constructor
            //Name = "Ali";
        }

        public void PrintStaticvalue()
        {
            //A CONST initialized in a method
            const string constStrig = "I am a constanct initialized in a method.";

            //A const cannot be modified once it is initialized
            //constInteger = 10;

            //readonly string s; //compile-time error as readonly cannot be assigned in a method

            Console.WriteLine("Static Member - " + staticDescription);
            Console.WriteLine("Readonly Member - " + readonlyString);
            Console.WriteLine("Const Member - " + constInteger);
            Console.WriteLine("Const - " + constStrig);
        }
    }
}
