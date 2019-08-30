using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedDesignPattern.Decorator.Interface;

namespace ObjectOrientedDesignPattern.Decorator
{
    public sealed class Suzuki : ICar
    {
        public string Make()
        {
            return "SuzukiV2";
        }

        public double GetPrice()
        {
            return 900000;
        }
    }
}
