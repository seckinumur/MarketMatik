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
using Microsoft.PointOfService;


namespace MarketMatik
{
    public partial class Giderlerformu : Form
    {
        public AnaForm anaform;
        public AnaForm formdd1 = (AnaForm)Application.OpenForms["AnaForm"];
        VeriEntities3 db;
        public string Tarih = DateTime.Now.Month.ToString();
        public string TarihNormal = DateTime.Now.ToShortDateString();
        public string Ay = DateTime.Now.Month.ToString();
        PosPrinter Yazici;
        public Giderlerformu()
        {
            db = new VeriEntities3();
            InitializeComponent();
        }

        private void Giderlerformu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'veriDataSet6.Giderler' table. You can move, or remove it, as needed.
            this.giderlerTableAdapter.Fill(this.veriDataSet6.Giderler);
            db = new VeriEntities3();
        }

        private void GiderEkle_Click(object sender, EventArgs e)
        {
            if (GiderAdi.Text == "" || GiderAdi.Text == " " || GiderTutari.Text == "" || GiderTutari.Text == " ")
            {
                MessageBox.Show("LÜTFEN GEÇERLİ BİR GİDER ADI VE TUTARI GİRİN", "KULLANICI HATASI");
            }
            else
            {
                string kontrol = GiderAdi.Text;
                try
                {
                    bool varmi = db.Giderler.Any(p => p.GiderAdi.Contains(kontrol));
                    if (varmi == false)
                    {

                        
                        Giderler giderler = new Giderler();
                        giderler.GiderAdi = GiderAdi.Text;
                        giderler.GiderTutari = GiderTutari.Text;
                        var ekle = db.KasaGunlukToplam.Where(p => p.Tarih == TarihNormal).FirstOrDefault();
                        var ekle1 = db.KasaAylik.Where(p => p.Tarih == Ay).FirstOrDefault();
                        double gid1 = double.Parse(ekle.Giderler);
                        double gidi2 = double.Parse(ekle1.KasaAylikGider);
                        double simdi = double.Parse(GiderTutari.Text);
                        double toplam = gid1 + simdi;
                        double toplam2 = gidi2 + simdi;
                        ekle1.KasaAylikGider = toplam2.ToString();
                        ekle.Giderler = toplam.ToString();
                        giderler.Tarih = Tarih;
                        db.Giderler.Add(giderler);
                        db.SaveChanges();
                        MessageBox.Show("GİDER BAŞARIYLA KAYDEDİLDİ", "VERİ TABANI İŞLEMLERİ");
                        this.Close();
                        formdd1.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("BU GİDER İSMİ ZATEN KAYDEDİLMİŞ AYNI İSİMLİ BİR GİDERİN BAŞKA BİR FATURASI İSE MESALA FATURA AYINI GİDER ADI SONUNA YAZIP KAYDEDEBİLİRSİNİZ", "DÖNGÜSEL KARMAŞIK KOD HATASI");
                    }
                }
                catch
                {
                    MessageBox.Show("VERİTABANINA BAĞLANILAMADI", "ÖLÜMCÜL HATA");
                }
            }
        }

        private void GiderlerGosterimPaneli_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int xkoordinat = GiderlerGosterimPaneli.CurrentCellAddress.X; //Seçili satırın X koordinatı
            int ykoordinat = GiderlerGosterimPaneli.CurrentCellAddress.Y;  //Seçili satırın Y koordinatı
            string str = "";
            str = GiderlerGosterimPaneli.Rows[ykoordinat].Cells[xkoordinat].Value.ToString();
            if (e.RowIndex == -1)
            {
                return;
            }
            GiderBul.Text = str;
            Giderler giderler = new Giderler();
            var giderdegistir = db.Giderler.Where(w => w.GiderAdi == str).FirstOrDefault();
            try
            {
                GiderAdi.Text = giderdegistir.GiderAdi;
                GiderTutari.Text = giderdegistir.GiderTutari;
            }
            catch
            {
                MessageBox.Show("VERİTABANINA BAĞLANILAMADI", "ÖLÜMCÜL HATA");
            }
        }
        private void GiderSil_Click(object sender, EventArgs e)
        {
            DialogResult Uyari = new DialogResult();
            Uyari = MessageBox.Show("GİDER SİLİNECEK DEVAM EDİLSİN Mİ?", "DİKKAT!", MessageBoxButtons.YesNo);
            if (Uyari == DialogResult.Yes)
            {
                Giderler giderler = new Giderler();
                var giderdegistir = db.Giderler.Where(w => w.GiderAdi == GiderBul.Text).FirstOrDefault();
                try
                {
                    var ekle = db.KasaGunlukToplam.Where(p => p.Tarih == TarihNormal).FirstOrDefault();
                    var ekle1 = db.KasaAylik.Where(p => p.Tarih == Ay).FirstOrDefault();
                    double gid1 = double.Parse(ekle.Giderler);
                    double gidi2 = double.Parse(ekle1.KasaAylikGider);
                    double simdi = double.Parse(GiderTutari.Text);
                    double toplam = gid1 - simdi;
                    double toplam2 = gidi2 - simdi;
                    ekle1.KasaAylikGider = toplam2.ToString();
                    ekle.Giderler = toplam.ToString();
                    db.Giderler.Remove(giderdegistir);

                    db.SaveChanges();
                    MessageBox.Show("GİDER BAŞARIYLA SİLİNDİ", "VERİ TABANI İŞLEMLERİ");
                    this.Close();
                    formdd1.Visible = true;
                }
                catch
                {
                    MessageBox.Show("VERİTABANINA BAĞLANILAMADI", "ÖLÜMCÜL HATA");
                }
            }
        }

        private void GiderBul_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData.ToString() == "Return")
            {
                if (GiderBul.Text == "" || GiderBul.Text == " ")
                {
                    MessageBox.Show("ARANACAK GİDER BULUNAMADI!", "VERİTABANI İŞLEMLERİ");
                }
                else
                {
                    for (int i = 0; i < GiderlerGosterimPaneli.Rows.Count - 1; i++) //hata alirsan "dataGridinIsmi.Rows.Count -1" yap 
                    {
                        if (GiderlerGosterimPaneli.Rows[i].Cells[0].Value.ToString() == GiderBul.Text)
                        {
                           
                            Giderler giderler = new Giderler();
                            var giderdegistir = db.Giderler.Where(w => w.GiderAdi == GiderBul.Text).FirstOrDefault();
                            try
                            {
                                GiderAdi.Text = giderdegistir.GiderAdi;
                                GiderTutari.Text = giderdegistir.GiderTutari;
                            }
                            catch
                            {
                                MessageBox.Show("VERİTABANINA BAĞLANILAMADI", "ÖLÜMCÜL HATA");
                            }
                        }
                    }
                }
            }

        }

        private void GunlukRapor_Click(object sender, EventArgs e)
        {
            string zaman = DateTime.Now.ToShortDateString();

            DialogResult Uyari = new DialogResult();
            Uyari = MessageBox.Show("TÜM GİDERLERİN RAPORU BASILACAK BU RAPOR UZUNLUĞU GİDERLERİNİZİN UZUNLUĞU KADAR OLACAKTIR. ESKİ GİDERLERİNİZİ SİLERSENİZ RAPOR DAHA KISA OLABİLİR. DEVAM EDİLSİN Mİ?", "UYARI!", MessageBoxButtons.YesNo);
            if (Uyari == DialogResult.Yes)
            {
                try
                {
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
                    Yazici.PrintNormal(PrinterStation.Slip, "GÜnlük Gider Raporu" + "  TARİH: " + DateTime.Now.ToShortDateString() + Environment.NewLine);
                    Yazici.PrintNormal(PrinterStation.Slip, "**************************************************************" + Environment.NewLine);
                    VeriEntities3 context = new VeriEntities3();
                    foreach (var bul in context.Giderler.Where(p => p.Tarih == zaman))
                    {
                        Yazici.PrintNormal(PrinterStation.Slip, "Gider adı: " + bul.GiderAdi + " Gider Tutarı: " + bul.GiderTutari + " Tarih: " + bul.Tarih + Environment.NewLine);
                    }
                    Yazici.PrintNormal(PrinterStation.Slip, "**************************************************************" + Environment.NewLine);
                    Yazici.PrintNormal(PrinterStation.Slip, "MARKETMATİK BETA V.1.0.2 seckinumur@gmail.com" + Environment.NewLine);
                    Yazici.CutPaper(100);
                    MessageBox.Show("Gider Yazdırıldı.", "Kullanıcı İşlemleri");
                    this.Close();
                    formdd1.Visible = true;

                }
                catch
                {
                    MessageBox.Show("DÖNGÜSEL VERİTABANI HATASI. DATA BULUNAMADI YADA VERİTABANI BAĞLANTISI KESİLDİ.", "ÇEKİRDEK KOD ÖLÜMCÜL HATA!");
                    MessageBox.Show("LÜTFEN GELİŞTİRİCİ İLE İRTİBAT KURUN. PROGRAM SONLANICAK", "ÇEKİRDEK KOD TERS MÜHENDİSLİK KORUMASI");
                    Application.Exit();
                }
            }
                     
        }

        private void AylikRapor_Click(object sender, EventArgs e)
        {
            this.Close();
            formdd1.Visible = true;
        }

        private void GiderTutari_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsLetter(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar);
        }
       
        private void Giderlerformu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                AylikRapor.PerformClick();
            }
            if (e.KeyCode== Keys.F1)
            {
                GiderEkle.PerformClick();
            }
            if (e.KeyCode== Keys.F2)
            {
                GiderSil.PerformClick();
            }
            if (e.KeyCode == Keys.F3)
            {
                GunlukRapor.PerformClick();
            }
        }
    }
}
