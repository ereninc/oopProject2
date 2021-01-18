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
    class ForvetOyuncusu:Futbolcu
    {
        public double Bitiricilik;
        public double IlkDokunus;
        public double Kafa;
        public double SogukKanlilik;
        public double OzelYetenek;

        private readonly Random random = new Random();
        private int rastgeleDeger;
        private int RandomUret()
        {
            return this.random.Next(70, 100);
        }

        public ForvetOyuncusu(string AdSoyad, int FormaNo) : base(AdSoyad, FormaNo)
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
            Bitiricilik = RandomUret();
            Kafa = RandomUret();
            IlkDokunus = RandomUret();
            SogukKanlilik = RandomUret();
            OzelYetenek = RandomUret();
            rastgeleDeger = RandomUret();
        }

        private double PasSkor = 0;
        public double PasVer()
        {
            PasSkor = (Pas * 0.3) + (Yetenek * 0.2) + (OzelYetenek * 0.2) + (Dayaniklilik * 0.1) + (DogalForm * 0.1) + (Sans * 0.1);
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
            GolVurusuSkor = (Yetenek * 0.2) + (OzelYetenek * 0.2) + (Sut * 0.1) + (Kafa * 0.1) + (Bitiricilik * 0.1) + (Sans * 0.1) + (DogalForm * 0.1) + (SogukKanlilik * 0.1) + (Kararlilik * 0.1);
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
