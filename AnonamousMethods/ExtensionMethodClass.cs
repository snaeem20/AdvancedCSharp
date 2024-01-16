using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonamousMethods
{
    internal static class ExtensionMethodClass
    {
        public static bool containsPattern(this string stringValue, string pattern)
        {
            if (stringValue == null) 
                return false;
            
            return stringValue.Contains(pattern);
        }

        public static bool containsPattern<T>(this List<T> list, T item)
        {
            if (item == null || list == null)
                return false;

            return list.Contains(item);
        }
    }
}
