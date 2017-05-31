using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoM
{
    class Map
    {   // Atribute Map:
        public readonly int Height; //readonly: biar Height ini hanya bisa diset 1 kali
        public readonly int Width;  // public: biar bisa dipanggil diclass lain yaitu di game.cs

        // Bikin consturactor --> g harus ada tiap class objek, contructor ada krn di progam.cs (hal ini Game.cs) manggil class ini dengan memberi nilai, krn di class map ini belum diset nilainya
        public Map(int width, int height)
        {
            Height = height; // yang bakal dipake dibawahnya adalah Height; ini adalah constructor & harus sama dengan nama class
            Width = width;
        }


        // Apakah point ada di area map? 
        public bool onMap(Point point) // krn yang diatas itu (int height) int itu jg class, jd ini ambil input dari class Point yg kita udh buat
        {
            //var panjang = point.X < Width && point.X >= 0;
            //var lebar = point.Y < Width && point.Y >= 0;
            //return panjang && lebar;

            // kalo code diatas mau ditulis sebaris
            var inbounds = point.X < Width && point.X >= 0 && point.Y < Width && point.Y >= 0;
            return inbounds;

            
        }


    }
}
