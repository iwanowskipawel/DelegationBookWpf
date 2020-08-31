using DelegationLibrary.DataAccess;
using DelegationLibrary.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Delegation.ViewModels
{
    public class ListViewModel
    {
        public ObservableCollection<BusinessTripViewModel> BusinessTrips { get; private set; } = new ObservableCollection<BusinessTripViewModel>();

        public ListViewModel(IDataCollection data)
        {
            foreach (var trip in data.BusinessTrips)
            {
                BusinessTrips.Add(new BusinessTripViewModel(trip));
            }
        }

    }
}
