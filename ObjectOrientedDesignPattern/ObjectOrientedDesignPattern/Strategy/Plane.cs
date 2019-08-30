using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedDesignPattern.Strategy
{
    public class Plane : TravelStrategy
    {
        public Plane()
        {
            KilometerCost = 20;
        }
        public override decimal Drive(int kilometer)
        {
            return kilometer * KilometerCost;
        }
    }
}
