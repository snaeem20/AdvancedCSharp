using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritedClasses
{
    public class Faculty
    {
        public int id;
        public string name;
        public string status;

        //init-only make a field immutable
        public int ID { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }


        ///////////////////////////////////
        ///Method Overloading
        ///////////////////////////////////

        public string GetStatus(int facultyId)
        {
            return "All is well";
        }

        public int GetStatus(string qualification)
        {
            return 0;
        }

        ///////////////////////////////////
        ///Method Overriding
        ///////////////////////////////////

        public virtual void GetInfo()
        {
            Console.WriteLine("Faculty Status is " + Status);
        }
    }

    public class VisitingFaculty : Faculty
    {
        public DateTime contractExpiryDate;

        public DateTime ContractExpiryDate { get => contractExpiryDate; set => contractExpiryDate = value; }

        public VisitingFaculty(int id, string name, string status, DateTime contractExpiryDate)
        {
            this.id = id;
            this.name = name;
            this.status = status;
            this.contractExpiryDate = contractExpiryDate;
        }

        public override void GetInfo()
        {
            Status = "VISITING";
            base.GetInfo();
        }

    }

    public class PermanentFaculty : Faculty
    {
        int leaves;

        public int Leaves { get => leaves; set => leaves = value; }

        public PermanentFaculty(int id, string name, string status, int totalLeaves)
        {
            this.id = id;
            this.name = name;
            this.status = status;
            this.leaves = totalLeaves;
        }

        public override void GetInfo()
        {
            Status = "PERMANENT";
            base.GetInfo();
        }
    }
}
