namespace AnonamousMethods
{
    internal class Program
    {
        delegate int DelGetValue(int value);
        delegate void DelPrintValue(int value);

        static void Main(string[] args)
        {
            ///////////////////////////////////////////////
            ///Anonamous Methods
            ///////////////////////////////////////////////
            DelGetValue getIfEven = delegate (int value)
            {
                if (value % 2 == 0)
                    return value;
                else
                    return 0;
            };

            DelGetValue getIfPositive = delegate (int value)
            {
                if (value > 0)
                    return value;
                else
                    return 0;
            };

            Console.WriteLine(getIfEven(10));
            Console.WriteLine(getIfPositive(-8));

            ////////////////////////////////////////////////////
            ///Delegates referencing multiple Anonamous Methods 
            ///////////////////////////////////////////////////
            DelPrintValue result = delegate (int value)
            {
                Console.WriteLine("The double of the value is: " + value * 2);
            };

            result += delegate (int value)
            {
                Console.WriteLine("The half of the value is: " + value / 2);
            };

            result(10);

            ////////////////////////////////////////////////////
            ///Extension Methods 
            ///////////////////////////////////////////////////
            string myValue = "Pakistan is my country.";
            string myPattern = "Pakistan";
            string secondPattern = "China";

            Console.WriteLine(myValue.containsPattern(myPattern));
            Console.WriteLine(myValue.containsPattern(secondPattern));


            ////////////////////////////////////////////////////
            ///Extension Methods for Generic types
            ///////////////////////////////////////////////////
            List<int> myIntList = new List<int> { 10, 5, 9};
            Console.WriteLine(myIntList.containsPattern(4));
            Console.WriteLine(myIntList.containsPattern(5));

            List<string> myStringList = new List<string> { "A1", "B2", "C3"};
            Console.WriteLine(myStringList.containsPattern("D4"));
            Console.WriteLine(myStringList.containsPattern("C3"));
        }
    }
}