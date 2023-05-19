using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex03.GarageLogic
{
    internal class Garage
    {
        internal class GaragedVehicle
        {
            public Vehicle Vehicle { get; set; }
            public string OwnerName { get; set; }
            public string Status { get; set; }
        }
        public Dictionary<string, GaragedVehicle> VehiclesInGarage { get; set; }

        public Garage()
        {
            VehiclesInGarage = new Dictionary<string, GaragedVehicle>();
        }
        public bool isVehicleInGarage(string i_id)
        {
            return VehiclesInGarage.ContainsKey(i_id);
        }

        public void Add(GaragedVehicle i_VehicleToAdd)
        {
            VehiclesInGarage[i_VehicleToAdd.Vehicle.PlateNumber] = i_VehicleToAdd;
        }
    }
}
