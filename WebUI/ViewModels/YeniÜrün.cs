using Fabrika.Entities;
using Fabrika;
using System.ComponentModel.DataAnnotations;

namespace WebUI.ViewModels
{
    public class YeniÜrün:IValidatableObject
    {
        [Display(Name ="Ürün Adı")]
        [Required(ErrorMessage ="Ürün Adı zorunludur.")]
        [MaxLength(50,ErrorMessage ="Ürün adı en fazla 50 karakter olabilir.")]
        public string Adı { get; set; }

        [Display(Name = "Ürün Açıklaması")]
        [MaxLength(500, ErrorMessage = "Ürün açıklaması en fazla 500 karakter olabilir.")]
        public string? Açıklama { get; set; }

        [Display(Name = "Ürün Kategorisi")]
        [Required(ErrorMessage = "Ürün kategorisi zorunludur.")]
        [Range(0,4,ErrorMessage ="Kategoriye geçersiz veri girdiniz.")]
        public ÜrünTipleri Tipi { get; set; }

        public Ürün Kaydet() {
            /*
            string açıklama;
            if (this.Açıklama == null)
                açıklama = "";
            else
                açıklama = this.Açıklama;
            */
            Ürün yeni = 
                NesneFabrikası.Fabrikam()
                .ÜrünYarat(this.Tipi, this.Adı, (this.Açıklama==null)?"":this.Açıklama );
            return yeni;            
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> hataListesi = new List<ValidationResult>();
            if (this.Tipi == ÜrünTipleri.Şekerlemeler)
            {
                hataListesi.Add(new ValidationResult("Şekerlemelerin kodu daha yazılmadı."));
            }
            return hataListesi;
        }
    }
}
