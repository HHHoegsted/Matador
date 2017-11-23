using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matador
{
    class GameEngine
    {
        costPlot rødovrevej;
        Plot lykke1;

        public void StartGame()
        {

        }

        public void Instantiate()
        {
            int[] leje = { 50, 250, 750, 2250, 4000, 6000 };
            rødovrevej = new costPlot(1, "Rødovrevej", 1, leje, 1000, 1000, 600, 0);
            lykke1 = new Plot(2, "Prøv Lykken", 11);

        }

        
    }

    
}
