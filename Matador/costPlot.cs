using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matador
{
    class costPlot : Plot
    {
        int[] leje = new int[6];
        int houseCost;
        int hotelCost;
        int pawnValue;
        byte buildStatus;
    

        public costPlot(byte number, string name, int color, int[] leje, int house, int hotel, int pawn, byte status) : base(number, name, color)
        {
            this.leje = leje;
            this.houseCost = house;
            this.hotelCost = hotel;
            this.pawnValue = pawn;
            this.buildStatus = status;
        }
    }
}
