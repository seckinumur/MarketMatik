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
    public partial class AylikRaporlamaFormu : Form
    {
        public VeriEntities3 db;
        public AnaForm form234 = (AnaForm)Application.OpenForms["AnaForm"];
        PosPrinter Yazici;
        public int secilenay = 0;
        public double MusteriBorcu;
        public string Ay = DateTime.Now.Month.ToString();
        public string Tarih = DateTime.Now.ToShortDateString();
        public AylikRaporlamaFormu()
        {
            InitializeComponent();
            db = new VeriEntities3();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void AylikRaporlamaFormu_Load(object sender, EventArgs e)
        {
            var liste = db.Musteriler.Where(p => p.MusteriBakiyesi != "0").ToList();
            foreach(var a in liste)
            {
                double alinan = double.Parse(a.MusteriBakiyesi);
                double toplam = MusteriBorcu + alinan;
                MusteriBorcu = toplam;
                
            }
            musteriborclari.Text = MusteriBorcu.ToString();


            
        }

        private void ocak_Click(object sender, EventArgs e)
        {
            try
            {
                var bul = db.KasaAylik.Where(p => p.Tarih == "1").FirstOrDefault();
                aylikciro.Text = bul.KasaAylikCiro;
                aylikkar.Text = bul.KasaAylikKar;
                aylikgider.Text = bul.KasaAylikGider;
                secim.Text = "OCAK";
                secilenay = 1;
            }
            catch
            {
                MessageBox.Show("BU AYA AİT VERİ BULUNAMADI!", "UYARI!");
            }
        }

        private void iptal_Click(object sender, EventArgs e)
        {
            this.Close();
            form234.Visible = true;
        }

        private void subat_Click(object sender, EventArgs e)
        {
            try
            {
                var bul = db.KasaAylik.Where(p => p.Tarih == "2").FirstOrDefault();
                aylikciro.Text = bul.KasaAylikCiro;
                aylikkar.Text = bul.KasaAylikKar;
                aylikgider.Text = bul.KasaAylikGider;
                secim.Text = "ŞUBAT";
                secilenay = 2;
            }
            catch
            {
                MessageBox.Show("BU AYA AİT VERİ BULUNAMADI!", "UYARI!");
            }
        }

        private void mart_Click(object sender, EventArgs e)
        {
            try
            {
                var bul = db.KasaAylik.Where(p => p.Tarih == "3").FirstOrDefault();
                aylikciro.Text = bul.KasaAylikCiro;
                aylikkar.Text = bul.KasaAylikKar;
                aylikgider.Text = bul.KasaAylikGider;
                secim.Text = "MART";
                secilenay = 3;
            }
            catch
            {
                MessageBox.Show("BU AYA AİT VERİ BULUNAMADI!", "UYARI!");
            }
        }

        private void nisan_Click(object sender, EventArgs e)
        {
            try
            {
                var bul = db.KasaAylik.Where(p => p.Tarih == "4").FirstOrDefault();
                aylikciro.Text = bul.KasaAylikCiro;
                aylikkar.Text = bul.KasaAylikKar;
                aylikgider.Text = bul.KasaAylikGider;
                secim.Text = "NİSAN";
                secilenay = 4;
            }
            catch
            {
                MessageBox.Show("BU AYA AİT VERİ BULUNAMADI!", "UYARI!");
            }
        }

        private void mayis_Click(object sender, EventArgs e)
        {
            try
            {
                var bul = db.KasaAylik.Where(p => p.Tarih == "5").FirstOrDefault();
                aylikciro.Text = bul.KasaAylikCiro;
                aylikkar.Text = bul.KasaAylikKar;
                aylikgider.Text = bul.KasaAylikGider;
                secim.Text = "MAYIS";
                secilenay = 5;
            }
            catch
            {
                MessageBox.Show("BU AYA AİT VERİ BULUNAMADI!", "UYARI!");
            }
        }

        private void haziran_Click(object sender, EventArgs e)
        {
            try
            {
                var bul = db.KasaAylik.Where(p => p.Tarih == "6").FirstOrDefault();
                aylikciro.Text = bul.KasaAylikCiro;
                aylikkar.Text = bul.KasaAylikKar;
                aylikgider.Text = bul.KasaAylikGider;
                secim.Text = "HAZİRAN";
                secilenay = 6;
            }
            catch
            {
                MessageBox.Show("BU AYA AİT VERİ BULUNAMADI!", "UYARI!");
            }
        }

        private void temmuz_Click(object sender, EventArgs e)
        {
            try
            {
                var bul = db.KasaAylik.Where(p => p.Tarih == "7").FirstOrDefault();
                aylikciro.Text = bul.KasaAylikCiro;
                aylikkar.Text = bul.KasaAylikKar;
                aylikgider.Text = bul.KasaAylikGider;
                secim.Text = "TEMMUZ";
                secilenay = 7;
            }
            catch
            {
                MessageBox.Show("BU AYA AİT VERİ BULUNAMADI!", "UYARI!");
            }
        }

        private void agustos_Click(object sender, EventArgs e)
        {
            try
            {
                var bul = db.KasaAylik.Where(p => p.Tarih == "8").FirstOrDefault();
                aylikciro.Text = bul.KasaAylikCiro;
                aylikkar.Text = bul.KasaAylikKar;
                aylikgider.Text = bul.KasaAylikGider;
                secim.Text = "AĞUSTOS";
                secilenay = 8;
            }
            catch
            {
                MessageBox.Show("BU AYA AİT VERİ BULUNAMADI!", "UYARI!");
            }
        }

        private void eylul_Click(object sender, EventArgs e)
        {
            try
            {
                var bul = db.KasaAylik.Where(p => p.Tarih == "9").FirstOrDefault();
                aylikciro.Text = bul.KasaAylikCiro;
                aylikkar.Text = bul.KasaAylikKar;
                aylikgider.Text = bul.KasaAylikGider;
                secim.Text = "EYLÜL";
                secilenay = 9;
            }
            catch
            {
                MessageBox.Show("BU AYA AİT VERİ BULUNAMADI!", "UYARI!");
            }
        }

        private void ekim_Click(object sender, EventArgs e)
        {
            try
            {
                var bul = db.KasaAylik.Where(p => p.Tarih == "10").FirstOrDefault();
                aylikciro.Text = bul.KasaAylikCiro;
                aylikkar.Text = bul.KasaAylikKar;
                aylikgider.Text = bul.KasaAylikGider;
                secim.Text = "EKİM";
                secilenay = 10;
            }
            catch
            {
                MessageBox.Show("BU AYA AİT VERİ BULUNAMADI!", "UYARI!");
            }
        }

        private void kasim_Click(object sender, EventArgs e)
        {
            try
            {
                var bul = db.KasaAylik.Where(p => p.Tarih == "11").FirstOrDefault();
                aylikciro.Text = bul.KasaAylikCiro;
                aylikkar.Text = bul.KasaAylikKar;
                aylikgider.Text = bul.KasaAylikGider;
                secim.Text = "KASIM";
                secilenay = 111;
            }
            catch
            {
                MessageBox.Show("BU AYA AİT VERİ BULUNAMADI!", "UYARI!");
            }
        }

        private void aralik_Click(object sender, EventArgs e)
        {
            try
            {
                var bul = db.KasaAylik.Where(p => p.Tarih == "12").FirstOrDefault();
                aylikciro.Text = bul.KasaAylikCiro;
                aylikkar.Text = bul.KasaAylikKar;
                aylikgider.Text = bul.KasaAylikGider;
                secim.Text = "ARALIK";
                secilenay = 12;
            }
            catch
            {
                MessageBox.Show("BU AYA AİT VERİ BULUNAMADI!", "UYARI!");
            }
        }

        private void raporcikar_Click(object sender, EventArgs e)
        {
            if (secilenay == 0)
            {
                MessageBox.Show("RAPOR ÇIKARILACAK BİR AY SEÇİLMEDİ! ÖNCE BİR AY SEÇİN!", "KULLANICI HATASI");
            }
            else
            {
                DialogResult Uyari = new DialogResult();
                Uyari = MessageBox.Show("SEÇİLEN AYIN RAPORU ÇIKARILACAK DEVAM EDİLSİN Mİ?", "UYARI!", MessageBoxButtons.YesNo);
                if (Uyari == DialogResult.Yes)
                {
                    Double AylikKar = double.Parse(aylikkar.Text);
                    double AylikCiro = double.Parse(aylikciro.Text);
                    double AylikGider = double.Parse(aylikgider.Text);
                    double GiderdusKar = AylikKar - AylikGider;
                    double GiderdusCiro = AylikCiro - AylikGider;
                    Double AylikciroMusteri = AylikCiro - MusteriBorcu;
                    double Aylikkarmusteri = AylikKar - MusteriBorcu;
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
                    Yazici.PrintNormal(PrinterStation.Slip, "AYLIK SATIŞ RAPORU" + "  TARİH: " + DateTime.Now.ToShortDateString() + Environment.NewLine);
                    Yazici.PrintNormal(PrinterStation.Slip, "**************************************************************" + Environment.NewLine);
                    Yazici.PrintNormal(PrinterStation.Slip, "TOPLAM CİRO: " +aylikciro.Text + " TL" + Environment.NewLine);
                    Yazici.PrintNormal(PrinterStation.Slip, "TOPLAM KAR  : " + aylikkar.Text + " TL" + Environment.NewLine);
                    Yazici.PrintNormal(PrinterStation.Slip, "**************************************************************" + Environment.NewLine);
                    Yazici.PrintNormal(PrinterStation.Slip, "AYLIK TOPLAM GİDER: " + aylikgider.Text + " TL" + Environment.NewLine);
                    Yazici.PrintNormal(PrinterStation.Slip, "AYLIK KAR'DAN  GİDERİN DÜŞÜMÜ: " + GiderdusKar.ToString() + " TL" + Environment.NewLine);
                    Yazici.PrintNormal(PrinterStation.Slip, "AYLIK CİRO'DAN  GİDERİN DÜŞÜMÜ: " + GiderdusCiro.ToString() + Environment.NewLine);
                    Yazici.PrintNormal(PrinterStation.Slip, "TOPLAM MÜŞTERİ BORCU: "+musteriborclari.Text + " TL" + Environment.NewLine);
                    Yazici.PrintNormal(PrinterStation.Slip, "AYLIK CİRO'DAN MÜŞTERİ BORUCU DÜŞÜMÜ: " + AylikciroMusteri.ToString()+" TL" + Environment.NewLine);
                    Yazici.PrintNormal(PrinterStation.Slip, "AYLIK KAR'DAN MÜŞTERİ BORUCU DÜŞÜMÜ: " + Aylikkarmusteri.ToString() + " TL" + Environment.NewLine);
                    Yazici.PrintNormal(PrinterStation.Slip, "**************************************************************" + Environment.NewLine);
                    Yazici.PrintNormal(PrinterStation.Slip, "----MALİ DEĞERİ YOKTUR---" + Environment.NewLine);
                    Yazici.PrintNormal(PrinterStation.Slip, "MARKETMATİK BETA V.1.0.2 seckinumur@gmail.com" + Environment.NewLine);
                    Yazici.CutPaper(100);
                    MessageBox.Show("RAPOR YAZDIRILDI", "UYARI!");
                    this.Close();
                    form234.Visible = true;
                }
            }
        }

        private void AylikRaporlamaFormu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                raporcikar.PerformClick();
            }
            if(e.KeyCode == Keys.Escape)
            {
                iptal.PerformClick();
            }
        }
    }
}
