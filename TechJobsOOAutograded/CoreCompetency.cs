using System;
using TechJobsOOAutograded;

namespace TechJobsOO
{
    public class CoreCompetency : JobField
    {

        //private int id;
        //public int Id { get; }
        //private static int nextId = 1;
        ////private string value;
        //public string Value { get; set; }

        // TODO: Change the fields to auto-implemented properties.

        //public CoreCompetency()
        //{
        //    Id = nextId;
        //    nextId++;
        //}

        
        public CoreCompetency(string v) : base(v)
        {
            //this will be empty as it would depend on the parent (base) class
        }

        public override bool Equals(object obj)
        {
            return obj is CoreCompetency competency &&
                   Id == competency.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        //public override string ToString()
        //{
        //    return Value;
        //}

    }
}
