using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex03.GarageLogic
{
    public class Motorcycle : Vehicle
    {
        public enum eLicenseLevel
        {
            A1,
            A2,
            AA,
            B1
        }

        private int m_EngineSize;
        private eLicenseLevel m_LicenseLevel;

        public Motorcycle(string i_Type) : base(i_Type)
        {

        }



    }
}
