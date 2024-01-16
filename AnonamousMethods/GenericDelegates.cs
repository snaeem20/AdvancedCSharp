using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericInterface
{
    delegate T DelGetValue<T>(T value);

    internal class GenericDelegates
    {
        public static int GetIfEven(int value)
        {
            if (value % 2 == 0)
                return value;
            else
                return 0;
        }

        public static float GetIfPositive(float value)
        {
            if (value > 0)
                return value;
            else
                return 0;
        }
    }
}
