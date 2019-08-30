using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedDesignPattern.Facade.IFacade;
using ObjectOrientedDesignPattern.Facade.Interface;

namespace ObjectOrientedDesignPattern.Facade
{
    public class UserOrder : IUseOrder
    {
        public int AddToCart(int itemId, int quantity)
        {
            Console.WriteLine("Add to start cart");
            ICart userCart = new ShoppingCartDetails();
            int cartId = 0;
            Product product = userCart.GetItemDetails(itemId);

            if (userCart.CheckItemAvailability(product))
            {
                userCart.LookItemInStock(itemId, quantity);
                cartId = userCart.AddItemToCart(itemId, quantity);
            }
            Console.WriteLine("End AddToCart");
            return cartId;
        }

        public int PlaceOrder(int cartId, int userId)
        {
            Console.WriteLine("Start PlaceOrder");
            int orderId = -1;
            IWallet wallet = new Wallet();
            ITax tax = new Tax();
            ICart userCart = new ShoppingCartDetails();
            IAddress address = new AddressDetails();
            IOrder order = new Order();
            double stateTax = tax.GetTaxByState("ABC");
            tax.ApplyTax(cartId, stateTax);

            double userWalletBalance = wallet.GetUserBalance(userId);
            double cartPrice = userCart.GetCartPrice(cartId);

            if (userWalletBalance > cartPrice)
            {
                Address userAddress = address.GetAddressDetails(userId);
                orderId = order.PlaceOrderDetails(cartId, userAddress.AddressId);
            }
            return orderId;
        }
    }
}
