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
    
    public partial class VeresiyeSecmeFormu : Form
    {
        public AnaForm anaform;
        PosPrinter Yazici;
        public double AnlikSatisToplam;
        public double MusteriOncekiBakiyeToplami;
        public AnaForm form1 = (AnaForm)Application.OpenForms["AnaForm"];
        public double MusteriYeniBakiyeToplam;
        public string Tarih = DateTime.Now.ToShortDateString();
        public string Ay = DateTime.Now.Month.ToString();
        public double kar = 0;
        VeriEntities3 db;
        public VeresiyeSecmeFormu()
        {
            InitializeComponent();
            db = new VeriEntities3();
        }

        private void VeresiyeSecmeFormu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'veriDataSet8.Musteriler' table. You can move, or remove it, as needed.
            this.musterilerTableAdapter1.Fill(this.veriDataSet8.Musteriler);
            // TODO: This line of code loads data into the 'veriDataSet4.Musteriler' table. You can move, or remove it, as needed.
            this.musterilerTableAdapter.Fill(this.veriDataSet4.Musteriler);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            form1.Visible = true;
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int xkoordinat = dataGridView1.CurrentCellAddress.X; //Seçili satırın X koordinatı
            int ykoordinat = dataGridView1.CurrentCellAddress.Y;  //Seçili satırın Y koordinatı
            string str = "";
            str = dataGridView1.Rows[ykoordinat].Cells[xkoordinat].Value.ToString();
            if (e.RowIndex == -1)
            {
                return;
            }
            SecAra.Text = str;
            try
            {
                var Bul = db.Musteriler.Where(w => w.MusteriAdi == SecAra.Text).FirstOrDefault();
                MusteriAdi.Text = Bul.MusteriAdi;
                OncekiBakiye.Text = Bul.MusteriBakiyesi;
                MusteriOncekiBakiyeToplami = double.Parse(OncekiBakiye.Text);
                MusteriYeniBakiyeToplam = MusteriOncekiBakiyeToplami + AnlikSatisToplam;
                YeniBakiye.Text = MusteriYeniBakiyeToplam.ToString();
            }
            catch
            {
                MessageBox.Show("veritabına bağlanılamadı", "kritik sistem hatası");
            }
        }

        private void SecAra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData.ToString() == "Return")
            {
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    if (dataGridView1.Rows[i].Cells[0].Value.ToString() == SecAra.Text)
                    {
                        try
                        {
                            var Bul = db.Musteriler.Where(w => w.MusteriAdi == SecAra.Text).FirstOrDefault();
                            MusteriAdi.Text = Bul.MusteriAdi;
                            OncekiBakiye.Text = Bul.MusteriBakiyesi;
                            MusteriOncekiBakiyeToplami = double.Parse(OncekiBakiye.Text);
                            MusteriYeniBakiyeToplam = MusteriOncekiBakiyeToplami + AnlikSatisToplam;
                            YeniBakiye.Text = MusteriYeniBakiyeToplam.ToString();
                        }
                        catch
                        {
                            MessageBox.Show("veritabına bağlanılamadı", "kritik sistem hatası");
                        }
                    }
                }
            }
        }

        private void SatisiBitir_Click(object sender, EventArgs e)
        {
            if (form1.KONTROL == true)
            {
                try
                {
                    var ekle1 = db.KasaAylik.Where(p => p.Tarih == Ay).FirstOrDefault();
                    var ekle = db.KasaGunlukToplam.Where(p => p.Tarih == Tarih).FirstOrDefault();
                    var Bul = db.Musteriler.Where(w => w.MusteriAdi == SecAra.Text).FirstOrDefault();
                    double Oncekikar = double.Parse(ekle.Kar);
                    double kartopla = Oncekikar + form1.AnlikKar;
                    double OncekiCiro = double.Parse(ekle.Ciro);
                    double Cirotopla = OncekiCiro + form1.AnlikCiro;
                    ekle.Ciro = Cirotopla.ToString();
                    ekle.Kar = kartopla.ToString();
                    double aykar = double.Parse(ekle1.KasaAylikKar);
                    double ayciro = double.Parse(ekle1.KasaAylikCiro);
                    double aykartopla = kartopla + aykar;
                    double aycirotopla = Cirotopla + ayciro;
                    ekle1.KasaAylikCiro = aycirotopla.ToString();
                    ekle1.KasaAylikKar = aykartopla.ToString();
                    db.SaveChanges();
                    OncekiBakiye.Text = Bul.MusteriBakiyesi;
                    MusteriOncekiBakiyeToplami = double.Parse(OncekiBakiye.Text);
                    MusteriYeniBakiyeToplam = MusteriOncekiBakiyeToplami + AnlikSatisToplam;
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
                    Yazici.PrintNormal(PrinterStation.Slip, "VERESİYE ÖDEME SATIŞ FİŞİ" + "  TARİH: " + DateTime.Now.ToShortDateString() + Environment.NewLine);
                    Yazici.PrintNormal(PrinterStation.Slip, "**************************************************************" + Environment.NewLine);
                    Yazici.PrintNormal(PrinterStation.Slip, "MÜŞTERİ ADI: "+Bul.MusteriAdi + Environment.NewLine);
                    Yazici.PrintNormal(PrinterStation.Slip, "MÜŞTERİ ÖNCEKİ BAKİYESİ: " + Bul.MusteriBakiyesi + Environment.NewLine);
                    Yazici.PrintNormal(PrinterStation.Slip, "MÜŞTERİ SATIŞ SONRAKİ BAKİYESİ: " + MusteriYeniBakiyeToplam.ToString()+ Environment.NewLine);
                    Yazici.PrintNormal(PrinterStation.Slip, "**************************************************************" + Environment.NewLine);
                    for (int i = 0; i < form1.dataGridView1.Rows.Count - 1; i++)
                    {
                        if (i == 100)
                        {
                            i = 0;
                            return;
                        }
                        Yazici.PrintNormal(PrinterStation.Slip, form1.dataGridView1.Rows[i].Cells[1].Value.ToString() + " ---- " + form1.dataGridView1.Rows[i].Cells[2].Value.ToString() + Environment.NewLine);
                    }
                    Yazici.PrintNormal(PrinterStation.Slip, "**************************************************************" + Environment.NewLine);
                    Yazici.PrintNormal(PrinterStation.Slip, "TOPLAM TUTAR: " + form1.ToplamTutarTextBox.Text + Environment.NewLine);
                    Yazici.PrintNormal(PrinterStation.Slip, "**************************************************************" + Environment.NewLine);
                    Yazici.PrintNormal(PrinterStation.Slip, "----MALİ DEĞERİ YOKTUR---" + Environment.NewLine);
                    Yazici.PrintNormal(PrinterStation.Slip, "MARKETMATİK BETA V.1.0.2 seckinumur@gmail.com" + Environment.NewLine);
                    Yazici.CutPaper(100);
                    Bul.MusteriBakiyesi = MusteriYeniBakiyeToplam.ToString();
                    db.SaveChanges();
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
            form1.KONTROL = false;
            form1.dataGridView1.Rows.Clear();
            form1.sayac = 0;
            form1.SonucToplam = 0;
            form1.AnlikSatisToplam = 0;
            form1.AnlikCiro = 0;
            form1.AnlikKar = 0;
            form1.ToplamTutarTextBox.Text = "";
            this.Close();
            form1.Visible = true;
        }

        private void VeresiyeSecmeFormu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                SatisiBitir.PerformClick();
            }
            if (e.KeyCode == Keys.Escape)
            {
                button2.PerformClick();
            }
        }
    }
}
