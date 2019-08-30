namespace ObjectOrientedDesignPattern
{
    public class MotorCycleBuilder : VehicleBuilder
    {
        private const string VehicleType = "MotorCycle";
        private const string FrameKey = "frame";
        private const string EngineKey = "engine";
        private const string WheelKey = "wheel";
        private const string DoorsKey = "doors";
        public MotorCycleBuilder()
        {
            vehicle = new Vehicle(VehicleType);
        }
        public override void BuildFrame()
        {
            vehicle[FrameKey] = "MotorCycleFrame";
        }

        public override void BuildEngines()
        {
            vehicle[EngineKey] = "500 cc";
        }

        public override void BuildWheels()
        {
            vehicle[WheelKey] = "2";
        }

        public override void BuildDoors()
        {
            vehicle[DoorsKey] = "0";
        }
    }
    public class CarBuilder:VehicleBuilder
    {
        private const string VehicleType = "Car";
        private const string FrameKey = "frame";
        private const string EngineKey = "engine";
        private const string WheelKey = "wheel";
        private const string DoorsKey = "doors";
        public CarBuilder()
        {
            vehicle = new Vehicle(VehicleType);
        }
        public override void BuildFrame()
        {
            vehicle[FrameKey] = "CarFrame";
        }

        public override void BuildEngines()
        {
            vehicle[EngineKey] = "1500 cc";
        }

        public override void BuildWheels()
        {
            vehicle[WheelKey] = "4";
        }

        public override void BuildDoors()
        {
            vehicle[DoorsKey] = "4";
        }
    }
    public class ScooterBuilder :VehicleBuilder
    {
        private const string VehicleType = "Scooter";
        private const string FrameKey = "frame";
        private const string EngineKey = "engine";
        private const string WheelKey = "wheel";
        private const string DoorsKey = "doors";

        public ScooterBuilder()
        {
            vehicle = new Vehicle(VehicleType);
        }
        public override void BuildFrame()
        {
            vehicle[FrameKey] = "ScooterFrame";
        }

        public override void BuildEngines()
        {
            vehicle[EngineKey] = "700 cc";
        }

        public override void BuildWheels()
        {
            vehicle[WheelKey] = "2";
        }

        public override void BuildDoors()
        {
            vehicle[DoorsKey] = "0";
        }
    }
}
