using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex03.GarageLogic
{
    internal class Wheel
    {
        private string m_manufacturer;
        public int MaxTierPressure { get; set; }
        public int CurrentTierPressure { get; private set; }

        public void Inflate(int i_pressure)
        {
            if (i_pressure > MaxTierPressure)
            {
                throw new InvalidOperationException();
            }

            CurrentTierPressure = i_pressure;
        }

    }
}
