using System.Collections.Generic;

namespace DelegationLibrary.Model
{
    public interface ICar
    {
        int CarID { get; set; }
        List<IKilometersCard> KilometersCards { get; set; }
        IDriver MainDriver { get; set; }
        int MeterStatus { get; set; }
        string Model { get; set; }
        string RegistrationNumber { get; set; }
    }
}