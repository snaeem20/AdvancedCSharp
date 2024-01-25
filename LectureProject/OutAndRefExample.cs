using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureProject
{
    internal static class OutAndRefExample
    {
        /// <summary>
        /// 1. out parameter has to be assigned a value before exiting from the method
        /// 2. we can have more than 1 out parameters in a method as aurguments
        /// </summary>
        /// <param name="num"></param>
        /// <param name="doubledNumber"></param>
        /// <param name="halvedNumber"></param>
        /// <returns></returns>
        public static bool OperateIfPositive(int num, out int doubledNumber, out int halvedNumber)
        {
            doubledNumber = 0;
            halvedNumber = 0;
            bool result = false;

            if (num > 0)
            {
                doubledNumber = num + num;
                halvedNumber = num / 2;
                result = true;
            }
            
            return result;
        }


        public static bool DoubleTheNumber(ref int num)
        {
            
            bool result = false;

            if (num > 0)
            {
                num += num;
                result = true;
            }

            return result;
        }

    }
}
