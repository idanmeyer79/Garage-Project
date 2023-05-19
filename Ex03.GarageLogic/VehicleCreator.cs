using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex03.GarageLogic
{
    internal class VehicleCreator
    {
        public Car BuildElectricCar()
        {
            return new Car("electric");
        }

        public Car BuildDieselCar()
        {
            return new Car("diesel");
        }

        public Motorcycle BuildElectricMotorcycle()
        {
            return new Motorcycle("electric");
        }

        public Motorcycle BuildDieselMotorcycle()
        {
            return new Motorcycle("diesel");
        }

        public Truck BuildTruck()
        {
            return new Truck();
        }
    }
}
