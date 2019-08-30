using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedDesignPattern.Composite.Interface;

namespace ObjectOrientedDesignPattern.Composite
{
    public class Manager : IEmployee
    {
        public List<IEmployee> SubOrdinates;

        public string Name { get; set; }
        public string Dept { get; set; }    
        public Manager(string name, string dept)
        {
            Name = name;
            Dept = dept;
            SubOrdinates = new List<IEmployee>();
        }
        public void GetDetails()
        {
            Console.WriteLine("Name: {0} Dept: {1} - Manager Composite", Name, Dept);
            foreach (var subOrdinate in SubOrdinates)
            {
                subOrdinate.GetDetails();
            }
        }
    }
}
