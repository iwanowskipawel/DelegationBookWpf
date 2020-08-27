using System;
using System.Collections.Generic;
using System.Text;

namespace DelegationLibrary.Model
{
    public class BusinessTrip : IBusinessTrip
    {
        public int BusinessTripID { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime ArrivalDate { get; set; }
        public IDriver Driver { get; set; }
        public IProject Project { get; set; }
        public IEmployee Keeper { get; set; }
        public IDestination Destination { get; set; }
        public int InitialMeter { get; set; }
        public int FinalMeter { get; set; }
        public int Distance => FinalMeter - InitialMeter;
    }
}
