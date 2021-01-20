using DelegationLibrary.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DelegationLibrary.DataAccess
{
    public class FakeLoader : IDataLoader
    {
        public IDataCollection Load()
        {
            IDriver wieslaw = new Driver()
            {
                EmployeeID = 1,
                FirstName = "Wiesław",
                LastName = "Eychler"
            };
            IEmployee pawelI = new Employee()
            {
                EmployeeID = 2,
                FirstName = "Paweł",
                LastName = "Iwanowski"
            };
            IEmployee pawelP = new Employee()
            {
                EmployeeID = 3,
                FirstName = "Paweł",
                LastName = "Pietruszewski"
            };

            IProject project1 = new Project()
            {
                ProjectID = 1,
                Symbol = "0-6541-24-1-00"
            };
            IProject project2 = new Project()
            {
                ProjectID = 2,
                Symbol = "0-6666-24-1-00"
            };
            
            IBusinessTrip trip1 = new BusinessTrip()
            {
                BusinessTripID = 1,
                DepartureDate = new DateTime(2020, 7, 13),
                ArrivalDate = new DateTime(2020, 7, 15),
                Driver = wieslaw,
                Destination = new Destination()
                {
                    DestinationID = 1,
                    Name = "Gdańsk"
                },
                InitialMeter = 353677,
                FinalMeter = 354456,
                Keeper = pawelI,
                Project = project1
            };
            IBusinessTrip trip2 = new BusinessTrip()
            {
                BusinessTripID = 2,
                DepartureDate = new DateTime(2020, 7, 16),
                ArrivalDate = new DateTime(2020, 7, 17),
                Driver = wieslaw,
                Destination = new Destination()
                {
                    DestinationID = 2,
                    Name = "Kraków"
                },
                InitialMeter = 354456,
                FinalMeter = 355273,
                Keeper = pawelP,
                Project = project2
            };
            IBusinessTrip trip3 = new BusinessTrip()
            {
                BusinessTripID = 3,
                DepartureDate = new DateTime(2020, 7, 22),
                ArrivalDate = new DateTime(2020, 7, 25),
                Driver = wieslaw,
                Destination = new Destination()
                {
                    DestinationID = 2,
                    Name = "Leźnica"
                },
                InitialMeter = 355273,
                FinalMeter = 355578,
                Keeper = pawelP,
                Project = project2
            };
            ICar car = new Car()
            {
                CarID = 1,
                Model = "Ford Transit",
                RegistrationNumber = "WB 65788",
                MainDriver = wieslaw,
                MeterStatus = 354456
            };

            IDataCollection output = new DataCollection()
            {
                Drivers = new List<IDriver>() { wieslaw },
                Employees = new List<IEmployee>() { pawelI, pawelP },
                BusinessTrips = new List<IBusinessTrip>() { trip1, trip2 },
                Projects = new List<IProject>() { project1, project2 },
                KilometersCards = new List<IKilometersCard>() {
                    new KilometersCard() {
                        KilometerCardID = 1,
                        Car = car,
                        CardSymbol = "7/2020",
                        WorkCardNumber = "456",
                        Trips = new List<IBusinessTrip>() { trip1, trip2 }
                    },
                    new KilometersCard() {
                        KilometerCardID = 2,
                        Car = car,
                        CardSymbol = "8/2020",
                        WorkCardNumber = "457",
                        Trips = new List<IBusinessTrip>() { trip3 }
                    }
                }
            };

            return output;
        }

        public bool Save(IDataCollection collection) { return true; }
    }
}
