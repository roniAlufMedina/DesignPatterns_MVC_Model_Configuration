using Fabrika;
using Fabrika.Entities;
using Microsoft.Build.Framework;
using WebUI.Custom_Validations;

namespace WebUI.ViewModels
{
    public class HareketEkle
    {
        [Required]
        public int ÜrünKodu { get; set; }

        [AmountValidation]        
        [Required]
        public int Adet { get; set; }
      
        public Hareket Kaydet() {
            Ürün ürün = NesneFabrikası.Fabrikam().Ürünler.First(a => a.Kodu == this.ÜrünKodu);
            return NesneFabrikası.Fabrikam().HareketYarat(ürün,this.Adet);
        }
    }
}
