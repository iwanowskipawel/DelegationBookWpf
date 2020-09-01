using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DelegationLibrary.Model
{
    [Serializable]
    public class Destination : IDestination
    {
        [Display(Name = "DestinationID")]
        public int DestinationID { get; set; }

        [Display(Name = "Nazwa")]
        public string Name { get; set; }

        [Display(Name = "Adres")]
        public IAddress Address { get; set; }

        [Display(Name = "Wyjazdy")]
        public List<IBusinessTrip> Trips { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
