using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedDesignPattern.Template
{
    public class SingaporeStylePizzaStore:BasePizzaStore
    {
        public override void TakeOrder()
        {
            //Use factory pattern
            throw new NotImplementedException();
        }

        public override void MakeOrder()
        {
            throw new NotImplementedException();
        }

        public override void CookPizza()
        {
            throw new NotImplementedException();
        }
    }
}
