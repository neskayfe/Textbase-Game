using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinOdev_Oyun
{
    class ClsPot
    {
       public  string Ad = AnaEkran.PotTur;
        public int Level { get; set; }
        public int Etki { get; set; }
        public string Tur { get; set; }
       // public string Ad { get; set; }
        public int Sure { get; set; }
        public int Adet { get; set; }
        public int Fiyat { get; set; }
        public ClsPot()
        {
           // Ad = "Küçük Healt Pot";
            

            if (Ad=="Küçük Healt Pot")
            {
                Level = 1;
                Tur = "Heal";
                Etki = 50;
                Adet = 1;
                Fiyat = 30;
            }
            else if (Ad=="Büyük Healt Pot")
            {
                Level = 2;
                Tur = "Heal";
                Etki = 100;
                Adet = 2;
                Fiyat = 75;
            }
            else if (Ad=="Küçük Atak Pot")
            {
                Level = 1;
                Tur = "Atak";
                Etki = 10;
                Fiyat = 100;
                Sure = 10;
            }
            else if (Ad == "Büyük Atak Pot")
            {
                Level = 2;
                Tur = "Atak";
                Etki = 20;
                Fiyat = 300;
                Sure = 10;
            }
            else if (Ad == "Küçük Defans Pot")
            {
                Level = 1;
                Tur = "Defans";
                Etki = 10;
                Fiyat = 100;
                Sure = 10;
            }
            else if (Ad == "Büyük Defans Pot")
            {
                Level = 2;
                Tur = "Defans";
                Etki = 20;
                Fiyat = 300;
                Sure = 10;
            }

        }
    }
}
