using System;
using System.Collections.Generic;

namespace AdapterPatternDemo
{
    // Target interface
    public interface IArchitectJob
    {
        void DesignArchitecture();
    }

    // Adaptee: Software Developer job
    public class SoftwareDeveloperJob
    {
        public void WriteSoftware()
        {
            Console.WriteLine("Writing software code...");
        }
    }

    // Adapter: Turns a Software Developer job into an Architect job
    public class SoftwareArchitectAdapter : IArchitectJob
    {
        private readonly SoftwareDeveloperJob _developerJob;

        public SoftwareArchitectAdapter(SoftwareDeveloperJob developerJob)
        {
            _developerJob = developerJob;
        }

        public void DesignArchitecture()
        {
            Console.WriteLine("Adapting software development skills to architectural design...");
            _developerJob.WriteSoftware();
            Console.WriteLine("Translating code into architectural blueprints...");
        }
    }

    // Sukumar, our job seeker
    public class Sukumar
    {
        public void ApplyForJob(IArchitectJob job)
        {
            Console.WriteLine("Sukumar: I'm applying for an Architect position!");
            job.DesignArchitecture();
        }
    }

    // Software companies in Gurugram
    public class SoftwareCompany
    {
        public string Name { get; set; }
        public SoftwareDeveloperJob AvailableJob { get; set; }

        public SoftwareCompany(string name)
        {
            Name = name;
            AvailableJob = new SoftwareDeveloperJob();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The story of Sukumar: An Architect's Journey in the World of Software");
            Console.WriteLine("==============================================================");

            var sukumar = new Sukumar();

            var companies = new List<SoftwareCompany>
            {
                new SoftwareCompany("ABC Tech Solutions"),
                new SoftwareCompany("MNC Code Crafters"),
                new SoftwareCompany("XYZ Software Innovators")
            };

            foreach (var company in companies)
            {
                Console.WriteLine($"\nSukumar visits {company.Name}...");
                
                var adapter = new SoftwareArchitectAdapter(company.AvailableJob);
                
                sukumar.ApplyForJob(adapter);
                
                Console.WriteLine($"Sukumar: Thank you for the opportunity at {company.Name}!");
            }

            Console.WriteLine("\nSukumar's journey demonstrates the power of the Adapter Pattern in his career transition.");
        }
    }
}
