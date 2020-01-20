using System;
using System.Collections.Generic;
using System.Text;

namespace TaxCalculator
{
    public class TaxCalcDefault : TaxCalculator
    {
        public override int CalculateTax(Vehicle vehicle)
        {
            //vehicle.Co2Emissions
            if (vehicle.Co2Emissions == 0)
            {
                return 0;
            }
            else if (vehicle.Co2Emissions >= 1 && vehicle.Co2Emissions <= 50)
            {
                return 10;
            }
            else if (vehicle.Co2Emissions >= 51 && vehicle.Co2Emissions <= 75)
            {
                return 25;
            }
            else if (vehicle.Co2Emissions >= 76 && vehicle.Co2Emissions <= 90)
            {
                return 105;
            }
            else if (vehicle.Co2Emissions >= 91 && vehicle.Co2Emissions <= 100)
            {
                return 125;
            }
            else if (vehicle.Co2Emissions >= 101 && vehicle.Co2Emissions <= 110)
            {
                return 145;
            }
            else if (vehicle.Co2Emissions >= 111 && vehicle.Co2Emissions <= 130)
            {
                return 165;
            }
            else if (vehicle.Co2Emissions >= 131 && vehicle.Co2Emissions <= 150)
            {
                return 205;
            }
            else if (vehicle.Co2Emissions >= 151 && vehicle.Co2Emissions <= 170)
            {
                return 515;
            }
            else if (vehicle.Co2Emissions >= 171 && vehicle.Co2Emissions <= 190)
            {
                return 830;
            }
            else if (vehicle.Co2Emissions >= 191 && vehicle.Co2Emissions <= 225)
            {
                return 1240;
            }
            else if (vehicle.Co2Emissions >= 191 && vehicle.Co2Emissions <= 225)
            {
                return 1240;
            }
            else if (vehicle.Co2Emissions >= 226 && vehicle.Co2Emissions <= 255)
            {
                return 1760;
            }
            else if (vehicle.Co2Emissions > 255)
            {
                return 2070;
            }
            return 1;

        }
    }
}
