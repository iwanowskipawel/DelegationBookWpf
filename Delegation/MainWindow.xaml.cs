using DataAccessLibrary.DataAccess;
using Delegation.ViewModels;
using Delegation.Views;
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
        string _currentDirectory = Environment.CurrentDirectory;

        public MainWindow()
        {
            InitializeComponent();
            SetupApplication();
        }

        private void SetupApplication()
        {
            IDataLoader dataLoader = new FakeLoader();
            
            //IDataLoader dataLoader = new ObjectLoader($"{ _currentDirectory }\\DelegationData.ddc");
            _dataCollection = DataAccess.GetCollection(dataLoader);
            //DataAccess.SaveCollection(_dataCollection, dataLoader);

            KilometersCard_ComboBox.ItemsSource = _dataCollection.KilometersCards;
            KilometersCard_ComboBox.SelectedItem = _dataCollection.KilometersCards.FirstOrDefault();

            projects_ComboBox.ItemsSource = _dataCollection.Projects;
            projects_ComboBox.SelectedItem = _dataCollection.Projects.FirstOrDefault();
        }

        private void DisplayKilometerCard(string cardSymbol)
        {
            var card = _dataCollection.KilometersCards.FirstOrDefault(k => k.CardSymbol == cardSymbol);
            var trips = card.Trips;
            DisplayKilometerCardSummaryInTextBox(card);
            trips.DisplayIn(dataGrid);
        }

        private void DisplayProject(string symbol)
        {
            var project = _dataCollection.Projects.FirstOrDefault(k => k.Symbol == symbol);
            DisplayProjectSummaryInTextBox(project);

            IEnumerable<IBusinessTrip> trips = _dataCollection.BusinessTrips
                .Where(t => t.Project.ProjectID == project.ProjectID);

            trips.DisplayIn(projects_dataGrid);
        }

        private void KilometersCard_ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedCard = KilometersCard_ComboBox.SelectedItem;
            DisplayKilometerCard(selectedCard.ToString());
        }

        private void Project_ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedProject = projects_ComboBox.SelectedItem;
            DisplayProject(selectedProject.ToString());
        }

        private void DisplayKilometerCardSummaryInTextBox(IKilometersCard card)
        {
            textBox.Text = "";
            textBox.Text += $"{ card.CardSymbol } dla { card.Car }.\nKierowca: { card.Car.MainDriver }";
        }

        private void DisplayProjectSummaryInTextBox(IProject project)
        {
            projects_textBox.Text = "";
            projects_textBox.Text += $"{ project.Symbol } dla { project.Company }.\nTytuł: { project.Title }";
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void AddKilometerCard_Button_Click(object sender, RoutedEventArgs e)
        {
            EditKilometersCard addCardWindow = new EditKilometersCard(new KilometersCard());
            addCardWindow.CarSelection_comboBox.ItemsSource = _dataCollection.Cars;

            addCardWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            addCardWindow.ShowDialog();

            if (addCardWindow.Success)
            {
                IKilometersCard card = addCardWindow.KilometersCard;
                card.KilometerCardID = _dataCollection.KilometersCards.Count + 1;
                card.Trips = new List<IBusinessTrip>();

                _dataCollection.KilometersCards.Add(card);
            }

        }

        private void AddTrip_Button_Click(object sender, RoutedEventArgs e)
        {
            AddTrip addTrip = new AddTrip((IKilometersCard)KilometersCard_ComboBox.SelectedItem);
            addTrip.Driver_ComboBox.ItemsSource = _dataCollection.Drivers;
            addTrip.Project_ComboBox.ItemsSource = _dataCollection.Projects;
            addTrip.Keeper_ComboBox.ItemsSource = _dataCollection.Employees;
            addTrip.Destination_ComboBox.ItemsSource = _dataCollection.Destinations;
            addTrip.Show();
        }
    }
}
