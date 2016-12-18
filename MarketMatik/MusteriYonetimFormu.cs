using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarketMatik.MODEL;

namespace MarketMatik
{
    public partial class MusteriYonetimFormu : Form
    {
        
        public double MusteriBorcu;
        public AnaForm form12 = (AnaForm)Application.OpenForms["AnaForm"];
        public VeriEntities3 db;
        public MusteriCariOdeUfakEkrani mustericariodeformu;
        public string ad, cari;

        public MusteriYonetimFormu()
        {
            InitializeComponent();
            db = new VeriEntities3();
        }
        private void MusteriYonetimFormu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'veriDataSet1.Musteriler' table. You can move, or remove it, as needed.
            this.musterilerTableAdapter1.Fill(this.veriDataSet1.Musteriler);
            this.musterilerTableAdapter.Fill(this.veriDataSet.Musteriler);
            var liste = db.Musteriler.Where(p => p.MusteriBakiyesi != "0").ToList();
            foreach (var a in liste)
            {
                double alinan = double.Parse(a.MusteriBakiyesi);
                double toplam = MusteriBorcu + alinan;
                MusteriBorcu = toplam;

            }
            textBox1.Text = MusteriBorcu.ToString();
          
        }
        private void IptalTusu_Click(object sender, EventArgs e)
        {
            this.Close();
            form12.Visible = true;
        }
        private void CariOdeTusu_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < MusteriSecmeYeri.Rows.Count - 1; i++) //hata alirsan "dataGridinIsmi.Rows.Count -1" yap 
            {
                if (MusteriSecmeYeri.Rows[i].Cells[0].Value.ToString() == MusteriAramaYeri.Text)
                {
                    mustericariodeformu = new MusteriCariOdeUfakEkrani();
                    ad = MusteriSecmeYeri.Rows[i].Cells[0].Value.ToString();
                    cari = MusteriSecmeYeri.Rows[i].Cells[1].Value.ToString();
                    mustericariodeformu.cariodemusteriadi.Text = ad;
                    mustericariodeformu.cariodemustericarisi.Text = cari;
                    mustericariodeformu.yenimusteriadi.Text = ad;
                    mustericariodeformu.Show();
                    this.Close();
                    
                }
            }
        }

        private void MusteriSecmeYeri_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            int xkoordinat = MusteriSecmeYeri.CurrentCellAddress.X; //Seçili satırın X koordinatı
            int ykoordinat = MusteriSecmeYeri.CurrentCellAddress.Y;  //Seçili satırın Y koordinatı
            string str = "";
            str = MusteriSecmeYeri.Rows[ykoordinat].Cells[xkoordinat].Value.ToString();
            if (e.RowIndex == -1)
            {
                return;
            }
            ad = str;
            MusteriAramaYeri.Text = ad;
        }

        private void CariiptalTusu_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < MusteriSecmeYeri.Rows.Count - 1; i++) //hata alirsan "dataGridinIsmi.Rows.Count -1" yap 
            {
                if (MusteriSecmeYeri.Rows[i].Cells[0].Value.ToString() == MusteriAramaYeri.Text)
                {
                    mustericariodeformu = new MusteriCariOdeUfakEkrani();
                    ad = MusteriSecmeYeri.Rows[i].Cells[0].Value.ToString();
                    cari = MusteriSecmeYeri.Rows[i].Cells[1].Value.ToString();
                    mustericariodeformu.cariodemusteriadi.Text = ad;
                    mustericariodeformu.cariodemustericarisi.Text = cari;
                    mustericariodeformu.yenimusteriadi.Text = ad;
                    mustericariodeformu.Show();
                    this.Close();
                   
                }
            }
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < MusteriSecmeYeri.Rows.Count - 1; i++) //hata alirsan "dataGridinIsmi.Rows.Count -1" yap 
            {
                if (MusteriSecmeYeri.Rows[i].Cells[0].Value.ToString() == MusteriAramaYeri.Text)
                {
                    mustericariodeformu = new MusteriCariOdeUfakEkrani();
                    ad = MusteriSecmeYeri.Rows[i].Cells[0].Value.ToString();
                    cari = MusteriSecmeYeri.Rows[i].Cells[1].Value.ToString();
                    mustericariodeformu.cariodemusteriadi.Text = ad;
                    mustericariodeformu.cariodemustericarisi.Text = cari;
                    mustericariodeformu.yenimusteriadi.Text = ad;
                    mustericariodeformu.Show();
                    this.Close();
                   
                }
            }
        }

        private void MusteriYonetimFormu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                IptalTusu.PerformClick();
            }
            if (e.KeyCode == Keys.F1)
            {
                CariOdeTusu.PerformClick();
            }
            if (e.KeyCode == Keys.F2)
            {
                CariiptalTusu.PerformClick();
            }
            if (e.KeyCode == Keys.F3)
            {
                button1.PerformClick();
            }
        }

        private void MusteriAramaYeri_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData.ToString() == "Return")
            {
                for (int i = 0; i < MusteriSecmeYeri.Rows.Count - 1; i++) //hata alirsan "dataGridinIsmi.Rows.Count -1" yap 
                {
                    if (MusteriSecmeYeri.Rows[i].Cells[0].Value.ToString() == MusteriAramaYeri.Text)
                    {
                        mustericariodeformu = new MusteriCariOdeUfakEkrani();
                        ad = MusteriSecmeYeri.Rows[i].Cells[0].Value.ToString();
                        cari = MusteriSecmeYeri.Rows[i].Cells[1].Value.ToString();
                        mustericariodeformu.cariodemusteriadi.Text = ad;
                        mustericariodeformu.cariodemustericarisi.Text = cari;
                        mustericariodeformu.yenimusteriadi.Text = ad;
                        mustericariodeformu.Show();
                        this.Close();
                    }
                }
            }
            else if (e.KeyData.ToString() == "Esc")
            {
                MusteriAramaYeri.Text = "";
            }
        }
    }
}
