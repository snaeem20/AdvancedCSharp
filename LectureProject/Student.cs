using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticVsReadOnlyVsConst
{
    internal class AptechStudent
    {
        string Name;

        int Id;

        public AptechStudent(string name, int id)
        {
            Name = name;
            Id = id;
        }

        public AptechStudent()
        { }
    }
}
