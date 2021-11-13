using System;

namespace metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            ürün ürün1 = new ürün();
            ürün1.adı = "kulaklık";
            ürün1.fiyatı = 100;
            ürün1.açıklama = "garanti var";

            ürün ürün2 = new ürün();
            ürün2.adı = "Tv";
            ürün2.fiyatı = 2000;
            ürün2.açıklama = "garanti yok";

            ürün ürün3 = new ürün();
            ürün3.adı = "bilgisayar";
            ürün3.fiyatı = 5000;
            ürün3.açıklama = "2.el";

            ürün[] ürünler = new ürün[]
            {
                ürün1,ürün2,ürün3
            };

            foreach (ürün x in ürünler )
            {
                Console.WriteLine(x.adı + " : " + x.fiyatı);
            };

            sepet_management sepet = new sepet_management();
            sepet.ekle(ürün1);
            sepet.ekle(ürün2);
            sepet.ekle(ürün3);



            
        }
    }
}
