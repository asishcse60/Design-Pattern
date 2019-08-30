using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedDesignPattern.Facade.Interface;

namespace ObjectOrientedDesignPattern.Facade
{
    public class Cart
    {
        public int CartId { get; set; }
        public int UserId { get; set; }
        public IEnumerable<CartItem> ShoppingCart { get; set; }    
    }
}
