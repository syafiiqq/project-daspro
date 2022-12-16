using System;

  namespace daspro
{
    class Program
    {
        //Main method
        static void Main(string[] args)
        {
           //deklarasi variabel
           int kodeA;
           int kodeB;
           int kodeC;
           int jumlahKode;
           String tebakanA;
           String tebakanB;
           String tebakanC;

           int hasilTambah;
           int hasilKali;
           //inisialisasi variabel
           kodeA = 1;
           kodeB = 2;
           kodeC = 3;

           jumlahKode = 3;
           
           //operasi aritmatika
           hasilTambah = kodeA+kodeB+kodeC;
           hasilKali = kodeA*kodeB*kodeC;

           //intro
           Console.WriteLine("anda adalah agen rahasia yang bertugas mendapatkan data dari server...");
           Console.WriteLine("akses ke server membutuhkan password yang tidak diketahui..");
           Console.WriteLine("password terdiri dari "+jumlahKode+" angka");
           Console.WriteLine("jika ditambahkan hasilnya "+hasilTambah);
           Console.WriteLine("jika dikalikan hasilnya "+hasilKali);

           //input user
           Console.Write("masukkan kode 1 : ");
           tebakanA = Console.ReadLine(); 
           Console.Write("masukkan kode 2 : ");
           tebakanB = Console.ReadLine();
           Console.Write("masukkan kode 3 : ");
           tebakanC = Console.ReadLine();

           Console.WriteLine("tebakan Anda : "+ tebakanA +"" + tebakanB +" "+ tebakanC +" ?");

           if(tebakanA == kodeA.ToString() && tebakanB == kodeB.ToString() && tebakanC == kodeC.ToString())
           {
            Console.WriteLine("tebakan anda benar!");
           }else{
            Console.WriteLine("tebakan anda salah!");
           }


        }
       
    }
}