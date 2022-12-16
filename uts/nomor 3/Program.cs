using System;

namespace uts{
    class nomor3{
        static void Main(string[] args){
            int denda = 0;
            int hari = 0;
            Console.Write("jumlah hari peminjaman : ");
            hari = Convert.ToInt32(Console.ReadLine());
            if(hari > 30){
                denda = (hari - 30) * 30000 + 50000 + 400000;
                Console.WriteLine("total denda : Rp." + denda);
                Console.WriteLine("keanggotaan dibatalkan");
        }else if(hari > 10){
            denda =  (hari - 10) * 20000 + 50000;
            Console.WriteLine("total Denda : Rp." + denda);
        }else if (hari > 5){
            denda = (hari - 5) * 10000 + 50000;
            Console.WriteLine("total Denda : Rp." + denda);
        }else{
            Console.WriteLine("tidak ada denda");
        }
        Console.ReadKey();
    }
}
}





