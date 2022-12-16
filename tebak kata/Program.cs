using System;
using System.Collections.Generic;

namespace tebakkata
{
    class Program
    {
        static String katarahasia ="ranahtigawarna";
        static int kesempatan=5;
        static List<string> tebakanmu = new List<string>{};
        static void Main(string[] args)
        {
            intro();
            Mulaimain();
            selesaimain();
        }
        static void intro()
        {
            Console.WriteLine("kita akan bermain tebak kata");
            Console.WriteLine($"kamu punya {kesempatan} kesempatan untuk menebak kata tersebut");
            Console.WriteLine("petunjuknya adalah kata ini merupakan judul film");
            Console.WriteLine($"kata tersebut terdiri dari {katarahasia.Length} huruf");
            Console.WriteLine("apakah yang kata dimaksud?");
            Console.ReadKey();
            Console.WriteLine();
        }
        static void Mulaimain()
        {
            while (kesempatan>0)
            {
                Console.Write("apa huruf tebakanmu? :");string input = Console.ReadLine();
                tebakanmu.Add(input);
                if (cekjawaban(katarahasia, tebakanmu))
                {
                    Console.WriteLine("selamat anda berhasil");
                    Console.WriteLine($"kata misterinya adalah {katarahasia}");
                    break;
                }
                else if (katarahasia.Contains(input))
                {
                    Console.WriteLine("huruf tersebut sudah ada didalam kata ini");
                    Console.WriteLine("silahkan tebak huruf lainnya...");
                    Console.WriteLine(cekhuruf(katarahasia, tebakanmu));
                }
                else
                {
                    Console.WriteLine("huruf itu tidak ada dalam kata ini");
                    kesempatan--;
                    Console.WriteLine($"kesempatan anda tinggal {kesempatan}");
                }

                if (kesempatan==0)
                {
                    selesaimain();
                    break;
                }
            }
        }
        static bool cekjawaban(string katarahasia, List<string> list)
    {bool status = false;
        for (int i = 0; i < katarahasia.Length; i++)
        {
            string huruftersisa = Convert.ToString(katarahasia[i]);
            if (list.Contains(huruftersisa))
            {
                status = true;
            }
            else
            {
                return status = false;
            }
        }
        return status;
    }
        static string cekhuruf(string katarahasia, List<string> list)
        {string kata = "";

        for (int i = 0; i < katarahasia.Length; i++)
        {
            string huruftersisa = Convert.ToString(katarahasia[i]);
            if (list.Contains(huruftersisa))
            {
                kata = kata + huruftersisa;
            }
            else
            {
                kata =  kata + "_";
            }
        }
            return kata;
        }
        static void selesaimain()
        {
            if (kesempatan == 0)
            {
            Console.WriteLine("Permainan berakhir");
            Console.WriteLine($"kata misteri sebenarnya adalah {katarahasia}");
            }
        }
    }

}
