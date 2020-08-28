using DelegationLibrary.DataAccess;
using DelegationLibrary.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Delegation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IDataCollection _dataCollection;
        public MainWindow()
        {
            SetupApplication();

            InitializeComponent();

            DisplayFakeDataInTextBox();
            DisplayFakeDataInDataGrid();
        }

        private void SetupApplication()
        {
            IDataLoader dataLoader = new FakeLoader();
            _dataCollection = DataAccess.GetCollection(dataLoader);
        }

        private void DisplayFakeDataInTextBox()
        {
            textBox.Text = "";
            foreach (var d in _dataCollection.KilometersCards)
            {
                textBox.Text += $"{ d.CardSymbol } dla { d.Car }.\nKierowca: { d.Car.MainDriver }\n\nLista wyjazdów:\n";
                foreach (var t in d.Trips)
                {
                    textBox.Text += $"{ t.DepartureDate } - { t.ArrivalDate } do { t.Destination.Name } - ilość przejechanych km: { t.Distance }\n";
                }
            }
        }

        private void DisplayFakeDataInDataGrid()
        {
            var tripInstance = _dataCollection.BusinessTrips.FirstOrDefault();

            List<string> tripPropertiesNames = CollectAllDisplayNamesFrom(tripInstance);

            dataGrid.AutoGenerateColumns = false;

            dataGrid.ItemsSource = _dataCollection.BusinessTrips;
            
            dataGrid.Columns.Add(new DataGridTextColumn() { Header = tripPropertiesNames[1] });

        }

        private List<string> CollectAllDisplayNamesFrom(object instance)
        {
            List<string> output = new List<string>();

            var tripProperties = instance.GetType().GetProperties();
            foreach (var p in tripProperties)
            {
                var attr = GetDisplayAttribute(instance, p.Name);
                if (attr == null)
                {
                    output.Add("");
                }
                else
                {
                    output.Add(attr.Name);
                }
            }

            return output;
        }

        private DisplayAttribute GetDisplayAttribute(object instance, string name)
        {
            DisplayAttribute output;

            var attributeType = typeof(DisplayAttribute);
            var prop = instance.GetType().GetProperty(name);

            output = (DisplayAttribute)prop.GetCustomAttributes(attributeType, false).FirstOrDefault();
            
            return output;
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
