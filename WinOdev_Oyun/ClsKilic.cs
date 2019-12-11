using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinOdev_Oyun
{
    class ClsKilic:ClsSilah
    {
        public int mesefa { get; set; }
        
       public ClsKilic()
        {

            Tur = "Demir";
            Ad = Tur + " Kılıç";
            Level = 1;
            Atak = 10;



            if (Tur == "Demir")
            {
                mesefa = mesefa;
                bonus = bonus * 0;
               
            }
            else if (Tur == "Altin")
            {
                mesefa = mesefa + 5;
                Atak = Atak + bonus;
            }
            else if (Tur == "Mitril")
            {
                mesefa = mesefa + 10;
                Atak = Atak * Level + (bonus * 2);
            }
        }
        
    }
}
