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
    public partial class UrunKaydet : Form
    {
        public AnaForm anaform;
        public AnaForm form1334 = (AnaForm)Application.OpenForms["AnaForm"];
        public UrunKaydet()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            form1334.Visible = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void UrunKaydet_Load(object sender, EventArgs e)
        {

        }

        private void UrunKaydetTusu_Click(object sender, EventArgs e)
        {
            VeriEntities3 db = new VeriEntities3();
            Urunler urunler = new Urunler();
            if (UrunKaydetBarkodNumarasi.Text == "" || UrunKaydetGelisFiyati.Text == "" || UrunKAydetSatisFiyati.Text == "" || UrunKaydetUrunAdi.Text == "")
            {
                MessageBox.Show("ÜRÜNÜN TÜM BİLGİLERİNİ DOLDURUNUZ!"+"HATA!");
            }
            else
            {
                try
                {
                    urunler.BarkodNo = UrunKaydetBarkodNumarasi.Text;
                    urunler.UrunAdi = UrunKaydetUrunAdi.Text;
                    urunler.UrunFiyati = UrunKAydetSatisFiyati.Text;
                    urunler.UrunGelisFiyati = UrunKaydetGelisFiyati.Text;
                    urunler.UrunSatisFiyati = "0";
                    db.Urunler.Add(urunler);
                    db.SaveChanges();
                    MessageBox.Show("Ürün Kaydetme Başarılı, EĞER SATIŞ ESNASINDA ÜRÜNÜ KAYDETTİYSENİZ BİR DAHA BARKODU OKUTUN", "ÜRÜN İŞLEMLERİ");
                    this.Close();
                    form1334.Visible = true;
                }
                catch
                {
                    MessageBox.Show("ÜRÜN LİSTESİNE DAHA ÖNCEDEN KAYDEDİLMİŞ BARKOD KODUYLA ÜRÜN EKLENMEK İSTENDİ!, EĞER ÜRÜN DEĞİŞTİRİLMEK İSTENİYORSA ÖNCE ÜRÜNÜ SİLİNİZ.", "HATA!");
                }
            }
        }

        private void UrunKaydetBarkodNumarasi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsLetter(e.KeyChar) || Char.IsSymbol(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar);
        }

        private void UrunKaydetGelisFiyati_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsLetter(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar);
        }

        private void UrunKAydetSatisFiyati_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsLetter(e.KeyChar)   || Char.IsWhiteSpace(e.KeyChar);
        }

        private void UrunKaydetGelisFiyati_TextChanged(object sender, EventArgs e)
        {

        }

        private void UrunKaydet_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                button2.PerformClick();
            }
            if (e.KeyCode == Keys.F1)
            {
                UrunKaydetTusu.PerformClick();
            }
        }
    }
}
