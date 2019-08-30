using System;

namespace ObjectOrientedDesignPattern
{
    public abstract class FlightQueryBuilder
    {
        protected FlightAgency flightAgency;

        public FlightAgency FlightAgency    
        {
            get { return flightAgency; }
        }
        public abstract void SetFromCity(string fromCity);
        public abstract void SetToCity(string toCity);   
        public abstract void SetDepartureDate(DateTime depatureDate);    
        public abstract void SetArrivalDate(DateTime arrivalDate);  
        public abstract void SetInfantCount(int infant);
        public abstract void SetAdultCount(int adult);
        public abstract void SetChildrenCount(int child);    
        public abstract void SetClassType(string type);    
        public abstract void SetDirectFlight(bool isDirect); 
    }
    public class FlightAgency
    {
        private string _agencyName;
        public FlightAgency(string agencyName)
        {
            _agencyName = agencyName;
        }
        public string fromCity { get; set; }
        public string toCity { get; set; }
        public DateTime depatureDate { get; set; }
        public DateTime arrivalDate { get; set; }
        public int infant { get; set; }
        public int adult { get; set; }
        public int child { get; set; }
        public string type { get; set; }
        public bool isDirect { get; set; }
    }

    public class Agency
    {
        public void SetQueryData(FlightQueryBuilder flightQueryBuilder, FlightInfo flightInfo)  
        {
            flightQueryBuilder.SetFromCity(flightInfo.fromCity);
            flightQueryBuilder.SetToCity(flightInfo.toCity);
            flightQueryBuilder.SetDepartureDate(flightInfo.depatureDate);
            flightQueryBuilder.SetArrivalDate(flightInfo.arrivalDate);
            flightQueryBuilder.SetInfantCount(flightInfo.infant);
            flightQueryBuilder.SetAdultCount(flightInfo.adult);
            flightQueryBuilder.SetChildrenCount(flightInfo.child);
            flightQueryBuilder.SetClassType(flightInfo.type);
            flightQueryBuilder.SetDirectFlight(flightInfo.isDirect);
        }
    }

    public class FlightInfo : FlightAgency
    {
        public FlightInfo(string agencyName) : base(agencyName)
        {
        }
    }

    public class TravelAgency1 : FlightQueryBuilder
    {
        public TravelAgency1()
        {
            flightAgency = new FlightAgency("TravelAgency1");
        }
        public override void SetFromCity(string fromCity)
        {
            flightAgency.fromCity = fromCity;
        }

        public override void SetToCity(string toCity)
        {
            flightAgency.toCity = toCity;
        }

        public override void SetDepartureDate(DateTime depatureDate)
        {
            flightAgency.depatureDate = depatureDate;
        }

        public override void SetArrivalDate(DateTime arrivalDate)
        {
            flightAgency.arrivalDate = arrivalDate;
        }

        public override void SetInfantCount(int infant)
        {
            flightAgency.infant = infant;
        }

        public override void SetAdultCount(int adult)
        {
            flightAgency.adult = adult;
        }

        public override void SetChildrenCount(int child)
        {
            flightAgency.child = child;
        }

        public override void SetClassType(string type)
        {
            flightAgency.type = type;
        }

        public override void SetDirectFlight(bool isDirect)
        {
            flightAgency.isDirect = isDirect;
        }
    }
    public class TravelAgency2 : FlightQueryBuilder
    {
        public TravelAgency2()
        {
            flightAgency = new FlightAgency("TravelAgency2");
        }
        public override void SetFromCity(string fromCity)
        {
            flightAgency.fromCity = fromCity;
        }

        public override void SetToCity(string toCity)
        {
            flightAgency.toCity = toCity;
        }

        public override void SetDepartureDate(DateTime depatureDate)
        {
            flightAgency.depatureDate = depatureDate;
        }

        public override void SetArrivalDate(DateTime arrivalDate)
        {
            flightAgency.arrivalDate = arrivalDate;
        }

        public override void SetInfantCount(int infant)
        {
            flightAgency.infant = infant;
        }

        public override void SetAdultCount(int adult)
        {
            flightAgency.adult = adult;
        }

        public override void SetChildrenCount(int child)
        {
            flightAgency.child = child;
        }

        public override void SetClassType(string type)
        {
            flightAgency.type = type;
        }

        public override void SetDirectFlight(bool isDirect)
        {
            flightAgency.isDirect = isDirect;
        }
    }
}
