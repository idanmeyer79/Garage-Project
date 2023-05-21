using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConsoleUI = Ex03.ConsoleUI;

namespace Ex03.GarageLogic
{
    class Program
    {
        public int Main()
        {
            ConsoleUI.GarageUI userInterface = new ConsoleUI.GarageUI();
            userInterface.ChooseAction();
            return 0;
        }
    }
}
