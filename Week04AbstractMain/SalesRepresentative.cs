using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week04AbstractMain
{
    internal class SalesRepresentative : Worker // Inherits from the abstract class Worker
    {
        public override void Title() // Implements the abstract method Title from the Worker class
        {
            Console.WriteLine("I am working as a sales representative."); // Displays the title of the worker
        }
        public SalesRepresentative(string name, string surname, string department) // Constructor to initialize the properties of the SalesRepresentative class
        {
            Name = name; // Sets the Name property
            Surname = surname; // Sets the Surname property
            Department = department; // Sets the Department property
        }
        public SalesRepresentative() // Default constructor for the SalesRepresentative class
        {
        }
    }
    
    }

