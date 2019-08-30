using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedDesignPattern.Facade.Interface
{
    public interface IAddress
    {
        Address GetAddressDetails(int userId);
    }
}
