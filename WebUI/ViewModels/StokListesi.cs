using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections;
using Fabrika;
using Fabrika.Entities;

namespace WebUI.ViewModels
{
    public class StokListesi: ICollection<StokItem>
    {
        private List<StokItem> items;

        public StokListesi()
        {
            NesneFabrikası fabrika = NesneFabrikası.Fabrikam();
            items = new List<StokItem>();
            foreach (var item in fabrika.Ürünler)
            {
                /*
                //1. Yöntem
                StokItem stok = new StokItem();
                stok.ÜrünDoldur(item
                    ,
                fabrika.Hareketler
                .Where(i => i.Ürün == (Ürün)item)
                .Sum(i => i.Adet));
                */
                //2. yöntem
                StokItem stok = new StokItem(
                    item,
                    fabrika.Hareketler
                        .Where(i => i.Ürün == (Ürün)item)
                        .Sum(i => i.Adet)
                    );

                items.Add(stok);
            }
        }

        public int Count => ((ICollection<StokItem>)items).Count;

        public bool IsReadOnly => ((ICollection<StokItem>)items).IsReadOnly;

        public void Add(StokItem item)
        {
            ((ICollection<StokItem>)items).Add(item);
        }

        public void Clear()
        {
            ((ICollection<StokItem>)items).Clear();
        }

        public bool Contains(StokItem item)
        {
            return ((ICollection<StokItem>)items).Contains(item);
        }

        public void CopyTo(StokItem[] array, int arrayIndex)
        {
            ((ICollection<StokItem>)items).CopyTo(array, arrayIndex);
        }

        public IEnumerator<StokItem> GetEnumerator()
        {
            return ((IEnumerable<StokItem>)items).GetEnumerator();
        }

        public bool Remove(StokItem item)
        {
            return ((ICollection<StokItem>)items).Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)items).GetEnumerator();
        }
    }
}
