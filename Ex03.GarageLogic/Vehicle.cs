using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex03.GarageLogic
{
    public abstract class Vehicle
    {
        public string Model { get; set; }
        public string PlateNumber { get; set; }
        public float EnergyPrecentleft { get; set; }
        public List<Wheel> Wheels { get; set; }
        public Engine Engine { get; set; }

        protected Vehicle(string i_Type)
        {
            if (i_Type == "electric")
            {
                Engine = new ElectricEngine();
            }
            else
            {
                Engine = new DieselEngine();
            }
        }
    }
}
