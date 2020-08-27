using System;
using System.Collections.Generic;
using System.Text;

namespace DelegationLibrary.Model
{
    public class Car
    {
        public int CarID { get; set; }
        public string Model { get; set; }
        public string RegistrationNumber { get; set; }
        public Driver MainDriver { get; set; }
        public int MeterStatus { get; set; }
        public List<KilometersCard> KilometersCards { get; set; }
    }
}
