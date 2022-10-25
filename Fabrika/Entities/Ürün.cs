namespace Fabrika.Entities
{
    public abstract class Ürün
    {
        public int Kodu { get; set; }
        public string Adı { get; set; }

        public string Açıklama { get; set; }

        public ÜrünTipleri Tipi { get; private set; }

        internal Ürün(ÜrünTipleri tip)
        {
            this.Tipi = tip;
        }
    }
}
