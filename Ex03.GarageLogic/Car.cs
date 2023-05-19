﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex03.GarageLogic
{
    internal abstract class Car : Vehicle
    {
        public enum eColor
        {
            White,
            Black,
            Yellow,
            Red
        }

        public enum eNumOfDoors
        {
            Two = 2,
            Three = 3,
            Four = 4,
            Five = 5
        }

        private eColor m_Color;
        private eNumOfDoors m_NumOfDoors;
    }
}
