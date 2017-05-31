using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoM
{
    class Tower
    {
        private readonly MapLocation _location;
        private const int _range = 1;
        private static Random randomGenerator = new Random();
        private const double _accuracy = 0.75;
        private const int _power = 1;


        public Tower(MapLocation location)
        {
            _location = location;
        }

        public void FireOnInvaders(Invader[] invaders)
        {
            foreach (Invader satuInvader in invaders)
            {
                if (satuInvader.IsActive && _location.InRangeOf(satuInvader.Location,_range))
                {
                    if (_accuracy >= randomGenerator.NextDouble())
                    {
                        satuInvader.decreaseHealth(_power);
                        Console.WriteLine("invader shooted succesfully");

                        if (satuInvader.IsNeutralized)
                            Console.WriteLine("invader died");
                    }
                    else
                    {
                        Console.WriteLine("invader shooted missed");
                    }
                                      
                    break;
                }
            }
        }



    }
}
