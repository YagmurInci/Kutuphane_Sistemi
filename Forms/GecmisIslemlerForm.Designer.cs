namespace GörselProje1.Forms
{
    partial class GecmisIslemlerForm
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
            this.dgvGecmis = new System.Windows.Forms.DataGridView();
            this.islemidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullaniciadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.islemturuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.islemaciklamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.islemtarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableIslemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userDBDataSet5 = new GörselProje1.UserDBDataSet5();
            this.btnMenu = new System.Windows.Forms.Button();
            this.tableIslemTableAdapter = new GörselProje1.UserDBDataSet5TableAdapters.TableIslemTableAdapter();
            this.btnIndır = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGecmis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableIslemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDBDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGecmis
            // 
            this.dgvGecmis.AutoGenerateColumns = false;
            this.dgvGecmis.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvGecmis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGecmis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.islemidDataGridViewTextBoxColumn,
            this.kullaniciadDataGridViewTextBoxColumn,
            this.islemturuDataGridViewTextBoxColumn,
            this.islemaciklamaDataGridViewTextBoxColumn,
            this.islemtarihiDataGridViewTextBoxColumn});
            this.dgvGecmis.DataSource = this.tableIslemBindingSource;
            this.dgvGecmis.Location = new System.Drawing.Point(110, 124);
            this.dgvGecmis.Name = "dgvGecmis";
            this.dgvGecmis.RowHeadersWidth = 51;
            this.dgvGecmis.RowTemplate.Height = 24;
            this.dgvGecmis.Size = new System.Drawing.Size(688, 321);
            this.dgvGecmis.TabIndex = 0;
            // 
            // islemidDataGridViewTextBoxColumn
            // 
            this.islemidDataGridViewTextBoxColumn.DataPropertyName = "islem_id";
            this.islemidDataGridViewTextBoxColumn.HeaderText = "islem_id";
            this.islemidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.islemidDataGridViewTextBoxColumn.Name = "islemidDataGridViewTextBoxColumn";
            this.islemidDataGridViewTextBoxColumn.ReadOnly = true;
            this.islemidDataGridViewTextBoxColumn.Width = 125;
            // 
            // kullaniciadDataGridViewTextBoxColumn
            // 
            this.kullaniciadDataGridViewTextBoxColumn.DataPropertyName = "kullanici_ad";
            this.kullaniciadDataGridViewTextBoxColumn.HeaderText = "kullanici_ad";
            this.kullaniciadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kullaniciadDataGridViewTextBoxColumn.Name = "kullaniciadDataGridViewTextBoxColumn";
            this.kullaniciadDataGridViewTextBoxColumn.Width = 125;
            // 
            // islemturuDataGridViewTextBoxColumn
            // 
            this.islemturuDataGridViewTextBoxColumn.DataPropertyName = "islem_turu";
            this.islemturuDataGridViewTextBoxColumn.HeaderText = "islem_turu";
            this.islemturuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.islemturuDataGridViewTextBoxColumn.Name = "islemturuDataGridViewTextBoxColumn";
            this.islemturuDataGridViewTextBoxColumn.Width = 125;
            // 
            // islemaciklamaDataGridViewTextBoxColumn
            // 
            this.islemaciklamaDataGridViewTextBoxColumn.DataPropertyName = "islem_aciklama";
            this.islemaciklamaDataGridViewTextBoxColumn.HeaderText = "islem_aciklama";
            this.islemaciklamaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.islemaciklamaDataGridViewTextBoxColumn.Name = "islemaciklamaDataGridViewTextBoxColumn";
            this.islemaciklamaDataGridViewTextBoxColumn.Width = 125;
            // 
            // islemtarihiDataGridViewTextBoxColumn
            // 
            this.islemtarihiDataGridViewTextBoxColumn.DataPropertyName = "islem_tarihi";
            this.islemtarihiDataGridViewTextBoxColumn.HeaderText = "islem_tarihi";
            this.islemtarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.islemtarihiDataGridViewTextBoxColumn.Name = "islemtarihiDataGridViewTextBoxColumn";
            this.islemtarihiDataGridViewTextBoxColumn.Width = 125;
            // 
            // tableIslemBindingSource
            // 
            this.tableIslemBindingSource.DataMember = "TableIslem";
            this.tableIslemBindingSource.DataSource = this.userDBDataSet5;
            // 
            // userDBDataSet5
            // 
            this.userDBDataSet5.DataSetName = "UserDBDataSet5";
            this.userDBDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Location = new System.Drawing.Point(656, 45);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(93, 33);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.Text = "Menü";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // tableIslemTableAdapter
            // 
            this.tableIslemTableAdapter.ClearBeforeFill = true;
            // 
            // btnIndır
            // 
            this.btnIndır.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnIndır.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIndır.Location = new System.Drawing.Point(348, 39);
            this.btnIndır.Name = "btnIndır";
            this.btnIndır.Size = new System.Drawing.Size(213, 44);
            this.btnIndır.TabIndex = 2;
            this.btnIndır.Text = "Geçmişini İndir (.txt)";
            this.btnIndır.UseVisualStyleBackColor = false;
            this.btnIndır.Click += new System.EventHandler(this.btnIndır_Click);
            // 
            // GecmisIslemlerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GörselProje1.Properties.Resources.Ekran_görüntüsü_2025_12_21_224616;
            this.ClientSize = new System.Drawing.Size(932, 613);
            this.Controls.Add(this.btnIndır);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.dgvGecmis);
            this.Name = "GecmisIslemlerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GecmisIslemlerForm";
            this.Load += new System.EventHandler(this.GecmisIslemlerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGecmis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableIslemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDBDataSet5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGecmis;
        private System.Windows.Forms.Button btnMenu;
        private UserDBDataSet5 userDBDataSet5;
        private System.Windows.Forms.BindingSource tableIslemBindingSource;
        private UserDBDataSet5TableAdapters.TableIslemTableAdapter tableIslemTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn islemidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn islemturuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn islemaciklamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn islemtarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnIndır;
    }
}