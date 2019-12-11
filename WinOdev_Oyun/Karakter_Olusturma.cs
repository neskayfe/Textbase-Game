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
    public partial class Karakter_Olusturma : Form
    {
        public Karakter_Olusturma()
        {
            InitializeComponent();
        }
        public static string isim,Irk,Sinif;
        ClsChar cChar = new ClsChar();
        ClsZirh zirh = new ClsZirh();

       public static string dosyayolu = Application.StartupPath+@"\";
        string irk = "";
        string sinif = "";
         public string Irksecim(string irk)
        {
            if (rdElf.Checked==true)
            {
                irk = rdElf.Text.ToString();
            }
            else if (rdOrk.Checked==true)
            {
                irk = rdOrk.Text.ToString();
            }
            else if (rdInsan.Checked==true)
            {
                irk = "Human";
            }
            else
            {
                irk = "bos";
            }

            return irk;
        }
        void secilmemisIrk()
        {
            MessageBox.Show("Irk Seçilmemiş !");
        }
        void temizle ()
        {
            rdWarrior.Checked = false;
            rdWizard.Checked = false;
            rdArcher.Checked = false;
            rdOrk.Checked = false;
            rdElf.Checked = false;
            rdInsan.Checked = false;
        }
       public  void resim()
        {
            
            pcCharResim.Image = Image.FromFile(dosyayolu + Irksecim(irk) + SinifSecim(sinif) + ".jpg");
            pcCharResim.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        public string SinifSecim(string sinif)
        {
            if (rdWarrior.Checked==true)
            {
                sinif = rdWarrior.Text.ToString();
            }
            else if (rdWizard.Checked==true)
            {
                sinif = rdWizard.Text.ToString();
            }
            else if (rdArcher.Checked==true)
            {
                sinif = rdArcher.Text.ToString();
            }
            else
            {
                sinif = "bos";
            }
            return sinif;
        }
        void Tanim()
        {
            if (true)
            {

            }
        }
       public  void kilic()
        {
            cChar.Silah = new ClsKilic();
            lblSilahSinif.Text = cChar.Silah.Ad.ToString();
            lblSilahAtak.Text = cChar.Silah.Atak.ToString();
            lblSilahLevel.Text = cChar.Silah.Level.ToString();
            lblSilahBonus.Text = cChar.Silah.bonus.ToString();
            lblSilahAd.Text = cChar.Silah.Level+" Level "+ cChar.Silah.Ad.ToString();

        }
        void Zirh()
        {
            cChar.Zirh = new ClsMetal();
            lblZirhAd.Text = cChar.Zirh.Level+" Level "+cChar.Zirh.Ad.ToString();
            lblZirhDef.Text = cChar.Zirh.Defans.ToString();
            lblZirhLevel.Text = cChar.Zirh.Level.ToString();
            lblZirhTur.Text = cChar.Zirh.Tur.ToString();
            lblZirhSinif.Text = cChar.Zirh.Ad.ToString();

        }
        private void RdWarrior_CheckedChanged(object sender, EventArgs e)
        {
            
            if (rdInsan.Checked == false && rdElf.Checked == false && rdOrk.Checked == false)
            {
                temizle();
                secilmemisIrk();

            }
            else
            {
                if (rdInsan.Checked == true && SinifSecim(sinif) != "bos")
                {
                    resim();
                    kilic();
                    Zirh();
                }
                else if (rdOrk.Checked == true && SinifSecim(sinif) != "bos")
                {
                    resim();
                    kilic();
                    Zirh();
                }
                else if (rdElf.Checked == true && SinifSecim(sinif) != "bos")
                {
                    resim();
                    kilic();
                    Zirh();
                }
            }
            lblTanim.Text = "TEST ";

        }

        private void RdArcher_CheckedChanged(object sender, EventArgs e)
        {
            
            if (rdInsan.Checked == false && rdElf.Checked == false && rdOrk.Checked == false)
            {
                secilmemisIrk();
                temizle();
            }
            else
            {
                if (rdInsan.Checked == true && SinifSecim(sinif) != "bos")
                {
                    resim();
                }
                else if (rdOrk.Checked == true && SinifSecim(sinif) != "bos")
                {
                    resim();
                }
                else if (rdElf.Checked == true && SinifSecim(sinif) != "bos")
                {
                    resim();
                }
            }
        }
        void bosresim ()
        {
            pcCharResim.Image = Image.FromFile(dosyayolu + "bos.jpg");
            pcCharResim.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void Karakter_Olusturma_Load(object sender, EventArgs e)
        {
            bosresim();
        }

        private void RdWizard_CheckedChanged(object sender, EventArgs e)
        {
            if (rdInsan.Checked==false && rdElf.Checked==false && rdOrk.Checked==false)
            {
                secilmemisIrk();
                temizle();
                
            }
            else
            {
                if (rdInsan.Checked == true && SinifSecim(sinif) != "bos")
                {
                    resim();
                }
                else if (rdOrk.Checked == true && SinifSecim(sinif) != "bos")
                {
                    resim();
                }
                else if (rdElf.Checked == true && SinifSecim(sinif) != "bos")
                {
                    resim();
                }
            }
            
            
        }

        private void RdElf_CheckedChanged(object sender, EventArgs e)
        {
            if (rdWarrior.Checked==true || rdArcher.Checked==true || rdWarrior.Checked==true)
            {
                bosresim();
                resim();
            }
            else
            {
                bosresim();
            }
            
            
        }

        private void LblTanim_Click(object sender, EventArgs e)
        {

        }

        private void RdOrk_CheckedChanged(object sender, EventArgs e)
        {
            if (rdWarrior.Checked == true || rdArcher.Checked == true || rdWarrior.Checked == true)
            {
                bosresim();
                resim();
            }
            else
            {
                bosresim();
            }

        }

        private void RdInsan_CheckedChanged(object sender, EventArgs e)
        {
            if (rdWarrior.Checked == true || rdArcher.Checked == true || rdWarrior.Checked == true)
            {
                bosresim();
                resim();
            }
            else
            {
                bosresim();
            }

        }

        private void BtnBasla_Click(object sender, EventArgs e)
        {
            if (txtIsim.Text!=string.Empty && (rdElf.Checked==true || rdInsan.Checked==true|| rdOrk.Checked==true)&& (rdWizard.Checked==true||rdArcher.Checked==true||rdWarrior.Checked==true))
            {
                //MessageBox.Show("Test");
                isim = txtIsim.Text.ToString();
                Irk = Irksecim(irk);
                Sinif = SinifSecim(sinif);

                AnaEkran ana = new AnaEkran();
                this.Hide();
                ana.Show();

                
                

            }
        }
    }
}
