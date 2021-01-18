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
    class OrtaSahaOyuncusu:Futbolcu
    {
        
        public double UzunTop;
        public double IlkDokunus;
        public double Uretkenlik;
        public double TopSurme;
        public double OzelYetenek;

        private readonly Random random = new Random();
        private int rastgeleDeger;
        private int RandomUret()
        {
            return this.random.Next(60, 100);
        }

        public OrtaSahaOyuncusu(string AdSoyad, int FormaNo) : base(AdSoyad, FormaNo)
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
            UzunTop = RandomUret();
            Uretkenlik = RandomUret();
            IlkDokunus = RandomUret();
            TopSurme = RandomUret();
            OzelYetenek = RandomUret();
            rastgeleDeger = RandomUret();
        }

        private double PasSkor = 0;
        public double PasVer()
        {
            PasSkor = (Pas * 0.3) + (Yetenek * 0.2) + (OzelYetenek * 0.2) + (Dayaniklilik * 0.1) + (DogalForm * 0.1) + (Sans * 0.1) + (UzunTop*0.1) + (TopSurme*0.1);
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
            GolVurusuSkor = (Yetenek * 0.3) + (OzelYetenek * 0.2) + (Sut * 0.1) + (IlkDokunus * 0.1) + (Kararlilik * 0.1) + (Sans * 0.1) + (DogalForm * 0.1);
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
