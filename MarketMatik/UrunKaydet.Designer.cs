namespace MarketMatik
{
    partial class UrunKaydet
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.UrunKaydetTusu = new System.Windows.Forms.Button();
            this.UrunKAydetSatisFiyati = new System.Windows.Forms.TextBox();
            this.UrunKaydetGelisFiyati = new System.Windows.Forms.TextBox();
            this.UrunKaydetUrunAdi = new System.Windows.Forms.TextBox();
            this.UrunKaydetBarkodNumarasi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.UrunKaydetTusu);
            this.groupBox1.Controls.Add(this.UrunKAydetSatisFiyati);
            this.groupBox1.Controls.Add(this.UrunKaydetGelisFiyati);
            this.groupBox1.Controls.Add(this.UrunKaydetUrunAdi);
            this.groupBox1.Controls.Add(this.UrunKaydetBarkodNumarasi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(806, 243);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Ürün Kaydet";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(553, 133);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(247, 90);
            this.button2.TabIndex = 9;
            this.button2.Text = "İPTAL (ESC)";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UrunKaydetTusu
            // 
            this.UrunKaydetTusu.BackColor = System.Drawing.Color.Green;
            this.UrunKaydetTusu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UrunKaydetTusu.Location = new System.Drawing.Point(553, 41);
            this.UrunKaydetTusu.Name = "UrunKaydetTusu";
            this.UrunKaydetTusu.Size = new System.Drawing.Size(247, 90);
            this.UrunKaydetTusu.TabIndex = 8;
            this.UrunKaydetTusu.Text = "KAYDET (F1)";
            this.UrunKaydetTusu.UseVisualStyleBackColor = false;
            this.UrunKaydetTusu.Click += new System.EventHandler(this.UrunKaydetTusu_Click);
            // 
            // UrunKAydetSatisFiyati
            // 
            this.UrunKAydetSatisFiyati.BackColor = System.Drawing.Color.Navy;
            this.UrunKAydetSatisFiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UrunKAydetSatisFiyati.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UrunKAydetSatisFiyati.Location = new System.Drawing.Point(271, 179);
            this.UrunKAydetSatisFiyati.Name = "UrunKAydetSatisFiyati";
            this.UrunKAydetSatisFiyati.Size = new System.Drawing.Size(276, 44);
            this.UrunKAydetSatisFiyati.TabIndex = 7;
            this.UrunKAydetSatisFiyati.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UrunKAydetSatisFiyati_KeyPress);
            // 
            // UrunKaydetGelisFiyati
            // 
            this.UrunKaydetGelisFiyati.BackColor = System.Drawing.Color.DarkGreen;
            this.UrunKaydetGelisFiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UrunKaydetGelisFiyati.ForeColor = System.Drawing.Color.Honeydew;
            this.UrunKaydetGelisFiyati.Location = new System.Drawing.Point(271, 133);
            this.UrunKaydetGelisFiyati.Name = "UrunKaydetGelisFiyati";
            this.UrunKaydetGelisFiyati.Size = new System.Drawing.Size(276, 44);
            this.UrunKaydetGelisFiyati.TabIndex = 6;
            this.UrunKaydetGelisFiyati.TextChanged += new System.EventHandler(this.UrunKaydetGelisFiyati_TextChanged);
            this.UrunKaydetGelisFiyati.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UrunKaydetGelisFiyati_KeyPress);
            // 
            // UrunKaydetUrunAdi
            // 
            this.UrunKaydetUrunAdi.BackColor = System.Drawing.SystemColors.HotTrack;
            this.UrunKaydetUrunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UrunKaydetUrunAdi.ForeColor = System.Drawing.SystemColors.Window;
            this.UrunKaydetUrunAdi.Location = new System.Drawing.Point(271, 87);
            this.UrunKaydetUrunAdi.Name = "UrunKaydetUrunAdi";
            this.UrunKaydetUrunAdi.Size = new System.Drawing.Size(276, 44);
            this.UrunKaydetUrunAdi.TabIndex = 5;
            // 
            // UrunKaydetBarkodNumarasi
            // 
            this.UrunKaydetBarkodNumarasi.BackColor = System.Drawing.Color.DarkRed;
            this.UrunKaydetBarkodNumarasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UrunKaydetBarkodNumarasi.ForeColor = System.Drawing.SystemColors.Window;
            this.UrunKaydetBarkodNumarasi.Location = new System.Drawing.Point(271, 41);
            this.UrunKaydetBarkodNumarasi.Name = "UrunKaydetBarkodNumarasi";
            this.UrunKaydetBarkodNumarasi.Size = new System.Drawing.Size(276, 44);
            this.UrunKaydetBarkodNumarasi.TabIndex = 4;
            this.UrunKaydetBarkodNumarasi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UrunKaydetBarkodNumarasi_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "SATIŞ FİYATI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "GELİŞ FİYATI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "BARKOD NUMARASI:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "ÜRÜN ADI:";
            // 
            // UrunKaydet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(818, 253);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UrunKaydet";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UrunKaydet";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.UrunKaydet_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UrunKaydet_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button UrunKaydetTusu;
        private System.Windows.Forms.TextBox UrunKAydetSatisFiyati;
        private System.Windows.Forms.TextBox UrunKaydetGelisFiyati;
        private System.Windows.Forms.TextBox UrunKaydetUrunAdi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox UrunKaydetBarkodNumarasi;
    }
}