using System.Collections.Generic;

namespace DelegationLibrary.Model
{
    public interface IDestination
    {
        IAddress Address { get; set; }
        int DestinationID { get; set; }
        string Name { get; set; }
        List<IBusinessTrip> Trips { get; set; }
    }
}