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

        public static void iterateList()
        {
            
        }
    }
}
