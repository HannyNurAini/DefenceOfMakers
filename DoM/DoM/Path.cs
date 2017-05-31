using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoM
{
    class Path
    {
        public int Length => _path.Length;
        private readonly MapLocation[] _path;

        public Path(MapLocation[] path) //Path ini bakal nerima array maplocation yang diberinama nantinya path
        {
            _path = path;//path dijadiin _path
        }

        //karena class lain masih bukun_path sedangkan _path ini dijadiin private
        //public MapLocation getLocationAt(int pathStep)
        //{
        //    return _path[pathStep];
        //}

        public MapLocation getLocationAt(int pathStep) //pathstep : index array maplocation
        { return pathStep < _path.Length ? _path[pathStep] : null; // syntetic sugar (syntaq gantiin if dibawah)
            //if (pathStep < _path.Length)
            //    return _path[pathStep];
            //else
            //    return null;
        }

        // SYNTETIC SUGAR: 
        // return name == "Sam" ? 100 : -1; //apakah namanya sam? jika 1 kasih nilainya 100, klo g kasih -1

    }
}
