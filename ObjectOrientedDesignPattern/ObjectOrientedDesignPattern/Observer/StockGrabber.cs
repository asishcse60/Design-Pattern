using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedDesignPattern.Observer.Interface;

namespace ObjectOrientedDesignPattern.Observer
{
    public class StockGrabber:ISubject
    {
        private List<IObserver> observers;
        private double ibmPrice { get; set; }
        private double applePrice { get; set; }
        private double googlePrice { get; set; }

        public StockGrabber()
        {
            observers = new List<IObserver>();
        }
        public void Resister(IObserver newObserver)
        {
            observers.Add(newObserver);
        }

        public void UnResister(IObserver deleteObserver)
        {
           var item = observers.Remove(deleteObserver);
           Console.WriteLine("Observer deleted: {0}", item);
        }

        public void NotifyObserver()
        {
            foreach (var observer in observers)
            {
                observer.Update(ibmPrice,applePrice,googlePrice);
            }
        }

        public void SetIbmPrice(double newPrice)
        {
            this.ibmPrice = newPrice;
            NotifyObserver();
        }
        public void SetApplePrice(double newPrice)
        {
            this.applePrice = newPrice;
            NotifyObserver();
        }
        public void SetGooglePrice(double newPrice)
        {
            this.googlePrice = newPrice;
            NotifyObserver();
        }
    }
}
