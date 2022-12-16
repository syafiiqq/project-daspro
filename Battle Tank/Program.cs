using System;

namespace BattleTank
{
    class Program
    {
        static void Main(string[] args)
        {
            int panjangarea = 5;
            char rumput = '~';
            char tank = 't';
            char hit = 'X';
            char miss = 'O';
            int jumlahtank = 3;

            char[,] playarea = buatRuang(panjangarea, rumput, tank, jumlahtank);

            print(playarea, rumput, tank);

            int jumlahtanktersembunyi = jumlahtank;
            while (jumlahtanktersembunyi > 0)
            {
                int[] tebakankoordinat = getkoordinattebakan(panjangarea);
                char updatetampilanarea = verifikasitebakan(tebakankoordinat, playarea, tank, rumput, hit, miss);
                if (updatetampilanarea == hit)
                {
                    jumlahtanktersembunyi--;
                }
                playarea = updatearea(playarea, tebakankoordinat, updatetampilanarea);
                print(playarea, rumput, tank);
            }
            Console.WriteLine("Game Over!");
        }
        static char[,] buatRuang(int panjangarea, char rumput, char tank, int jumlahtank)
        {
            char[,] ruangan = new char[panjangarea, panjangarea];

            for (int baris = 0; baris < panjangarea; baris++)
            {
                for (int kolom = 0; kolom < panjangarea; kolom++)
                {
                    ruangan[baris, kolom] = rumput;
                }
            }
            return letakkantank(ruangan, jumlahtank, rumput, tank);
        }
        static char[,] letakkantank(char[,] ruangan, int jumlahtank, char rumput, char tank)
        {
            int letaktank = 0;
            int panjangarea = 5;

            while (letaktank < jumlahtank)
            {
                int[] lokasitank = koordinattank(panjangarea);
                char posisi = ruangan[lokasitank[0], lokasitank[1]];

                if (posisi==rumput)
                {
                    ruangan[lokasitank[0], lokasitank[1]] = tank;
                    letaktank++;
                }
            }
            return ruangan;
        }
        static int[] koordinattank(int panjangarea)
        {
            Random rnd = new Random();
            int[] koordinat = new int[2];
            for (int i = 0; i < koordinat.Length; i++)
            {
                koordinat[i] = rnd.Next(panjangarea); 
            }
            return koordinat;
        }
        private static void print(char[,] playarea, char rumput, char tank)
        {
            Console.Write("  ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(i + 1 + " ");
            }
            Console.WriteLine();
            for (int baris = 0; baris < 5; baris++)
            {
                Console.Write(baris + 1 + " ");
                for (int kolom = 0; kolom < 5; kolom++)
                {
                    char posisi = playarea[baris, kolom];
                    if (posisi == tank)
                    {
                        Console.Write(rumput + " ");
                    } 
                    else
                    {
                        Console.Write(posisi + " ");
                    }
                }
                Console.WriteLine();
            }
        }
        static int[] getkoordinattebakan(int panjangarea)
        {
            int baris;
            int kolom;

            do
            {
                Console.Write("Pilih Baris: ");
                baris = Convert.ToInt32(Console.ReadLine());
            } while (baris < 0 || baris > panjangarea + 1);

            do
            {
                Console.Write("Pilih Kolom: ");
                kolom = Convert.ToInt32(Console.ReadLine());
            } while (kolom < 0 || kolom > panjangarea + 1);
            return new[]{baris - 1, kolom - 1};
        }
        static char verifikasitebakan(int[] tebakan, char[,] playarea, char tank, char rumput, char hit, char miss)
        {
            string pesan;
            int baris = tebakan[0];
            int kolom = tebakan[1];
            char target = playarea[baris, kolom];

            if (target == tank)
            {
                pesan = "Hit!";
                target = hit;
            } 
            else if (target == rumput)
            {
                pesan = "Miss!";
                target = miss;
            }
            else
            {
                pesan = "Clear!";
            }
            Console.WriteLine(pesan);
            Console.WriteLine("----");
            return target;
        }
        static char[,] updatearea(char[,] area, int[] tebakankoordinat, char updatetampilanarea)
        {
            int baris = tebakankoordinat[0];
            int kolom = tebakankoordinat[1];
            area[baris, kolom] = updatetampilanarea;
            return area;   
        }
    }
}