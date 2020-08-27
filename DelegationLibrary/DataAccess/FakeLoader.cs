using DelegationLibrary.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DelegationLibrary.DataAccess
{
    public class FakeLoader : IDataLoader
    {
        public IDataCollection LoadData()
        {
            Employee wieslaw = new Employee()
            {
                EmployeeID = 1,
                FirstName = "Wiesław",
                LastName = "Eychler"
            };
            Employee pawelI = new Employee()
            {
                EmployeeID = 2,
                FirstName = "Paweł",
                LastName = "Iwanowski"
            };
            Employee pawelP = new Employee()
            {
                EmployeeID = 3,
                FirstName = "Paweł",
                LastName = "Pietruszewski"
            };

            DataCollection output = new DataCollection()
            {
                KilometersCards = new List<KilometersCard>() {
                    new KilometersCard() {
                        KilometerCardID = 1,
                        Car = new Car() {
                            CarID = 1,
                            Model = "Ford Transit",
                            RegistrationNumber = "WB 65788",
                            MainDriver = (Driver)wieslaw,
                            MeterStatus = 354456
                        },
                        CardSymbol = "7/2020",
                        CardWorkCardNumber = "456",
                        Trips = new List<IBusinessTrip>()
                        {
                            new BusinessTrip() { 
                                BusinessTripID = 1,
                                DepartureDate = new DateTime(2020, 7, 13),
                                ArrivalDate = new DateTime(2020, 7, 15),
                                Driver = (Driver)wieslaw,
                                Destination = new Destination(){
                                    DestinationID = 1,
                                    Name = "Gdańsk"
                                },
                                InitialMeter = 353677,
                                FinalMeter = 354456,
                                Keeper = pawelI,
                                Project = new Project(){
                                    ProjectID = 1,
                                    Symbol = "0-6541-24-1-00"
                                }
                            },
                            new BusinessTrip() { 
                                BusinessTripID = 2,
                                DepartureDate = new DateTime(2020, 7, 16),
                                ArrivalDate = new DateTime(2020, 7, 17),
                                Driver = (Driver)wieslaw,
                                Destination = new Destination(){
                                    DestinationID = 2,
                                    Name = "Kraków"
                                },
                                InitialMeter = 354456,
                                FinalMeter = 355273,
                                Keeper = pawelP,
                                Project = new Project(){
                                    ProjectID = 1,
                                    Symbol = "0-6666-24-1-00"
                                }
                            }
                        }
                    }
                }
            };

            return output;
        }
    }
}
