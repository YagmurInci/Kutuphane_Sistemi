namespace GörselProje1.Forms
{
    partial class RezervasyonForm
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
            this.cmbOdaNo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnRezervasyon = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbKisiSayisi = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.cmbSaatAraligi = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbOdaNo
            // 
            this.cmbOdaNo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmbOdaNo.FormattingEnabled = true;
            this.cmbOdaNo.Items.AddRange(new object[] {
            "Oda 1 ",
            "Oda 2",
            "Oda 3",
            "Oda 4",
            "Oda 5"});
            this.cmbOdaNo.Location = new System.Drawing.Point(478, 160);
            this.cmbOdaNo.Name = "cmbOdaNo";
            this.cmbOdaNo.Size = new System.Drawing.Size(166, 24);
            this.cmbOdaNo.TabIndex = 0;
            this.cmbOdaNo.SelectedIndexChanged += new System.EventHandler(this.cmbOdaNo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(334, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kişi Sayısı : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(381, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rezervasyon Sayfası";
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeri.Location = new System.Drawing.Point(541, 408);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(103, 44);
            this.btnGeri.TabIndex = 3;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnRezervasyon
            // 
            this.btnRezervasyon.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRezervasyon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRezervasyon.Location = new System.Drawing.Point(311, 408);
            this.btnRezervasyon.Name = "btnRezervasyon";
            this.btnRezervasyon.Size = new System.Drawing.Size(157, 44);
            this.btnRezervasyon.TabIndex = 4;
            this.btnRezervasyon.Text = "Rezervasyon Yap";
            this.btnRezervasyon.UseVisualStyleBackColor = false;
            this.btnRezervasyon.Click += new System.EventHandler(this.btnRezervasyon_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(308, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Oda Numarası : ";
            // 
            // cmbKisiSayisi
            // 
            this.cmbKisiSayisi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmbKisiSayisi.FormattingEnabled = true;
            this.cmbKisiSayisi.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cmbKisiSayisi.Location = new System.Drawing.Point(478, 214);
            this.cmbKisiSayisi.Name = "cmbKisiSayisi";
            this.cmbKisiSayisi.Size = new System.Drawing.Size(166, 24);
            this.cmbKisiSayisi.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(278, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Rezervasyon Tarihi : ";
            // 
            // dtpTarih
            // 
            this.dtpTarih.CalendarMonthBackground = System.Drawing.SystemColors.ActiveCaption;
            this.dtpTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTarih.Location = new System.Drawing.Point(478, 281);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(166, 22);
            this.dtpTarih.TabIndex = 8;
            // 
            // cmbSaatAraligi
            // 
            this.cmbSaatAraligi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmbSaatAraligi.FormattingEnabled = true;
            this.cmbSaatAraligi.Items.AddRange(new object[] {
            "09:00 - 11:00",
            "11:00 - 13:00",
            "13:00 - 15:00",
            "15:00 - 17:00"});
            this.cmbSaatAraligi.Location = new System.Drawing.Point(478, 338);
            this.cmbSaatAraligi.Name = "cmbSaatAraligi";
            this.cmbSaatAraligi.Size = new System.Drawing.Size(166, 24);
            this.cmbSaatAraligi.TabIndex = 9;
            this.cmbSaatAraligi.SelectedIndexChanged += new System.EventHandler(this.cmbSaatAraligi_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(243, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Rezervasyon Saat Aralığı : ";
            // 
            // RezervasyonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GörselProje1.Properties.Resources.Ekran_görüntüsü_2025_12_21_224616;
            this.ClientSize = new System.Drawing.Size(932, 613);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbSaatAraligi);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbKisiSayisi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRezervasyon);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbOdaNo);
            this.Name = "RezervasyonForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RezervasyonForm";
            this.Load += new System.EventHandler(this.RezervasyonForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbOdaNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnRezervasyon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbKisiSayisi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.ComboBox cmbSaatAraligi;
        private System.Windows.Forms.Label label5;
    }
}