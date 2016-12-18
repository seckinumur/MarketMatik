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
using Microsoft.VisualBasic;
using Microsoft.PointOfService;

namespace MarketMatik
{
    public partial class AnaForm : Form
    {
        public VeresiyeSecmeFormu veresiyesecme;
        public MusteriCariOdeUfakEkrani musteriodeekrani;
        public string Tarih = DateTime.Now.ToShortDateString();
        public UrunKaydet urunkaydetformu;
        public  double kar = 0;
        public MusteriYonetimFormu musteriyonetimformu;
        public Urunislemleriformu urunislemleriformu;
        public Giderlerformu giderlerformu;
        public KarsilamaEkrani ac;
        public  double AnlikKar = 0 ;
        public  double AnlikCiro = 0;
        public  int sayac = 0;
        public  double AnlikSatisToplam = 0;
        public  double SonucToplam = 0;
        public  bool KONTROL = false;
        public  string Musterisecimi;
        public string Ay = DateTime.Now.Month.ToString();
        public VeriEntities3 db;
        PosPrinter Yazici;
        public int bakbakalim = 0;
        public AnaForm()
        {
            InitializeComponent();
            db = new VeriEntities3();
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {

            dataGridView1.Columns.Add("Barkod", "Barkod No:");
            dataGridView1.Columns.Add("Urunadi", "Ürün Adi:");
            dataGridView1.Columns.Add("Fiyat", "Fiyatı:");
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            urunkaydetformu = new UrunKaydet();
            urunkaydetformu.Show();
            this.Visible = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            MusteriKaydetFormu musterikaydetformu = new MusteriKaydetFormu();
            musterikaydetformu.Show();
            this.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double toplamtutar, sonuc;
            double.TryParse(ToplamTutarTextBox.Text, out toplamtutar);
            if (toplamtutar <= 5)
            {
                sonuc = 5 - toplamtutar;
                ParaUstuTextBox.Text = sonuc.ToString();
                BesTL.BackColor = Color.OrangeRed;
                OnTl.BackColor = Color.OrangeRed;
                YirmiTl.BackColor = Color.OrangeRed;
                ElliTl.BackColor = Color.OrangeRed;
                YuzTl.BackColor = Color.OrangeRed;
                IkiyuzTl.BackColor = Color.OrangeRed;
            }
            else
            {
                BesTL.BackColor = Color.Black;
                OnTl.BackColor = Color.OrangeRed;
                YirmiTl.BackColor = Color.OrangeRed;
                ElliTl.BackColor = Color.OrangeRed;
                YuzTl.BackColor = Color.OrangeRed;
                IkiyuzTl.BackColor = Color.OrangeRed;
            }
        }

        private void OnTl_Click(object sender, EventArgs e)
        {
            double toplamtutar, sonuc;
            double.TryParse(ToplamTutarTextBox.Text, out toplamtutar);
            if (toplamtutar <= 10)
            {
                sonuc = 10 - toplamtutar;
                ParaUstuTextBox.Text = sonuc.ToString();
                BesTL.BackColor = Color.OrangeRed;
                OnTl.BackColor = Color.OrangeRed;
                YirmiTl.BackColor = Color.OrangeRed;
                ElliTl.BackColor = Color.OrangeRed;
                YuzTl.BackColor = Color.OrangeRed;
                IkiyuzTl.BackColor = Color.OrangeRed;
            }
            else
            {
                BesTL.BackColor = Color.Black;
                OnTl.BackColor = Color.Black;
                YirmiTl.BackColor = Color.OrangeRed;
                ElliTl.BackColor = Color.OrangeRed;
                YuzTl.BackColor = Color.OrangeRed;
                IkiyuzTl.BackColor = Color.OrangeRed;
            }
        }

        private void YirmiTl_Click(object sender, EventArgs e)
        {
            double toplamtutar, sonuc;
            double.TryParse(ToplamTutarTextBox.Text, out toplamtutar);
            if (toplamtutar <= 20)
            {
                sonuc = 20 - toplamtutar;
                ParaUstuTextBox.Text = sonuc.ToString();
                BesTL.BackColor = Color.OrangeRed;
                OnTl.BackColor = Color.OrangeRed;
                YirmiTl.BackColor = Color.OrangeRed;
                ElliTl.BackColor = Color.OrangeRed;
                YuzTl.BackColor = Color.OrangeRed;
                IkiyuzTl.BackColor = Color.OrangeRed;
            }
            else
            {
                BesTL.BackColor = Color.Black;
                OnTl.BackColor = Color.Black;
                YirmiTl.BackColor = Color.Black;
                ElliTl.BackColor = Color.OrangeRed;
                YuzTl.BackColor = Color.OrangeRed;
                IkiyuzTl.BackColor = Color.OrangeRed;
            }
        }

        private void ElliTl_Click(object sender, EventArgs e)
        {
            double toplamtutar, sonuc;
            double.TryParse(ToplamTutarTextBox.Text, out toplamtutar);
            if (toplamtutar <= 50)
            {
                sonuc = 50 - toplamtutar;
                ParaUstuTextBox.Text = sonuc.ToString();
                BesTL.BackColor = Color.OrangeRed;
                OnTl.BackColor = Color.OrangeRed;
                YirmiTl.BackColor = Color.OrangeRed;
                ElliTl.BackColor = Color.OrangeRed;
                YuzTl.BackColor = Color.OrangeRed;
                IkiyuzTl.BackColor = Color.OrangeRed;
            }
            else
            {
                BesTL.BackColor = Color.Black;
                OnTl.BackColor = Color.Black;
                YirmiTl.BackColor = Color.Black;
                ElliTl.BackColor = Color.Black;
                YuzTl.BackColor = Color.OrangeRed;
                IkiyuzTl.BackColor = Color.OrangeRed;
            }
        }

        private void YuzTl_Click(object sender, EventArgs e)
        {
            double toplamtutar, sonuc;
            double.TryParse(ToplamTutarTextBox.Text, out toplamtutar);
            if (toplamtutar <= 100)
            {
                sonuc = 100 - toplamtutar;
                ParaUstuTextBox.Text = sonuc.ToString();
                BesTL.BackColor = Color.OrangeRed;
                OnTl.BackColor = Color.OrangeRed;
                YirmiTl.BackColor = Color.OrangeRed;
                ElliTl.BackColor = Color.OrangeRed;
                YuzTl.BackColor = Color.OrangeRed;
                IkiyuzTl.BackColor = Color.OrangeRed;
            }
            else
            {
                BesTL.BackColor = Color.Black;
                OnTl.BackColor = Color.Black;
                YirmiTl.BackColor = Color.Black;
                ElliTl.BackColor = Color.Black;
                YuzTl.BackColor = Color.Black;
                IkiyuzTl.BackColor = Color.OrangeRed;
            }
        }

        private void IkiyuzTl_Click(object sender, EventArgs e)
        {
            double toplamtutar, sonuc;
            double.TryParse(ToplamTutarTextBox.Text, out toplamtutar);
            if (toplamtutar <= 200)
            {
                sonuc = 200 - toplamtutar;
                ParaUstuTextBox.Text = sonuc.ToString();
                BesTL.BackColor = Color.OrangeRed;
                OnTl.BackColor = Color.OrangeRed;
                YirmiTl.BackColor = Color.OrangeRed;
                ElliTl.BackColor = Color.OrangeRed;
                YuzTl.BackColor = Color.OrangeRed;
                IkiyuzTl.BackColor = Color.OrangeRed;
            }
            else
            {
                BesTL.BackColor = Color.Black;
                OnTl.BackColor = Color.Black;
                YirmiTl.BackColor = Color.Black;
                ElliTl.BackColor = Color.Black;
                YuzTl.BackColor = Color.Black;
                IkiyuzTl.BackColor = Color.Black;
            }
        }

        private void BarkotOkumaBolgesi_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyData.ToString() == "Return")
            {
                if (BarkotOkumaBolgesi.Text == "" || BarkotOkumaBolgesi.Text == " ")
                {
                    MessageBox.Show("DÖNGÜSEL VERİ ALIM HATASI! BARKOD KODU ALGILANAMADI YADA TERMİNALLE BAĞLANTI SAĞLANAMADI! NULL DEĞER DÖNEMEZ!", "KULLANICI DÖNGÜSEL HATASI!");
                }
                else
                {

                    bool varmi = db.Urunler.Any(p => p.BarkodNo.Contains(BarkotOkumaBolgesi.Text));
                    if (varmi == true)
                    {
                        try
                        {
                            var BarkodBul = db.Urunler.Where(w => w.BarkodNo == BarkotOkumaBolgesi.Text).FirstOrDefault();
                            if (BarkodBul.BarkodNo == BarkotOkumaBolgesi.Text)
                            {

                                dataGridView1.Rows.Add();
                                dataGridView1.Rows[sayac].Cells[0].Value = BarkotOkumaBolgesi.Text;
                                dataGridView1.Rows[sayac].Cells[1].Value = BarkodBul.UrunAdi;
                                dataGridView1.Rows[sayac].Cells[2].Value = BarkodBul.UrunFiyati;

                                AnlikSatisToplam = double.Parse(BarkodBul.UrunFiyati);
                                AnlikCiro = AnlikSatisToplam + AnlikCiro;
                                kar = double.Parse(BarkodBul.UrunGelisFiyati);
                                AnlikKar = kar + AnlikKar;
                                SonucToplam = AnlikSatisToplam + SonucToplam;
                                ToplamTutarTextBox.Text = SonucToplam.ToString();
                                sayac++;
                                BarkotOkumaBolgesi.Text = "";
                                KONTROL = true;
                            }
                        }
                        catch
                        {
                            urunkaydetformu = new UrunKaydet();
                            urunkaydetformu.UrunKaydetBarkodNumarasi.Text = BarkotOkumaBolgesi.Text;
                            urunkaydetformu.Show();
                            BarkotOkumaBolgesi.Text = "";
                            this.Visible = false;
                        }
                    }
                    else
                    {
                        urunkaydetformu = new UrunKaydet();
                        urunkaydetformu.UrunKaydetBarkodNumarasi.Text = BarkotOkumaBolgesi.Text;
                        urunkaydetformu.Show();
                        BarkotOkumaBolgesi.Text = "";
                        this.Visible = false;
                    }
                }
            }
        }

        private void yARDIMToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            dataGridView1.Rows.Clear();
            sayac = 0;
            SonucToplam = 0;
            AnlikSatisToplam = 0;
            AnlikCiro = 0;
            AnlikKar = 0;
            ToplamTutarTextBox.Text = "";
            KONTROL = false;
            MessageBox.Show("SATIŞ İPTAL EDİLDİ!", "KULLANICI İŞLEMİ");
        }

        private void müşteriİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button8.PerformClick();
        }

        private void ElleParaGirisi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData.ToString() == "Return")
            {
                double elleparagirisi = double.Parse(ElleParaGirisi.Text);
                double toplamtutar = double.Parse(ToplamTutarTextBox.Text);
                double sonuc;
                if (toplamtutar <= elleparagirisi)
                {
                    sonuc = elleparagirisi - toplamtutar;
                    ParaUstuTextBox.Text = sonuc.ToString();
                }
                else
                {
                    MessageBox.Show("Toplam Tutar Ödenen Paradan büyük olamaz!", "eylem ekspekşin htası");
                }
            }
        }

        private void ürünİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button9.PerformClick();
            
        }

        private void gİDERLERİRAPORLAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button3.PerformClick();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            giderlerformu = new Giderlerformu();
            giderlerformu.Show();
            this.Visible = false;
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void AnaForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                button6.PerformClick();
            }
            if (e.KeyCode == Keys.F1)
            {
                button4.PerformClick();
            }
            if (e.KeyCode == Keys.F9)
            {
                button8.PerformClick();
            }
            if (e.KeyCode == Keys.F6)
            {
                button13.PerformClick();
            }
            if (e.KeyCode == Keys.F7)
            {
                button14.PerformClick();
            }
            if (e.KeyCode == Keys.F8)
            {
                button3.PerformClick();
            }
            if (e.KeyCode == Keys.F11)
            {
                button7.PerformClick();
            }
            if (e.KeyCode == Keys.F10)
            {
                button2.PerformClick();
            }
            if (e.KeyCode == Keys.F2)
            {
                button5.PerformClick();
            }
            if (e.KeyCode == Keys.F4)
            {
                button1.PerformClick();
            }
            if (e.KeyCode == Keys.F12)
            {
                button9.PerformClick();
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string BarkodCikar = Interaction.InputBox("BARKODUNU OKUTUN ÇIKRILCAK ÜRÜNÜN BARKODU OKUNDUKTAN SONRA ÜRÜN SATIŞ SEPETİNDEN ÇIKARILIR.", "ÜRÜN ÇIKAR", "", 500, 500);

            if (BarkodCikar == "" || BarkodCikar == " ")
            {
                MessageBox.Show("Geçerli Bir Barkod Girilmedi!", "Hata");
            }
            else
            {
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++) //hata alirsan "dataGridinIsmi.Rows.Count -1" yap 
                {
                    if (dataGridView1.Rows[i].Cells[0].Value.ToString() == BarkodCikar)
                    {
                        dataGridView1.Rows.RemoveAt(i);
                        try
                        {
                            var BarkodBul = db.Urunler.Where(w => w.BarkodNo == BarkodCikar).FirstOrDefault();
                            AnlikSatisToplam = double.Parse(BarkodBul.UrunFiyati);
                            AnlikCiro = AnlikCiro - AnlikSatisToplam;
                            kar = double.Parse(BarkodBul.UrunGelisFiyati);
                            AnlikKar = AnlikKar - kar;
                            SonucToplam = SonucToplam - AnlikSatisToplam;
                            double Gonder = SonucToplam;
                            ToplamTutarTextBox.Text = Gonder.ToString();
                            sayac--;
                            MessageBox.Show(BarkodCikar + " Barkod Numaralı " + BarkodBul.UrunAdi + " Ürün Satıi Sepetinden Çıkarıldı.", "Kullanıcı işlemleri");
                            return;
                        }
                        catch
                        {
                            MessageBox.Show("DÖNGÜSEL BARKOD OKUMA HATASI! VERİTABANINA BAĞLANAMADI YADA TERMİNAL BAĞLANTISI KESİLDİ", "ÇEKİRDEK KOD ÖLÜMCÜL HATA!");
                        }
                    }
                }
            }
        }

        private void BarkotOkumaBolgesi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsLetter(e.KeyChar) || Char.IsSymbol(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar);
        }

        private void ElleParaGirisi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsLetter(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar);
        }

        private void ElleParaGirisi_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)  //Peşin Ödeme
        {

            if (KONTROL == true)
            {
                try
                {
                    var ekle = db.KasaGunlukToplam.Where(p => p.Tarih == Tarih).FirstOrDefault();
                    var ekle1 = db.KasaAylik.Where(p => p.Tarih == Ay).FirstOrDefault();
                    
                    double Oncekikar = double.Parse(ekle.Kar);
                    double kartopla = Oncekikar + AnlikKar;
                    double OncekiCiro = double.Parse(ekle.Ciro);
                    double Cirotopla = OncekiCiro + AnlikCiro;
                    double aykar = double.Parse(ekle1.KasaAylikKar);
                    double ayciro = double.Parse(ekle1.KasaAylikCiro);
                    double aykartopla = kartopla + aykar;
                    double aycirotopla = Cirotopla + ayciro;
                    ekle1.KasaAylikCiro = aycirotopla.ToString();
                    ekle1.KasaAylikKar = aykartopla.ToString();
                    ekle.Ciro = Cirotopla.ToString();
                    ekle.Kar = kartopla.ToString();
                    db.SaveChanges();
                    var explorer = new PosExplorer();
                    var deviceInfo = explorer.GetDevice(DeviceType.PosPrinter);
                    if (deviceInfo == null)
                    {
                        MessageBox.Show("BİLGİSAYARA BAĞLI YAZICI YOK YADA BAĞLANTI KURULAMADI", "ÇEKİRDEK KOD TERS MÜHENDİSLİK KORUMASI!");
                        return;
                    }
                    Yazici = (PosPrinter)explorer.CreateInstance(deviceInfo);
                    Yazici.Open();
                    Yazici.Claim(500);
                    Yazici.DeviceEnabled = true;
                    Yazici.StatusUpdateEvent += (s, evt) =>
                    {
                        if (evt.Status == PosPrinter.StatusCoverOpen)
                        {
                            MessageBox.Show("Yazıcının kağıt kapağı açıldı");
                        }
                        if (evt.Status == PosPrinter.StatusCoverOK)
                        {
                            MessageBox.Show("Yazıcının kağıt kapağı kapandı");
                        }
                        if (evt.Status == PosPrinter.StatusJournalCartridgeEmpty)
                        {
                            MessageBox.Show("Yazıcının kartuşu bitmek üzere");
                        }
                    };
                    Yazici.PrintNormal(PrinterStation.Slip, "                          PRESTIGE CAFE                       " + Environment.NewLine);
                    Yazici.PrintNormal(PrinterStation.Slip, "PEŞİN ÖDEME SATIŞ FİŞİ" + "  TARİH: " + DateTime.Now.ToShortDateString() + Environment.NewLine);
                    Yazici.PrintNormal(PrinterStation.Slip, "**************************************************************" + Environment.NewLine);
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        if (i == 100)
                        {
                            i = 0;
                            return;
                        }
                        Yazici.PrintNormal(PrinterStation.Slip, dataGridView1.Rows[i].Cells[1].Value.ToString() + " ---- " + dataGridView1.Rows[i].Cells[2].Value.ToString() + Environment.NewLine);
                    }
                    Yazici.PrintNormal(PrinterStation.Slip, "**************************************************************" + Environment.NewLine);
                    Yazici.PrintNormal(PrinterStation.Slip, "TOPLAM TUTAR: "+ToplamTutarTextBox.Text + Environment.NewLine);
                    Yazici.PrintNormal(PrinterStation.Slip, "**************************************************************" + Environment.NewLine);
                    Yazici.PrintNormal(PrinterStation.Slip, "----MALİ DEĞERİ YOKTUR---" + Environment.NewLine);
                    Yazici.PrintNormal(PrinterStation.Slip, "MARKETMATİK BETA V.1.0.2 seckinumur@gmail.com" + Environment.NewLine);
                    Yazici.CutPaper(100);
                    KONTROL = false;
                }
                catch
                {
                    MessageBox.Show("Veritabanı Hatası", "Kritik Sistem Hatası");
                }
            }
            else
            {
                MessageBox.Show("Alışveriş Sepetinde Ürün Yokken, Peşin Ödeme Yapılamaz!", "Genel Hata");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            musteriyonetimformu = new MusteriYonetimFormu();
            musteriyonetimformu.Show();
            this.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (KONTROL == true)
            {
                veresiyesecme = new VeresiyeSecmeFormu();
                veresiyesecme.Show();
                veresiyesecme.AnlikSatisToplam = double.Parse(ToplamTutarTextBox.Text);
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Alışveriş Sepetinde Ürün Yokken, Peşin Ödeme Yapılamaz!", "Genel Hata");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult Uyari = new DialogResult();
            Uyari = MessageBox.Show("ŞUANA KADARKİ SATIŞ RAPORU ÇIKARTILACAK DEVAM EDİLSİN Mİ?","UYARI!", MessageBoxButtons.YesNo);
            if (Uyari == DialogResult.Yes)
            {
                try
                {
                    var ekle = db.KasaGunlukToplam.Where(p => p.Tarih == Tarih).FirstOrDefault();
                    double giderler = double.Parse(ekle.Giderler);
                    double kar = double.Parse(ekle.Kar);
                    double ciro = double.Parse(ekle.Ciro);
                    double duskar = kar - giderler;
                    double dusciro = ciro - giderler;
                    var explorer = new PosExplorer();
                    var deviceInfo = explorer.GetDevice(DeviceType.PosPrinter);
                    if (deviceInfo == null)
                    {
                        MessageBox.Show("BİLGİSAYARA BAĞLI YAZICI YOK YADA BAĞLANTI KURULAMADI", "ÇEKİRDEK KOD TERS MÜHENDİSLİK KORUMASI!");
                        return;
                    }
                    Yazici = (PosPrinter)explorer.CreateInstance(deviceInfo);
                    Yazici.Open();
                    Yazici.Claim(500);
                    Yazici.DeviceEnabled = true;
                    Yazici.StatusUpdateEvent += (s, evt) =>
                    {
                        if (evt.Status == PosPrinter.StatusCoverOpen)
                        {
                            MessageBox.Show("Yazıcının kağıt kapağı açıldı");
                        }
                        if (evt.Status == PosPrinter.StatusCoverOK)
                        {
                            MessageBox.Show("Yazıcının kağıt kapağı kapandı");
                        }
                        if (evt.Status == PosPrinter.StatusJournalCartridgeEmpty)
                        {
                            MessageBox.Show("Yazıcının kartuşu bitmek üzere");
                        }
                    };
                    Yazici.PrintNormal(PrinterStation.Slip, "                          PRESTIGE CAFE                       " + Environment.NewLine);
                    Yazici.PrintNormal(PrinterStation.Slip, "GÜNLÜK SATIŞ RAPORU" + "  TARİH: " + DateTime.Now.ToShortDateString() + Environment.NewLine);
                    Yazici.PrintNormal(PrinterStation.Slip, "**************************************************************" + Environment.NewLine);
                    Yazici.PrintNormal(PrinterStation.Slip, "TOPLAM SATIŞ: "+ekle.Ciro + Environment.NewLine);
                    Yazici.PrintNormal(PrinterStation.Slip, "TOPLAM KAR  : " + ekle.Kar + Environment.NewLine);
                    Yazici.PrintNormal(PrinterStation.Slip, "**************************************************************" + Environment.NewLine);
                    Yazici.PrintNormal(PrinterStation.Slip, "BUGÜN TOPLAM GİDER: "+giderler.ToString() + Environment.NewLine);
                    Yazici.PrintNormal(PrinterStation.Slip, "BUGÜNKÜ KAR'DAN  GİDERİN DÜŞÜMÜ: " + duskar.ToString()+ Environment.NewLine);
                    Yazici.PrintNormal(PrinterStation.Slip, "BUGÜNKÜ CİRO'DAN  GİDERİN DÜŞÜMÜ: " + dusciro.ToString() + Environment.NewLine);
                    Yazici.PrintNormal(PrinterStation.Slip, "**************************************************************" + Environment.NewLine);
                    Yazici.PrintNormal(PrinterStation.Slip, "----MALİ DEĞERİ YOKTUR---" + Environment.NewLine);
                    Yazici.PrintNormal(PrinterStation.Slip, "MARKETMATİK BETA V.1.0.2 seckinumur@gmail.com" + Environment.NewLine);
                    Yazici.CutPaper(100);
                    MessageBox.Show("RAPOR BAŞARIYLA YAZDIRILDI", "UYARI!");
                }
                catch
                {

                }
            }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            AylikRaporlamaFormu aylik = new AylikRaporlamaFormu();
            aylik.Show();
            this.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            urunislemleriformu = new Urunislemleriformu();
            urunislemleriformu.Show();
            this.Visible = false;
        }
    }
}
