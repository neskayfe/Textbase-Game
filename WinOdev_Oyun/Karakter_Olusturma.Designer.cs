namespace WinOdev_Oyun
{
    partial class Karakter_Olusturma
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.pcCharResim = new System.Windows.Forms.PictureBox();
            this.rdElf = new System.Windows.Forms.RadioButton();
            this.pnlIrk = new System.Windows.Forms.Panel();
            this.rdInsan = new System.Windows.Forms.RadioButton();
            this.rdOrk = new System.Windows.Forms.RadioButton();
            this.pnlSinif = new System.Windows.Forms.Panel();
            this.rdWizard = new System.Windows.Forms.RadioButton();
            this.rdArcher = new System.Windows.Forms.RadioButton();
            this.rdWarrior = new System.Windows.Forms.RadioButton();
            this.lblTanim = new System.Windows.Forms.Label();
            this.btnBasla = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSilahSinif = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSilahLevel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSilahAtak = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSilahBonus = new System.Windows.Forms.Label();
            this.lblSilahAd = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblZirhAd = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblZirhSinif = new System.Windows.Forms.Label();
            this.lblZirhLevel = new System.Windows.Forms.Label();
            this.lblZirhDef = new System.Windows.Forms.Label();
            this.lblZirhTur = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcCharResim)).BeginInit();
            this.pnlIrk.SuspendLayout();
            this.pnlSinif.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(37, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Karakter İsmi :";
            // 
            // txtIsim
            // 
            this.txtIsim.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIsim.Location = new System.Drawing.Point(157, 21);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(150, 22);
            this.txtIsim.TabIndex = 1;
            // 
            // pcCharResim
            // 
            this.pcCharResim.Location = new System.Drawing.Point(339, 23);
            this.pcCharResim.Name = "pcCharResim";
            this.pcCharResim.Size = new System.Drawing.Size(238, 178);
            this.pcCharResim.TabIndex = 2;
            this.pcCharResim.TabStop = false;
            // 
            // rdElf
            // 
            this.rdElf.AutoSize = true;
            this.rdElf.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdElf.Location = new System.Drawing.Point(3, 3);
            this.rdElf.Name = "rdElf";
            this.rdElf.Size = new System.Drawing.Size(46, 23);
            this.rdElf.TabIndex = 3;
            this.rdElf.TabStop = true;
            this.rdElf.Text = "Elf";
            this.rdElf.UseVisualStyleBackColor = true;
            this.rdElf.CheckedChanged += new System.EventHandler(this.RdElf_CheckedChanged);
            // 
            // pnlIrk
            // 
            this.pnlIrk.Controls.Add(this.rdInsan);
            this.pnlIrk.Controls.Add(this.rdOrk);
            this.pnlIrk.Controls.Add(this.rdElf);
            this.pnlIrk.Location = new System.Drawing.Point(41, 58);
            this.pnlIrk.Name = "pnlIrk";
            this.pnlIrk.Size = new System.Drawing.Size(266, 66);
            this.pnlIrk.TabIndex = 4;
            // 
            // rdInsan
            // 
            this.rdInsan.AutoSize = true;
            this.rdInsan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdInsan.Location = new System.Drawing.Point(199, 3);
            this.rdInsan.Name = "rdInsan";
            this.rdInsan.Size = new System.Drawing.Size(64, 23);
            this.rdInsan.TabIndex = 3;
            this.rdInsan.TabStop = true;
            this.rdInsan.Text = "İnsan";
            this.rdInsan.UseVisualStyleBackColor = true;
            this.rdInsan.CheckedChanged += new System.EventHandler(this.RdInsan_CheckedChanged);
            // 
            // rdOrk
            // 
            this.rdOrk.AutoSize = true;
            this.rdOrk.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdOrk.Location = new System.Drawing.Point(106, 3);
            this.rdOrk.Name = "rdOrk";
            this.rdOrk.Size = new System.Drawing.Size(54, 23);
            this.rdOrk.TabIndex = 3;
            this.rdOrk.TabStop = true;
            this.rdOrk.Text = "Ork";
            this.rdOrk.UseVisualStyleBackColor = true;
            this.rdOrk.CheckedChanged += new System.EventHandler(this.RdOrk_CheckedChanged);
            // 
            // pnlSinif
            // 
            this.pnlSinif.Controls.Add(this.rdWizard);
            this.pnlSinif.Controls.Add(this.rdArcher);
            this.pnlSinif.Controls.Add(this.rdWarrior);
            this.pnlSinif.Location = new System.Drawing.Point(41, 135);
            this.pnlSinif.Name = "pnlSinif";
            this.pnlSinif.Size = new System.Drawing.Size(266, 66);
            this.pnlSinif.TabIndex = 4;
            // 
            // rdWizard
            // 
            this.rdWizard.AutoSize = true;
            this.rdWizard.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdWizard.Location = new System.Drawing.Point(189, 3);
            this.rdWizard.Name = "rdWizard";
            this.rdWizard.Size = new System.Drawing.Size(74, 23);
            this.rdWizard.TabIndex = 3;
            this.rdWizard.TabStop = true;
            this.rdWizard.Text = "Wizard";
            this.rdWizard.UseVisualStyleBackColor = true;
            this.rdWizard.CheckedChanged += new System.EventHandler(this.RdWizard_CheckedChanged);
            // 
            // rdArcher
            // 
            this.rdArcher.AutoSize = true;
            this.rdArcher.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdArcher.Location = new System.Drawing.Point(106, 3);
            this.rdArcher.Name = "rdArcher";
            this.rdArcher.Size = new System.Drawing.Size(73, 23);
            this.rdArcher.TabIndex = 3;
            this.rdArcher.TabStop = true;
            this.rdArcher.Text = "Archer";
            this.rdArcher.UseVisualStyleBackColor = true;
            this.rdArcher.CheckedChanged += new System.EventHandler(this.RdArcher_CheckedChanged);
            // 
            // rdWarrior
            // 
            this.rdWarrior.AutoSize = true;
            this.rdWarrior.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdWarrior.Location = new System.Drawing.Point(3, 3);
            this.rdWarrior.Name = "rdWarrior";
            this.rdWarrior.Size = new System.Drawing.Size(79, 23);
            this.rdWarrior.TabIndex = 3;
            this.rdWarrior.TabStop = true;
            this.rdWarrior.Text = "Warrior";
            this.rdWarrior.UseVisualStyleBackColor = true;
            this.rdWarrior.CheckedChanged += new System.EventHandler(this.RdWarrior_CheckedChanged);
            // 
            // lblTanim
            // 
            this.lblTanim.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTanim.Location = new System.Drawing.Point(37, 220);
            this.lblTanim.Name = "lblTanim";
            this.lblTanim.Size = new System.Drawing.Size(540, 87);
            this.lblTanim.TabIndex = 5;
            this.lblTanim.Text = "label2";
            this.lblTanim.Click += new System.EventHandler(this.LblTanim_Click);
            // 
            // btnBasla
            // 
            this.btnBasla.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBasla.Location = new System.Drawing.Point(41, 405);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(536, 36);
            this.btnBasla.TabIndex = 6;
            this.btnBasla.Text = "Oyuna Başla";
            this.btnBasla.UseVisualStyleBackColor = true;
            this.btnBasla.Click += new System.EventHandler(this.BtnBasla_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(583, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Silah  Bilgileri :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(583, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sınıfı :";
            // 
            // lblSilahSinif
            // 
            this.lblSilahSinif.AutoSize = true;
            this.lblSilahSinif.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSilahSinif.Location = new System.Drawing.Point(634, 58);
            this.lblSilahSinif.Name = "lblSilahSinif";
            this.lblSilahSinif.Size = new System.Drawing.Size(19, 15);
            this.lblSilahSinif.TabIndex = 0;
            this.lblSilahSinif.Text = "....";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(583, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Level :";
            // 
            // lblSilahLevel
            // 
            this.lblSilahLevel.AutoSize = true;
            this.lblSilahLevel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSilahLevel.Location = new System.Drawing.Point(634, 84);
            this.lblSilahLevel.Name = "lblSilahLevel";
            this.lblSilahLevel.Size = new System.Drawing.Size(19, 15);
            this.lblSilahLevel.TabIndex = 0;
            this.lblSilahLevel.Text = "....";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(752, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Atak :";
            // 
            // lblSilahAtak
            // 
            this.lblSilahAtak.AutoSize = true;
            this.lblSilahAtak.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSilahAtak.Location = new System.Drawing.Point(803, 58);
            this.lblSilahAtak.Name = "lblSilahAtak";
            this.lblSilahAtak.Size = new System.Drawing.Size(19, 15);
            this.lblSilahAtak.TabIndex = 0;
            this.lblSilahAtak.Text = "....";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(754, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Bonus :";
            // 
            // lblSilahBonus
            // 
            this.lblSilahBonus.AutoSize = true;
            this.lblSilahBonus.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSilahBonus.Location = new System.Drawing.Point(805, 84);
            this.lblSilahBonus.Name = "lblSilahBonus";
            this.lblSilahBonus.Size = new System.Drawing.Size(19, 15);
            this.lblSilahBonus.TabIndex = 0;
            this.lblSilahBonus.Text = "....";
            // 
            // lblSilahAd
            // 
            this.lblSilahAd.AutoSize = true;
            this.lblSilahAd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSilahAd.Location = new System.Drawing.Point(701, 23);
            this.lblSilahAd.Name = "lblSilahAd";
            this.lblSilahAd.Size = new System.Drawing.Size(25, 19);
            this.lblSilahAd.TabIndex = 0;
            this.lblSilahAd.Text = "....";
            this.lblSilahAd.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(583, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Zırh  Bilgileri :";
            // 
            // lblZirhAd
            // 
            this.lblZirhAd.AutoSize = true;
            this.lblZirhAd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblZirhAd.Location = new System.Drawing.Point(701, 122);
            this.lblZirhAd.Name = "lblZirhAd";
            this.lblZirhAd.Size = new System.Drawing.Size(25, 19);
            this.lblZirhAd.TabIndex = 0;
            this.lblZirhAd.Text = "....";
            this.lblZirhAd.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(583, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Sınıfı :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(583, 183);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "Level :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(752, 157);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "Defans :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(754, 183);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 15);
            this.label12.TabIndex = 0;
            this.label12.Text = "Tur :";
            // 
            // lblZirhSinif
            // 
            this.lblZirhSinif.AutoSize = true;
            this.lblZirhSinif.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblZirhSinif.Location = new System.Drawing.Point(634, 157);
            this.lblZirhSinif.Name = "lblZirhSinif";
            this.lblZirhSinif.Size = new System.Drawing.Size(19, 15);
            this.lblZirhSinif.TabIndex = 0;
            this.lblZirhSinif.Text = "....";
            // 
            // lblZirhLevel
            // 
            this.lblZirhLevel.AutoSize = true;
            this.lblZirhLevel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblZirhLevel.Location = new System.Drawing.Point(634, 183);
            this.lblZirhLevel.Name = "lblZirhLevel";
            this.lblZirhLevel.Size = new System.Drawing.Size(19, 15);
            this.lblZirhLevel.TabIndex = 0;
            this.lblZirhLevel.Text = "....";
            // 
            // lblZirhDef
            // 
            this.lblZirhDef.AutoSize = true;
            this.lblZirhDef.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblZirhDef.Location = new System.Drawing.Point(803, 157);
            this.lblZirhDef.Name = "lblZirhDef";
            this.lblZirhDef.Size = new System.Drawing.Size(19, 15);
            this.lblZirhDef.TabIndex = 0;
            this.lblZirhDef.Text = "....";
            // 
            // lblZirhTur
            // 
            this.lblZirhTur.AutoSize = true;
            this.lblZirhTur.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblZirhTur.Location = new System.Drawing.Point(805, 183);
            this.lblZirhTur.Name = "lblZirhTur";
            this.lblZirhTur.Size = new System.Drawing.Size(19, 15);
            this.lblZirhTur.TabIndex = 0;
            this.lblZirhTur.Text = "....";
            // 
            // Karakter_Olusturma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 453);
            this.Controls.Add(this.btnBasla);
            this.Controls.Add(this.lblTanim);
            this.Controls.Add(this.pnlSinif);
            this.Controls.Add(this.pnlIrk);
            this.Controls.Add(this.pcCharResim);
            this.Controls.Add(this.txtIsim);
            this.Controls.Add(this.lblZirhTur);
            this.Controls.Add(this.lblSilahBonus);
            this.Controls.Add(this.lblZirhDef);
            this.Controls.Add(this.lblSilahAtak);
            this.Controls.Add(this.lblZirhLevel);
            this.Controls.Add(this.lblSilahLevel);
            this.Controls.Add(this.lblZirhSinif);
            this.Controls.Add(this.lblSilahSinif);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblZirhAd);
            this.Controls.Add(this.lblSilahAd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Karakter_Olusturma";
            this.Text = "Karakter_Olusturma";
            this.Load += new System.EventHandler(this.Karakter_Olusturma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcCharResim)).EndInit();
            this.pnlIrk.ResumeLayout(false);
            this.pnlIrk.PerformLayout();
            this.pnlSinif.ResumeLayout(false);
            this.pnlSinif.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.PictureBox pcCharResim;
        private System.Windows.Forms.Label lblTanim;
        public System.Windows.Forms.RadioButton rdElf;
        public System.Windows.Forms.Panel pnlIrk;
        public System.Windows.Forms.RadioButton rdInsan;
        public System.Windows.Forms.RadioButton rdOrk;
        public System.Windows.Forms.Panel pnlSinif;
        public System.Windows.Forms.RadioButton rdWizard;
        public System.Windows.Forms.RadioButton rdArcher;
        public System.Windows.Forms.RadioButton rdWarrior;
        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSilahSinif;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSilahLevel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblSilahAtak;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSilahBonus;
        private System.Windows.Forms.Label lblSilahAd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblZirhAd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblZirhSinif;
        private System.Windows.Forms.Label lblZirhLevel;
        private System.Windows.Forms.Label lblZirhDef;
        private System.Windows.Forms.Label lblZirhTur;
    }
}