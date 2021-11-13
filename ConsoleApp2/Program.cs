using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] kurslar = new string[]
            {"yazılım geliştirme kursu","java","bilgisayara ilk adım ", "python da temel algoritmalar"
            };

            for (int i = 0; i<kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }


        }
    }
}
