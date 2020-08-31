using DelegationLibrary.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Delegation.ViewModels
{
    public class BusinessTripsListViewModel
    {
        ObservableCollection<BusinessTripViewModel> _trips = new ObservableCollection<BusinessTripViewModel>();

        public BusinessTripsListViewModel(IEnumerable<IBusinessTrip> trips)
        {
            foreach (var trip in trips)
            {
                _trips.Add(new BusinessTripViewModel(trip));
            }
        }

        public ObservableCollection<BusinessTripViewModel> Trips => _trips;
    }
}
