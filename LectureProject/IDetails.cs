using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GenericInterface
{
	//Interface
    internal interface IDetails
    {
        void DisplayDetails();
    }

	//Generic Class that adds 3 values in the list and displays each list item's details.
	//The class has Interface Constraint
    class GenericInterfaceConstaintList<T> where T : IDetails 
    {
        T[] values = new T[3];
        int index = 0;

        public void Add(T obj)
        {
            values[index] = obj;
            index++;
        }

        public void ListDisplayDetails() 
        { 
            for (int i = 0; i < values.Length; i++)
            {
                values[i].DisplayDetails();
            }
        }
    }

	//Class inherited from IDetails
    class Student : IDetails
    {       
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Student(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }

        public void DisplayDetails()
        {
            Console.WriteLine(Id + " | " + Name + " | " + Description);
        }
    }

	//Class inherited from IDetails
    class Course : IDetails
    {       

        public int Number { get; set; }
        public string Title { get; set; }

        public Course(int number, string title)
        {
            Number = number;
            Title = title;
        }

        public void DisplayDetails()
        {
            Console.WriteLine(Number + " | " + Title);
        }

    }

}
