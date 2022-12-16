using System;

namespace uts{
    class nomor4{
        static void Main(string[] args){
            int menang = 0;
            int kalah = 0;
            int seimbang = 0;
            char userinput = ' ';
            Random rnd = new Random();

            while (userinput != 'e'){
                Console.Write("Masukkan pilihan anda (b/g/k/e): ");
                userinput = Convert.ToChar(Console.ReadLine());

                if (userinput == 'e'){
                    Console.WriteLine("Selamat Tinggal");
                    break;
                }
                int comp = rnd.Next(1, 4);
                if (userinput == 'b'){
                    if (comp == 1){
                        Console.WriteLine("Komputer memilih batu");
                        Console.WriteLine("Hasil: Seri");
                        seimbang++;
                    }
                    else if (comp == 2){
                        Console.WriteLine("Komputer memilih gunting");
                        Console.WriteLine("Hasil: Menang");
                        menang++;
                    }
                    else if (comp == 3){
                        Console.WriteLine("Komputer memilih kertas");
                        Console.WriteLine("Hasil: Kalah");
                        kalah++;
                    }
                }
                else if (userinput == 'g'){
                    if (comp == 1){
                        Console.WriteLine("Komputer memilih batu");
                        Console.WriteLine("Hasil: Kalah");
                        kalah++;
                    }
                    else if (comp == 2){
                        Console.WriteLine("Komputer memilih gunting");
                        Console.WriteLine("Hasil: Seri");
                        seimbang++;
                    }
                    else if (comp == 3){
                        Console.WriteLine("Komputer memilih kertas");
                        Console.WriteLine("Hasil: Menang");
                        menang++;
                    }
                }
                else if (userinput == 'k'){
                    if (comp == 1){
                        Console.WriteLine("Komputer memilih batu");
                        Console.WriteLine("Hasil: Menang");
                        menang++;
                    }
                    else if (comp == 2){
                        Console.WriteLine("Komputer memilih gunting");
                        Console.WriteLine("Hasil: Kalah");
                        kalah++;
                    }
                    else if (comp == 3){
                        Console.WriteLine("Komputer memilih kertas");
                        Console.WriteLine("Hasil: Seri");
                        seimbang++;
                    }
                }
                Console.WriteLine("skor kamu : Menang: {0}, Kalah: {1}, Seri: {2}", menang, kalah, seimbang);
                Console.WriteLine("tekan enter untuk melanjutkan");
                Console.ReadKey();
                Console.Clear();
                }

              
            }
        }
    }
