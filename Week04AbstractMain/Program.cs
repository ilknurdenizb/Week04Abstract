using System;
using Week04AbstractMain;

class Program
{
    static void Main ()
    {
        Worker worker1 = new ProjectManager("Alice", "Johnson", "Project Management"); // Create an instance of ProjectManager
        Worker worker2 = new SoftwareDeveloper("Bob", "Smith", "Software Development"); // Create an instance of SoftwareDeveloper
        Worker worker3 = new SalesRepresentative("Charlie", "Brown", "Sales"); // Create an instance of SalesRepresentative

        Console.WriteLine($"{worker1.Name} {worker1.Surname} is working on {worker1.Department}"); // Display worker details
        worker1.Title(); // Call the Title method to display the worker's title
        Console.WriteLine("----------------------------");
        Console.WriteLine($"{worker2.Name} {worker2.Surname} is working on {worker2.Department}"); // Display worker details
        worker2.Title(); // Call the Title method to display the worker's title
        Console.WriteLine("----------------------------");
        Console.WriteLine($"{worker3.Name} {worker3.Surname} is working on {worker3.Department}"); // Display worker details
        worker3.Title();

    }
}