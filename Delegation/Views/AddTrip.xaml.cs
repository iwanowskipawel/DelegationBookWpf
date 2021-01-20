using DelegationLibrary.DataAccess;
using DelegationLibrary.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Delegation.Views
{
    /// <summary>
    /// Interaction logic for AddTrip.xaml
    /// </summary>
    public partial class AddTrip : Window
    {
        IKilometersCard _kilometersCard;
        int nextID;
        public AddTrip(IKilometersCard card)
        {
            InitializeComponent();
            _kilometersCard = card;
            nextID = _kilometersCard.Trips.Count + 1;
            BusinessTripID_TextBlock.Text = nextID.ToString();
        }

        private void Save_Button_Click(object sender, RoutedEventArgs e)
        {

            _kilometersCard.Trips.Add(new BusinessTrip
            {
                BusinessTripID = nextID,
                DepartureDate = Departure_DataPicker.SelectedDate.Value,
                ArrivalDate = Arrival_DataPicker.SelectedDate.Value,
                Driver = (IDriver)Driver_ComboBox.SelectedItem,
                Destination = (IDestination)Destination_ComboBox.SelectedItem,
                InitialMeter = int.Parse(InitialMeter_TextBox.Text),
                FinalMeter = int.Parse(FinalMeter_TextBox.Text),
                Keeper = (IEmployee)Keeper_ComboBox.SelectedItem,
                Project = (IProject)Project_ComboBox.SelectedItem
            }) ;

            this.Close();
        }

        private void Cancel_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
