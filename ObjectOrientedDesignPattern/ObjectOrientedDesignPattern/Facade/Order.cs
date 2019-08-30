using System;
using ObjectOrientedDesignPattern.Facade.Interface;

namespace ObjectOrientedDesignPattern.Facade
{
    public class Order : IOrder
    {
        public int PlaceOrderDetails(int cartId, int shippingAddressId)
        {
            Console.WriteLine("Place order cartId:{0} shippingAddressId: {1}", cartId, shippingAddressId);
            return 10;
        }
    }
}
