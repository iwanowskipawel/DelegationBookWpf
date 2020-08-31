using Delegation.ViewModels;
using DelegationLibrary.DataAccess;
using DelegationLibrary.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
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
            KilometersCard_ComboBox.ItemsSource = _dataCollection.KilometersCards;
        }

        private void SetupApplication()
        {
            IDataLoader dataLoader = new FakeLoader();
            _dataCollection = DataAccess.GetCollection(dataLoader);
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void KilometerCard_Button_Click(object sender, RoutedEventArgs e)
        {
            var card = _dataCollection.KilometersCards.FirstOrDefault();
            DisplayKilometerCardSummaryInTextBox(card);

            var businessTrips = new ObservableCollection<BusinessTripViewModel>();
            foreach (var trip in card.Trips)
            {
                businessTrips.Add(new BusinessTripViewModel(trip));
            }

            businessTrips.DisplayBusinessTrips(dataGrid);
        }

        private void DisplayKilometerCardSummaryInTextBox(IKilometersCard card)
        {
            textBox.Text = "";
            var d = card;
            textBox.Text += $"{ d.CardSymbol } dla { d.Car }.\nKierowca: { d.Car.MainDriver }";

        }

        private void KilometersCard_ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
