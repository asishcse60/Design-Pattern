using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedDesignPattern.Decorator.Interface;

namespace ObjectOrientedDesignPattern.Decorator.DecoratorComponent
{
    public class OfferConcreateDecorator : CarDecorator
    {
        public OfferConcreateDecorator(ICar _car) : base(_car)
        {
        }

        public override double GetDisCountedPrice()
        {
            return .8 * base.GetPrice();
        }
    }
}
