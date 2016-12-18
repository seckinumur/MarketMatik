namespace MarketMatik
{
    partial class Urunislemleriformu
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
            this.iptal = new System.Windows.Forms.Button();
            this.UrunSil = new System.Windows.Forms.Button();
            this.UrunGuncelle = new System.Windows.Forms.Button();
            this.UrunGelisFiyati = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.UrunFiyati = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.UrunAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.UrunBarkodu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UrunGostergesi = new System.Windows.Forms.DataGridView();
            this.barkodNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunFiyatiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunGelisFiyatiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunSatisFiyatiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.veriDataSet5 = new MarketMatik.VeriDataSet5();
            this.BarkodOkut = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.urunlerTableAdapter = new MarketMatik.VeriDataSet5TableAdapters.UrunlerTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UrunGostergesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veriDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.iptal);
            this.groupBox1.Controls.Add(this.UrunSil);
            this.groupBox1.Controls.Add(this.UrunGuncelle);
            this.groupBox1.Controls.Add(this.UrunGelisFiyati);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.UrunFiyati);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.UrunAdi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.UrunBarkodu);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.UrunGostergesi);
            this.groupBox1.Controls.Add(this.BarkodOkut);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(10, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(875, 558);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ÜRÜN GÜNCELLE YADA SİL";
            // 
            // iptal
            // 
            this.iptal.BackColor = System.Drawing.Color.Purple;
            this.iptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.iptal.ForeColor = System.Drawing.Color.White;
            this.iptal.Location = new System.Drawing.Point(731, 410);
            this.iptal.Margin = new System.Windows.Forms.Padding(2);
            this.iptal.Name = "iptal";
            this.iptal.Size = new System.Drawing.Size(140, 138);
            this.iptal.TabIndex = 15;
            this.iptal.Text = "İPTAL (ESC)";
            this.iptal.UseVisualStyleBackColor = false;
            this.iptal.Click += new System.EventHandler(this.iptal_Click);
            // 
            // UrunSil
            // 
            this.UrunSil.BackColor = System.Drawing.Color.Crimson;
            this.UrunSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UrunSil.ForeColor = System.Drawing.Color.White;
            this.UrunSil.Location = new System.Drawing.Point(583, 410);
            this.UrunSil.Margin = new System.Windows.Forms.Padding(2);
            this.UrunSil.Name = "UrunSil";
            this.UrunSil.Size = new System.Drawing.Size(144, 138);
            this.UrunSil.TabIndex = 14;
            this.UrunSil.Text = "ÜRÜN SİL (F2)";
            this.UrunSil.UseVisualStyleBackColor = false;
            this.UrunSil.Click += new System.EventHandler(this.UrunSil_Click);
            // 
            // UrunGuncelle
            // 
            this.UrunGuncelle.BackColor = System.Drawing.Color.Green;
            this.UrunGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UrunGuncelle.ForeColor = System.Drawing.Color.White;
            this.UrunGuncelle.Location = new System.Drawing.Point(387, 410);
            this.UrunGuncelle.Margin = new System.Windows.Forms.Padding(2);
            this.UrunGuncelle.Name = "UrunGuncelle";
            this.UrunGuncelle.Size = new System.Drawing.Size(191, 138);
            this.UrunGuncelle.TabIndex = 13;
            this.UrunGuncelle.Text = "ÜRÜN GÜNCELLE (F1)";
            this.UrunGuncelle.UseVisualStyleBackColor = false;
            this.UrunGuncelle.Click += new System.EventHandler(this.UrunGuncelle_Click);
            // 
            // UrunGelisFiyati
            // 
            this.UrunGelisFiyati.BackColor = System.Drawing.Color.SaddleBrown;
            this.UrunGelisFiyati.ForeColor = System.Drawing.Color.White;
            this.UrunGelisFiyati.Location = new System.Drawing.Point(232, 517);
            this.UrunGelisFiyati.Margin = new System.Windows.Forms.Padding(2);
            this.UrunGelisFiyati.Name = "UrunGelisFiyati";
            this.UrunGelisFiyati.Size = new System.Drawing.Size(151, 32);
            this.UrunGelisFiyati.TabIndex = 12;
            this.UrunGelisFiyati.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UrunGelisFiyati_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 517);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(227, 26);
            this.label6.TabIndex = 11;
            this.label6.Text = "ÜRÜN GELİŞ FİYATI:";
            // 
            // UrunFiyati
            // 
            this.UrunFiyati.BackColor = System.Drawing.Color.DarkOrange;
            this.UrunFiyati.ForeColor = System.Drawing.Color.White;
            this.UrunFiyati.Location = new System.Drawing.Point(232, 481);
            this.UrunFiyati.Margin = new System.Windows.Forms.Padding(2);
            this.UrunFiyati.Name = "UrunFiyati";
            this.UrunFiyati.Size = new System.Drawing.Size(151, 32);
            this.UrunFiyati.TabIndex = 10;
            this.UrunFiyati.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UrunFiyati_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 481);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 26);
            this.label5.TabIndex = 9;
            this.label5.Text = "ÜRÜN FİYATI:";
            // 
            // UrunAdi
            // 
            this.UrunAdi.BackColor = System.Drawing.SystemColors.Highlight;
            this.UrunAdi.ForeColor = System.Drawing.Color.White;
            this.UrunAdi.Location = new System.Drawing.Point(204, 445);
            this.UrunAdi.Margin = new System.Windows.Forms.Padding(2);
            this.UrunAdi.Name = "UrunAdi";
            this.UrunAdi.Size = new System.Drawing.Size(180, 32);
            this.UrunAdi.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 445);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "ÜRÜN ADI:";
            // 
            // UrunBarkodu
            // 
            this.UrunBarkodu.BackColor = System.Drawing.Color.Red;
            this.UrunBarkodu.ForeColor = System.Drawing.Color.White;
            this.UrunBarkodu.Location = new System.Drawing.Point(204, 410);
            this.UrunBarkodu.Margin = new System.Windows.Forms.Padding(2);
            this.UrunBarkodu.Name = "UrunBarkodu";
            this.UrunBarkodu.Size = new System.Drawing.Size(180, 32);
            this.UrunBarkodu.TabIndex = 4;
            this.UrunBarkodu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UrunBarkodu_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 410);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "ÜRÜN BARKODU:";
            // 
            // UrunGostergesi
            // 
            this.UrunGostergesi.AllowUserToDeleteRows = false;
            this.UrunGostergesi.AutoGenerateColumns = false;
            this.UrunGostergesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.UrunGostergesi.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.UrunGostergesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UrunGostergesi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.barkodNoDataGridViewTextBoxColumn,
            this.urunAdiDataGridViewTextBoxColumn,
            this.urunFiyatiDataGridViewTextBoxColumn,
            this.urunGelisFiyatiDataGridViewTextBoxColumn,
            this.urunSatisFiyatiDataGridViewTextBoxColumn});
            this.UrunGostergesi.DataSource = this.urunlerBindingSource;
            this.UrunGostergesi.Location = new System.Drawing.Point(5, 58);
            this.UrunGostergesi.Margin = new System.Windows.Forms.Padding(2);
            this.UrunGostergesi.Name = "UrunGostergesi";
            this.UrunGostergesi.ReadOnly = true;
            this.UrunGostergesi.RowTemplate.Height = 24;
            this.UrunGostergesi.Size = new System.Drawing.Size(866, 341);
            this.UrunGostergesi.TabIndex = 2;
            this.UrunGostergesi.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.UrunGostergesi_CellMouseDoubleClick);
            // 
            // barkodNoDataGridViewTextBoxColumn
            // 
            this.barkodNoDataGridViewTextBoxColumn.DataPropertyName = "BarkodNo";
            this.barkodNoDataGridViewTextBoxColumn.HeaderText = "BarkodNo";
            this.barkodNoDataGridViewTextBoxColumn.Name = "barkodNoDataGridViewTextBoxColumn";
            this.barkodNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.barkodNoDataGridViewTextBoxColumn.Width = 134;
            // 
            // urunAdiDataGridViewTextBoxColumn
            // 
            this.urunAdiDataGridViewTextBoxColumn.DataPropertyName = "UrunAdi";
            this.urunAdiDataGridViewTextBoxColumn.HeaderText = "UrunAdi";
            this.urunAdiDataGridViewTextBoxColumn.Name = "urunAdiDataGridViewTextBoxColumn";
            this.urunAdiDataGridViewTextBoxColumn.ReadOnly = true;
            this.urunAdiDataGridViewTextBoxColumn.Width = 116;
            // 
            // urunFiyatiDataGridViewTextBoxColumn
            // 
            this.urunFiyatiDataGridViewTextBoxColumn.DataPropertyName = "UrunFiyati";
            this.urunFiyatiDataGridViewTextBoxColumn.HeaderText = "UrunFiyati";
            this.urunFiyatiDataGridViewTextBoxColumn.Name = "urunFiyatiDataGridViewTextBoxColumn";
            this.urunFiyatiDataGridViewTextBoxColumn.ReadOnly = true;
            this.urunFiyatiDataGridViewTextBoxColumn.Width = 136;
            // 
            // urunGelisFiyatiDataGridViewTextBoxColumn
            // 
            this.urunGelisFiyatiDataGridViewTextBoxColumn.DataPropertyName = "UrunGelisFiyati";
            this.urunGelisFiyatiDataGridViewTextBoxColumn.HeaderText = "UrunGelisFiyati";
            this.urunGelisFiyatiDataGridViewTextBoxColumn.Name = "urunGelisFiyatiDataGridViewTextBoxColumn";
            this.urunGelisFiyatiDataGridViewTextBoxColumn.ReadOnly = true;
            this.urunGelisFiyatiDataGridViewTextBoxColumn.Width = 186;
            // 
            // urunSatisFiyatiDataGridViewTextBoxColumn
            // 
            this.urunSatisFiyatiDataGridViewTextBoxColumn.DataPropertyName = "UrunSatisFiyati";
            this.urunSatisFiyatiDataGridViewTextBoxColumn.HeaderText = "UrunSatisFiyati";
            this.urunSatisFiyatiDataGridViewTextBoxColumn.Name = "urunSatisFiyatiDataGridViewTextBoxColumn";
            this.urunSatisFiyatiDataGridViewTextBoxColumn.ReadOnly = true;
            this.urunSatisFiyatiDataGridViewTextBoxColumn.Width = 185;
            // 
            // urunlerBindingSource
            // 
            this.urunlerBindingSource.DataMember = "Urunler";
            this.urunlerBindingSource.DataSource = this.veriDataSet5;
            // 
            // veriDataSet5
            // 
            this.veriDataSet5.DataSetName = "VeriDataSet5";
            this.veriDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BarkodOkut
            // 
            this.BarkodOkut.BackColor = System.Drawing.Color.Red;
            this.BarkodOkut.ForeColor = System.Drawing.Color.White;
            this.BarkodOkut.Location = new System.Drawing.Point(615, 18);
            this.BarkodOkut.Margin = new System.Windows.Forms.Padding(2);
            this.BarkodOkut.Name = "BarkodOkut";
            this.BarkodOkut.Size = new System.Drawing.Size(257, 32);
            this.BarkodOkut.TabIndex = 1;
            this.BarkodOkut.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BarkodOkut_KeyDown);
            this.BarkodOkut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BarkodOkut_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(508, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "BARKOD:";
            // 
            // urunlerTableAdapter
            // 
            this.urunlerTableAdapter.ClearBeforeFill = true;
            // 
            // Urunislemleriformu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(887, 571);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Urunislemleriformu";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ÜRÜN İŞLEMLERİ";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Urunislemleriformu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Urunislemleriformu_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UrunGostergesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veriDataSet5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView UrunGostergesi;
        private System.Windows.Forms.TextBox BarkodOkut;
        private System.Windows.Forms.Label label1;
        private VeriDataSet5 veriDataSet5;
        private System.Windows.Forms.BindingSource urunlerBindingSource;
        private VeriDataSet5TableAdapters.UrunlerTableAdapter urunlerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn barkodNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunFiyatiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunGelisFiyatiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunSatisFiyatiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button UrunSil;
        private System.Windows.Forms.Button UrunGuncelle;
        private System.Windows.Forms.TextBox UrunGelisFiyati;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox UrunFiyati;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox UrunAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UrunBarkodu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button iptal;
    }
}