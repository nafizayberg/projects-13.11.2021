using System;

namespace refarans_değerler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 30;
            int sayi2 = 60;
            sayi1 = sayi2;
            sayi2 = 65;
            Console.WriteLine(sayi1);

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 90, 100, 200 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            Console.WriteLine(sayilar1[0]);



        }
    }
}
