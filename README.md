
# Teknoloji Mağazası Ürün Kayıt Uygulaması

## Proje Açıklaması
Bu proje, bir teknoloji mağazasında Telefon ve Bilgisayar ürünlerinin kaydını tutmak için geliştirilmiştir. Ürünlerin özelliklerini kullanıcıdan alarak kaydeden ve listeleyen bir konsol uygulamasıdır.
Uygulama, nesne yönelimli programlama (OOP) ilkeleri olan Inheritance (Kalıtım), Polymorphism (Çok Biçimlilik), Encapsulation (Kapsülleme) ve Abstraction (Soyutlama) özelliklerini kullanarak geliştirilmiştir.

##  Uygulama Özellikleri

### 1. Sınıf Yapısı

 - BaseMakine (Temel Sınıf)
   
 -- Ortak Özellikler:

 * Üretim Tarihi
 * Seri Numarası
 * Ad
 * Açıklama
 * İşletim Sistemi

-- Metotlar:

 * BilgileriYazdir(): Ortak özellikleri yazdırır. Derived sınıflarda ezilerek (override) ek özellikler de yazdırılır.
 * UrunAdiGetir(): Abstract bir metottur, her sınıfta ezilerek ürüne özgü isim bilgisi konsola yazdırılır.

 - Telefon (Derived Class)
   
 -- Ek Özellikler:
   
 * Türk Lisansı Durumu
   
 -- Ezilen Metotlar:
 
 * BilgileriYazdir(): Temel sınıfın yazdırma metodu üzerine, Türk lisansı bilgisi eklenerek çalışır.
   
 * UrunAdiGetir(): Telefon adını konsola yazdırır.

### 2. Program Akışı

 1 - Kullanıcıya telefon üretmek için 1, bilgisayar üretmek için 2 girmesi gerektiği belirtilir.
 
 2 - Kullanıcının seçim yaptığı ürün sınıfına göre bir nesne oluşturulur ve özellikleri kullanıcıdan alınır.
 
 3 - Ürün oluşturulduğunda başarı mesajı konsola yazdırılır ve ürün listeye eklenir.
 
 4 - Kullanıcıya başka bir ürün oluşturmak isteyip istemediği sorulur:
 
 * Evet: İşlem başa döner ve yeni bir ürün oluşturulur.
   
 * Hayır: Tüm ürünler listelenir, ürün bilgileri ekrana yazdırılır ve program sonlanır.
   
