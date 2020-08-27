using System.Collections.Generic;

namespace DelegationLibrary.Model
{
    public interface IKilometersCard
    {
        ICar Car { get; set; }
        string CardSymbol { get; set; }
        string WorkCardNumber { get; set; }
        int KilometerCardID { get; set; }
        int TotalDistance { get; }
        List<IBusinessTrip> Trips { get; set; }
    }
}