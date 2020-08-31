using Delegation.ViewModels;
using DelegationLibrary.DataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.DirectoryServices.ActiveDirectory;
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
        ListViewModel _viewModel;

        public MainWindow()
        {
            SetupApplication();

            InitializeComponent();
        }

        private void SetupApplication()
        {
            IDataLoader dataLoader = new FakeLoader();
            _dataCollection = DataAccess.GetCollection(dataLoader);

            _viewModel = new ListViewModel(_dataCollection);
        }

        private void DisplayKilometerCardSummaryInTextBox()
        {
            textBox.Text = "";
            foreach (var d in _dataCollection.KilometersCards)
            {
                textBox.Text += $"{ d.CardSymbol } dla { d.Car }.\nKierowca: { d.Car.MainDriver }\n\nLista wyjazdów:\n";
            }
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void KilometerCard_Button_Click(object sender, RoutedEventArgs e)
        {
            DisplayKilometerCardSummaryInTextBox();

            var businessTrips = _viewModel.BusinessTrips;
            businessTrips.DisplayBusinessTrips(dataGrid);
        }
    }
}
