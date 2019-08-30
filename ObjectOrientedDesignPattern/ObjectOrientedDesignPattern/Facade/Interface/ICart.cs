using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedDesignPattern.Facade.Interface
{
    public interface ICart
    {
        Product GetItemDetails(int itemId);
        bool CheckItemAvailability(Product product);
        bool LookItemInStock(int itemId, int quantity);
        int AddItemToCart(int itemId, int quantity);    
        double GetCartPrice(int cartId);    
    }
}
