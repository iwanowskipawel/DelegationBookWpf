using DelegationLibrary.DataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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
        }

        private void SetupApplication()
        {
            IDataLoader dataLoader = new FakeLoader();
            _dataCollection = DataAccess.GetCollection(dataLoader);

            DisplayFakeDataInTextBox();
        }

        private void DisplayFakeDataInTextBox()
        {
            textBox.Text = "";
            foreach (var d in _dataCollection.KilometersCards)
            {
                textBox.Text += $"{ d.CardSymbol } dla { d.Car.Model } { d.Car.RegistrationNumber }.\nLista wyjazdów:";
                foreach (var t in d.Trips)
                {
                    textBox.Text += $"{ t.DepartureDate } - { t.ArrivalDate } do { t.Destination } - ilość przejechanych km: { t.Distance }";
                }
            }
        }
    }
}
