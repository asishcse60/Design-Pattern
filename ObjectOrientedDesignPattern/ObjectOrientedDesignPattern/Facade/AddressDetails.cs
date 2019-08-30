using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedDesignPattern.Facade.Interface;

namespace ObjectOrientedDesignPattern.Facade
{
    public class AddressDetails:IAddress
    {
        public Address GetAddressDetails(int userId)
        {
            Console.WriteLine("Subsystem address userId: {0}", userId);
            return new Address();
        }
    }
}
