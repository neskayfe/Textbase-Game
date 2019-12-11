using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinOdev_Oyun
{

    class ClsSilah
    {
        string Sinif = Karakter_Olusturma.Sinif;
        public string Ad { get; set; }
        public int Level { get; set; }
        public int Atak { get; set; }
        public string Tur { get; set; }
        public int bonus { get; set; }

        public ClsSilah()
        {
            bonus = 10;
            int atak = 0;
            Atak = 20;
            Tur = "Demir";
            if (Tur == "Demir")
            {
                Atak = Atak * Level;

            }
            else if (Tur == "Altin")
            {
                atak = Convert.ToInt32(Atak / 4);
                Atak = Atak * Level + atak;

            }
            else if (Tur == "Mitril")
            {
                atak = Convert.ToInt32(Atak / 2);
                Atak = Atak * Level + atak;
            }

        }

    }
}
