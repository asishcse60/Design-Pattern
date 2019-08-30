using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedDesignPattern.Strategy
{
    public class TravelPlanner
    {
        private TravelStrategy _travelStrategy;

        public TravelPlanner(TravelStrategy travelStrategy)
        {
            _travelStrategy = travelStrategy;
        }

        public void Drive(int kilometers)
        {
            var cost = _travelStrategy.Drive(kilometers);
            Console.WriteLine("Cost: {0}", cost);
        }
    }
}
