using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedDesignPattern.Facade.Interface;

namespace ObjectOrientedDesignPattern.Facade
{
    public class Tax:ITax
    {
        public double GetTaxByState(string state)
        {
            Console.WriteLine("GetTaxByState");
            return 2.00;
        }

        public void ApplyTax(int cartId, double taxPercent)
        {
            Console.WriteLine("Apply Tax");
        }
    }
}
