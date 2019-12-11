using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinOdev_Oyun
{
    public partial class AnaEkran : Form
    {//eksiller Tekrar Savaştırma ve warrior hariç diğerlerinde 2.skill sorunu 
        public AnaEkran()
        {
            InitializeComponent();
        }
       
        void SatinalamaTanim()
        {
            ClsPot bilgiPot = new ClsPot();
            btnSatinal.Enabled = true;
            //lblPotTanim.Text = "";
            //lblPotTanim.Text = pot + " " + Tur + " Potu\n";
            //lblPotTanim.Text += potdeger + " " + Tur + " Ekler\n";
            //lblPotTanim.Text += "Fiyati " + Fiyat + " Para";
            lblPotTanim.Text = bilgiPot.Ad+"\n";
            lblPotTanim.Text += bilgiPot.Tur + " " + bilgiPot.Etki+"\n";
            //  lblPotTanim.Text += pots. + " " + Tur + " Ekler\n";
            lblPotTanim.Text += "Fiyati " + bilgiPot.Fiyat + " Para";


        }
        string pot = "";
        string Tur = "";
        string potdeger = "";
        string Fiyat = "";
        int sayi = 0;
    
        
        void skil1()
        {
            int DusmanCan = Convert.ToInt32(lblMobCan.Text);
            int DusmanDef = Convert.ToInt32(lblMobDef.Text);
            int OyuncuAtak = Convert.ToInt32(lblAtak.Text);
            int Hasar = 0;
            int silahLvl = Convert.ToInt32(lblSilahLevel.Text);

            int min = Convert.ToInt32(Math.Floor((OyuncuAtak*silahLvl) * 0.8))+5;
            int max = Convert.ToInt32(Math.Ceiling((OyuncuAtak*silahLvl) * 1.2))+5;
           
            Random rnd = new Random();
            if (rnd.Next(1,4)==1)
            {
                Hasar = 0;
                lbBilgi.Items.Add("Iskaladınız");
                lbBilgi.SelectedIndex = lbBilgi.Items.Count - 1;
            }
            else
            {
                Hasar = rnd.Next(min, max);
                DusmanCan = DusmanCan - Hasar;
                lblMobCan.Text = DusmanCan.ToString();
                lbBilgi.Items.Add($"Düşmana {Hasar} Hasar Verdiniz ");
                lbBilgi.SelectedIndex = lbBilgi.Items.Count - 1;
            }
            tmOyuncu.Start();
            pcSkill1.Visible = false;

            if (DusmanCan<=0)
            {
                pbMobGif.Visible = false;
                btnBasla.Visible = false;
                pbZemin.Top = -307;
                pcCharGif.Top = 536;
                tmOyuncu.Stop();
                tmOyuncu2.Stop();
                tmMob.Stop();
                pcSkill1.Visible = false;
                pcSkil2.Visible = false;
                int drop = rnd.Next(25, 100);
                int para = Convert.ToInt32(lblPara.Text);
                lblPara.Text = (para + drop).ToString();
                yerlerine();
                MessageBox.Show($"Tebrikler Düşmanı Yendiniz ve {drop} Para Kazandınz ! ");

            }
        }
        void skil2()
        {
            int DusmanCan = Convert.ToInt32(lblMobCan.Text);
            int DusmanDef = Convert.ToInt32(lblMobDef.Text);
            int OyuncuAtak = Convert.ToInt32(lblAtak.Text);
            int Hasar = 0;
            int silahLvl = Convert.ToInt32(lblSilahLevel.Text);
            int min = Convert.ToInt32(Math.Floor((OyuncuAtak*silahLvl) * 0.8))*oyuncu.level + 25;
            int max = Convert.ToInt32(Math.Ceiling((OyuncuAtak*silahLvl) * 1.2))*oyuncu.level + 25;

            Random rnd = new Random();
            if (rnd.Next(1, 10) <= 4)
            {
                Hasar = 0;
                lbBilgi.Items.Add("Iskaladınız");
                lbBilgi.SelectedIndex = lbBilgi.Items.Count - 1;
            }
            else
            {
                if (rnd.Next(1,5)==1)
                {
                    Hasar = rnd.Next(min, max);
                    DusmanCan = DusmanCan - Convert.ToInt32( Hasar*1.5);
                    lblMobCan.Text = DusmanCan.ToString();
                    lbBilgi.Items.Add($"Düşmana {Hasar} KRİTİK Hasar Verdiniz ");
                    lbBilgi.SelectedIndex = lbBilgi.Items.Count - 1;
                }
                else
                {
                    Hasar = rnd.Next(min, max);
                    DusmanCan = DusmanCan - Hasar;
                    lblMobCan.Text = DusmanCan.ToString();
                    lbBilgi.Items.Add($"Düşmana {Hasar} Hasar Verdiniz ");
                    lbBilgi.SelectedIndex = lbBilgi.Items.Count - 1;
                }
               
            }
            tmOyuncu2.Start();
            pcSkil2.Visible = false;

            if (DusmanCan <= 0)
            {
                pbMobGif.Visible = false;
                btnBasla.Visible = false;
                pbZemin.Top = -307;
                pcCharGif.Top = 536;
                tmOyuncu.Stop();
                tmOyuncu2.Stop();
                tmMob.Stop();
                pcSkill1.Visible = false;
                pcSkil2.Visible = false;
                int drop = rnd.Next(25, 100);
                int para = Convert.ToInt32(lblPara.Text);
                lblPara.Text = (para + drop).ToString();
                yerlerine();
                MessageBox.Show($"Tebrikler Düşmanı Yendiniz ve {drop} Para Kazandınz ! ");

            }
        }
        void mobSkil1()
        {
            int oyuncuCan = Convert.ToInt32(lblCan.Text);
            int oyuncuDef = Convert.ToInt32(lblDef.Text);
            int MobAtak = Convert.ToInt32(lblMobAtak.Text);
            int hasar = 0;
            int min = Convert.ToInt32(Math.Floor((MobAtak) * 0.6)) ;
            int max = Convert.ToInt32(Math.Ceiling((MobAtak) * 1.2));

            Random rnd = new Random();
            if (rnd.Next(1,4)==1)
            {
                hasar = 0;
                lbBilgi.Items.Add("Düşman Iskaladı ");
                lbBilgi.SelectedIndex = lbBilgi.Items.Count - 1;
            }
            else
            {
                hasar = rnd.Next(min, max);
                oyuncuCan = oyuncuCan - hasar;
                lblCan.Text = oyuncuCan.ToString();
                lbBilgi.Items.Add($"Düşmandan {hasar} hasar Aldınız");
                lbBilgi.SelectedIndex = lbBilgi.Items.Count - 1;
            }
            if (oyuncuCan<=0)
            {
                tmMob.Stop();
                tmOyuncu.Stop();
                tmOyuncu2.Stop();
                yerlerine();
                MessageBox.Show("Öldün Game OVER !");
            }

        }
        string dosyayolu = Karakter_Olusturma.dosyayolu;     
        private void PcHealPotSmall_Click(object sender, EventArgs e)
        {
            PotTur = "Küçük Healt Pot";
            //pot = "Küçük";
            //Tur = "Can";
            //potdeger = "25";
            //Fiyat = "10";
            SatinalamaTanim();
            //sayi = 1;
            
        }

        private void PcStrengPotSmall_Click(object sender, EventArgs e)
        {
            PotTur = "Küçük Atak Pot";
            SatinalamaTanim();
        }

        private void PcDefPotSmall_Click(object sender, EventArgs e)
        {
            PotTur = "Küçük Defans Pot";
            SatinalamaTanim();
        }

        private void PcHealPotBig_Click(object sender, EventArgs e)
        {
            PotTur = "Büyük Healt Pot";
            SatinalamaTanim();
        }

        private void PcDefPotBig_Click(object sender, EventArgs e)
        {
            PotTur = "Büyük Defans Pot";
            SatinalamaTanim();
        }

        private void PcStrengPotBig_Click(object sender, EventArgs e)
        {
            PotTur = "Büyük Atak Pot";
            SatinalamaTanim();
        }

        private void Pc1_Click(object sender, EventArgs e)
        {

        }
        ClsChar oyuncu = new ClsChar();
        void resim ()
        {
            pcChar.Image = Image.FromFile(dosyayolu + oyuncu.Irk + oyuncu.Sinif + ".jpg");
            pcChar.SizeMode = PictureBoxSizeMode.StretchImage;
            pcCharGif.Image = Image.FromFile(dosyayolu + oyuncu.Sinif + ".gif");
            pcCharGif.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        void silah()
        {
            oyuncu.Silah = new ClsKilic();
            lblSilahSinif.Text = oyuncu.Silah.Ad.ToString();
            lblSilahAtak.Text = oyuncu.Silah.Atak.ToString();
            lblSilahLevel.Text = oyuncu.Silah.Level.ToString();
            lblSilahBonus.Text = oyuncu.Silah.bonus.ToString();
            lblSilahAd.Text = oyuncu.Silah.Level + " Level " + oyuncu.Silah.Ad.ToString();
        }
        void Zirh()
        {
            oyuncu.Zirh = new ClsMetal();
            lblZirhAd.Text = oyuncu.Zirh.Level + " Level " + oyuncu.Zirh.Ad.ToString();
            lblZirhDef.Text = oyuncu.Zirh.Defans.ToString();
            lblZirhLevel.Text = oyuncu.Zirh.Level.ToString();
            lblZirhTur.Text = oyuncu.Zirh.Tur.ToString();
            lblZirhSinif.Text = oyuncu.Zirh.Ad.ToString();

        }
        

        void dusmanolusturma()
        {
            int savuma = oyuncu.Defans + oyuncu.Zirh.Defans;
            int dmg = oyuncu.HasarGucu + oyuncu.Silah.Atak;
            int lvl = oyuncu.level;
            int can = 200;
            string Irk = "Bos";
            string Sinif = "";
            int hiz = 100;
            Random rnd = new Random();
            if (rnd.Next(1,3)==2)
            {
                savuma = Convert.ToInt32(savuma*0.75);
                dmg = Convert.ToInt32(dmg * 0.75);
            }
            else
            {
                savuma = savuma;
                dmg = dmg;
                can = Convert.ToInt32(can * 1.25);
            }
            int irk = rnd.Next(1, 3);
            if (irk==1)
            {
                Irk = "Goblin";
                Sinif = "Wizard";
                savuma = Convert.ToInt32(savuma * 0.8);
                dmg = Convert.ToInt32(dmg * 1.2);
            }
            else
            {
                Irk = "Troll";
                Sinif = "Warrior";
                savuma = Convert.ToInt32(savuma * 0.8);
                dmg = Convert.ToInt32(dmg * 1.2);
            }

            lblMobCan.Text = can.ToString();
            lblMobIrk.Text = Irk.ToString();
            lblMobSinif.Text = Sinif.ToString();
            lblMobDef.Text = savuma.ToString();
            lblMobAtak.Text = dmg.ToString();
            lblHiz.Text = hiz.ToString();
            lblMobLevel.Text = lvl.ToString();
            pcMob.Image = Image.FromFile(dosyayolu +Irk+ ".jpg");
            pcMob.SizeMode = PictureBoxSizeMode.StretchImage;

        }
        int hpbAdet = 0;
        int hpkAdet = 2;
        int atakKAdet = 1;
        int atakBAdet = 0;
        int defKAdet = 1;
        int defBAdet = 0;
        
        private void AnaEkran_Load(object sender, EventArgs e)
        {
            btnhpK.Text = "Heal (K)-" + hpkAdet;
            btnHpB.Text = "Heal (B)-" + hpbAdet;
            btnAtakK.Text = "Atak (K)-" + atakKAdet;
            btnAtakB.Text = "Atak (B)-" + atakBAdet;
            btnDefK.Text = "Def (K)-" + defKAdet;
            btnDefB.Text = "Def (B)-" + defBAdet;
            oyuncu.Ad = Karakter_Olusturma.isim;
            oyuncu.Sinif = Karakter_Olusturma.Sinif;
            oyuncu.Irk = Karakter_Olusturma.Irk;
            oyuncu.level = 1;
            silah();
            Zirh();
            oyuncu.Silah = new ClsKilic();
            int atak = oyuncu.HasarGucu + oyuncu.Silah.Atak;
            lblCharInfo.Text = oyuncu.Ad;
            lblCan.Text = oyuncu.can.ToString();
            lblIrk.Text = Karakter_Olusturma.Irk.ToString();
            lblSinif.Text = Karakter_Olusturma.Sinif.ToString();
            lblPara.Text = oyuncu.para.ToString();
            lblLevel.Text = oyuncu.level.ToString();
            lblAtak.Text = atak.ToString();
            lblDef.Text = oyuncu.Defans.ToString();
            lblHiz.Text = oyuncu.Hiz.ToString();
            resim();
                       
            //ClsPot hpK = new ClsPot();
            //hpK.Ad = "Küçük Hp Pot";
            //hpK.Tur = "heal";
            //hpK.Etki = 50;
            //hpK.Level = 1;
            //oyuncu.Pots.Add(hpK);
            //ClsPot hpB = new ClsPot();
            //hpB.Ad = "Büyük Hp Pot";
            //hpB.Tur = "heal";
            //hpB.Etki = 100;
            //hpB.Level = 2;
            ////oyuncu.Pots.Add(hpB);
            //ClsPot AtakK = new ClsPot();
            //AtakK.Ad = "Küçük Atak pot";
            //AtakK.Tur = "Atak";
            //AtakK.Etki = 10;
            //AtakK.Sure = 10;
            //oyuncu.Pots.Add(AtakK);

           
        }
        void yerlerine()
        {
            pcCharGif.Top = 536;
            pbZemin.Top = -307;
            btnBasla.Top = 670;
            pbMobGif.Top = 260;
            btnBasla.Top = 363;
            pbMobGif.Visible = false;
            btnBasla.Visible = false;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            yerlerine();
            pbMobGif.Visible = true;
            tmMob.Start();
            if (oyuncu.Sinif=="Warrior")
            {
                if (pcCharGif.Top- pbMobGif.Top>= 50)
                {
                    tmCharYurume.Start();

                }
                else
                {
                    tmCharYurume.Stop();
                    tmOyuncu.Start();
                    tmOyuncu2.Start();
                }
            }
            else
            {

                tmOyuncu.Start();
                tmOyuncu2.Start();

            }
        }
        int Sure = 0;
        private void TmOyuncu_Tick(object sender, EventArgs e)
        {
           
            Sure++;
            if ((Sure%2)==0)
            {
                pcSkill1.Visible = true;
                tmOyuncu.Stop();
            }
           
        }

        private void PcSkill1_Click(object sender, EventArgs e)
        {
            if (oyuncu.Sinif=="Warrior")
            {
                if (pbMobGif.Top-pcCharGif.Top<=25)
                {
                    skil1();
                }
            }
            else
            {
                skil1();
            }
            
        }
       
        private void AnaEkran_KeyDown(object sender, KeyEventArgs e)
        {
            AnaEkran frm = new AnaEkran();

            if (e.KeyCode == Keys.Up &&(pbMobGif.Top-pcCharGif.Top<=-140))
            {
                pbZemin.Top += 10;
                btnBasla.Top += 10;
                pbMobGif.Top += 10;
                if (pcCharGif.Top<=btnBasla.Bottom)
                {
                    btnBasla.Visible = true;
                    pbMobGif.Visible = true;
                    frm.KeyPreview = false;
                    dusmanolusturma();
                }
            }
        }

        private void TmCharYurume_Tick(object sender, EventArgs e)
        {
            if (pcCharGif.Top - pbMobGif.Top >= 150)
            {
                pcCharGif.Top -= 50;
            }
            else
            {
                tmCharYurume.Stop();
                pcSkill1.Visible = true;
                pcSkil2.Visible = true;
            }
           
        }
        int Mobsure = 0;
        private void TmMob_Tick(object sender, EventArgs e)
        {
          
            Mobsure++;
            if (Mobsure%4==0)
            {
                mobSkil1();
            }
            
        }
        int Sure2 = 0;
        private void TmOyuncu2_Tick(object sender, EventArgs e)
        {
            Sure2++;
            if ((Sure2 % 5) == 0)
            {
                pcSkil2.Visible = true;
            }

        }

        private void PcSkil2_Click(object sender, EventArgs e)
        {
            skil2();
            pcSkil2.Visible = false;
        }
        
        public static string PotTur = "";

        void PotKullan()
        {
            ClsPot potBilgi = new ClsPot();
            void can()
            {
                lblCan.Text = (Convert.ToInt32(lblCan.Text) + potBilgi.Etki).ToString();

                if (PotTur == "Küçük Healt Pot")
                {
                    hpkAdet -= 1;
                }
                else
                {
                    hpbAdet -= 1;
                }
                lbBilgi.Items.Add($"{potBilgi.Level} Level Pot Kullanıdnız");
                lbBilgi.Items.Add($"Canını {potBilgi.Etki} artı");
                lbBilgi.SelectedIndex = lbBilgi.Items.Count - 1;
            }
            void atak()
            {
               // ClsPot potBilgi = new ClsPot();
                lblAtak.Text = (Convert.ToInt32(lblAtak.Text) + potBilgi.Etki).ToString();
                if (PotTur == "Küçük Atak Pot")
                {
                    atakKAdet -= 1;
                    butonİsim();
                }
                else
                {
                    atakBAdet -= 1;
                    butonİsim();
                }
                lbBilgi.Items.Add($"{potBilgi.Level} Level {potBilgi.Tur} Pot Kullanıdnız");
                lbBilgi.Items.Add($"Atağınız {potBilgi.Sure} saniye ile {potBilgi.Etki} artı");
                lbBilgi.SelectedIndex = lbBilgi.Items.Count - 1;
                tmAtak.Start();
            }

            void defans()
            {
                lblDef.Text= (Convert.ToInt32(lblDef.Text) + potBilgi.Etki).ToString();
                if (PotTur=="Küçük Defans Pot")
                {
                    defKAdet -= 1;
                }
                else
                {
                    defBAdet -= 1;
                }
                lbBilgi.Items.Add($"{potBilgi.Level} Level {potBilgi.Tur} Pot Kullanıdnız");
                lbBilgi.Items.Add($"Defansınız {potBilgi.Sure} saniye ile {potBilgi.Etki} artı");
                lbBilgi.SelectedIndex = lbBilgi.Items.Count - 1;
                tmDef.Start();
            }
            if (hpkAdet > 0 && PotTur== "Küçük Healt Pot ")
            {
                can();
            }
            else if (hpbAdet>0 && PotTur== "Büyük Healt Pot")
            {
                can();
            }
            else if (atakKAdet>0 &&  PotTur== "Küçük Atak Pot")
            {
                atak();
            }
            else if (defKAdet>0 && PotTur=="Küçük Defans Pot")
            {
                defans();
            }
            else if (defKAdet > 0 && PotTur == "Büyük Defans Pot")
            {
                defans();
            }

        }

        private void BtnhpK_Click(object sender, EventArgs e)
        {
            PotTur = "Küçük Healt Pot";
            PotKullan();
            butonİsim();          
        }
        void butonİsim()
        {
            if (PotTur=="Küçük Healt Pot")
            {
                btnhpK.Text = "Heal (K)-" + hpkAdet;
            }
            else if (PotTur == "Büyük Healt Pot")
            {
                btnHpB.Text = "Heal (B)-" + hpbAdet;
            }
            else if (PotTur== "Küçük Atak Pot")
            {
                btnAtakK.Text = "Atak (K)-" + atakKAdet;
            }
            else if (PotTur == "Büyük Atak Pot")
            {
                btnAtakB.Text = "Atak (B)-" + atakBAdet;
            }
            else if (PotTur == "Küçük Defans Pot")
            {
                btnDefK.Text = "Def (K)-" + defKAdet;
            }
            else if (PotTur == "Büyük Defans Pot")
            {
                btnDefB.Text = "Def (b)-" + defBAdet;
            }
        }
        void potSatinAl()
        {
            ClsPot bilgiPot = new ClsPot();
                int para = Convert.ToInt32(lblPara.Text);
                if (para >= bilgiPot.Fiyat)
                {
                    para = para - bilgiPot.Fiyat;
                    lblPara.Text = para.ToString();
                if (PotTur == "Küçük Healt Pot")
                {
                    hpkAdet += 1;
                }
                else if (PotTur == "Büyük Healt Pot")
                {
                   hpbAdet+=1;
                }
                else if (PotTur == "Küçük Atak Pot")
                {
                    atakKAdet+=1;
                }
                else if (PotTur == "Büyük Atak Pot")
                {
                    atakBAdet+=1;
                }
                else if (PotTur == "Küçük Defans Pot")
                {
                    defKAdet+=1;
                }
                else if (PotTur == "Büyük Defans Pot")
                {
                    defBAdet+=1;
                }
                butonİsim();
                }
        }
        private void BtnSatinal_Click(object sender, EventArgs e)
        {
            potSatinAl();
        }

        private void BtnHpB_Click(object sender, EventArgs e)
        {
            PotTur = "Büyük Healt Pot";
            PotKullan();
            butonİsim();
        }

        private void BtnAtakK_Click(object sender, EventArgs e)
        {
            PotTur = "Küçük Atak Pot";
            PotKullan();
            butonİsim();
        }
        int atakSure = 0;
        int defSure = 0;
        private void TmAtak_Tick(object sender, EventArgs e)
        {
            atakSure++;
            ClsPot potBilgi = new ClsPot();
            if (atakSure==potBilgi.Sure)
            {
                lblAtak.Text = (Convert.ToInt32(lblAtak.Text) - potBilgi.Etki).ToString();
                lbBilgi.Items.Add($"Atağınız Eski Haline Geldi ");
                lbBilgi.SelectedIndex = lbBilgi.Items.Count - 1;
                tmAtak.Stop();
            }
            
        }

        private void BtnDefK_Click(object sender, EventArgs e)
        {
            PotTur = "Küçük Defans Pot";
            PotKullan();
            butonİsim();
        }

        private void BtnDefB_Click(object sender, EventArgs e)
        {
            PotTur = "Büyük Defans Pot";
            PotKullan();
            butonİsim();
        }

        private void TmDef_Tick(object sender, EventArgs e)
        {
            defSure++;
            ClsPot potBilgi = new ClsPot();
            if (defSure == potBilgi.Sure)
            {
                lblAtak.Text = (Convert.ToInt32(lblDef.Text) - potBilgi.Etki).ToString();
                lbBilgi.Items.Add($"Defansınız Eski Haline Geldi ");
                lbBilgi.SelectedIndex = lbBilgi.Items.Count - 1;
                tmDef.Stop();
            }
        }

        private void BtnSilahUp_Click(object sender, EventArgs e)
        {
            int para = Convert.ToInt32(lblPara.Text);
            int SilahLvl = Convert.ToInt32(lblSilahLevel.Text);
            Random rnd = new Random();
            if (para>=150 &&SilahLvl==1)
            {
                int sans = rnd.Next(1, 10);
                if (sans > 5)
                {
                    lblSilahLevel.Text = (SilahLvl + 1).ToString();
                    lblPara.Text = (para - 100).ToString();
                    MessageBox.Show("Tebrikler Silahin Bir level Üste Çıktı");
                }
                else
                {
                    lblPara.Text = (para - 100).ToString();
                    MessageBox.Show("olmadı Bir dahaki Sefere !");
                }
               
            }
            else if (para > 250 && SilahLvl == 2)
            {
                int sans = rnd.Next(1, 15);
                if (sans>10)
                {
                    lblSilahLevel.Text = (SilahLvl + 1).ToString();
                    lblPara.Text = (para - 250).ToString();
                    MessageBox.Show("Tebrikler Silahin Bir level Üste Çıktı");
                }
                else
                {
                    lblPara.Text = (para - 250).ToString();
                    MessageBox.Show("olmadı Bir dahaki Sefere !");
                }
            }
            else
            {
                MessageBox.Show("Yeterli Paran Yok ! Daha Çok  çalış");
            }

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            int para = Convert.ToInt32(lblPara.Text);
            string Tur = lblSilahSinif.Text;
            Random rnd = new Random();
        }
    }
}
