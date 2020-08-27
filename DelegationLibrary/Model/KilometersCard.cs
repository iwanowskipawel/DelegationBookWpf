using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegationLibrary.Model
{
    public class KilometersCard
    {
        public int KilometerCardID { get; set; }
        public string CardSymbol { get; set; }
        public Car Car { get; set; }
        public string CardWorkCardNumber { get; set; }
        public List<BusinessTrip> Trips { get; set; }
        public int TotalDistance => Trips.Sum(x => x.Distance);
    }
}
