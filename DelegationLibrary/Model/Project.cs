using System;
using System.Collections.Generic;
using System.Text;

namespace DelegationLibrary.Model
{
    public class Project
    {
        public int ProjectID { get; set; }
        public string Symbol { get; set; }
        public string Company { get; set; }
        public string Title { get; set; }
        public List<BusinessTrip> Trips { get; set; }
    }
}
