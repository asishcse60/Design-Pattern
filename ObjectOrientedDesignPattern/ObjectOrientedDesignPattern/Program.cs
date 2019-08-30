using System;
using ObjectOrientedDesignPattern.AdapterPattern;
using ObjectOrientedDesignPattern.Command;
using ObjectOrientedDesignPattern.Command.Interface;
using ObjectOrientedDesignPattern.Composite;
using ObjectOrientedDesignPattern.Composite.Interface;
using ObjectOrientedDesignPattern.Composite.Leaf;
using ObjectOrientedDesignPattern.Decorator;
using ObjectOrientedDesignPattern.Decorator.DecoratorComponent;
using ObjectOrientedDesignPattern.Facade;
using ObjectOrientedDesignPattern.Facade.IFacade;
using ObjectOrientedDesignPattern.Observer;
using ObjectOrientedDesignPattern.Observer.Interface;
using ObjectOrientedDesignPattern.Strategy;

namespace ObjectOrientedDesignPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*S(Single Responsibility Principal): A class should have one and only one, reason to change. save from side effect
              O(Open Close Principal): Software entities(classes, modules, functions etc) should be open for extension, but closed for modification.Use Interface, interface introduce additional level of abstraction which enables you for loose coupling.
              L(Liscov Substituition Principal):Let Φ(x) be a property provable about objects x of type T. Then Φ(y) should be true for objects y of type S where S is a subtype of T.The principle defines that objects of a superclass shall be replaceable with objects of its subclasses without breaking the application.
              I(Interface Segregation Principal): Client should not be forced depend upon interfaces that they do not use.Example: CoffeeMachine
              D(Dependency Inversion Principal):
              1. High-level modules should not depend on low-level modules. Both should depend on abstractions.
              2. Abstractions should not depend on details. Details should depend on abstractions
             */
            /*Creational Patterns: Singleton: LoadBalancer, Builder: VehicleBuilder, Factory:Salary, Abstract Factory: same to factory, only create a new abstraction layer, Phototype: Clone object*/
            /*Structural Pattern: Adapter : MediaPlayer, Composite: Manager-Employee like tree structure, Decorator: Car Making, Facade*/
            //Decorator (Wrapper Pattern): Attach additional responsibility to an object dynamically,Decorators provide a flexible alternative to sub classing for its extending functionalities
            /*Behavioral Patterns: Command, Observer, Strategy, Template*/

            /*Solid Principal, Dependency Injection*/
            //LoadBalancer lb1 = LoadBalancer.GetLoadBalancer();
            //LoadBalancer lb2 = LoadBalancer.GetLoadBalancer();
            //LoadBalancer lb3 = LoadBalancer.GetLoadBalancer();
            //LoadBalancer lb4 = LoadBalancer.GetLoadBalancer();
            //// Same instance?

            //if (lb1 == lb2 && lb2 == lb3 && lb3 == lb4)
            //{
            //    Console.WriteLine("Same instance\n");
            //}
            //// Load balance 15 server requests

            //LoadBalancer balancer = LoadBalancer.GetLoadBalancer();
            //for (int i = 0; i < 15; i++)
            //{
            //    string server = balancer.Server;
            //    Console.WriteLine("Dispatch Request to: " + server);
            //}
            //Singleton Pattern End

            //VehicleBuilder vehicleBuilder;
            //Shop shop = new Shop();

            //vehicleBuilder = new ScooterBuilder();
            //shop.Construct(vehicleBuilder);
            //vehicleBuilder.Vehicle.Show();

            //vehicleBuilder = new CarBuilder();
            //shop.Construct(vehicleBuilder);
            //vehicleBuilder.Vehicle.Show();

            //vehicleBuilder = new MotorCycleBuilder();
            //shop.Construct(vehicleBuilder);
            //vehicleBuilder.Vehicle.Show();
            // Builder Pattern is End

            //var audioPlayer = new AudioPlayer();
            //audioPlayer.Play("mp3","beyond the horizon.mp3");
            //audioPlayer.Play("mp4","along.mp4");
            //audioPlayer.Play("vlc","far far away.vlc");
            //audioPlayer.Play("avi","mind me.avi");
            //Adapter Pattern

            IEmployee jhon = new Employee("jhon", "IT");
            IEmployee mike = new Employee("mike", "IT");
            IEmployee json = new Employee("json", "HR");
            IEmployee erik = new Employee("erik", "HR");
            IEmployee henry = new Employee("henry", "HR");

            IEmployee james = new Manager("james", "IT") { SubOrdinates = { jhon, mike } };
            IEmployee philips = new Manager("philips", "HR") { SubOrdinates = { json, erik, henry } };

            IEmployee Bob = new Manager("Bob", "Head") { SubOrdinates = { james, philips } };

            Bob.GetDetails();
            //Composite Pattern end

            //ICar suzuki = new Suzuki();
            //CarDecorator carDecorator = new OfferConcreateDecorator(suzuki);
            //Console.WriteLine("Car Name: {0} Car Price: {1} Car Price(After Discount): {2}", carDecorator.Make(), carDecorator.GetPrice(), carDecorator.GetDisCountedPrice());
            //Decorator Pattern end

            //IUseOrder userOrder = new UserOrder();
            //int cartId = userOrder.AddToCart(1001, 2);
            //int userId = 1234;
            //int orderId = userOrder.PlaceOrder(cartId, userId);
            //Facade Pattern end

            //IElectronicDevice  electronicDevice = new Television();
            //TurnTvOn turnTvOn = new TurnTvOn(electronicDevice);
            //DeviceButton  dbButton = new DeviceButton(turnTvOn);

            //dbButton.PressButton();

            //Command Pattern end

            //StockGrabber stockGraber = new StockGrabber();
            //IObserver stockObserver1 = new StockObserver(stockGraber);

            //stockGraber.SetIbmPrice(120);
            //stockGraber.SetApplePrice(140);
            //stockGraber.SetGooglePrice(150);

            //IObserver stockObserver2 = new StockObserver(stockGraber);
            //stockGraber.SetIbmPrice(120);
            //stockGraber.SetApplePrice(140);
            //stockGraber.SetGooglePrice(150);

            //stockGraber.UnResister(stockObserver2);

            //Observer Pattern ends

            //TravelStrategy Ts = new Car();
            //TravelPlanner travelPlanner = new TravelPlanner(Ts);
            //travelPlanner.Drive(20);

            Console.ReadKey();
        }
    }
}
