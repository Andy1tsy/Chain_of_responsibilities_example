using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilitiesWorkers
{
    class Kolhoznik
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }
        public string Position { get; set; }

        public Kolhoznik(string name, int age, int salary, string position)
        {
            Name = name;
            Age = age;
            Salary = salary;
            Position = position;
        }

        public override string ToString()
        {
            return string.Format("Name: {0,-16}, Age: {1,-3}, Salary: {2,-4}, Position: {3, -12} ", Name, Age, Salary, Position);
        }
    }
}
