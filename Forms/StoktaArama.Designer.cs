namespace GörselProje1.Forms
{
    partial class StoktaArama
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
            this.components = new System.ComponentModel.Container();
            this.dgvKitaplar = new System.Windows.Forms.DataGridView();
            this.kitapidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yazaradDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sayfasayisiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kayittarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bagisciadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bagiscimailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapdurumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableBookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userDBDataSet2 = new GörselProje1.UserDBDataSet2();
            this.tableBookTableAdapter = new GörselProje1.UserDBDataSet2TableAdapters.TableBookTableAdapter();
            this.btnAra = new System.Windows.Forms.Button();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnRaporAl = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitaplar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDBDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKitaplar
            // 
            this.dgvKitaplar.AutoGenerateColumns = false;
            this.dgvKitaplar.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKitaplar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kitapidDataGridViewTextBoxColumn,
            this.kitapadDataGridViewTextBoxColumn,
            this.yazaradDataGridViewTextBoxColumn,
            this.sayfasayisiDataGridViewTextBoxColumn,
            this.kayittarihiDataGridViewTextBoxColumn,
            this.bagisciadDataGridViewTextBoxColumn,
            this.bagiscimailDataGridViewTextBoxColumn,
            this.kitapdurumDataGridViewTextBoxColumn});
            this.dgvKitaplar.DataSource = this.tableBookBindingSource;
            this.dgvKitaplar.Location = new System.Drawing.Point(47, 126);
            this.dgvKitaplar.Name = "dgvKitaplar";
            this.dgvKitaplar.RowHeadersWidth = 51;
            this.dgvKitaplar.RowTemplate.Height = 24;
            this.dgvKitaplar.Size = new System.Drawing.Size(1072, 399);
            this.dgvKitaplar.TabIndex = 0;
            this.dgvKitaplar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKitaplar_CellContentClick);
            // 
            // kitapidDataGridViewTextBoxColumn
            // 
            this.kitapidDataGridViewTextBoxColumn.DataPropertyName = "kitap_id";
            this.kitapidDataGridViewTextBoxColumn.HeaderText = "kitap_id";
            this.kitapidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kitapidDataGridViewTextBoxColumn.Name = "kitapidDataGridViewTextBoxColumn";
            this.kitapidDataGridViewTextBoxColumn.ReadOnly = true;
            this.kitapidDataGridViewTextBoxColumn.Width = 125;
            // 
            // kitapadDataGridViewTextBoxColumn
            // 
            this.kitapadDataGridViewTextBoxColumn.DataPropertyName = "kitap_ad";
            this.kitapadDataGridViewTextBoxColumn.HeaderText = "kitap_ad";
            this.kitapadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kitapadDataGridViewTextBoxColumn.Name = "kitapadDataGridViewTextBoxColumn";
            this.kitapadDataGridViewTextBoxColumn.Width = 125;
            // 
            // yazaradDataGridViewTextBoxColumn
            // 
            this.yazaradDataGridViewTextBoxColumn.DataPropertyName = "yazar_ad";
            this.yazaradDataGridViewTextBoxColumn.HeaderText = "yazar_ad";
            this.yazaradDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yazaradDataGridViewTextBoxColumn.Name = "yazaradDataGridViewTextBoxColumn";
            this.yazaradDataGridViewTextBoxColumn.Width = 125;
            // 
            // sayfasayisiDataGridViewTextBoxColumn
            // 
            this.sayfasayisiDataGridViewTextBoxColumn.DataPropertyName = "sayfa_sayisi";
            this.sayfasayisiDataGridViewTextBoxColumn.HeaderText = "sayfa_sayisi";
            this.sayfasayisiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sayfasayisiDataGridViewTextBoxColumn.Name = "sayfasayisiDataGridViewTextBoxColumn";
            this.sayfasayisiDataGridViewTextBoxColumn.Width = 125;
            // 
            // kayittarihiDataGridViewTextBoxColumn
            // 
            this.kayittarihiDataGridViewTextBoxColumn.DataPropertyName = "kayit_tarihi";
            this.kayittarihiDataGridViewTextBoxColumn.HeaderText = "kayit_tarihi";
            this.kayittarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kayittarihiDataGridViewTextBoxColumn.Name = "kayittarihiDataGridViewTextBoxColumn";
            this.kayittarihiDataGridViewTextBoxColumn.Width = 125;
            // 
            // bagisciadDataGridViewTextBoxColumn
            // 
            this.bagisciadDataGridViewTextBoxColumn.DataPropertyName = "bagisci_ad";
            this.bagisciadDataGridViewTextBoxColumn.HeaderText = "bagisci_ad";
            this.bagisciadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bagisciadDataGridViewTextBoxColumn.Name = "bagisciadDataGridViewTextBoxColumn";
            this.bagisciadDataGridViewTextBoxColumn.Width = 125;
            // 
            // bagiscimailDataGridViewTextBoxColumn
            // 
            this.bagiscimailDataGridViewTextBoxColumn.DataPropertyName = "bagisci_mail";
            this.bagiscimailDataGridViewTextBoxColumn.HeaderText = "bagisci_mail";
            this.bagiscimailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bagiscimailDataGridViewTextBoxColumn.Name = "bagiscimailDataGridViewTextBoxColumn";
            this.bagiscimailDataGridViewTextBoxColumn.Width = 125;
            // 
            // kitapdurumDataGridViewTextBoxColumn
            // 
            this.kitapdurumDataGridViewTextBoxColumn.DataPropertyName = "kitap_durum";
            this.kitapdurumDataGridViewTextBoxColumn.HeaderText = "kitap_durum";
            this.kitapdurumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kitapdurumDataGridViewTextBoxColumn.Name = "kitapdurumDataGridViewTextBoxColumn";
            this.kitapdurumDataGridViewTextBoxColumn.Width = 125;
            // 
            // tableBookBindingSource
            // 
            this.tableBookBindingSource.DataMember = "TableBook";
            this.tableBookBindingSource.DataSource = this.userDBDataSet2;
            // 
            // userDBDataSet2
            // 
            this.userDBDataSet2.DataSetName = "UserDBDataSet2";
            this.userDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBookTableAdapter
            // 
            this.tableBookTableAdapter.ClearBeforeFill = true;
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAra.Location = new System.Drawing.Point(621, 26);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(80, 35);
            this.btnAra.TabIndex = 1;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = false;
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(430, 35);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(164, 22);
            this.txtAra.TabIndex = 2;
            this.txtAra.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMenu.Location = new System.Drawing.Point(1049, 12);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(94, 29);
            this.btnMenu.TabIndex = 3;
            this.btnMenu.Text = "Menü";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRaporAl
            // 
            this.btnRaporAl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRaporAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaporAl.Location = new System.Drawing.Point(737, 26);
            this.btnRaporAl.Name = "btnRaporAl";
            this.btnRaporAl.Size = new System.Drawing.Size(167, 35);
            this.btnRaporAl.TabIndex = 4;
            this.btnRaporAl.Text = "Listeyi Kaydet (.txt)";
            this.btnRaporAl.UseVisualStyleBackColor = false;
            this.btnRaporAl.Click += new System.EventHandler(this.btnRaporAl_Click);
            // 
            // StoktaArama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GörselProje1.Properties.Resources.Ekran_görüntüsü_2025_12_21_224616;
            this.ClientSize = new System.Drawing.Size(1182, 603);
            this.Controls.Add(this.btnRaporAl);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.dgvKitaplar);
            this.Name = "StoktaArama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StoktaArama";
            this.Load += new System.EventHandler(this.StoktaArama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitaplar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDBDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKitaplar;
        private UserDBDataSet2 userDBDataSet2;
        private System.Windows.Forms.BindingSource tableBookBindingSource;
        private UserDBDataSet2TableAdapters.TableBookTableAdapter tableBookTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yazaradDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sayfasayisiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kayittarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bagisciadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bagiscimailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapdurumDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnRaporAl;
    }
}