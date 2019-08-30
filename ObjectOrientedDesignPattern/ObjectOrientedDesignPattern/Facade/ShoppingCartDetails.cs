using System;
using ObjectOrientedDesignPattern.Facade.Interface;

namespace ObjectOrientedDesignPattern.Facade
{
    public class ShoppingCartDetails:ICart
    {
        public Product GetItemDetails(int itemId)   
        {
            Console.WriteLine("GetProductDetails: {0}", itemId);
            return new Product();
        }

        public bool CheckItemAvailability(Product product)
        {
            Console.WriteLine("Check Item Availability");
            return true;
        }

        public bool LookItemInStock(int itemId, int quantity)
        {
            Console.WriteLine("Lock Item in Stock");
            return true;
        }

        public int AddItemToCart(int itemId, int quantity)
        {
            Console.WriteLine("Add Item to Cart");
            return 10;
        }

        public double GetCartPrice(int cartId)
        {
            Console.WriteLine("Get Cart Price");
            return 12.00;
        }
    }
}
