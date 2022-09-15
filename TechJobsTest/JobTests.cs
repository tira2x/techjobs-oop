using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTest
{
    [TestClass]
    public class JobTests
    {
       
        [TestMethod]
        public void TestSettingJobId()
        {
            TechJob job1 = new TechJob();
            TechJob job2 = new TechJob();
            Assert.IsFalse(TechJob.Equals(job1, job2));
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            TechJob job1 = new TechJob("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.IsTrue(job1.Name == "Product tester");
            Assert.AreEqual(job1.EmployerName.ToString(), "ACME");
            Assert.AreEqual(job1.EmployerLocation.ToString(), "Desert");
            Assert.AreEqual(job1.JobType.ToString(), "Quality control");
            Assert.AreEqual(job1.JobCoreCompetency.ToString(), "Persistence");
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            TechJob job1 = new TechJob("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            TechJob job2 = new TechJob("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.IsFalse(job1.Equals(job2));
        }

        [TestMethod]
        public void TestToStringStartsAndEndsWithNewLine()
        {
            TechJob job1 = new TechJob("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            Assert.AreEqual(true, job1.ToString().StartsWith("\n"));
            Assert.AreEqual(true, job1.ToString().EndsWith("\n"));
        }

        [TestMethod]
        public void TestToStringContainsCorrectLabelsAndData()
        {
            TechJob job1 = new TechJob("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            
            Assert.AreEqual(true, job1.ToString().Contains($"Id: {job1.Id}"));
            Assert.AreEqual(true, job1.ToString().Contains("Name: Product tester"));
            Assert.AreEqual(true, job1.ToString().Contains("Employer: ACME"));
            Assert.AreEqual(true, job1.ToString().Contains("Location: Desert"));
            Assert.AreEqual(true, job1.ToString().Contains("Position Type: Quality control"));
            Assert.AreEqual(true, job1.ToString().Contains("Core Competency: Persistence"));
        }
        [TestMethod]
        public void TestToStringHandlesEmptyField()
        {
            TechJob job1 = new TechJob();
            Assert.AreEqual(job1.ToString(), $"ID: {job1.Id} \n" +
                $"Name: Data not available\n" +
                $"Employer:  Data not available\n" +
                $"Location: Data not available\n" +
                $"Position Type: Data not available\n" +
                $"Core Competency: Data not available");
        }

        [TestMethod]
        public void TestToString()
        {
            TechJob job1 = new TechJob("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.AreEqual(job1.ToString(), $"ID: {job1.Id} \n" +
                $"Name: {job1.Name}\n" +
                $"Employer:  {job1.EmployerName}\n" +
                $"Location: {job1.EmployerLocation}\n" +
                $"Position Type: {job1.JobType}\n" +
                $"Core Competency: {job1.JobCoreCompetency}");
        }

        [TestMethod]
        public void TestToStringJobWithOnlyIdField()
        {
            TechJob job1 = new TechJob();
            Assert.AreEqual("\nOOPS! This job does not seem to exist.\n", job1.ToString());
        }
    }
}
