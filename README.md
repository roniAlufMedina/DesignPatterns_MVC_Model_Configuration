# DesignPatterns_MVC_Model_Configuration
Design Paterns MVC Model, ModelView, Katmanlı Mimari Projesi

Katmanlı Mimariye giriş ve Design Patterns Örneği (Singleton, Simple Factory)

## Proje Amacı
MVC Eğitimin ortasında Model'i anlattıktan sonra katmanlı mimari'ye geçişi anlatmak ve Design Paternlerine giriş yapmak için hazırlanmıştır.
Öğrencilerimize Modelin ancak MVC projesinden çıkınca katmanlı mimari'ye geçebildiğimizi anlatıyoruz.
Viewlar için ayrı ayrı ViewModeller oluşturuyoruz. 
ViewModellerde aşağıdaki konular örnekleniyor:
 * Data Annotation
 * Custom Validation
 * IValidateObject

## Proje Süresi 
Projeyi öğrenciler ile tamamı ile yapmak 3 saati buluyor. Eğer konu da anlatılacaksa 2. güne bir kısmı kalabilir.

## Projenin Tanımı 
Farklı Kategorilerde Ürünler yaratıp stoklarımıza eklemek istiyoruz. Stok giriş hareketi ile stok miktarlarımızı artıyoruz.

## Akış
1.  Ürün ve Hareket Entity lerini yarat
2.  Üründen miras alan sınıfları yarat 
3.  Ürün ve Hareket yaratırken ID ne olacak diye sor? Fabrika ihtiyacını göster.
4.  Fabrikaya kolay erişim için Singleton mantığını anlat ve Uygula
5.  Nesneleri fabrika üzerinden yarat
6. İhtiyaç olan View Modelleri yarat
7. Data Annotation Ekle, Custon Validation Ekle, IValidateObject Ekle
8. Controller kodunu yaz
9. Viewları oluştur. 


## Ödev veya Ek Geliştirilebilecek Özellikler
Ürün Çıkarmak için ViewModel hazırla
Ürün Detayını Görüntüle
Ürün bilgilerini değiştir (Update)

