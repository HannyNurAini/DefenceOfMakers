using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoM
{
    class Invader
    {
        private readonly Path _path;
        private int _pathStep = 0;
        public int Health { get; private set; } = 2;//fungsi penghitung darah invader
        public bool IsActive => !(IsNeutralized || HasScored); //invader masih aktif apa g
        //public bool IsNeutralized => Health <= 0; //invader udh mati apa blm

        //sama aja kaya gini
        public bool IsNeutralized
        {
            get
            {
                return Health <= 0;
            }
        }


        public MapLocation Location
        {
            get
            {
                return _path.getLocationAt(_pathStep);
            }
        }

        public Invader(Path path)
        {
            _path = path;
        }

        public void Move() //invader maju otomatis
        {
            _pathStep += 1;
        }

        public void decreaseHealth(int factor)
        {
            Health -= factor;
        }

        public bool HasScored { get { return _pathStep >= _path.Length; } }


    }
}
