using DelegationLibrary.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DelegationLibrary.DataAccess
{
    public class DataCollection : IDataCollection
    {
        public IEnumerable<IAddress> Addresses { get; set; }
        public IEnumerable<IBusinessTrip> BusinessTrips { get; set; }
        public IEnumerable<ICar> Cars { get; set; }
        public IEnumerable<ICompany> Companies { get; set; }
        public IEnumerable<IDestination> Destinations { get; set; }
        public IEnumerable<IDriver> Drivers { get; set; }
        public IEnumerable<IEmployee> Employees { get; set; }
        public IEnumerable<IKilometersCard> KilometersCards { get; set; }
        public IEnumerable<IProject> Projects { get; set; }

    }
}
