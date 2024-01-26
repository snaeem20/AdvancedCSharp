using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureProject
{
    /// <summary>
    /// 1. A Lambda Expression is an anonamous expression. 
    /// 2. It simplifies coding through in-line coding.
    /// </summary>
    internal static class LambdaExpressions
    {
        public delegate double DelCalculatePowers(int value, int power);

        public static void CalculatePowers()
        {
            Console.WriteLine("Input Number:");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("Input Power greater from 1 to 5:");
            int pow = int.Parse(Console.ReadLine());

            //using lambda expression for delegates.
            DelCalculatePowers calPower = (value, power) => Math.Pow(value, power);

            Console.WriteLine(calPower(num, pow));

        }

        public delegate bool DelCompareStrings(string s1, string s2);
        public static void IsSame(string s1, string s2)
        {
            //LambdaExpression with return statement
            DelCompareStrings delCompareStrings = (str1, str2) => { return str1 == str2; };
        
            Console.WriteLine(delCompareStrings(s1, s2));
        }

         public static void PrintOrderedList()
         {
             List<string> names = new List<string>() { "Kausar", "Zeeshan", "Ali"};
        
             IOrderedEnumerable<string> orderedList =  names.OrderBy(value => value);
        
             foreach (string s in names.OrderBy(s =>s ))
             {
                 Console.WriteLine(s);
             }
         }

        public static void SortByName()
        {
            List<Teacher> teachers = new List<Teacher>();
            teachers.Add(new Teacher("Kauser", 110));
            teachers.Add(new Teacher("Zeeshan", 12));
            teachers.Add(new Teacher("Ali", 31));
        
            IOrderedEnumerable<Teacher> orderedList = teachers.OrderBy(x => x.Id);
        
            foreach (var item in orderedList)
            {
                Console.WriteLine(item.Name);
            }
        }
        
        
        public class Teacher
        {
            public Teacher(string name, int id)
            {
                Name = name;
                Id = id;
            }
        
            public string Name { get; set; }
            public int Id { get; set; }
        
        }
    }
}
