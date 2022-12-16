using System;

namespace uts{
    class nomor2{
        static void Main(string[] args){
            int jawab = 0;
            Random rng = new Random();
            int cek = rng.Next(1,100);
            while(jawab != cek){
                Console.Write("tebaklah angka antara 1-100! : ");
                jawab = Convert.ToInt32(Console.ReadLine());
                if (jawab < cek){
                    Console.WriteLine("SALAH!, angka terlalu rendah");
                }else if(jawab > cek){
                    Console.WriteLine("SALAH!, angka terlalu tinggi");
                }else{
                    Console.WriteLine("SELAMAT! anda berhasil!");
                    Console.WriteLine("Bye..");
                    Console.ReadKey();
                }
                
            }
        }
            
        }
    }


