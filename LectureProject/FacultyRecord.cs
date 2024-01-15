using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordDataType
{
    public record FacultyRecord
    {
        public int id;
        public string name;
        public string qualification;

        //init-only make a field immutable
        public int ID { get; init; }
        public string Name { get; init; }
        public string Qualification { get; init; }
      
    }
}
