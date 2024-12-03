Bu proje, bir kargo şirketinin ulaştırma filosundaki araçların hızlarının uydu sistemleri yardımıyla izlenmesini sağlayan bir olay (event) tabanlı sistem geliştirmek amacıyla hazırlanmıştır. Araçların hız limitlerini aşması durumunda, istenilen aksiyonların alınmasına olanak tanıyan bir yapı sunar.

## Projenin Amacı 📋

- **Araç Takibi:** Araçların güncel koordinat ve hız bilgilerinin düzenli olarak alınması.
- **Hız Limit Kontrolü:** Hız limitini aşan araçlar için bir olayın tetiklenmesi.
- **Esneklik:** Hız limiti aşıldığında istenen aksiyonların kolayca özelleştirilebilmesi.
## Çalışma Mantığı ⚙️
- `Arac` sınıfından oluşturulan bir nesne, hız bilgisi güncellendiğinde kontrol yapar.
- Eğer hız, varsayılan hız limiti olan **110 km/sa** değerini aşarsa, **`HızLimiti`** olayı tetiklenir.
