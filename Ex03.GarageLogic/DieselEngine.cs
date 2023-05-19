using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex03.GarageLogic
{
    internal class DieselEngine
    {
        public enum eFuelType
        {
            Soler,
            Octan95,
            Octan96,
            Octan98
        }

        private eFuelType m_FuelType;
        private float m_FuelAmount;
        private float m_MaxFuelAmount;

        private void fillTank(eFuelType i_FuelType, float i_FuelToAdd) {}
    }
}
