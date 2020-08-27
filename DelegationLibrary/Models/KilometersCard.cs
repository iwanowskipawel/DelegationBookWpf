using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegationLibrary.Model
{
    public class KilometersCard : IKilometersCard
    {
        public int KilometerCardID { get; set; }
        public string CardSymbol { get; set; }
        public ICar Car { get; set; }
        public string WorkCardNumber { get; set; }
        public List<IBusinessTrip> Trips { get; set; }
        public int TotalDistance => Trips.Sum(x => x.Distance);
    }
}
