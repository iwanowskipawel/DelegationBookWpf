using DelegationLibrary.Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Windows.Controls;
using System.Windows.Data;

namespace Delegation
{
    public static class GridDisplayExtender
    {
        public static void DisplayInGrid(this IEnumerable<IBusinessTrip> trips, DataGrid dataGrid)
        {
            dataGrid.AutoGenerateColumns = false;
            var tripInstance = trips.FirstOrDefault();
            ObservableCollection<IBusinessTrip> tripsObs = new ObservableCollection<IBusinessTrip>(trips);

            var tripProperties = tripInstance.GetType().GetProperties();

            dataGrid.ItemsSource = trips;

            foreach (var property in tripProperties)
            {
                DataGridTextColumn col = new DataGridTextColumn()
                {
                    Header = GetDisplayName(tripInstance, property),
                    Binding = new Binding(property.Name)
                };
                dataGrid.Columns.Add(col);
            }
        }

        private static string GetDisplayName(object instance, PropertyInfo propertyInfo)
        {
            string output = "";
            var attr = GetDisplayAttribute(instance, propertyInfo.Name);
            if (attr != null)
            {
                output = attr.Name;
            }
            return output;
        }

        private static DisplayAttribute GetDisplayAttribute(object instance, string name)
        {
            DisplayAttribute output;

            var attributeType = typeof(DisplayAttribute);
            var prop = instance.GetType().GetProperty(name);

            output = (DisplayAttribute)prop.GetCustomAttributes(attributeType, false).FirstOrDefault();

            return output;
        }
    }
}
