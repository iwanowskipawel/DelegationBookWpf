using System;
using System.Collections.Generic;
using System.Text;

namespace DelegationLibrary.Model
{
    public class BusinessTrip
    {
        public int BusinessTripID { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime ArrivalDate { get; set; }
        public Driver Driver { get; set; }
        public Project Project { get; set; }
        public Employee Keeper { get; set; }
        public Destination Destination { get; set; }
        public int InitialMeter { get; set; }
        public int FinalMeter { get; set; }
        public int Distance => FinalMeter - InitialMeter;
    }
}
