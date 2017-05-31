using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoM
{
    class MDException : Exception //krn ngambil class lain jd dia inherited dari clss exception dr visual studio
    {
        
        public MDException()
        {

        }

        public MDException(string message):base(message)
        {

        }

    }

    // buat class baru yang inherited dengan MakersDefenseException
    class OutOfBoundsException : MDException
    {
        public OutOfBoundsException()
        {
        }

        public OutOfBoundsException(string message) : base(message)
        {
        }
    }



}
