using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RasingDEMO2
{
    class Difficulty
    {
        static public int difficulty(double dis)
        {
            int carsped = 4;

            if (dis > 100)
            {
                carsped = 6;
            }
            if (dis > 250)
            {
                carsped = 8;
            }

            return carsped;
        }
    }
}
