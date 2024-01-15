﻿// See https://aka.ms/new-console-template for more information
using GenericInterface;
using Session12;
using System;
using System.Collections.Generic;
using static System.Formats.Asn1.AsnWriter;
using Generics;

/// <summary>
/// This class contains all the examples of C# Lecture
/// </summary>
class MainLectureProgram
{
    static void Main(string[] arg)
    {

    }

    /// <summary>
    /// Swaps the values of two variables
    /// </summary>
    /// <typeparam name="T">Generic Data Type</typeparam>
    /// <param name="Val1">Value of type T</param>
    /// <param name="Val2">Value of type T</param>
    public static void Swap<T>(T Val1, T Val2)
    {
        Console.WriteLine("Old values: " + Val1 + " and " + Val2);

        T tempValue = Val1;
        Val1 = Val2;
        Val2 = tempValue;

        Console.WriteLine("New values: " + Val1 + " and " + Val2);
    }

    /// <summary>
    /// Generic Method Example
    /// </summary>
    public static void CallGenericMethodExample()
    {
        Console.WriteLine("Swapping Numbers:");
        Swap<int>(12, 10);

        Console.WriteLine("Swapping String:");
        Swap<string>("first", "second");
    }

    /// <summary>
    /// Generic Interface Example
    /// </summary>
    public static void CallGenericInterfaceExample()
    {
        int scoreSementer1 = 50, scoreSementer2 = 90;
        Scores score = new Scores();
        Console.WriteLine("Total Score: " + score.Add(scoreSementer1, scoreSementer2));
        Console.WriteLine("Score Difference: " + score.Subtract(scoreSementer1, scoreSementer2));

        double scoreMisc1 = 5.5, scoreMisc2 = 1.25;
        Rates miscScore = new Rates();
        Console.WriteLine("Total Rate: " + miscScore.Add(scoreMisc1, scoreMisc2));
        Console.WriteLine("Rate Difference: " + miscScore.Subtract(scoreMisc1, scoreMisc2));
    }

    /// <summary>
    /// Generic Interface CONSTRAINTS Example
    /// </summary>
    public static void CallGenericClassInterfaceExample()
    {
        GenericInterfaceConstaintList<Student> students = new GenericInterfaceConstaintList<Student>();

        Student S1 = new Student(1, "Haseeb", "Front end developer");
        students.Add(S1);
        students.Add(new Student(2, "Alishba", "UX Designer"));
        students.Add(new Student(3, "Arib", "Data Administrator"));

        students.ListDisplayDetails();

        GenericInterfaceConstaintList<Course> courses = new GenericInterfaceConstaintList<Course>();
        Course C1 = new Course(1, "C#");
        courses.Add(C1);
        courses.Add(new Course(2, "SQL"));
        courses.Add(new Course(3, "MVC"));

        courses.ListDisplayDetails();

    }

    /// <summary>
    /// Generic Interface DELEGATES Example
    /// </summary>
    public static void CallGenericDelegateExample()
    {
        DelGetValue<int> getIntValue = GenericDelegates.GetIfEven;
        DelGetValue<float> getFloatValue = GenericDelegates.GetIfPositive;

        Console.WriteLine(getIntValue(9));
        Console.WriteLine(getFloatValue(-10.25F));
    }

    /// <summary>
    /// Class Constructors
    /// </summary>
    public static void CallClassConstructorExample()
    {
        Session12.AptechStudent aptechStudent = new Session12.AptechStudent();
        Session12.AptechStudent aptechStudent2 = new Session12.AptechStudent("sAMIA", 5);
    }

    /// <summary>
    /// Method Overloading With Type Parameters
    /// </summary>
    public static void CallMethodOverloadingWithTypeParametersExample()
    {
        MethodOverloading<int, string> obj1 = new MethodOverloading<int, string>();
        obj1.SetValue(5);
        obj1.SetValue("Test");
        obj1.DisplayValues();
    }

    /// <summary>
    /// Iterators
    /// </summary>
    public static void CallIteratorExample()
    {
        MyIterator itr = new MyIterator();
        foreach (string item in itr.values)
        {
            Console.WriteLine(item);
        }

        int[] arr = { 1, 8, 55 };
        MyGenericIterator<int> gItr = new MyGenericIterator<int>(arr);
        foreach (int item in gItr.values)
        {

        }

        string[] sArr = { "AA", "BB", "CC" };
        MyGenericIterator<string> gStringItr = new MyGenericIterator<string>(sArr);
        foreach (string item in gStringItr.values)
        {

        }

        MyGenericIterator<string> gStringItr2 = new MyGenericIterator<string>(new string[] { "AA", "BB", "CC" });
        foreach (string item in gStringItr2.values)
        {

        }
    }

    /// <summary>
    /// Delegate that gets an int value
    /// </summary>
    /// <param name="value">integer value</param>
    /// <returns></returns>
    delegate int DelGetValue(int value);

    /// <summary>
    /// Delegate that prints a value
    /// </summary>
    /// <param name="value">integer value</param>
    delegate void DelPrintValue(int value);

    /// <summary>
    /// Anonamous Methods
    /// </summary>
    public static void CallAnonamousMethodExample()
    {
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
    }

    /// <summary>
    /// Delegates referencing multiple Anonamous Methods 
    /// </summary>
    public static void CallMultipleAnonamousMethodExample()
    {
        DelPrintValue result = delegate (int value)
        {
            Console.WriteLine("The double of the value is: " + value * 2);
        };

        result += delegate (int value)
        {
            Console.WriteLine("The half of the value is: " + value / 2);
        };

        result(10);

    }

    /// <summary>
    /// Extension Methods 
    /// </summary>
    public static void CallExtensionMethodExample()
    {
        string myValue = "Pakistan is my country.";
        string myPattern = "Pakistan";
        string secondPattern = "China";

        Console.WriteLine(myValue.containsPattern(myPattern));
        Console.WriteLine(myValue.containsPattern(secondPattern));
    }

    /// <summary>
    /// Extension Methods for Generic types
    /// </summary>
    public static void CallExtensionMethodsForGenericTypes()
    {
        List<int> myIntList = new List<int> { 10, 5, 9 };
        Console.WriteLine(myIntList.containsPattern(4));
        Console.WriteLine(myIntList.containsPattern(5));

        List<string> myStringList = new List<string> { "A1", "B2", "C3" };
        Console.WriteLine(myStringList.containsPattern("D4"));
        Console.WriteLine(myStringList.containsPattern("C3"));

    }
}

