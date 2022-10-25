using Fabrika.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Fabrika
{
    //SimpleFactory ve Singleton Pattern
    public class NesneFabrikası
    {
        private int HareketCounter = 0;
        private int[] ÜrünCounter = {0,1000,2000,3000,4000 };

        private static NesneFabrikası? _fabrikam;

        public List<Ürün> Ürünler { get; set; }
        public List<Hareket> Hareketler { get; set; }


        public static NesneFabrikası Fabrikam() {
            if (_fabrikam == null)
                _fabrikam = new NesneFabrikası();
            return _fabrikam;
        }
        public Hareket HareketYarat(Ürün ürün, int Adet) 
        {
            HareketCounter++;
            Hareket yeni =new Hareket(ürün,Adet)
                {
                    Tarih = DateTime.Now,
                    Id = HareketCounter
                };
            Hareketler.Add(yeni);
            return yeni;
        }
        public Ürün ÜrünYarat
            (ÜrünTipleri Tip,string Adı,string Açıklama ) 
        {
            Ürün ürün;
            switch (Tip)
            {    
                case ÜrünTipleri.Kırtasiye:
                    ürün = new KırtasiyeÜrün();
                    break;
                case ÜrünTipleri.Bakliyat:
                    ürün = new BakliyatÜrün();
                    break;
                case ÜrünTipleri.SütÜrünleri:
                    ürün = new SütÜrün();
                    break;
                case ÜrünTipleri.İçecekler:
                    ürün = new İçecekÜrün();
                    break;

                default:
                    throw new Exception("İlgili ürün tipinde şimdilik ürün yaratamıyoruz.");
            }
            ürün.Kodu = ++ÜrünCounter[(int)Tip];
            ürün.Adı = Adı;
            ürün.Açıklama = Açıklama;
            Ürünler.Add(ürün);
            return ürün;
        }


        private NesneFabrikası()
        {
            Ürünler = new List<Ürün>();
            Hareketler = new List<Hareket>();            

            this.ÜrünYarat(ÜrünTipleri.Kırtasiye, "Kalem", "Kurşun Kalem");
            //this.ÜrünYarat(ÜrünTipleri.Şekerlemeler, "Gofret", "Çikolatalı Gofret");
            this.HareketYarat(Ürünler.First(), 3);
            this.HareketYarat(Ürünler.First(), 2);
        }
    }
}
