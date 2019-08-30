using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedDesignPattern.Observer.Interface
{
    public interface ISubject
    {
        void Resister(IObserver o);
        void UnResister(IObserver o);
        void NotifyObserver();
    }
}
