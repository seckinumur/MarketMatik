namespace MarketMatik
{
    partial class MusteriYonetimFormu
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.MusteriSecmeYeri = new System.Windows.Forms.DataGridView();
            this.musteriAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MusteriBakiyesi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musterilerBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.veriDataSet1 = new MarketMatik.VeriDataSet1();
            this.MusteriAramaYeri = new System.Windows.Forms.TextBox();
            this.IptalTusu = new System.Windows.Forms.Button();
            this.CariiptalTusu = new System.Windows.Forms.Button();
            this.CariOdeTusu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.musterilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.veriDataSet = new MarketMatik.VeriDataSet();
            this.musterilerTableAdapter = new MarketMatik.VeriDataSetTableAdapters.MusterilerTableAdapter();
            this.musterilerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.musterilerTableAdapter1 = new MarketMatik.VeriDataSet1TableAdapters.MusterilerTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MusteriSecmeYeri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musterilerBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veriDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musterilerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veriDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musterilerBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.MusteriSecmeYeri);
            this.groupBox1.Controls.Add(this.MusteriAramaYeri);
            this.groupBox1.Controls.Add(this.IptalTusu);
            this.groupBox1.Controls.Add(this.CariiptalTusu);
            this.groupBox1.Controls.Add(this.CariOdeTusu);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(945, 522);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Yönetim Ekranı";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(455, 471);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(250, 44);
            this.textBox1.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 474);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(443, 37);
            this.label4.TabIndex = 14;
            this.label4.Text = "TOPLAM MÜŞTERİ CARİSİ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(562, 56);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "TUŞUNA BAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(586, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "ENTER";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(711, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 124);
            this.button1.TabIndex = 11;
            this.button1.Text = "MÜŞTERİ DÜZENLE (F3)";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MusteriSecmeYeri
            // 
            this.MusteriSecmeYeri.AllowUserToDeleteRows = false;
            this.MusteriSecmeYeri.AutoGenerateColumns = false;
            this.MusteriSecmeYeri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.MusteriSecmeYeri.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.MusteriSecmeYeri.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.MusteriSecmeYeri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MusteriSecmeYeri.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.musteriAdiDataGridViewTextBoxColumn,
            this.MusteriBakiyesi});
            this.MusteriSecmeYeri.DataSource = this.musterilerBindingSource2;
            this.MusteriSecmeYeri.Location = new System.Drawing.Point(7, 93);
            this.MusteriSecmeYeri.Name = "MusteriSecmeYeri";
            this.MusteriSecmeYeri.ReadOnly = true;
            this.MusteriSecmeYeri.Size = new System.Drawing.Size(698, 372);
            this.MusteriSecmeYeri.TabIndex = 10;
            this.MusteriSecmeYeri.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.MusteriSecmeYeri_CellMouseDoubleClick);
            // 
            // musteriAdiDataGridViewTextBoxColumn
            // 
            this.musteriAdiDataGridViewTextBoxColumn.DataPropertyName = "MusteriAdi";
            this.musteriAdiDataGridViewTextBoxColumn.HeaderText = "MusteriAdi";
            this.musteriAdiDataGridViewTextBoxColumn.Name = "musteriAdiDataGridViewTextBoxColumn";
            this.musteriAdiDataGridViewTextBoxColumn.ReadOnly = true;
            this.musteriAdiDataGridViewTextBoxColumn.Width = 203;
            // 
            // MusteriBakiyesi
            // 
            this.MusteriBakiyesi.DataPropertyName = "MusteriBakiyesi";
            this.MusteriBakiyesi.HeaderText = "MusteriBakiyesi";
            this.MusteriBakiyesi.Name = "MusteriBakiyesi";
            this.MusteriBakiyesi.ReadOnly = true;
            this.MusteriBakiyesi.Width = 278;
            // 
            // musterilerBindingSource2
            // 
            this.musterilerBindingSource2.DataMember = "Musteriler";
            this.musterilerBindingSource2.DataSource = this.veriDataSet1;
            // 
            // veriDataSet1
            // 
            this.veriDataSet1.DataSetName = "VeriDataSet1";
            this.veriDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MusteriAramaYeri
            // 
            this.MusteriAramaYeri.BackColor = System.Drawing.Color.Yellow;
            this.MusteriAramaYeri.Location = new System.Drawing.Point(233, 43);
            this.MusteriAramaYeri.Name = "MusteriAramaYeri";
            this.MusteriAramaYeri.Size = new System.Drawing.Size(324, 44);
            this.MusteriAramaYeri.TabIndex = 9;
            this.MusteriAramaYeri.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MusteriAramaYeri_KeyDown);
            // 
            // IptalTusu
            // 
            this.IptalTusu.BackColor = System.Drawing.Color.Crimson;
            this.IptalTusu.ForeColor = System.Drawing.Color.White;
            this.IptalTusu.Location = new System.Drawing.Point(710, 436);
            this.IptalTusu.Name = "IptalTusu";
            this.IptalTusu.Size = new System.Drawing.Size(229, 79);
            this.IptalTusu.TabIndex = 7;
            this.IptalTusu.Text = "İPTAL (ESC)";
            this.IptalTusu.UseVisualStyleBackColor = false;
            this.IptalTusu.Click += new System.EventHandler(this.IptalTusu_Click);
            // 
            // CariiptalTusu
            // 
            this.CariiptalTusu.BackColor = System.Drawing.Color.Orange;
            this.CariiptalTusu.ForeColor = System.Drawing.Color.White;
            this.CariiptalTusu.Location = new System.Drawing.Point(711, 139);
            this.CariiptalTusu.Name = "CariiptalTusu";
            this.CariiptalTusu.Size = new System.Drawing.Size(229, 161);
            this.CariiptalTusu.TabIndex = 4;
            this.CariiptalTusu.Text = "CARİ SİL, AKTAR, DÜZENLE (F2)";
            this.CariiptalTusu.UseVisualStyleBackColor = false;
            this.CariiptalTusu.Click += new System.EventHandler(this.CariiptalTusu_Click);
            // 
            // CariOdeTusu
            // 
            this.CariOdeTusu.BackColor = System.Drawing.Color.Green;
            this.CariOdeTusu.ForeColor = System.Drawing.Color.White;
            this.CariOdeTusu.Location = new System.Drawing.Point(710, 24);
            this.CariOdeTusu.Name = "CariOdeTusu";
            this.CariOdeTusu.Size = new System.Drawing.Size(229, 109);
            this.CariOdeTusu.TabIndex = 3;
            this.CariOdeTusu.Text = "CARİ ÖDE (F1)";
            this.CariOdeTusu.UseVisualStyleBackColor = false;
            this.CariOdeTusu.Click += new System.EventHandler(this.CariOdeTusu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri Ara:";
            // 
            // musterilerBindingSource
            // 
            this.musterilerBindingSource.DataMember = "Musteriler";
            this.musterilerBindingSource.DataSource = this.veriDataSet;
            // 
            // veriDataSet
            // 
            this.veriDataSet.DataSetName = "VeriDataSet";
            this.veriDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // musterilerTableAdapter
            // 
            this.musterilerTableAdapter.ClearBeforeFill = true;
            // 
            // musterilerBindingSource1
            // 
            this.musterilerBindingSource1.DataMember = "Musteriler";
            this.musterilerBindingSource1.DataSource = this.veriDataSet;
            // 
            // musterilerTableAdapter1
            // 
            this.musterilerTableAdapter1.ClearBeforeFill = true;
            // 
            // MusteriYonetimFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(968, 540);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MusteriYonetimFormu";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MÜŞTERİ YÖNETİM PANELİ";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MusteriYonetimFormu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MusteriYonetimFormu_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MusteriSecmeYeri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musterilerBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veriDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musterilerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veriDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musterilerBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private VeriDataSet veriDataSet;
        private System.Windows.Forms.BindingSource musterilerBindingSource;
        private VeriDataSetTableAdapters.MusterilerTableAdapter musterilerTableAdapter;
        public System.Windows.Forms.Button CariOdeTusu;
        public System.Windows.Forms.Button CariiptalTusu;
        public System.Windows.Forms.Button IptalTusu;
        private System.Windows.Forms.TextBox MusteriAramaYeri;
        private System.Windows.Forms.BindingSource musterilerBindingSource1;
        private VeriDataSet1 veriDataSet1;
        private System.Windows.Forms.BindingSource musterilerBindingSource2;
        private VeriDataSet1TableAdapters.MusterilerTableAdapter musterilerTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MusteriBakiyesi;
        public System.Windows.Forms.DataGridView MusteriSecmeYeri;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
    }
}