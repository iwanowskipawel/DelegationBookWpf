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
        public AddTrip(IKilometersCard card)
        {
            InitializeComponent();
            _kilometersCard = card;
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            _kilometersCard.Trips.Add(new BusinessTrip { BusinessTripID = 3 });
        }
    }
}
