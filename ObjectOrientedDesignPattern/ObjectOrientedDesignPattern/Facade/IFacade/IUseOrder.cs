using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedDesignPattern.Facade.IFacade
{
    public interface IUseOrder
    {
        int AddToCart(int itemId, int quantity);    
        int PlaceOrder(int cartId, int userId);     
    }
}
