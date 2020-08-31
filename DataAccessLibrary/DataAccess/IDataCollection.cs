using DelegationLibrary.Model;
using System.Collections.Generic;

namespace DelegationLibrary.DataAccess
{
    public interface IDataCollection
    {
        IEnumerable<IAddress> Addresses { get; set; }
        IEnumerable<IBusinessTrip> BusinessTrips { get; set; }
        IEnumerable<ICar> Cars { get; set; }
        IEnumerable<ICompany> Companies { get; set; }
        IEnumerable<IDestination> Destinations { get; set; }
        IEnumerable<IDriver> Drivers { get; set; }
        IEnumerable<IEmployee> Employees { get; set; }
        IEnumerable<IKilometersCard> KilometersCards { get; set; }
        IEnumerable<IProject> Projects { get; set; }
    }
}