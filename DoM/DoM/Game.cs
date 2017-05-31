using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoM
{
    class Game
    {
        static void Main(string[] args)
        {
            // Manggil class objek map
            Map map = new Map(8, 5); // height = 8, width = 5
            //Console.WriteLine(map.Height * map.Width); // krn di class map height = Height maka map.Height ini jadi = 8, bisa aja heightnya di set 8 tp Height nya 9 ketika Height = height+1

            //// Masukin nilai tuk point dan Cek apa dia ada di area map?
            //Point point = new Point(4, 2); // ngisi nilai x dan y
            //bool isOnMap = map.onMap(point); // ngecek posisi point ada diwilayah map atau tidak; isOnMap (bebas krn variabel baru)
            //Console.WriteLine(isOnMap);

            //Console.WriteLine(point.distanceTo(4, 3)); //nilai X = 4, Y = 2 dari input point diatas, x=4, y=3 input drsini

            //// Manggil Maplocation & Cek MapLocation adalah inheritance Point
            //MapLocation point2 = new MapLocation(8, 5, map);
            //isOnMap = map.onMap(point2); 
            //Console.WriteLine(isOnMap);

            //// Ambil fungsi distanceTo dari class Point
            //MapLocation point3 = new MapLocation(8, 5, map);
            //Console.WriteLine(point2.distanceTo(7, 5));

            //// Coba deh, jawabnnya true or false
            //Console.WriteLine("aa" is string);
            //Console.WriteLine("aa" is int);
            
            //// Coba deh pahamin!! Point : ibunya; Maplocation : anaknya
            //Console.WriteLine(point3 is Point); // point3 punya maplocation -->maplocation anaknya point
            //Console.WriteLine(point is MapLocation); // ibunya bukan anaknya --> yg punya ibunya bukan selalu punya anaknya

            //RABU
            try
            {
                //array namanya path yang tipe isinya adalah Maplocation
                Path path = new Path(new[]
                {
                    new MapLocation(0, 2, map),
                    new MapLocation(1, 2, map),
                    new MapLocation(2, 2, map),
                    new MapLocation(3, 2, map),
                    new MapLocation(4, 2, map),
                    new MapLocation(5, 2, map),
                    new MapLocation(6, 2, map),
                    new MapLocation(7, 2, map)
                });

                //bikin 4 invader
                Invader[] invaders =
                {
                    new Invader(path),
                    new Invader(path),
                    new Invader(path),
                    new Invader(path),
                };

                //bikin 3 tower
                Tower[] tower =
                {
                    new Tower (new MapLocation(1,3,map)), //tower ditaro di koordinat (x,y)(1,3) sambil dicek ada g koordinat itu di map
                    new Tower (new MapLocation(2,3,map)),
                    new Tower (new MapLocation(3,3,map)),
                    new Tower (new MapLocation(4,3,map)),
                    new Tower (new MapLocation(5,3,map)),
                };

                Level level = new Level(invaders)
                {
                    Tower = tower
                };

                bool playerStatus = level.Play();
                Console.WriteLine("Player " + (playerStatus ? "won" : "lost"));
                
                
                //MapLocation location = path.getLocationAt(0); //0 : index array dari path jadi = new MapLocation(0, 2, map)

                //if (location != null)
                //    Console.WriteLine(location.X + "," + location.Y);

            }
            catch (OutOfBoundsException ex)
            {
                Console.WriteLine("exception lv 1 " + ex.Message);
            }
            catch (MDException ex) //kasih variabel ex buat manggil message catch di class maplocation
            {
                Console.WriteLine("exception lv 2 "+ ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine("exception lv 3 "+ ex.Message);
            }
        }
    }
}
