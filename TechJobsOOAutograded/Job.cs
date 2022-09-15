using System;
using System.Data;
using System.Text;
using System.Xml.Linq;

namespace TechJobsOO
{
    public class TechJob
    {
        
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.
        public TechJob()
        {
            Id = nextId;
            nextId++;
        }

        public TechJob(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;

        }

        // TODO: Generate Equals() and GetHashCode() methods.

        public override bool Equals(object obj)
        {
            return obj is TechJob techJob &&
                   Id == techJob.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }


        public override string ToString()
        {
            
            string msg = $"\nId: {Id}\n";
            string noData = "Data Not Available";

            if (Name == "")
            {
                msg += $"Name: {noData}\n";
            }
            else
            {
                msg += $"Name: {Name}\n";
            }

            if (EmployerName.Value == "")
            {
                msg += $"Employer: {noData}\n";
            }
            else
            {
                msg += $"Employer: {EmployerName.Value}\n";
            }

            if (EmployerLocation.Value == "")
            {
                msg += $"Location: {noData}\n";
            }
            else
            {
                msg += $"Location: {EmployerLocation.Value}\n";
            }

            if (JobType.Value == "")
            {
                msg += $"Position Type:{noData}\n";
            }
            else
            {
                msg += $"Position Type: {JobType.Value}\n";
            }

            if (JobCoreCompetency.Value == "")
            {
                msg += $"Core Competency: {noData}\n";
            }
            else
            {
                msg += $"Core Competency: {JobCoreCompetency.Value}\n";
            }

            return msg;
        }


    }
}