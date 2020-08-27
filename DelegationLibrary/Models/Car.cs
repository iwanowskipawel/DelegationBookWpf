using System;
using System.Collections.Generic;
using System.Text;

namespace DelegationLibrary.Model
{
    public class Car : ICar
    {
        public int CarID { get; set; }
        public string Model { get; set; }
        public string RegistrationNumber { get; set; }
        public IDriver MainDriver { get; set; }
        public int MeterStatus { get; set; }
        public List<IKilometersCard> KilometersCards { get; set; }
    }
}
