using System.Collections.Generic;

namespace DelegationLibrary.Model
{
    public interface IDriver
    {
        int DriverID { get; set; }
        List<ICar> UsedCars { get; set; }
    }
}