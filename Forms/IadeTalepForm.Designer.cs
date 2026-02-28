namespace GörselProje1.Forms
{
    partial class IadeTalepForm
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
            this.dgvIadeListesi = new System.Windows.Forms.DataGridView();
            this.kitapidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yazaradDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sayfasayisiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kayittarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bagisciadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bagiscimailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapdurumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oduncalanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableBookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userDBDataSet4 = new GörselProje1.UserDBDataSet4();
            this.btnIade = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.tableBookTableAdapter = new GörselProje1.UserDBDataSet4TableAdapters.TableBookTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAra = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIadeListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDBDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvIadeListesi
            // 
            this.dgvIadeListesi.AutoGenerateColumns = false;
            this.dgvIadeListesi.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvIadeListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIadeListesi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kitapidDataGridViewTextBoxColumn,
            this.kitapadDataGridViewTextBoxColumn,
            this.yazaradDataGridViewTextBoxColumn,
            this.sayfasayisiDataGridViewTextBoxColumn,
            this.kayittarihiDataGridViewTextBoxColumn,
            this.bagisciadDataGridViewTextBoxColumn,
            this.bagiscimailDataGridViewTextBoxColumn,
            this.kitapdurumDataGridViewTextBoxColumn,
            this.oduncalanDataGridViewTextBoxColumn});
            this.dgvIadeListesi.DataSource = this.tableBookBindingSource;
            this.dgvIadeListesi.Location = new System.Drawing.Point(170, 204);
            this.dgvIadeListesi.Name = "dgvIadeListesi";
            this.dgvIadeListesi.RowHeadersWidth = 51;
            this.dgvIadeListesi.RowTemplate.Height = 24;
            this.dgvIadeListesi.Size = new System.Drawing.Size(581, 212);
            this.dgvIadeListesi.TabIndex = 0;
            this.dgvIadeListesi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIadeListesi_CellContentClick);
            this.dgvIadeListesi.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvIadeListesi_DataBindingComplete);
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
            // oduncalanDataGridViewTextBoxColumn
            // 
            this.oduncalanDataGridViewTextBoxColumn.DataPropertyName = "odunc_alan";
            this.oduncalanDataGridViewTextBoxColumn.HeaderText = "odunc_alan";
            this.oduncalanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.oduncalanDataGridViewTextBoxColumn.Name = "oduncalanDataGridViewTextBoxColumn";
            this.oduncalanDataGridViewTextBoxColumn.Width = 125;
            // 
            // tableBookBindingSource
            // 
            this.tableBookBindingSource.DataMember = "TableBook";
            this.tableBookBindingSource.DataSource = this.userDBDataSet4;
            // 
            // userDBDataSet4
            // 
            this.userDBDataSet4.DataSetName = "UserDBDataSet4";
            this.userDBDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnIade
            // 
            this.btnIade.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnIade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIade.Location = new System.Drawing.Point(564, 78);
            this.btnIade.Name = "btnIade";
            this.btnIade.Size = new System.Drawing.Size(81, 37);
            this.btnIade.TabIndex = 1;
            this.btnIade.Text = "İade Et";
            this.btnIade.UseVisualStyleBackColor = false;
            this.btnIade.Click += new System.EventHandler(this.btnIade_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Location = new System.Drawing.Point(769, 49);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(81, 37);
            this.btnMenu.TabIndex = 2;
            this.btnMenu.Text = "Menü";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // tableBookTableAdapter
            // 
            this.tableBookTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kitap Ara";
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(353, 86);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(205, 22);
            this.txtAra.TabIndex = 4;
            // 
            // IadeTalepForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GörselProje1.Properties.Resources.Ekran_görüntüsü_2025_12_21_224616;
            this.ClientSize = new System.Drawing.Size(932, 613);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnIade);
            this.Controls.Add(this.dgvIadeListesi);
            this.Name = "IadeTalepForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IadeTalebi";
            this.Load += new System.EventHandler(this.IadeTalebi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIadeListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDBDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIadeListesi;
        private System.Windows.Forms.Button btnIade;
        private System.Windows.Forms.Button btnMenu;
        private UserDBDataSet4 userDBDataSet4;
        private System.Windows.Forms.BindingSource tableBookBindingSource;
        private UserDBDataSet4TableAdapters.TableBookTableAdapter tableBookTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yazaradDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sayfasayisiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kayittarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bagisciadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bagiscimailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapdurumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oduncalanDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAra;
    }
}