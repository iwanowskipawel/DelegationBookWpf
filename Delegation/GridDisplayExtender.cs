using DelegationLibrary.Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Data;

namespace Delegation
{
    public static class GridDisplayExtender
    {
        public static void DisplayInGrid(this IEnumerable<IBusinessTrip> trips, DataGrid dataGrid)
        {
            dataGrid.Columns.Clear();
            dataGrid.AutoGenerateColumns = false;

            var defaultTrip = trips.FirstOrDefault();
            var tripProperties = defaultTrip.GetType().GetProperties();

            dataGrid.ItemsSource = trips;

            foreach (var property in tripProperties)
            {
                DataGridTextColumn col = new DataGridTextColumn()
                {
                    Header = AttributeImporter.GetDisplayName(defaultTrip, property),
                    Binding = new Binding(property.Name)
                };
                dataGrid.Columns.Add(col);
            }
        }
    }
}
