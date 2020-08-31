using DelegationLibrary.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Delegation.ViewModels
{
    public class BusinessTripsListViewModel
    {
        public ObservableCollection<BusinessTripViewModel> Trips { get; private set; } = new ObservableCollection<BusinessTripViewModel>();

        public BusinessTripsListViewModel(IEnumerable<IBusinessTrip> trips)
        {
            foreach (var trip in trips)
            {
                Trips.Add(new BusinessTripViewModel(trip));
            }
        }

    }
}
