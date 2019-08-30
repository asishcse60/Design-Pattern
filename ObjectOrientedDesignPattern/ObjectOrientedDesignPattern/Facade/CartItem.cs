using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedDesignPattern.Facade
{
    public class CartItem
    {
        public int ProductId { get; set; }  
        public int Quantity { get; set; }   
        public double TaxPercentage { get; set; }       
        public double Cost { get; set; }        
        public double Price { get; set; }           
    }
}
