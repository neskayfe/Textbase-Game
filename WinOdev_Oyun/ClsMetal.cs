using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinOdev_Oyun
{
    class ClsMetal:ClsZirh
    {
        public ClsMetal()
        {
            Defans = Convert.ToInt32(Defans * 1.25);
            Tur = "Demir";
            Ad = Tur + " Zirh";
            Level = 1;
            
        }
        
        
    }
}
