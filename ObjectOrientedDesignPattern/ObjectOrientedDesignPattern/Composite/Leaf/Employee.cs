using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedDesignPattern.Composite.Interface;

namespace ObjectOrientedDesignPattern.Composite.Leaf
{
    public class Employee : IEmployee
    {
        public string Name { get; set; }    
        public string Dept { get; set; }     
        public Employee(string name, string dept)
        {
            Name = name;
            Dept = dept;
        }
        public void GetDetails()
        {
            Console.WriteLine("Name: {0} Dept: {1} - Leaf Composite", Name, Dept);
        }
    }
}
