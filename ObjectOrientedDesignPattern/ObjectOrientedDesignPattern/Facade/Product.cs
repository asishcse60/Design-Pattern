using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedDesignPattern.Facade
{
    public class Product
    {
        public int ProductId { get; set; }  
        public string Name { get; set; }    
        public string Description { get; set; }     
        public int Quantity { get; set; }       
        public double Cost { get; set; }        
        public int LockedQty { get; set; }        
    }
}
