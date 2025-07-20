using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week04AbstractMain
{
    internal class SoftwareDeveloper : Worker // Inherits from the abstract class Worker
    {
        public override void Title() // Implements the abstract method Title from the Worker class
        {
            Console.WriteLine("I am working as a software developer."); // Displays the title of the worker
        }
        public SoftwareDeveloper(string name, string surname, string department) // Constructor to initialize the properties of the SoftwareDeveloper class
        {
            Name = name;
            Surname = surname;
            Department = department;
        }
        public SoftwareDeveloper() // Default constructor for the SoftwareDeveloper class
        {

        }
    }

}
