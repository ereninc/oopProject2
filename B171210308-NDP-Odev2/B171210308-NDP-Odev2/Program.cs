using System;
using System.Collections;
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
    class Program
    {
        public static List<Futbolcu> takim = new List<Futbolcu>();
        static void PozisyonOlusturucu()
        {
            takim.Add(new Futbolcu("Ali A", 1));
            takim.Add(new DefansOyuncusu("Veli B", 2));
            takim.Add(new DefansOyuncusu("Mehmet C", 3));
            takim.Add(new DefansOyuncusu("Eren D", 4));
            takim.Add(new DefansOyuncusu("Baris E", 5));
            takim.Add(new DefansOyuncusu("Ugur F", 6));
            takim.Add(new DefansOyuncusu("Ahmet G", 7));
            takim.Add(new DefansOyuncusu("Hasan H", 8));
            takim.Add(new DefansOyuncusu("Emre I", 9));
            takim.Add(new DefansOyuncusu("Ozan J", 10));
            takim.Add(new DefansOyuncusu("Kadir K", 11));

            Random rnd = new Random();
            Console.WriteLine("Pozisyon Başladı =>");

            int[] rastDizi = new int[6];
            int rastgeleDeger = rnd.Next(1, 11);
            rastDizi[0] = rastgeleDeger;
            int sayac = 1;

            /*pas verme skoru projemizde yüksek seçildiği için neredeyse hiç bir pas başarısız olmuyor fakat pas skoru 60 dan
             * yukarı çektiğimizde ise düzgün çalıştığı gözükecektir.
             */

            //pozisyonun 3 kere oluşması için (başarılı olma durumunda pas atma işleminin 3 kere gerçekleşmesi için döngü)
            for (int i = 0; i < 4; i++)
            {
                if (i != 3)//3. pas atıldığında topa sahip olan futbolcu tekrar pas atmasın diye koşul
                {
                    //aynı futbolcuya top gelmesin diye yazılan while döngüsü
                    while (rastDizi[sayac - 1] == rastgeleDeger)
                    {
                        rastgeleDeger = rnd.Next(1, 11);
                    }
                    rastDizi[sayac] = rastgeleDeger;
                    sayac++;

                    //pas atma işlemleri
                    Console.WriteLine("Top şuan " + takim[rastgeleDeger].AdSoyad + " adlı futbolcuda ve pas atıyor.");
                    if (takim[rastgeleDeger].FormaNo == 1)
                    {
                        Futbolcu Fut = new Futbolcu(takim[rastgeleDeger].AdSoyad, takim[rastgeleDeger].formaNo);
                        Fut.PasVer();
                    }
                    else if (takim[rastgeleDeger].FormaNo >= 2 && takim[rastgeleDeger].FormaNo <= 5)
                    {
                        DefansOyuncusu Def = new DefansOyuncusu(takim[rastgeleDeger].AdSoyad, takim[rastgeleDeger].formaNo);
                        Def.PasVer();
                    }
                    else if (takim[rastgeleDeger].FormaNo >= 6 && takim[rastgeleDeger].FormaNo <= 9)
                    {
                        DefansOyuncusu Ort = new DefansOyuncusu(takim[rastgeleDeger].AdSoyad, takim[rastgeleDeger].formaNo);
                        Ort.PasVer();
                    }
                    else if (takim[rastgeleDeger].FormaNo >= 10)
                    {
                        DefansOyuncusu For = new DefansOyuncusu(takim[rastgeleDeger].AdSoyad, takim[rastgeleDeger].formaNo);
                        For.PasVer();
                    }
                }

                //eğer pas işlemleri başarılı olduysa ve top 3. futbolcudaysa geçerleşecek blok
                else if (i == 3)
                {
                    while (rastDizi[sayac - 1] == rastgeleDeger)
                    {
                        rastgeleDeger = rnd.Next(1, 11);
                    }
                    rastDizi[sayac] = rastgeleDeger;
                    sayac++;

                    Console.WriteLine("Top şuan " + takim[rastgeleDeger].AdSoyad + " adlı futbolcuda..");
                    Console.WriteLine(takim[rastgeleDeger].AdSoyad + " adlı futbolcu şut çekiyooor!! ve..");

                    if (takim[rastgeleDeger].FormaNo == 1)
                    {
                        takim[rastgeleDeger].GolVurusu();
                    }
                    else if (takim[rastgeleDeger].FormaNo >= 2 && takim[rastgeleDeger].FormaNo <= 5)
                    {
                        DefansOyuncusu DefFut = new DefansOyuncusu(takim[rastgeleDeger].AdSoyad, takim[rastgeleDeger].FormaNo);
                        DefFut.GolVurusu();
                    }
                    else if (takim[rastgeleDeger].FormaNo >= 6 && takim[rastgeleDeger].FormaNo <= 9)
                    {
                        DefansOyuncusu OrtFut = new DefansOyuncusu(takim[rastgeleDeger].AdSoyad, takim[rastgeleDeger].FormaNo);
                        OrtFut.GolVurusu();
                    }
                    else
                    {
                        DefansOyuncusu ForFut = new DefansOyuncusu(takim[rastgeleDeger].AdSoyad, takim[rastgeleDeger].FormaNo);
                        ForFut.GolVurusu();
                    }
                }
            }
        }
        
        static void Main(string[] args)
        {
            PozisyonOlusturucu(); //main fonksiyonun ana görevinden dışarı çıkılmaması için işlemler ayrı metotta yapıldı ve burada çağırıldı.
            Console.ReadKey();
        }
    }
}