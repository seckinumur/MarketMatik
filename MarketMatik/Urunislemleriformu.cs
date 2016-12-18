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
    public partial class Urunislemleriformu : Form
    {
        VeriEntities3 db;
        public AnaForm form134 = (AnaForm)Application.OpenForms["AnaForm"];
        public Urunislemleriformu()
        {
            InitializeComponent();
            db = new VeriEntities3();
        }

        private void Urunislemleriformu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'veriDataSet5.Urunler' table. You can move, or remove it, as needed.
            this.urunlerTableAdapter.Fill(this.veriDataSet5.Urunler);
        }

        private void iptal_Click(object sender, EventArgs e)
        {
            this.Close();
            form134.Visible = true;
        }

        private void UrunGostergesi_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int xkoordinat = UrunGostergesi.CurrentCellAddress.X; //Seçili satırın X koordinatı
            int ykoordinat = UrunGostergesi.CurrentCellAddress.Y;  //Seçili satırın Y koordinatı
            string str = "";
            str = UrunGostergesi.Rows[ykoordinat].Cells[xkoordinat].Value.ToString();
            if (e.RowIndex == -1)
            {
                return;
            }
            BarkodOkut.Text = str;
            Urunler urunler = new Urunler();
            var urundegistir = db.Urunler.Where(w => w.BarkodNo == str).FirstOrDefault();
            try
            {
                UrunBarkodu.Text = urundegistir.BarkodNo;
                UrunAdi.Text = urundegistir.UrunAdi;
                UrunFiyati.Text = urundegistir.UrunFiyati;
                UrunGelisFiyati.Text = urundegistir.UrunGelisFiyati;
            }
            catch
            {
                MessageBox.Show("SADECE BARKOD NUMARASINI SEÇİN ÜRÜN İSMİNİ DEĞİL", "KULLANICI HATASI");
            }
        }

        private void BarkodOkut_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData.ToString() == "Return")
            {
                if (BarkodOkut.Text == "" || BarkodOkut.Text == " ")
                {
                    MessageBox.Show("GEÇERLİ BİR BARKOD KODU GİRİN!", "KULLANICI HATASI");
                }
                else
                {
                    string str;
                    str = BarkodOkut.Text;
                    Urunler urunler = new Urunler();
                    var urundegistir = db.Urunler.Where(w => w.BarkodNo == str).FirstOrDefault();
                    try
                    {
                        UrunBarkodu.Text = urundegistir.BarkodNo;
                        UrunAdi.Text = urundegistir.UrunAdi;
                        UrunFiyati.Text = urundegistir.UrunFiyati;
                        UrunGelisFiyati.Text = urundegistir.UrunGelisFiyati;
                    }
                    catch
                    {
                        MessageBox.Show("VERİTABNINA BAĞLANILAMADI.", "ÖLÜMCÜL HATA");
                    }
                }
            }
        }

        private void UrunGuncelle_Click(object sender, EventArgs e)
        {
            DialogResult Uyari = new DialogResult();
            Uyari = MessageBox.Show("ÜRÜN GÜNCELLENECEK DEVAM EDİLSİN Mİ?", "DİKKAT!", MessageBoxButtons.YesNo);
            if (Uyari == DialogResult.Yes)
            {
                if (UrunBarkodu.Text == "" || UrunBarkodu.Text == " " || BarkodOkut.Text == "" || BarkodOkut.Text == " " || UrunAdi.Text == "" || UrunAdi.Text == " " || UrunFiyati.Text == "" || UrunFiyati.Text == " " || UrunGelisFiyati.Text == "" || UrunGelisFiyati.Text == " ")
                {
                    MessageBox.Show("ÜRÜN BİLGİLERİ BOŞ BIRAKALAMAZ VE YENİ ÜRÜN GİRİŞİ YAPILAMAZ. ÜRÜN BİLGİLERİNİ DOLDURUN YADA ÜRÜN KAYDET BUTONUNDAN YENİ ÜRÜN GİRİŞİ YAPIN", "KULLANICI HATASI");
                }
                else
                {
                    string str;
                    str = BarkodOkut.Text;
                    Urunler urunler = new Urunler();
                    var urundegistir = db.Urunler.Where(w => w.BarkodNo == str).FirstOrDefault();
                    try
                    {
                        urundegistir.BarkodNo = UrunBarkodu.Text;
                        urundegistir.UrunAdi = UrunAdi.Text;
                        urundegistir.UrunFiyati = UrunFiyati.Text;
                        urundegistir.UrunGelisFiyati = UrunGelisFiyati.Text;
                        db.SaveChanges();
                        MessageBox.Show("ÜRÜN BAŞARIYLA GÜNCELLENDİ!", "VERİTABANI İŞLEMLERİ");
                        this.Close();
                        form134.Visible = true;
                    }
                    catch
                    {
                        MessageBox.Show("VERİTABNINA BAĞLANILAMADI.", "ÖLÜMCÜL HATA");
                    }
                }
            }
        }

        private void UrunSil_Click(object sender, EventArgs e)
        {
            DialogResult Uyari = new DialogResult();
            Uyari = MessageBox.Show("ÜRÜN SİLİNECEK DEVAM EDİLSİN Mİ?", "DİKKAT!", MessageBoxButtons.YesNo);
            if (Uyari == DialogResult.Yes)
            {

                string str;
                str = BarkodOkut.Text;
                Urunler urunler = new Urunler();
                var urundegistir = db.Urunler.Where(w => w.BarkodNo == str).FirstOrDefault();
                try
                {
                    db.Urunler.Remove(urundegistir);
                    db.SaveChanges();
                    MessageBox.Show("ÜRÜN BAŞARIYLA SİLİNDİ!", "VERİTABANI İŞLEMLERİ");
                    this.Close();
                    form134.Visible = true;
                }
                catch
                {
                    MessageBox.Show("VERİTABNINA BAĞLANILAMADI.", "ÖLÜMCÜL HATA");
                }

            }
        }

        private void BarkodOkut_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsLetter(e.KeyChar) || Char.IsSymbol(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar);
        }

        private void UrunBarkodu_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsLetter(e.KeyChar) || Char.IsSymbol(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar);
        }

        private void UrunFiyati_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsLetter(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar);
        }

        private void UrunGelisFiyati_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsLetter(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar);
        }

        private void Urunislemleriformu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                iptal.PerformClick();
            }
            if (e.KeyCode == Keys.F2)
            {
                UrunSil.PerformClick();
            }
            if (e.KeyCode == Keys.F1)
            {
                UrunGuncelle.PerformClick();
            }
        }
    }
}
