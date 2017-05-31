using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoM
{
    // MapLocation adlaah inheritance class Point
    class MapLocation : Point 
    {   
        // Krn maplocation inheritance dari point, jd harus dikasih gni
        public MapLocation(int x, int y, Map map) : base(x,y) // Base () bergantung sama () di maplocation
        {
            if (!map.onMap(this)) //maksdnya kalo map tidak ada di onMap jadi dilempar oleh throw untuk ditangkap catch
            {
                throw new OutOfBoundsException("g ada pointnya");
            }
        }

        public bool InRangeOf(MapLocation location, int range)
        {
            return distanceTo(location) <= range;
        }

    }
}
