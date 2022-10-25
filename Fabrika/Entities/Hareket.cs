namespace Fabrika.Entities
{
    public class Hareket
    {
        public int Id { get; set; }
        public Ürün Ürün { get; set; }

        public DateTime Tarih { get; set; }

        public int Adet { get; set; }

        internal Hareket(Ürün Ürün,int Adet)
        {
            this.Ürün = Ürün;
            this.Adet = Adet;
        }
    }
}
