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
    class DefansOyuncusu : Futbolcu
    {
        public double PozisyonAlma;
        public double Kafa;
        public double Sicrama;

        private readonly Random random = new Random();
        private int rastgeleDeger;
        private int RandomUret()
        {
            return this.random.Next(50, 90);
        }

        public DefansOyuncusu(string AdSoyad, int FormaNo) : base(AdSoyad, FormaNo)
        {

            this.AdSoyad = AdSoyad;
            this.FormaNo = FormaNo;
            Hiz = RandomUret();
            Dayaniklilik = RandomUret();
            Pas = RandomUret();
            Sut = RandomUret();
            Yetenek = RandomUret();
            Kararlilik = RandomUret();
            DogalForm = RandomUret();
            Sans = RandomUret();
            PozisyonAlma = RandomUret();
            Kafa = RandomUret();
            Sicrama = RandomUret();
            rastgeleDeger = RandomUret();
        }

        private double PasSkor = 0;
        public double PasVer()
        {
            PasSkor = (Pas * 0.3) + (Yetenek * 0.3) + (Dayaniklilik * 0.1) + (DogalForm * 0.1) + (PozisyonAlma * 0.1) + (Sans * 0.2);
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
            GolVurusuSkor = (Yetenek * 0.3) + (Sut * 0.2) + (Kararlilik * 0.1) + (DogalForm * 0.1) + (Kafa * 0.1) + (Sans * 0.1) + (Sicrama * 0.1);
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
