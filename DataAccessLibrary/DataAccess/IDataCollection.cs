using DelegationLibrary.Model;
using System.Collections.Generic;
using System.Linq;

namespace DelegationLibrary.DataAccess
{
    public interface IDataCollection
    {
        ICollection<IAddress> Addresses { get; set; }
        ICollection<IBusinessTrip> BusinessTrips { get; set; }
        ICollection<ICar> Cars { get; set; }
        ICollection<ICompany> Companies { get; set; }
        ICollection<IDestination> Destinations { get; set; }
        ICollection<IDriver> Drivers { get; set; }
        ICollection<IEmployee> Employees { get; set; }
        ICollection<IKilometersCard> KilometersCards { get; set; }
        ICollection<IProject> Projects { get; set; }
    }
}