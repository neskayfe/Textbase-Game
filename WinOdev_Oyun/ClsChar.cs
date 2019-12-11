using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinOdev_Oyun
{
    class ClsChar
    {
        ClsSilah silah = new ClsSilah();

        public int can { get; set; }
        public int level { get; set; }
        public string Irk { get; set; }
        public string Sinif { get; set; }
        public string Ad { get; set; }
        public int Defans    { get; set; }
        public int HasarGucu { get; set; }
        public int Hiz { get; set; }
        public int para { get; set; }
        public ClsSilah Silah { get; set; }
        public ClsZirh Zirh { get; set; }
       // public List<ClsPot> Pots { get; set; }
        
        public ClsChar()
        {         
            can = 250;
            Hiz = 100;
            Defans = 40;
            HasarGucu = 5;
            para = 100;
            Sinif = Karakter_Olusturma.Sinif;
            if (Sinif=="Warrior")
            {
                can = can + 50;
                Hiz = Hiz + 20;
                Defans = Defans + 10;
                HasarGucu = HasarGucu + 1;
            }
            else if (Sinif=="Archer")
            {
                can = can + 30;
                Hiz = Hiz - 10;
                Defans = Defans  -5;
                HasarGucu = HasarGucu -1;

            }
            else if (Sinif=="Wizard")
            {
                can = can - 20;
                Hiz = Hiz - 20;
                Defans = Defans - 10;
                HasarGucu = HasarGucu +3;
            }
           
        }
        public int Saldiri()
        {
           
            
            Random rnd = new Random();
            int min = Convert.ToInt32(Math.Floor((HasarGucu +level) * 0.8));
            int max = Convert.ToInt32(Math.Floor((HasarGucu + level) * 1.2))+silah.Atak;
            return rnd.Next(min, max);
        }
        public int HasarAlma()
        {
            Random rnd = new Random();
            int min = Convert.ToInt32(Math.Floor((Defans + level) * 0.8));
            int max = Convert.ToInt32(Math.Floor((Defans + level) * 1.2));
            return rnd.Next(min, max);
        }
        public bool GameOver()
        {
            if (can<=0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
