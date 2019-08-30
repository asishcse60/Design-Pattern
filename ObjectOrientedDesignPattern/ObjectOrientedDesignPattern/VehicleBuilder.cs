using System;
using System.Collections.Generic;

namespace ObjectOrientedDesignPattern
{
    public abstract class VehicleBuilder
    {
        protected Vehicle vehicle;

        public Vehicle Vehicle
        {
            get { return vehicle; }
        }

        public abstract void BuildFrame();
        public abstract void BuildEngines();
        public abstract void BuildWheels();
        public abstract void BuildDoors();  
    }

    public class Shop
    {
        // Builder uses a complex series of steps
        public void Construct(VehicleBuilder vehicleBuilder)
        {
            vehicleBuilder.BuildFrame();
            vehicleBuilder.BuildEngines();
            vehicleBuilder.BuildDoors();
            vehicleBuilder.BuildWheels();
        }
    } 
    public class Vehicle
    {
        private string _vehicleType;
        private Dictionary<string, string>Parts = new Dictionary<string, string>();

        public Vehicle(string vehicleType)
        {
            _vehicleType = vehicleType;
        }

        //Indexer
        public string this[string key]
        {
            get => Parts[key];
            set => Parts[key] = value;
        }

        public void Show()
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine("Vehicle Type: {0}", _vehicleType);
            Console.WriteLine(" Frame : {0}", Parts["frame"]);
            Console.WriteLine(" Engine : {0}", Parts["engine"]);
            Console.WriteLine(" #Wheels: {0}", Parts["wheels"]);
            Console.WriteLine(" #Doors : {0}", Parts["doors"]);
        }
    }
}
