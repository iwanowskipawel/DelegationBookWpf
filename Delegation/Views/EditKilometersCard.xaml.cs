using DelegationLibrary.DataAccess;
using DelegationLibrary.Model;
using System;
using System.Collections.Generic;
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
    /// Interaction logic for AddKilometersCard.xaml
    /// </summary>
    public partial class EditKilometersCard : Window
    {
        public IKilometersCard KilometersCard { get; set; }
        public bool Success { get; private set; } = false;
        public EditKilometersCard()
        {
            InitializeComponent();
        }

        public EditKilometersCard(IKilometersCard card)
        {
            InitializeComponent();
            KilometersCard = card;
            CarSelection_comboBox.SelectedItem = KilometersCard.Car;
        }

        private void Cancel_button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Save_Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                KilometersCard.Car = (ICar)CarSelection_comboBox.SelectedItem;
                KilometersCard.CardSymbol = CardSymbol_textBox.Text;
                KilometersCard.WorkCardNumber = WorkCardNumber_textBox.Text;

                Success = true;
            }
            catch(Exception ex)
            {
                throw new Exception("Błąd przy zapisie Karty Kilometrowej", ex);
            }
            this.Close();
        }

        private void AddCar_button_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
