using System;
using System.Collections.Generic;
using System.Text;

namespace DelegationLibrary.Model
{
    public class Destination : IDestination
    {
        public int DestinationID { get; set; }
        public string Name { get; set; }
        public IAddress Address { get; set; }
        public List<IBusinessTrip> Trips { get; set; }
    }
}
