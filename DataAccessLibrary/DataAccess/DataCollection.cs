using DelegationLibrary.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DelegationLibrary.DataAccess
{
    [Serializable]
    public class DataCollection : IDataCollection
    {
        public ICollection<IAddress> Addresses { get; set; }
        public ICollection<IBusinessTrip> BusinessTrips { get; set; }
        public ICollection<ICar> Cars { get; set; }
        public ICollection<ICompany> Companies { get; set; }
        public ICollection<IDestination> Destinations { get; set; }
        public ICollection<IDriver> Drivers { get; set; }
        public ICollection<IEmployee> Employees { get; set; }
        public ICollection<IKilometersCard> KilometersCards { get; set; }
        public ICollection<IProject> Projects { get; set; }

    }
}
