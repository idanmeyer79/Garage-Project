using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex03.GarageLogic
{
    internal class GarageManager
    {
        private Garage m_garage;

        public GarageManager()
        {
            m_garage = new Garage();
        }

        public void EnterNewCar(string i_licensePlate)
        {
            if (m_garage.isVehicleInGarage(i_licensePlate))
            {
                // Car already exists in the garage, set its status to "Under repair"
                Garage.GaragedVehicle existingCar = m_garage.VehiclesInGarage[i_licensePlate];
                existingCar.Status = "Under repair";
                Console.WriteLine("Car is already in the garage. Setting status to 'Under repair'.");
            }
            else
            {
                string vehicleType = PromptUserForVehicleType();
                Garage.GaragedVehicle vehicleToAdd = null;
                if (vehicleType.ToLower() == "electric car")
                {
                    vehicleToAdd = addElecricCar();
                }
                else if (vehicleType.ToLower() == "Diesel car")
                {
                    vehicleToAdd = addDieselCar();
                }
                else if (vehicleType.ToLower() == "truck")
                {
                    vehicleToAdd = addTruck();
                }
                else if (vehicleType.ToLower() == "electric motorcycle")
                {
                    vehicleToAdd = addElecricMotorcycle();
                }
                else if (vehicleType.ToLower() == "diesel motorcycle")
                {
                    vehicleToAdd = addDieselMotorcycle(); ;
                }
                else
                {
                    Console.WriteLine("Invalid vehicle type.");
                }

                if(vehicleToAdd != null)
                {
                    m_garage.Add(vehicleToAdd);
                }
            }
        }

        private Garage.GaragedVehicle AddElectricCar()
        {
            // Prompt the user for electric car details and create a new Garage.GaragedVehicle object
            // ...
            return new Garage.GaragedVehicle(/* vehicle details */);
        }

        private Garage.GaragedVehicle AddDieselCar()
        {
            // Prompt the user for diesel car details and create a new Garage.GaragedVehicle object
            // ...
            return new Garage.GaragedVehicle(/* vehicle details */);
        }

        private Garage.GaragedVehicle AddTruck()
        {
            // Prompt the user for truck details and create a new Garage.GaragedVehicle object
            // ...
            return new Garage.GaragedVehicle(/* vehicle details */);
        }

        private Garage.GaragedVehicle AddElectricMotorcycle()
        {
            // Prompt the user for electric motorcycle details and create a new Garage.GaragedVehicle object
            // ...
            return new Garage.GaragedVehicle(/* vehicle details */);
        }

        private Garage.GaragedVehicle AddDieselMotorcycle()
        {
            // Prompt the user for diesel motorcycle details and create a new Garage.GaragedVehicle object
            // ...
            return new Garage.GaragedVehicle(/* vehicle details */);
        }


        private string PromptUserForVehicleType()
        {
            Console.WriteLine("Enter the vehicle type (Car, Motorcycle, Truck, etc.): ");
            string vehicleType = Console.ReadLine();
            return vehicleType;
        }

        private Vehicle CreateNewVehicle(string vehicleType)
        {
            // Create a new vehicle based on the provided type and prompt the user for its details
            // You can customize this method based on the properties and behavior of your Vehicle class
            Vehicle newVehicle = new Vehicle();
            newVehicle.Type = vehicleType;
            PromptUserForVehicleDetails(newVehicle);
            return newVehicle;
        }

        private void PromptUserForVehicleDetails(Vehicle vehicle)
        {
            // Prompt the user for vehicle details such as fuel amount, tire pressure, color, etc.
            // You can customize this method based on the properties and behavior of your Vehicle class
            Console.WriteLine("Enter the vehicle details:");
            Console.WriteLine("Fuel amount: ");
            vehicle.FuelAmount = int.Parse(Console.ReadLine());

            Console.WriteLine("Tire pressure (enter the same value for all tires): ");
            int tirePressure = int.Parse(Console.ReadLine());
            vehicle.SetTirePressure(tirePressure);

            // Prompt for other details based on the specific vehicle type
            // ...

            Console.WriteLine("Vehicle details entered.");
        }
    }
}
