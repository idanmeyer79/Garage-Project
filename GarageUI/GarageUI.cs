using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace GarageUI
{
    public class GarageUI
    {
        enum eActions
        {
            enterNewVechicle = 1,
            showVehicleInGarage,
            changeVeihcleStatus,
            inflateTiersToMax,
            fillFuelTank,
            chargeVehicalBattery,
            getVehicleByPlateNum,
            exit

        }
        public static void ChooseAction()
        {
            eActions action = getAction();
            switch(action)
            {
                case eActions.enterNewVechicle:

                case eActions.showVehicleInGarage:

                case eActions.changeVeihcleStatus:

                case eActions.inflateTiersToMax:

                case eActions.fillFuelTank:

                case eActions.chargeVehicalBattery:

                case eActions.getVehicleByPlateNum:

                case eActions.exit:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public static eActions getAction()
        {
            throw new NotImplementedException();
        }
    }
}
