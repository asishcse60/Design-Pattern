using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedDesignPattern.Observer.Interface
{
    public interface IObserver
    {
        void Update(double ibmPrice, double applePrice, double googlePrice);
    }
}
