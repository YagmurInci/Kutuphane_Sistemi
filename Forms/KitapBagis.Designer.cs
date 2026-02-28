namespace GörselProje1.Forms
{
    partial class KitapBagis
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnBagis = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtKitapAd = new System.Windows.Forms.TextBox();
            this.txtYazarAd = new System.Windows.Forms.TextBox();
            this.txtSayfa = new System.Windows.Forms.TextBox();
            this.txtBagisciAdSoyad = new System.Windows.Forms.TextBox();
            this.dateBagis = new System.Windows.Forms.DateTimePicker();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(409, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap Bağış Sayfası";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(342, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kitap Adı  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(342, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yazar Adı : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(322, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Bağış Tarihi : ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(290, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Bağışçı Adı - Soyadı : ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(519, 458);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 34);
            this.button1.TabIndex = 7;
            this.button1.Text = "Vazgeç";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(705, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 31);
            this.button2.TabIndex = 8;
            this.button2.Text = "Menü";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnBagis
            // 
            this.btnBagis.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBagis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBagis.Location = new System.Drawing.Point(345, 458);
            this.btnBagis.Name = "btnBagis";
            this.btnBagis.Size = new System.Drawing.Size(123, 34);
            this.btnBagis.TabIndex = 9;
            this.btnBagis.Text = "Bağış Yap ";
            this.btnBagis.UseVisualStyleBackColor = false;
            this.btnBagis.Click += new System.EventHandler(this.button3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(327, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 18);
            this.label8.TabIndex = 10;
            this.label8.Text = "Sayfa Sayısı :";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtKitapAd
            // 
            this.txtKitapAd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtKitapAd.Location = new System.Drawing.Point(461, 169);
            this.txtKitapAd.Name = "txtKitapAd";
            this.txtKitapAd.Size = new System.Drawing.Size(149, 22);
            this.txtKitapAd.TabIndex = 11;
            // 
            // txtYazarAd
            // 
            this.txtYazarAd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtYazarAd.Location = new System.Drawing.Point(461, 207);
            this.txtYazarAd.Name = "txtYazarAd";
            this.txtYazarAd.Size = new System.Drawing.Size(149, 22);
            this.txtYazarAd.TabIndex = 12;
            // 
            // txtSayfa
            // 
            this.txtSayfa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtSayfa.Location = new System.Drawing.Point(461, 249);
            this.txtSayfa.Name = "txtSayfa";
            this.txtSayfa.Size = new System.Drawing.Size(149, 22);
            this.txtSayfa.TabIndex = 13;
            this.txtSayfa.TextChanged += new System.EventHandler(this.txtAdet_TextChanged);
            // 
            // txtBagisciAdSoyad
            // 
            this.txtBagisciAdSoyad.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtBagisciAdSoyad.Location = new System.Drawing.Point(463, 340);
            this.txtBagisciAdSoyad.Name = "txtBagisciAdSoyad";
            this.txtBagisciAdSoyad.Size = new System.Drawing.Size(149, 22);
            this.txtBagisciAdSoyad.TabIndex = 15;
            this.txtBagisciAdSoyad.TextChanged += new System.EventHandler(this.txtBagisciAdSoyad_TextChanged);
            // 
            // dateBagis
            // 
            this.dateBagis.CalendarMonthBackground = System.Drawing.SystemColors.ActiveCaption;
            this.dateBagis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateBagis.Location = new System.Drawing.Point(461, 294);
            this.dateBagis.Name = "dateBagis";
            this.dateBagis.Size = new System.Drawing.Size(149, 22);
            this.dateBagis.TabIndex = 17;
            this.dateBagis.ValueChanged += new System.EventHandler(this.dateBagis_ValueChanged);
            // 
            // txtMail
            // 
            this.txtMail.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtMail.Location = new System.Drawing.Point(461, 391);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(149, 22);
            this.txtMail.TabIndex = 19;
            this.txtMail.TextChanged += new System.EventHandler(this.txtMail_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(342, 395);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "Bağışçı Mail : ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // KitapBagis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GörselProje1.Properties.Resources.Ekran_görüntüsü_2025_12_21_224616;
            this.ClientSize = new System.Drawing.Size(932, 613);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateBagis);
            this.Controls.Add(this.txtBagisciAdSoyad);
            this.Controls.Add(this.txtSayfa);
            this.Controls.Add(this.txtYazarAd);
            this.Controls.Add(this.txtKitapAd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnBagis);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "KitapBagis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KitapBagis";
            this.Load += new System.EventHandler(this.KitapBagis_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnBagis;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtKitapAd;
        private System.Windows.Forms.TextBox txtYazarAd;
        private System.Windows.Forms.TextBox txtSayfa;
        private System.Windows.Forms.TextBox txtBagisciAdSoyad;
        private System.Windows.Forms.DateTimePicker dateBagis;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label4;
    }
}