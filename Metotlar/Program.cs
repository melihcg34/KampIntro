using System;


namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
                    
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyat = 15;
            urun1.Aciklama = "Amasya Elması";
            urun1.stokAdet = 38;

           
            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyat = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";
            urun2.stokAdet = 48;
            
            Urun[] urunler = new Urun[] {urun1,urun2 };


            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyat);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("----------");

            }

            Console.WriteLine("------------Metotlar------------");
            //**instance - class örneği oluşturmak**
            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);


        }
    }
}