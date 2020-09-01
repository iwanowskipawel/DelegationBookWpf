using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace DelegationLibrary.Model
{
    [Serializable]
    public class BusinessTrip : IBusinessTrip
    {
        [Display(Name = "BusinessTripID")]
        public int BusinessTripID { get; set; }

        [Display(Name = "Wyjazd")]
        public DateTime DepartureDate { get; set; }

        [Display(Name = "Przyjazd")]
        public DateTime ArrivalDate { get; set; }

        [Display(Name = "Kierowca")]
        public IDriver Driver { get; set; }

        [Display(Name = "Temat", AutoGenerateField = true)]
        public IProject Project { get; set; }

        [Display(Name = "Dysponent", AutoGenerateField = true)]
        public IEmployee Keeper { get; set; }

        [Display(Name = "Miejsce docelowe", AutoGenerateField = true)]
        public IDestination Destination { get; set; }

        [Display(Name = "Stan licznika początkowy")]
        public int InitialMeter { get; set; }

        [Display(Name = "Stan licznika końcowy")]
        public int FinalMeter { get; set; }

        [Display(Name = "Liczba przejechanych km")]
        public int Distance => FinalMeter - InitialMeter;

        public IKilometersCard KilometersCard { get; set; }
    }
}
