using System;

namespace class_intro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            kurs kurs1 = new kurs();
            kurs1.egitmen = "harun yılmaz";
            kurs1.kurs_adı = "c#";
            kurs1.izlenme_oranı = 78;


            kurs kurs2 = new kurs();
            kurs2.egitmen = "musa tongşi";
            kurs2.kurs_adı = "python";
            kurs2.izlenme_oranı = 58;

            kurs kurs3 = new kurs();
            kurs3.egitmen = "muhsin tongşi";
            kurs3.kurs_adı = "java";
            kurs3.izlenme_oranı = 88;

            kurs[] kurslar = new kurs[]
            {
                kurs1,kurs2,kurs3
            };

            foreach (kurs x in kurslar)
            {
                Console.WriteLine(x.kurs_adı + " : " + x.egitmen);
            }


        }

    }
    class kurs
    {
        public string kurs_adı {get; set; }
        public string egitmen { get; set; }
        public int izlenme_oranı { get; set; }
    }
}
