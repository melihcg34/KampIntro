using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "Python";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 86;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "C#";
            kurs2.Egitmen = "Engin Demiroğ";
            kurs2.IzlenmeOrani = 78;
           
            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Java";
            kurs3.Egitmen = "Melih Gölçiçek";
            kurs3.IzlenmeOrani = 91;

            //Console.WriteLine(kurs1.KursAdi+" / "+ kurs1.Egitmen+ " / " + kurs1.IzlenmeOrani);
            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi+":"+kurs.Egitmen+":"+kurs.IzlenmeOrani);
            }
        }
    }


    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    
    
    
    }


}
