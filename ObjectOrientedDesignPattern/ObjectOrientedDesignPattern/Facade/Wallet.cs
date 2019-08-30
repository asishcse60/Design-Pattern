using System;
using ObjectOrientedDesignPattern.Facade.Interface;

namespace ObjectOrientedDesignPattern.Facade
{
    public class Wallet:IWallet
    {
        public double GetUserBalance(int userId)
        {
            Console.WriteLine("Check Item Availability");
            return 10.00;
        }
    }
}
