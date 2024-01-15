using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericInterface
{
    internal interface IMath<T>
    {
        T Add(T value1, T value2); 
        T Subtract(T value1, T value2);
    }

    class Scores : IMath<int>
    {
        /// <summary>
        /// Adds the given values
        /// </summary>
        /// <param name="value1"></param>
        /// <param name="value2"></param>
        /// <returns></returns>
        public int Add(int value1, int value2)
        {
            return value1 + value2;
        }

        /// <summary>
        /// Finds the difference between the given value
        /// </summary>
        /// <param name="value1"></param>
        /// <param name="value2"></param>
        /// <returns></returns>
        public int Subtract(int value1, int value2)
        {
            int result = 0;

            if (value1 > value2)
                result = value1 - value2;
            else if(value1 < value2)
                result = value2 - value1;

            return result;
        }
    }

    class Rates : IMath<double>
    {
        /// <summary>
        /// Adds the given values
        /// </summary>
        /// <param name="value1"></param>
        /// <param name="value2"></param>
        /// <returns></returns>
        public double Add(double value1, double value2)
        {
            return value1 + value2;
        }

        /// <summary>
        /// Finds the difference between the given value
        /// </summary>
        /// <param name="value1"></param>
        /// <param name="value2"></param>
        /// <returns></returns>
        public double Subtract(double value1, double value2)
        {
            double result = 0;

            if (value1 > value2)
                result = value1 - value2;
            else if (value1 < value2)
                result = value2 - value1;

            return result;
        }
    }


}
