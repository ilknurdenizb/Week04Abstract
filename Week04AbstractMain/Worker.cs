using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week04AbstractMain
{
    internal abstract class Worker // Abstract class representing a worker
    {
        public string Name { get; set; } // Property for the worker's name
        public string Surname { get; set; } // Property for the worker's surname
        public string Department { get; set; } // Property for the worker's department

        public abstract void Title(); // Abstract method to be implemented by derived classes to display the worker's title


    }
}
