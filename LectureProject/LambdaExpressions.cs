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
        public delegate int DelCalculatePowers(int value, int power);

        public static void CalculatePowers()
        {
            Console.WriteLine("Input Number:");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("Input Powergreater than 1 and less than 6:");
            int pow = int.Parse(Console.ReadLine());

            //using lambda expression for delegates.
            DelCalculatePowers calPower = (value, power) => value ^ power;

            Console.WriteLine(calPower(num, pow));

        }
    }
}
