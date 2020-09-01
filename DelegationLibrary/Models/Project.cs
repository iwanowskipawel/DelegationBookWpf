using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DelegationLibrary.Model
{
    [Serializable]
    public class Project : IProject
    {
        [Display(Name = "ProjectID")]
        public int ProjectID { get; set; }

        [Display(Name = "Symbol")]
        public string Symbol { get; set; }

        [Display(Name = "Firma")]
        public string Company { get; set; }

        [Display(Name = "Tytuł")]
        public string Title { get; set; }

        [Display(Name = "Wyjazdy")]
        public List<IBusinessTrip> Trips { get; set; }

        public override string ToString() => Symbol;
    }
}
