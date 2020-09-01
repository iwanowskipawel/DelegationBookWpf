using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace DelegationLibrary.Model
{
    [Serializable]
    public class KilometersCard : IKilometersCard
    {
        [Display(Name = "KilometerCardID")]
        public int KilometerCardID { get; set; }

        [Display(Name = "Nr karty")]
        public string CardSymbol { get; set; }

        [Display(Name = "Samochód", AutoGenerateField = true)]
        public ICar Car { get; set; }

        [Display(Name = "Karta pracy pojazdu")]
        public string WorkCardNumber { get; set; }

        [Display(Name = "Wyjazdy", AutoGenerateField = true)]
        public List<IBusinessTrip> Trips { get; set; }

        [Display(Name = "Przejechany dystans")]
        public int TotalDistance => Trips.Sum(x => x.Distance);

        public override string ToString()
        {
            return CardSymbol;
        }
    }
}
