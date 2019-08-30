﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedDesignPattern.Decorator.Interface;

namespace ObjectOrientedDesignPattern.Decorator.DecoratorComponent
{
    public abstract class CarDecorator : ICar
    {
        private ICar car;

        public CarDecorator(ICar _car)
        {
            car = _car;
        }
        public string Make()
        {
            return car.Make();
        }

        public double GetPrice()
        {
            return car.GetPrice();
        }

        public abstract double GetDisCountedPrice();
    }
}
