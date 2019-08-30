using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedDesignPattern.Decorator.Interface;

namespace ObjectOrientedDesignPattern.Decorator
{
    public sealed class Hunday : ICar  
    {
        public string Make()
        {
            return "HatchBack";
        }

        public double GetPrice()
        {
            return 800000;
        }
    }
}
