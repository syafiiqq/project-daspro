using System;

namespace AduDadu
{
    class AduDadu
    {
        static void Main(string[] args)
        {
        
            Console.WriteLine("Selamat Datang Dalam Permainan Adu Dadu");
            Console.WriteLine("Pada Permainan Adu Dadu ini  Player akan berlawanan Melawan Komputer");
            Console.WriteLine("putaran pertama adalah komputer dan kedua player");
            Console.WriteLine("tekan enter untuk memutar dadu");
            Console.ReadKey();
            int komputer;
            int player;
            int komputerPoint = 0;
            int playerPoint = 0;
            int JumlahRonde = 0;
            Random random = new Random();
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("=====================");
                Console.WriteLine("tekan enter untuk memutar dadu berikutnya....");
                Console.WriteLine(" ");
                Console.ReadKey();
                JumlahRonde++;
                Console.WriteLine("Ronde"+ JumlahRonde );
                Console.WriteLine("===========================");
                Console.WriteLine("Giliran Komputer memutar dadu");
                System.Threading.Thread.Sleep(1000);
                komputer = random.Next(1, 7);
                Console.WriteLine("komputer memutar dadu : "+ komputer);
                Console.ReadKey();
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("Giliran player memutar dadu");
                System.Threading.Thread.Sleep(1000);
                player = random.Next(1, 7);
                Console.WriteLine("player memutar dadu : "+player);
                
                
                if(player > komputer)
                {
                    playerPoint++;
                    Console.WriteLine("player memenangkan permainan");
                }
                else if(player < komputer)
                {
                    komputerPoint++;
                    Console.Write("komputer menang");
                }
                else
                {
                    Console.WriteLine("permainan seri");
                }
                Console.WriteLine("skor saat ini- player : "+ playerPoint +"|| komputer : "+ komputerPoint +".");

            }
   
            if(playerPoint > komputerPoint)
            {
                Console.WriteLine("kamu menang");
            }
            else if(playerPoint < komputerPoint)
            {
                Console.WriteLine("komputer menang");
            }
            
            Console.WriteLine(" ");
            Console.WriteLine("Tekan tombol apa saja untuk melihat creator game adu dadu");
            Console.WriteLine(" ");
            Console.ReadKey();
            Console.WriteLine("Nama : Syafiq");
            Console.WriteLine("NIM  : 2207114104");
            Console.WriteLine("Kelas: Teknik Informatika A");
        
            Console.ReadKey();

        }
    }
}