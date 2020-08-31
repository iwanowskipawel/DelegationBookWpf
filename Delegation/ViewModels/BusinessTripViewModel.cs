using DelegationLibrary.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Delegation.ViewModels
{
    public class BusinessTripViewModel
    {
        IBusinessTrip _trip;
        public BusinessTripViewModel(IBusinessTrip trip)
        {
            _trip = trip;
        }

        [Display(Name = "ID")]
        public int BusinessTripID => _trip.BusinessTripID;

        [Display(Name = "Wyjazd")]
        public string DepartureDate => _trip.DepartureDate.ToShortDateString();

        [Display(Name = "Przyjazd")]
        public string ArrivalDate => _trip.ArrivalDate.ToShortDateString();

        [Display(Name = "Kierowca")]
        public string Driver => _trip.Driver.ToString();

        [Display(Name = "Temat", AutoGenerateField = true)]
        public string Project => _trip.Project.Symbol;

        [Display(Name = "Dysponent", AutoGenerateField = true)]
        public string Keeper => _trip.Keeper.ToString();

        [Display(Name = "Miejsce docelowe", AutoGenerateField = true)]
        public string Destination => _trip.Destination.ToString();

        [Display(Name = "Stan licznika początkowy")]
        public int InitialMeter => _trip.InitialMeter;

        [Display(Name = "Stan licznika końcowy")]
        public int FinalMeter => _trip.FinalMeter;

        [Display(Name = "Liczba przejechanych km")]
        public int Distance => FinalMeter - InitialMeter;
    }
}
