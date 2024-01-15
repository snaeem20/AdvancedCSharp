using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session12
{
    internal class MethodOverloading<M,N>
    {
        M val1;
        N val2;

        public void SetValue(M value)
        { 
            val1 = value;
        }

        public void SetValue(N value)
        {
            val2 = value;
        }

        public void DisplayValues()
        {
            Console.WriteLine("Value 1: " + val1);
            Console.WriteLine("Value 2: " + val2);
        }
    }
}
