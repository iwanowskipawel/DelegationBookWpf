using DataAccessLibrary.DataAccess;
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
            InitializeComponent();
            SetupApplication();

            XmlLoader loader = new XmlLoader("D:\\Delegacje.txt");
            //loader.SaveData(_dataCollection);
        }

        private void SetupApplication()
        {
            //IDataLoader dataLoader = new XmlLoader("D:\\Delegacje.txt");
            IDataLoader dataLoader = new FakeLoader();
            _dataCollection = DataAccess.GetCollection(dataLoader);

            KilometersCard_ComboBox.ItemsSource = _dataCollection.KilometersCards;
            KilometersCard_ComboBox.SelectedItem = _dataCollection.KilometersCards.FirstOrDefault();

            projects_ComboBox.ItemsSource = _dataCollection.Projects;
            projects_ComboBox.SelectedItem = _dataCollection.Projects.FirstOrDefault();
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void DisplayKilometerCard(string cardSymbol)
        {
            var card = _dataCollection.KilometersCards.FirstOrDefault(k => k.CardSymbol == cardSymbol);
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
            textBox.Text += $"{ card.CardSymbol } dla { card.Car }.\nKierowca: { card.Car.MainDriver }";
        }

        private void KilometersCard_ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedCard = KilometersCard_ComboBox.SelectedItem;
            DisplayKilometerCard(selectedCard.ToString());
        }

        private void AddKilometerCard_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Project_ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedProject = projects_ComboBox.SelectedItem;
            DisplayProject(selectedProject.ToString());
        }

        private void DisplayProject(string symbol)
        {
            var project = _dataCollection.Projects.FirstOrDefault(k => k.Symbol == symbol);
            DisplayProjectSummaryInTextBox(project);

            IEnumerable<IBusinessTrip> trips = _dataCollection.BusinessTrips.Where(t => t.Project.ProjectID == project.ProjectID);

            var businessTrips = new ObservableCollection<BusinessTripViewModel>();
            foreach (var trip in trips)
            {
                businessTrips.Add(new BusinessTripViewModel(trip));
            }

            businessTrips.DisplayBusinessTrips(projects_dataGrid);
        }

        private void DisplayProjectSummaryInTextBox(IProject project)
        {
            projects_textBox.Text = "";
            projects_textBox.Text += $"{ project.Symbol } dla { project.Company }.\nTytuł: { project.Title }";
        }
    }
}
