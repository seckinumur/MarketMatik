namespace MarketMatik
{
    partial class Giderlerformu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AylikRapor = new System.Windows.Forms.Button();
            this.GunlukRapor = new System.Windows.Forms.Button();
            this.GiderSil = new System.Windows.Forms.Button();
            this.GiderEkle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.GiderTutari = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GiderAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GiderBul = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GiderlerGosterimPaneli = new System.Windows.Forms.DataGridView();
            this.giderAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giderTutariDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giderlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.veriDataSet6 = new MarketMatik.VeriDataSet6();
            this.giderlerTableAdapter = new MarketMatik.VeriDataSet6TableAdapters.GiderlerTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GiderlerGosterimPaneli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giderlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veriDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AylikRapor);
            this.groupBox1.Controls.Add(this.GunlukRapor);
            this.groupBox1.Controls.Add(this.GiderSil);
            this.groupBox1.Controls.Add(this.GiderEkle);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.GiderTutari);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.GiderAdi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.GiderBul);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.GiderlerGosterimPaneli);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(10, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(1002, 506);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GİDER YÖNETİM VE RAPORLAMA PANELİ";
            // 
            // AylikRapor
            // 
            this.AylikRapor.BackColor = System.Drawing.Color.SaddleBrown;
            this.AylikRapor.ForeColor = System.Drawing.Color.White;
            this.AylikRapor.Location = new System.Drawing.Point(608, 443);
            this.AylikRapor.Margin = new System.Windows.Forms.Padding(2);
            this.AylikRapor.Name = "AylikRapor";
            this.AylikRapor.Size = new System.Drawing.Size(394, 58);
            this.AylikRapor.TabIndex = 7;
            this.AylikRapor.Text = "ÇIKIŞ (ESC)";
            this.AylikRapor.UseVisualStyleBackColor = false;
            this.AylikRapor.Click += new System.EventHandler(this.AylikRapor_Click);
            // 
            // GunlukRapor
            // 
            this.GunlukRapor.BackColor = System.Drawing.Color.Orange;
            this.GunlukRapor.ForeColor = System.Drawing.Color.White;
            this.GunlukRapor.Location = new System.Drawing.Point(608, 372);
            this.GunlukRapor.Margin = new System.Windows.Forms.Padding(2);
            this.GunlukRapor.Name = "GunlukRapor";
            this.GunlukRapor.Size = new System.Drawing.Size(394, 69);
            this.GunlukRapor.TabIndex = 6;
            this.GunlukRapor.Text = "GÜNLÜK RAPOR (F3)";
            this.GunlukRapor.UseVisualStyleBackColor = false;
            this.GunlukRapor.Click += new System.EventHandler(this.GunlukRapor_Click);
            // 
            // GiderSil
            // 
            this.GiderSil.BackColor = System.Drawing.Color.Crimson;
            this.GiderSil.ForeColor = System.Drawing.Color.White;
            this.GiderSil.Location = new System.Drawing.Point(608, 288);
            this.GiderSil.Margin = new System.Windows.Forms.Padding(2);
            this.GiderSil.Name = "GiderSil";
            this.GiderSil.Size = new System.Drawing.Size(394, 80);
            this.GiderSil.TabIndex = 5;
            this.GiderSil.Text = "GİDER SİL (F2)";
            this.GiderSil.UseVisualStyleBackColor = false;
            this.GiderSil.Click += new System.EventHandler(this.GiderSil_Click);
            // 
            // GiderEkle
            // 
            this.GiderEkle.BackColor = System.Drawing.Color.Green;
            this.GiderEkle.ForeColor = System.Drawing.Color.White;
            this.GiderEkle.Location = new System.Drawing.Point(608, 204);
            this.GiderEkle.Margin = new System.Windows.Forms.Padding(2);
            this.GiderEkle.Name = "GiderEkle";
            this.GiderEkle.Size = new System.Drawing.Size(390, 80);
            this.GiderEkle.TabIndex = 3;
            this.GiderEkle.Text = "GİDER EKLE (F1)";
            this.GiderEkle.UseVisualStyleBackColor = false;
            this.GiderEkle.Click += new System.EventHandler(this.GiderEkle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(604, 69);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "GİDER BUL:";
            // 
            // GiderTutari
            // 
            this.GiderTutari.Location = new System.Drawing.Point(805, 147);
            this.GiderTutari.Margin = new System.Windows.Forms.Padding(2);
            this.GiderTutari.Name = "GiderTutari";
            this.GiderTutari.Size = new System.Drawing.Size(194, 35);
            this.GiderTutari.TabIndex = 2;
            this.GiderTutari.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GiderTutari_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(604, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "GİDER TUTARI:";
            // 
            // GiderAdi
            // 
            this.GiderAdi.Location = new System.Drawing.Point(747, 109);
            this.GiderAdi.Margin = new System.Windows.Forms.Padding(2);
            this.GiderAdi.Name = "GiderAdi";
            this.GiderAdi.Size = new System.Drawing.Size(252, 35);
            this.GiderAdi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(604, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "GİDER ADI:";
            // 
            // GiderBul
            // 
            this.GiderBul.BackColor = System.Drawing.Color.Navy;
            this.GiderBul.ForeColor = System.Drawing.Color.White;
            this.GiderBul.Location = new System.Drawing.Point(793, 65);
            this.GiderBul.Margin = new System.Windows.Forms.Padding(2);
            this.GiderBul.Name = "GiderBul";
            this.GiderBul.Size = new System.Drawing.Size(206, 35);
            this.GiderBul.TabIndex = 0;
            this.GiderBul.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GiderBul_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(604, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "GİDER DÜZENLE VE EKLE:";
            // 
            // GiderlerGosterimPaneli
            // 
            this.GiderlerGosterimPaneli.AllowUserToDeleteRows = false;
            this.GiderlerGosterimPaneli.AutoGenerateColumns = false;
            this.GiderlerGosterimPaneli.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GiderlerGosterimPaneli.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GiderlerGosterimPaneli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GiderlerGosterimPaneli.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.giderAdiDataGridViewTextBoxColumn,
            this.giderTutariDataGridViewTextBoxColumn,
            this.tarihDataGridViewTextBoxColumn});
            this.GiderlerGosterimPaneli.DataSource = this.giderlerBindingSource;
            this.GiderlerGosterimPaneli.Location = new System.Drawing.Point(5, 33);
            this.GiderlerGosterimPaneli.Margin = new System.Windows.Forms.Padding(2);
            this.GiderlerGosterimPaneli.Name = "GiderlerGosterimPaneli";
            this.GiderlerGosterimPaneli.ReadOnly = true;
            this.GiderlerGosterimPaneli.RowTemplate.Height = 24;
            this.GiderlerGosterimPaneli.Size = new System.Drawing.Size(594, 465);
            this.GiderlerGosterimPaneli.TabIndex = 0;
            this.GiderlerGosterimPaneli.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GiderlerGosterimPaneli_CellDoubleClick);
            // 
            // giderAdiDataGridViewTextBoxColumn
            // 
            this.giderAdiDataGridViewTextBoxColumn.DataPropertyName = "GiderAdi";
            this.giderAdiDataGridViewTextBoxColumn.HeaderText = "GiderAdi";
            this.giderAdiDataGridViewTextBoxColumn.Name = "giderAdiDataGridViewTextBoxColumn";
            this.giderAdiDataGridViewTextBoxColumn.ReadOnly = true;
            this.giderAdiDataGridViewTextBoxColumn.Width = 133;
            // 
            // giderTutariDataGridViewTextBoxColumn
            // 
            this.giderTutariDataGridViewTextBoxColumn.DataPropertyName = "GiderTutari";
            this.giderTutariDataGridViewTextBoxColumn.HeaderText = "GiderTutari";
            this.giderTutariDataGridViewTextBoxColumn.Name = "giderTutariDataGridViewTextBoxColumn";
            this.giderTutariDataGridViewTextBoxColumn.ReadOnly = true;
            this.giderTutariDataGridViewTextBoxColumn.Width = 160;
            // 
            // tarihDataGridViewTextBoxColumn
            // 
            this.tarihDataGridViewTextBoxColumn.DataPropertyName = "Tarih";
            this.tarihDataGridViewTextBoxColumn.HeaderText = "Tarih";
            this.tarihDataGridViewTextBoxColumn.Name = "tarihDataGridViewTextBoxColumn";
            this.tarihDataGridViewTextBoxColumn.ReadOnly = true;
            this.tarihDataGridViewTextBoxColumn.Width = 94;
            // 
            // giderlerBindingSource
            // 
            this.giderlerBindingSource.DataMember = "Giderler";
            this.giderlerBindingSource.DataSource = this.veriDataSet6;
            // 
            // veriDataSet6
            // 
            this.veriDataSet6.DataSetName = "VeriDataSet6";
            this.veriDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // giderlerTableAdapter
            // 
            this.giderlerTableAdapter.ClearBeforeFill = true;
            // 
            // Giderlerformu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1021, 523);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Giderlerformu";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GİDER PANELİ";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Giderlerformu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Giderlerformu_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GiderlerGosterimPaneli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giderlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veriDataSet6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView GiderlerGosterimPaneli;
        private VeriDataSet6 veriDataSet6;
        private System.Windows.Forms.BindingSource giderlerBindingSource;
        private VeriDataSet6TableAdapters.GiderlerTableAdapter giderlerTableAdapter;
        private System.Windows.Forms.Button AylikRapor;
        private System.Windows.Forms.Button GunlukRapor;
        private System.Windows.Forms.Button GiderSil;
        private System.Windows.Forms.Button GiderEkle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox GiderTutari;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox GiderAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox GiderBul;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn giderAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giderTutariDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
    }
}