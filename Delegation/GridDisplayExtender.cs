using Delegation.ViewModels;
using DelegationLibrary.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Data;

namespace Delegation
{
    public static class GridDisplayExtender
    {
        public static void DisplayInGrid(this BusinessTripsListViewModel dataModel, DataGrid dataGrid)
        {
            dataGrid.Columns.Clear();
            dataGrid.AutoGenerateColumns = false;

            var defaultTrip = dataModel.Trips.FirstOrDefault();
            var tripProperties = defaultTrip.GetType().GetProperties();

            dataGrid.ItemsSource = dataModel.Trips;

            foreach (var property in tripProperties)
            {
                DataGridTextColumn col = new DataGridTextColumn()
                {
                    Header = AttributeImporter.GetDisplayName(defaultTrip, property),
                    Binding = new Binding(property.Name) { Mode = BindingMode.OneWay }
                };
                dataGrid.Columns.Add(col);
            }
        }
    }
}
