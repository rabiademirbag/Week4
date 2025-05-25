# Telefon ve Bilgisayar Üretim Uygulaması (Konsol)

Bu C# konsol uygulaması, kullanıcıdan aldığı bilgilere göre **telefon** veya **bilgisayar** üretir. Kullanıcı her ürün için gerekli alanları doldurur ve sistem tarafından ürün bilgileri ekrana yazdırılır. Uygulama, kullanıcı `hayır` diyene kadar ürün üretimini tekrarlar.

## Özellikler

- Kullanıcıdan seçim alarak **telefon** veya **bilgisayar** üretimi yapılabilir.
- Kullanıcıdan alınan bilgilerle nesne oluşturulur (Telefon / Bilgisayar).
- Üretilen ürün bilgileri ekrana yazdırılır.
- Kullanıcı isterse başka ürün üretmeye devam edebilir.
- Geçersiz girişler için kullanıcı uyarılır ve tekrar giriş yapması istenir.

- ## Uygulamada Kullanılan Temel Kavramlar

- **Nesne Tabanlı Programlama (OOP)** prensipleri:
  - Kalıtım (Inheritance)
  - Polimorfizm
  - Soyutlama (Abstraction)
  - Kapsülleme (Encapsulation)
- `BaseMakine` adlı soyut sınıf üzerinden türetilen `Telefon` ve `Bilgisayar` sınıfları.
- `while` döngüsü ve `if-else` yapıları ile kontrol akışı.
- `int.TryParse()` kullanımı ile sayısal giriş doğrulama.
