using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinOdev_Oyun
{
    class ClsZirh
    {
        public string Ad { get; set; }
        public int Level { get; set; }
        public int Defans { get; set; }

        public string Tur { get; set; }

        public ClsZirh()
        {
            int sayi = 1;
            Defans = 20;
            if (Tur=="Demir")
            {
                Defans = Defans * Level;
            }
            else if (Tur=="Altin")
            {
                sayi = Convert.ToInt32(Defans * 2) * 3;
                Defans = Defans + sayi * Level;
            }
            else if (Tur=="Mitril")
            {
                sayi = Convert.ToInt32(Defans * 2);
                Defans = Defans + sayi;
            }
        }

    }
}
