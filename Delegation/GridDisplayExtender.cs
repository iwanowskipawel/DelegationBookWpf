using Delegation.ViewModels;
using DelegationLibrary.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Data;

namespace Delegation
{
    public static class GridDisplayExtender
    {
        public static void DisplayBusinessTrips(this ObservableCollection<BusinessTripViewModel> dataModel, DataGrid dataGrid)
        {
            dataGrid.Columns.Clear();
            dataGrid.AutoGenerateColumns = false;

            var defaultTrip = dataModel.FirstOrDefault();
            var tripProperties = defaultTrip.GetType().GetProperties();

            dataGrid.ItemsSource = dataModel;

            foreach (var property in tripProperties)
            {
                DataGridTextColumn col = new DataGridTextColumn()
                {
                    Header = AttributeImporter.GetDisplayName(defaultTrip, property),
                    Binding = new Binding(property.Name) { Mode = BindingMode.OneWay }, Width = DataGridLength.Auto            
                };
                dataGrid.Columns.Add(col);
            }
        }

        public static void DisplayBusinessTrips(this IEnumerable<IBusinessTrip> trips, DataGrid dataGrid)
        {
            var businessTrips = new ObservableCollection<BusinessTripViewModel>();
            foreach (var trip in trips)
            {
                businessTrips.Add(new BusinessTripViewModel(trip));
            }

            businessTrips.DisplayBusinessTrips(dataGrid);
        }
    }
}
