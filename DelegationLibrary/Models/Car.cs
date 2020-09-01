using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DelegationLibrary.Model
{
    [Serializable]
    public class Car : ICar
    {
        [Display(Name = "CarID")]
        public int CarID { get; set; }

        [Display(Name = "Model")]
        public string Model { get; set; }

        [Display(Name = "Numer rejestracyjny")]
        public string RegistrationNumber { get; set; }

        [Display(Name = "Główny kierowca")]
        public IDriver MainDriver { get; set; }

        [Display(Name = "Stan licznika")]
        public int MeterStatus { get; set; }

        [Display(Name = "Karty przejechanych km")]
        public List<IKilometersCard> KilometersCards { get; set; }

        public override string ToString()
        {
            return $"{ Model } { RegistrationNumber }";
        }
    }
}
