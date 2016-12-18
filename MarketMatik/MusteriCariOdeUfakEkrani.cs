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
    public partial class MusteriCariOdeUfakEkrani : Form
    {
        public MusteriYonetimFormu musteriyonetimformu;
        //public AnaForm form11 = (AnaForm)Application.OpenForms["AnaForm"];
        public VeriEntities3 db;
        PosPrinter Yazici;
        public MusteriCariOdeUfakEkrani()
        {
            InitializeComponent();
            db = new VeriEntities3();
        }
        private void MusteriCariOdeUfakEkrani_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'veriDataSet4.Musteriler' table. You can move, or remove it, as needed.
            this.musterilerTableAdapter3.Fill(this.veriDataSet4.Musteriler);
            // TODO: This line of code loads data into the 'veriDataSet3.Musteriler' table. You can move, or remove it, as needed.
            this.musterilerTableAdapter2.Fill(this.veriDataSet3.Musteriler);
            // TODO: This line of code loads data into the 'veriDataSet2.Musteriler' table. You can move, or remove it, as needed.
            this.musterilerTableAdapter1.Fill(this.veriDataSet2.Musteriler);
            this.musterilerTableAdapter.Fill(this.veriDataSet.Musteriler);
        }
        private void cariodetamaminiode_Click(object sender, EventArgs e)
        {
            Musteriler musteriler = new Musteriler();
            var MusteriCariOde = db.Musteriler.Where(w => w.MusteriAdi == cariodemusteriadi.Text).FirstOrDefault();
            try
            {
                String Odeme = MusteriCariOde.MusteriBakiyesi;
                MusteriCariOde.MusteriBakiyesi = "0";
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
                Yazici.PrintNormal(PrinterStation.Slip, "CARİ ÖDEME BİLGİ FİŞİ" + "  TARİH: " + DateTime.Now.ToShortDateString() + Environment.NewLine);
                Yazici.PrintNormal(PrinterStation.Slip, "**************************************************************" + Environment.NewLine);
                Yazici.PrintNormal(PrinterStation.Slip, "MÜŞTERİ ADI   : " + MusteriCariOde.MusteriAdi + Environment.NewLine);
                Yazici.PrintNormal(PrinterStation.Slip, "--------------------------------------------------------------" + Environment.NewLine);
                Yazici.PrintNormal(PrinterStation.Slip, "MÜŞTERİ CARİSİ: " + Odeme + Environment.NewLine);
                Yazici.PrintNormal(PrinterStation.Slip, "--------------------------------------------------------------" + Environment.NewLine);
                Yazici.PrintNormal(PrinterStation.Slip, "ÖDENEN MİKTAR : " + Odeme + Environment.NewLine);
                Yazici.PrintNormal(PrinterStation.Slip, "**************************************************************" + Environment.NewLine);
                Yazici.PrintNormal(PrinterStation.Slip, "                        TEŞEKKÜR EDERİZ                       " + Environment.NewLine);
                Yazici.PrintNormal(PrinterStation.Slip, "MARKETMATİK BETA V.1.0.2 seckinumur@gmail.com" + Environment.NewLine);
                Yazici.CutPaper(100);
                musteriyonetimformu = new MusteriYonetimFormu();
                musteriyonetimformu.Show();
                this.Close();
                
                
            }
            catch
            {
                MessageBox.Show("DÖNGÜSEL VERİTABANI HATASI. DATA BULUNAMADI YADA VERİTABANI BAĞLANTISI KESİLDİ.", "ÇEKİRDEK KOD ÖLÜMCÜL HATA!");
                MessageBox.Show("LÜTFEN GELİŞTİRİCİ İLE İRTİBAT KURUN. PROGRAM SONLANICAK", "ÇEKİRDEK KOD TERS MÜHENDİSLİK KORUMASI");
                Application.Exit();
            }
        }

        private void cariodegirilentutarkadarode_Click(object sender, EventArgs e)
        {
            Musteriler musteriler = new Musteriler();
            var MusteriCariOde = db.Musteriler.Where(w => w.MusteriAdi == cariodemusteriadi.Text).FirstOrDefault();
            try
            {
                String Odeme = MusteriCariOde.MusteriBakiyesi;
                double odenentutar = double.Parse(cariodeodenentutar.Text);
                double borc = double.Parse(Odeme);
                double sonuc;
                string odenenpara;
                if (odenentutar >= borc || odenentutar <= 0)
                {
                    MessageBox.Show("ÖDENEN TUTAR BORÇTAN FAZLA VEYA AZ OLAMAZ!", "KULLANICI HATASI!");
                }
                else
                {
                    sonuc = borc - odenentutar;
                    odenenpara = sonuc.ToString();
                    MusteriCariOde.MusteriBakiyesi = odenenpara;
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
                    Yazici.PrintNormal(PrinterStation.Slip, "CARİ ÖDEME BİLGİ FİŞİ" + "  TARİH: " + DateTime.Now.ToShortDateString() + Environment.NewLine);
                    Yazici.PrintNormal(PrinterStation.Slip, "**************************************************************" + Environment.NewLine);
                    Yazici.PrintNormal(PrinterStation.Slip, "MÜŞTERİ ADI         : " + MusteriCariOde.MusteriAdi + Environment.NewLine);
                    Yazici.PrintNormal(PrinterStation.Slip, "--------------------------------------------------------------" + Environment.NewLine);
                    Yazici.PrintNormal(PrinterStation.Slip, "MÜŞTERİ ESKİ CARİSİ : " + Odeme + Environment.NewLine);
                    Yazici.PrintNormal(PrinterStation.Slip, "--------------------------------------------------------------" + Environment.NewLine);
                    Yazici.PrintNormal(PrinterStation.Slip, "ÖDENEN MİKTAR       : " + cariodeodenentutar.Text + Environment.NewLine);
                    Yazici.PrintNormal(PrinterStation.Slip, "--------------------------------------------------------------" + Environment.NewLine);
                    Yazici.PrintNormal(PrinterStation.Slip, "KALAN CARİ          : " + odenenpara + Environment.NewLine);
                    Yazici.PrintNormal(PrinterStation.Slip, "**************************************************************" + Environment.NewLine);
                    Yazici.PrintNormal(PrinterStation.Slip, "                        TEŞEKKÜR EDERİZ                       " + Environment.NewLine);
                    Yazici.PrintNormal(PrinterStation.Slip, "MARKETMATİK BETA V.1.0.2 seckinumur@gmail.com" + Environment.NewLine);
                    Yazici.CutPaper(100);
                    musteriyonetimformu = new MusteriYonetimFormu();
                    musteriyonetimformu.Show();
                    this.Close();
                    
                }
            }
            catch
            {
                MessageBox.Show("DÖNGÜSEL VERİTABANI HATASI. DATA BULUNAMADI YADA VERİTABANI BAĞLANTISI KESİLDİ.", "ÇEKİRDEK KOD ÖLÜMCÜL HATA!");
                MessageBox.Show("LÜTFEN GELİŞTİRİCİ İLE İRTİBAT KURUN. PROGRAM SONLANICAK", "ÇEKİRDEK KOD TERS MÜHENDİSLİK KORUMASI");
                Application.Exit();
            }


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (yenimusteriadi.Text == "" || yenimusteriadi.Text == " " || yenimustericarisi.Text == "" || yenimustericarisi.Text == " ")
            {
                MessageBox.Show("LÜTFEN GEÇERLİ BİR MÜŞTERİ ADI VEYA BAKİYESİ GİRİN", "KULLANICI HATASI");
            }
            else
            {
                DialogResult Uyari = new DialogResult();
                Uyari = MessageBox.Show("MÜŞTERİ BİLGİLERİ GÜNCELLENECEK DEVAM EDİLSİN Mİ?", "DİKKAT!", MessageBoxButtons.YesNo);
                if (Uyari == DialogResult.Yes)
                {
                    Musteriler musteriler = new Musteriler();
                    var MusteriCariOde = db.Musteriler.Where(w => w.MusteriAdi == cariodemusteriadi.Text).FirstOrDefault();
                    try
                    {
                        MusteriCariOde.MusteriBakiyesi = yenimustericarisi.Text;
                        MusteriCariOde.MusteriAdi = yenimusteriadi.Text;
                        db.SaveChanges();
                        MessageBox.Show("MÜŞTERİ ADI VE CARİSİ BAŞARIYLA GÜNCELLENDİ", "VERİTABANI İŞLEMLERİ");
                        musteriyonetimformu = new MusteriYonetimFormu();
                        musteriyonetimformu.Show();
                        this.Close();
                        
                    }
                    catch
                    {
                        MessageBox.Show("MÜŞTERİ ADI VE CARİSİ GÜNCELLENEMEDİ! VERİTABANI İLE İLETİŞİM KURULAMADI!", "VERİTABANI ÖLÜMCÜL HATA");
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult Uyari = new DialogResult();
            Uyari = MessageBox.Show("MÜŞTERİ SİLİNECEK! BU İŞLEM TÜM MÜŞTERİ BİLGİLERİNİ VE CARİSİNİ SİLER. İŞLEME DEVAM EDİLSİN Mİ?", "DİKKAT!", MessageBoxButtons.YesNo);
            if (Uyari == DialogResult.Yes)
            {
                Musteriler musteriler = new Musteriler();
                var MusteriCariOde = db.Musteriler.Where(w => w.MusteriAdi == cariodemusteriadi.Text).FirstOrDefault();
                try
                {
                    db.Musteriler.Remove(MusteriCariOde);
                    db.SaveChanges();
                    MessageBox.Show("MÜŞTERİ BAŞARIYLA SİLİNDİ", "KULLANICI İŞLEMLERİ");
                    musteriyonetimformu = new MusteriYonetimFormu();
                    musteriyonetimformu.Show();
                    this.Close();
                    
                }
                catch
                {
                    MessageBox.Show("MÜŞTERİ ADI VE CARİSİ SİLİNEMEDİ! VERİTABANI İLE İLETİŞİM KURULAMADI!", "VERİTABANI ÖLÜMCÜL HATA");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void AktarilcakMusterisecimyeri_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData.ToString() == "Return")
            {
                for (int i = 0; i < mustericarisiaktargostergesi.Rows.Count - 1; i++) //hata alirsan "dataGridinIsmi.Rows.Count -1" yap 
                {
                    if (mustericarisiaktargostergesi.Rows[i].Cells[0].Value.ToString() == AktarilcakMusterisecimyeri.Text)
                    {
                        string ad, bakiye, aktarad, aktarbakiye;
                        aktarad = cariodemusteriadi.Text;
                        aktarbakiye = cariodemustericarisi.Text;
                        ad = mustericarisiaktargostergesi.Rows[i].Cells[0].Value.ToString();
                        bakiye = mustericarisiaktargostergesi.Rows[i].Cells[1].Value.ToString();
                        Musteriler musteriler = new Musteriler();
                        var Musteriaktar1 = db.Musteriler.Where(w => w.MusteriAdi == ad).FirstOrDefault();
                        var MusteriAktar2 = db.Musteriler.Where(w => w.MusteriAdi == aktarad).FirstOrDefault();
                        try
                        {
                            DialogResult Uyari = new DialogResult();
                            Uyari = MessageBox.Show("AKTARILAN MÜŞTERİ ADI: " + ad + " MÜŞTERİ BAKİYESİ: " + bakiye + " AKTARILCAK MÜŞTERİ ADI: " + aktarad + " AKTARILMADAN ÖNCEKİ BAKİYESİ: " + aktarbakiye + " MÜŞTERİ CARİSİ AKTARILCAK ONAYLIYORMUSUNUZ?", "DİKKAT!", MessageBoxButtons.YesNo);
                            if (Uyari == DialogResult.Yes)
                            {
                                double aktarilcakmusteri = double.Parse(bakiye);
                                double aktarilanmusteri = double.Parse(aktarbakiye);
                                double sonuc = aktarilcakmusteri + aktarilanmusteri;
                                string yenibakiye = sonuc.ToString();
                                Musteriaktar1.MusteriBakiyesi = yenibakiye;
                                MusteriAktar2.MusteriBakiyesi = "0";
                                db.SaveChanges();
                                MessageBox.Show("MÜŞTERİ CARİSİ BAŞARIYLA GÜNCELLENDİ", "VERİTABANI İŞLEMLERİ");
                                musteriyonetimformu = new MusteriYonetimFormu();
                                musteriyonetimformu.Show();
                                this.Close();
                                
                            }
                        }
                        catch
                        {
                            MessageBox.Show("VERİTABANINA BAĞLANILAMADI", "ÖLÜMCÜL HATA");
                        }
                    }
                }
            }
            else if (e.KeyData.ToString() == "Esc")
            {
                AktarilcakMusterisecimyeri.Text = "";
            }
        }

        private void mustericarisiaktargostergesi_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int xkoordinat = mustericarisiaktargostergesi.CurrentCellAddress.X; //Seçili satırın X koordinatı
            int ykoordinat = mustericarisiaktargostergesi.CurrentCellAddress.Y;  //Seçili satırın Y koordinatı
            string str = "";
            str = mustericarisiaktargostergesi.Rows[ykoordinat].Cells[xkoordinat].Value.ToString();
            if (e.RowIndex == -1)
            {
                return;
            }
            AktarilcakMusterisecimyeri.Text = str;
        }

        private void bakiyeaktar_Click(object sender, EventArgs e)
        {
            if (AktarilcakMusterisecimyeri.Text=="" || AktarilcakMusterisecimyeri.Text==" ")
            {
                MessageBox.Show("MÜŞTERİ ADINI GİRİN!", "KULLANICI HATASI");
            }
            else
            {
                string ad,bakiye,aktarad, aktarbakiye;
                aktarad = cariodemusteriadi.Text;
                aktarbakiye = cariodemustericarisi.Text;
                Musteriler musteriler = new Musteriler();
                var Musteriaktar1 = db.Musteriler.Where(w => w.MusteriAdi == AktarilcakMusterisecimyeri.Text).FirstOrDefault();
                var MusteriAktar2 = db.Musteriler.Where(w => w.MusteriAdi == aktarad).FirstOrDefault();
                ad = Musteriaktar1.MusteriAdi;
                bakiye = Musteriaktar1.MusteriBakiyesi;
                try
                {
                    DialogResult Uyari = new DialogResult();
                    Uyari = MessageBox.Show("AKTARILAN MÜŞTERİ ADI: " + ad + " MÜŞTERİ BAKİYESİ: " + bakiye + " AKTARILCAK MÜŞTERİ ADI: " + aktarad + " AKTARILMADAN ÖNCEKİ BAKİYESİ: " + aktarbakiye + " MÜŞTERİ CARİSİ AKTARILCAK ONAYLIYORMUSUNUZ?", "DİKKAT!", MessageBoxButtons.YesNo);
                    if (Uyari == DialogResult.Yes)
                    {
                        double aktarilcakmusteri = double.Parse(bakiye);
                        double aktarilanmusteri = double.Parse(aktarbakiye);
                        double sonuc = aktarilcakmusteri + aktarilanmusteri;
                        string yenibakiye = sonuc.ToString();
                        Musteriaktar1.MusteriBakiyesi = yenibakiye;
                        MusteriAktar2.MusteriBakiyesi = "0";
                        db.SaveChanges();
                        MessageBox.Show("MÜŞTERİ CARİSİ BAŞARIYLA GÜNCELLENDİ", "VERİTABANI İŞLEMLERİ");
                        
                        musteriyonetimformu = new MusteriYonetimFormu();
                        musteriyonetimformu.Show();
                        this.Close();
                    }
                }
                catch
                {
                    MessageBox.Show("VERİTABANINA BAĞLANILAMADI", "ÖLÜMCÜL HATA");
                }
                
            }
        }

        private void cariodeodenentutar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsLetter(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar);
        }

        private void yenimustericarisi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsLetter(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar);
        }

        private void MusteriCariOdeUfakEkrani_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                button3.PerformClick();
            }
            if (e.KeyCode == Keys.F1)
            {
                cariodetamaminiode.PerformClick();
            }
            if (e.KeyCode == Keys.F2)
            {
                cariodegirilentutarkadarode.PerformClick();
            }
            if (e.KeyCode == Keys.F3)
            {
                button1.PerformClick();
            }
            if (e.KeyCode == Keys.F4)
            {
                button2.PerformClick();
            }
            if (e.KeyCode == Keys.F6)
            {
                bakiyeaktar.PerformClick();
            }
        }
    }
}