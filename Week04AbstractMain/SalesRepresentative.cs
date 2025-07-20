using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week04AbstractMain
{
    internal class SalesRepresentative : Worker
    {
        public override void Title()
        {
            Console.WriteLine("Sales Representative");
        }
        public SalesRepresentative(string name, string surname, string department)
        {
            Name = name;
            Surname = surname;
            Department = department;
        }
        public SalesRepresentative()
        {
        }
    }
    
    }

