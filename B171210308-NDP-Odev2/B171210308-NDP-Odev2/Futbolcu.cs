using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/****************************************************************************
**					    SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					    2018-2019 BAHAR DÖNEMİ
**	
**				  ÖDEV NUMARASI..........: ÖDEV NO - 2
**				  ÖĞRENCİ ADI............: Erencan İNANCI
**				  ÖĞRENCİ NUMARASI.......: B171210308
**                DERSİN ALINDIĞI GRUP...: 2. Öğretim / B Grubu
****************************************************************************/

namespace B171210308_NDP_Odev2
{
    class Futbolcu
    {
        public string AdSoyad;
        public int FormaNo;
        public double Hiz;
        public double Dayaniklilik;
        public double Pas;
        public double Sut;
        public double Yetenek;
        public double Kararlilik;
        public double DogalForm;
        public double Sans;

        private readonly Random random = new Random();
        private int rastgeleDeger;

        private int RandomUret()
        {
            return this.random.Next(50, 100);
        }

        public Futbolcu(string adSoyad, int formaNo)
        {
            this.AdSoyad = adSoyad;
            this.FormaNo = formaNo;
            this.Hiz = RandomUret();
            this.Dayaniklilik = RandomUret();
            this.Pas = RandomUret();
            this.Sut = RandomUret();
            this.Yetenek = RandomUret();
            this.Kararlilik = RandomUret();
            this.DogalForm = RandomUret();
            this.Sans = RandomUret();
            this.rastgeleDeger = RandomUret();
        }

        public string adSoyad { get { return AdSoyad; } set { AdSoyad = value; } }
        public int formaNo { get { return FormaNo; } set { FormaNo = value; } }

        public Futbolcu() { }


        private double PasSkor = 0;
        public double PasVer()
        {
            Pas = RandomUret();
            Yetenek = RandomUret();
            Dayaniklilik = RandomUret();
            DogalForm = RandomUret();
            Sans = RandomUret();
            PasSkor = (Pas * 0.3) + (Yetenek * 0.3) + (Dayaniklilik * 0.1) + (DogalForm * 0.1) + (Sans * 0.1);
            if (PasSkor >= 60)
            {
                Console.WriteLine("Pas başarılı..");
            }
            else if (PasSkor < 60)
            {
                Console.WriteLine("Pas başarısız.. Pozisyonu tekrar oluşturun.");
                Console.ReadLine();
                Environment.Exit(0);
            }
            return PasSkor;
        }

        private double GolVurusuSkor;
        public double GolVurusu()
        {
            GolVurusuSkor = (Yetenek * 0.3) + (Sut * 0.2) + (Kararlilik * 0.1) + (DogalForm * 0.1) + (Hiz * 0.1) + (Sans * 0.2);
            if (GolVurusuSkor >= 70)
            {
                Console.WriteLine("GOOOOL!!");
                Console.ReadLine();
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Şut başarısız.. Pozisyonu tekrar oluşturun.");
                Console.ReadLine();
                Environment.Exit(0);
            }
            return GolVurusuSkor;
        }
    }
}