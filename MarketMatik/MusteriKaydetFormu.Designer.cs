namespace MarketMatik
{
    partial class MusteriKaydetFormu
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
            this.button1 = new System.Windows.Forms.Button();
            this.MusteriKaydetFormuMusteriGiris = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.MusteriKaydetFormuMusteriGiris);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(675, 231);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MÜŞTERİ KAYDET";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(439, 138);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(230, 83);
            this.button2.TabIndex = 3;
            this.button2.Text = "İPTAL (ESC)";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGreen;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(439, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 83);
            this.button1.TabIndex = 2;
            this.button1.Text = "KAYDET (F1)";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MusteriKaydetFormuMusteriGiris
            // 
            this.MusteriKaydetFormuMusteriGiris.BackColor = System.Drawing.SystemColors.HotTrack;
            this.MusteriKaydetFormuMusteriGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MusteriKaydetFormuMusteriGiris.ForeColor = System.Drawing.Color.White;
            this.MusteriKaydetFormuMusteriGiris.Location = new System.Drawing.Point(6, 90);
            this.MusteriKaydetFormuMusteriGiris.Multiline = true;
            this.MusteriKaydetFormuMusteriGiris.Name = "MusteriKaydetFormuMusteriGiris";
            this.MusteriKaydetFormuMusteriGiris.Size = new System.Drawing.Size(427, 131);
            this.MusteriKaydetFormuMusteriGiris.TabIndex = 1;
            this.MusteriKaydetFormuMusteriGiris.TextChanged += new System.EventHandler(this.MusteriKaydetFormuMusteriGiris_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(6, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "MÜŞTERİ ADI VEYA DAİRE NO:";
            // 
            // MusteriKaydetFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(691, 248);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MusteriKaydetFormu";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MusteriKaydetFormu";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MusteriKaydetFormu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MusteriKaydetFormu_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox MusteriKaydetFormuMusteriGiris;
        private System.Windows.Forms.Label label1;
    }
}