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
    public partial class KarsilamaEkrani : Form
    {
        public VeriEntities3 db;
        public string Tarih = DateTime.Now.ToShortDateString();
        public string Ay = DateTime.Now.Month.ToString();
        public AnaForm anaform;
        public KarsilamaEkrani()
        {
            InitializeComponent();
            db = new VeriEntities3();
        }

        private void KarsilamaEkrani_Load(object sender, EventArgs e)
        {
            try
            {
                bool varmi = db.KasaGunlukToplam.Any(p => p.Tarih.Contains(Tarih));
                bool Aykontrol = db.KasaAylik.Any(p => p.Tarih.Contains(Ay));
                if (varmi == true)
                {

                    var ekle = db.KasaGunlukToplam.Where(p => p.Tarih == Tarih).FirstOrDefault();
                    Yazi1.Text = "Tekrar Hoş Geldiniz İyi Satışlar";
                    yaziKasa.Text = ekle.Ciro.ToString();


                }
                else
                {

                    KasaGunlukToplam kasaacilis = new KasaGunlukToplam();
                    kasaacilis.Tarih = Tarih;
                    kasaacilis.Ciro = "0";
                    kasaacilis.Giderler = "0";
                    kasaacilis.Kar = "0";
                    db.KasaGunlukToplam.Add(kasaacilis);
                    db.SaveChanges();
                    Yazi1.Text = "İyi Günler Prestige Cafe";
                    yaziKasa.Hide();
                    label3.Text = "Kasa Açılışı Yapıldı";
                }
                if (Aykontrol == true)
                {

                }
                else
                {
                    KasaAylik kasaaylik = new KasaAylik();
                    kasaaylik.Tarih = Ay;
                    kasaaylik.KasaAylikCiro = "0";
                    kasaaylik.KasaAylikGider = "0";
                    kasaaylik.KasaAylikKar = "0";
                    db.KasaAylik.Add(kasaaylik);
                    db.SaveChanges();
                    label3.Text = "Yeni Ay Kasa Açılışı Yapıldı.";
                    MessageBox.Show("YENİ BİR AYA GİRİŞ YAPILDI! ÖNCEKİ AYIN SATIŞLARINI AYLIK RAPORLARDAN GÖREBİLİRSİNİZ. EĞER YENİ BİR YILA GİRDİYSENİZ GEÇEN YILIN OCAK AYININ SATIŞLARI ÜZERİNDE BU AYIN SATIŞLARI YAZILACAKTIR. MUTLAKA AYLIK RAPOR KAĞITLARINI SAKLAYINIZ. DAHA FAZLA BİLGİ İÇİN GELİŞTİRİCİYLE İRTİBATA GEÇİN.", "BİLGİ!");
                }
            }
            catch
            {
                MessageBox.Show("VERİTABANINA BAĞLANAMADI! PROGRAM ÇÖKMÜŞTÜR. LÜTFEN GELİŞTİRİCİ İLE İRTİBAT KURUN.", "ÖLÜMCÜL ÇEKİRDEK KOD HATASI");
                Application.Exit();
            }
            timer1.Enabled = true;
            timer1.Interval = 3000;
        }

        private void yaziKasa_Click(object sender, EventArgs e)
        {

        }

        private void Yazi1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            anaform = new AnaForm();
            anaform.Show();
            this.Hide();
        }
    }
}
