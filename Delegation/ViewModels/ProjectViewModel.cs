using DelegationLibrary.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Delegation.ViewModels
{
    public class ProjectViewModel
    {
        [Display(Name = "ID")]
        public int ProjectID { get; set; }

        [Display(Name = "Symbol")]
        public string Symbol { get; set; }

        [Display(Name = "Firma")]
        public string Company { get; set; }

        [Display(Name = "Tytuł")]
        public string Title { get; set; }

        //[Display(Name = "Wyjazdy")]
        //public List<IBusinessTrip> Trips { get; set; }
    }
}
