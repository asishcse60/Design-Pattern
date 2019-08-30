using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedDesignPattern.Facade
{
    public class Address
    {
        public int AddressId { get; set; }  
        public string AddressDetails { get; set; }     
        public string PinCode { get; set; }    
        public string Phone { get; set; }      
        public string Country { get; set; }    
        public string State { get; set; }    
        public string City { get; set; }       
    }
}
