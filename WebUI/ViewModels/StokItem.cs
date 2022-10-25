using Fabrika.Entities;
using Fabrika;

namespace WebUI.ViewModels
{
    public class StokItem
    {
        public int Kodu { get; set; }
        public string Adı { get; set; }
        public ÜrünTipleri Tipi { get; set; }

        public int ToplamAdet { get; set; }
        public StokItem(Ürün Stok, int Toplam)
        {
            this.Kodu = Stok.Kodu;
            this.Adı = Stok.Adı;
            this.Tipi = Stok.Tipi;
            this.ToplamAdet = Toplam;
        }

        /*
        public StokItem()
        {


        }
        */
        /*
        public void ÜrünDoldur(Ürün stok,int toplam ) { 
            this.Kodu = stok.Kodu;
            this.Adı = stok.Adı;
            this.Tipi = stok.Tipi;
            this.ToplamAdet = toplam;
        }
        */
    }
}
