using System;
using System.Collections.Generic;
using System.Text;

namespace DelegationLibrary.Model
{
    public class Destination
    {
        public int DestinationID { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }
        public List<BusinessTrip> Trips { get; set; }
    }
}
