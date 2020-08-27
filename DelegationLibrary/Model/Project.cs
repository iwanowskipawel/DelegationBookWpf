using System;
using System.Collections.Generic;
using System.Text;

namespace DelegationLibrary.Model
{
    public class Project : IProject
    {
        public int ProjectID { get; set; }
        public string Symbol { get; set; }
        public string Company { get; set; }
        public string Title { get; set; }
        public List<IBusinessTrip> Trips { get; set; }
    }
}
