using System.Collections.Generic;

namespace DelegationLibrary.Model
{
    public interface IProject
    {
        string Company { get; set; }
        int ProjectID { get; set; }
        string Symbol { get; set; }
        string Title { get; set; }
        List<IBusinessTrip> Trips { get; set; }
    }
}