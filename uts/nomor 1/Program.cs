using System;

namespace uts{
    class nomor1{
        public static void Main(string[] args){
            String nama, nim, konsentrasi;
            Console.Write("nama : ");
            nama = Console.ReadLine();
            Console.Write("NIM : ");
            nim = Console.ReadLine();
            Console.Write("konsentrasi : ");
            konsentrasi = Console.ReadLine();
            Console.WriteLine("|*************************|");
            Console.WriteLine("{0,-8} {1,18}", "|nama", nama+"|");
            Console.WriteLine("{0,-8} {1,18}", "|NIM", nim+"|");
            Console.WriteLine("|-------------------------|");
            Console.WriteLine("{0,-8} {1,14}", "|konsentrasi", konsentrasi+"|");
            Console.WriteLine("|*************************|");
        }
    }
}