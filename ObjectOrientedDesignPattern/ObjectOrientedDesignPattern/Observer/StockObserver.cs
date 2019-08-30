using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedDesignPattern.Observer.Interface;

namespace ObjectOrientedDesignPattern.Observer
{
    public class StockObserver : IObserver
    {
        private double ibmPrice { get; set; }
        private double applePrice { get; set; }
        private double googlePrice { get; set; }
        public static int ObserverIdTracker = 0;
        public int ObserverId = 0;
        private ISubject stockGraber;

        public StockObserver(ISubject subject)
        {
            this.stockGraber = subject;
            ObserverId = ++ObserverIdTracker;
            stockGraber.Resister(this);
        }
        public void Update(double ibmPrice, double applePrice, double googlePrice)
        {
            this.ibmPrice = ibmPrice;
            this.applePrice = applePrice;
            this.googlePrice = googlePrice;
            Console.WriteLine("IbmPrice:{0} ApplePrice:{1} GooglePrice:{2}", ibmPrice, applePrice, googlePrice);
        }
    }
}
