using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matador
{
    class Plot
    {
        string plotName;
        byte plotNumber;
        int plotColor;
        // enum plotColor { blue, orange, green, grey, red, white, yellow, purple, social, transport, special};

        public Plot(byte number, string name, int color)
        {
            this.plotNumber = number;
            this.plotName = name;
            this.plotColor = color;
        }

    }
}
