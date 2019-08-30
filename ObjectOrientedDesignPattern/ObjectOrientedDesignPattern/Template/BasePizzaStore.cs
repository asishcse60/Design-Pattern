using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedDesignPattern.Template.Interface;

namespace ObjectOrientedDesignPattern.Template
{
    public abstract class BasePizzaStore
    {
        protected IPizza PizzaForDelivery;
        public abstract void TakeOrder();   
        public abstract void MakeOrder();   
        public abstract void CookPizza();   

        public IPizza CreatePizzaForDelivery()  
        {
            TakeOrder();
            ProcessPayment();
            MakeOrder();
            CookPizza();
            DeliverPizza();
            return PizzaForDelivery;
        }

        private void DeliverPizza()
        {
            throw new NotImplementedException();
        }

        private void ProcessPayment()
        {
            throw new NotImplementedException();
        }
    }
}
