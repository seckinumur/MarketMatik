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
    public partial class MusteriKaydetFormu : Form
    {
        public AnaForm form1 = (AnaForm)Application.OpenForms["AnaForm"];
        public MusteriKaydetFormu()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            MusteriKaydetFormuMusteriGiris.Text = "";
            this.Close();

            form1.Visible = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string Karsilastir = MusteriKaydetFormuMusteriGiris.Text;
            VeriEntities3 db = new VeriEntities3();
            Musteriler musteriler = new Musteriler();
            if (MusteriKaydetFormuMusteriGiris.Text == "")
            {
                MessageBox.Show("MÜSTERİ ADI BOŞ BIRAKILAMAZ!", "VERİTABANI VERİ GİRİŞİ HATASI!");
            }
            else
            {
                try
                {
                    bool varmi = db.Musteriler.Any(p => p.MusteriAdi.Contains(Karsilastir));
                    if (varmi == true)
                    {
                        MessageBox.Show("AYNI MÜŞTERİ VERİTABANINA DAHA ÖNCE KAYDEDİLMİŞ.", "VERİTABANI VERİ GİRİŞİ HATASI!!");
                    }
                    else
                    {
                        musteriler.MusteriAdi = Karsilastir.ToString();
                        musteriler.MusteriBakiyesi = "0";
                        db.Musteriler.Add(musteriler);
                        db.SaveChanges();
                        MessageBox.Show("Müşteri Başarıyla Kaydedildi.", "VERİTABANI İŞLEMLERİ");
                        MusteriKaydetFormuMusteriGiris.Text = "";
                        this.Close();
                    }
                }
                catch
                {
                    MessageBox.Show("DÖNGÜSEL VERİTABANI BAĞLANTI HATASI!", "VERİTABANI ÖLÜMCÜL HATA!");
                }
            }
        }
        private void MusteriKaydetFormu_Load(object sender, EventArgs e)
        {
        }
        private void MusteriKaydetFormuMusteriGiris_TextChanged(object sender, EventArgs e)
        {
            MusteriKaydetFormuMusteriGiris.Text = MusteriKaydetFormuMusteriGiris.Text.ToLower();
            MusteriKaydetFormuMusteriGiris.SelectionStart = MusteriKaydetFormuMusteriGiris.Text.Length;
        }

        private void MusteriKaydetFormu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                button2.PerformClick();
            }
            if (e.KeyCode == Keys.F1)
            {
                button1.PerformClick();
            }
        }
    }
}
