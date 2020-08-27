using System;

namespace DelegationLibrary.Model
{
    public interface IBusinessTrip
    {
        DateTime ArrivalDate { get; set; }
        int BusinessTripID { get; set; }
        DateTime DepartureDate { get; set; }
        IDestination Destination { get; set; }
        int Distance { get; }
        IDriver Driver { get; set; }
        int FinalMeter { get; set; }
        int InitialMeter { get; set; }
        IEmployee Keeper { get; set; }
        IProject Project { get; set; }
    }
}