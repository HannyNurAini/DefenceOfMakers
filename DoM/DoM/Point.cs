using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoM
{
    class Point
    {
        // Atribute Point:
        public readonly int X; //readonly: biar Height ini hanya bisa diset 1 kali
        public readonly int Y;

        // Bikin consturactor --> g harus ada tiap class objek, contructor ada krn di progam.cs (hal ini Game.cs) manggil class ini dengan memberi nilai, krn di class map ini belum diset nilainya
        public Point(int x, int y)
        {
            X = x; // yg bakal dipake dibawahnya adalah Height; ini adalah constructor & harus sama dengan nama class
            Y = y;
        }

        // Buat cek jarak invader ke jangkauan tower
        public int distanceTo(int x, int y) // x,y disini beda dgn yang diatas krn jd constructor beda class
        {
            var selisihX = X - x;
            var selisihY = Y - y;
            var selisihXkuadrat = selisihX * selisihX;
            var selisihYkuadrat = Math.Pow(selisihY, 2); // kuadrat

            var jumlah = selisihXkuadrat + selisihYkuadrat;
            var akar = Math.Sqrt(jumlah);

            return (int) akar; //--> atau int.Parse(akar), krn nilai krn koma
        }

        // Overloading: manggil fungsi distanceTo dengan parameter yang beda
        public int distanceTo (Point point)
        {
            return distanceTo(point.X, point.Y);
        }

    }
}
