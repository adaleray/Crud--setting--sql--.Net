Öğrenci Yönetim Sistemi
Bu proje, öğrenci yönetimi ve ders ekleme işlemleri için geliştirilmiş bir Windows Forms uygulamasıdır. Uygulama, öğrencilerin derslerine kayıt yapılması, sınıf yönetimi ve öğrenci bilgileri gibi işlemleri yapabilmek için kullanılmaktadır.

Proje Özeti
Bu uygulama, öğrencilerin ders kaydı yapmasını ve sınıf yönetimini sağlar. Öğrenciler derslere kayıt edilebilir, sınıflar eklenip güncellenebilir, silinebilir. Uygulama, ilişkili veritabanı ile öğrenci, ders, sınıf bilgilerini yönetmeye olanak tanır.

Özellikler
Öğrenci ekleme, güncelleme, silme
Ders ekleme, güncelleme, silme
Öğrencilerin derslerine kayıt olma
Öğrencinin aldığı derslerin görüntülenmesi
Sınıf yönetimi (sınıf ekleme, güncelleme, silme)
Öğrencilerin derslerinin kontrol edilmesi ve eklenmesi
Kullanılan Teknolojiler
.NET Framework 4.7.2: Uygulama Windows Forms ile geliştirilmiştir.
C#: Programlama dili olarak C# kullanılmıştır.
Entity Framework: Veritabanı işlemleri için kullanılan ORM (Object-Relational Mapping) aracıdır.
Microsoft SQL Server: Veritabanı yönetim sistemi olarak kullanılmıştır.
Kurulum
Bu projeyi bilgisayarınıza indirmek için aşağıdaki adımları takip edebilirsiniz.

1. Projeyi GitHub'dan Klonlayın
Öncelikle, bu depoyu bilgisayarınıza klonlayın:

bash
Kodu kopyala
git clone https://github.com/<kullanici-adiniz>/FinalOdev.git
2. Gerekli NuGet Paketlerini Yükleyin
Proje Entity Framework kullanmaktadır, bu nedenle NuGet paketlerini yüklemeniz gerekebilir. Visual Studio'yu açın ve Tools > NuGet Package Manager > Package Manager Console yolunu takip ederek aşağıdaki komutları girin:

bash
Kodu kopyala
Install-Package EntityFramework
3. Veritabanı Bağlantı Ayarlarını Yapın
Uygulama, veritabanına bağlanabilmesi için bir ConnectionString gerektirir. Bu bağlantı bilgilerini app.config dosyasındaki connectionStrings kısmına eklemeniz gerekecek.

xml
Kodu kopyala
<connectionStrings>
  <add name="StudentDbContex" connectionString="Server=localhost; Database=OgrenciDB; Integrated Security=True;" providerName="System.Data.SqlClient" />
</connectionStrings>
4. Projeyi Çalıştırın
Projeyi Visual Studio'da açarak, F5 tuşuna basarak çalıştırabilirsiniz.

Kullanım
Öğrenci Ekleme
Öğrencilerinizi Öğrenci Ekleme formunu kullanarak ekleyebilirsiniz.
Öğrencilerin adı, soyadı, numarası ve sınıfı gibi bilgileri girerek yeni bir öğrenci ekleyebilirsiniz.
Ders Ekleme
Ders eklemek için Ders Ekleme formunu kullanabilirsiniz.
Ders adı gibi bilgileri girerek yeni bir ders ekleyebilirsiniz.
Öğrenciye Ders Ekleme
Öğrencinin derslerini eklemek için Öğrenci Ders Ekleme formunu kullanabilirsiniz.
Listeden dersleri seçip öğrenciye ders ekleyebilirsiniz.
Sınıf Yönetimi
Sınıf Yönetimi kısmında yeni sınıflar oluşturabilir, mevcut sınıfları güncelleyebilir veya silebilirsiniz.
Bir sınıf silinmeden önce o sınıfta öğrenci olup olmadığı kontrol edilir.
Katkıda Bulunma
Bu projeye katkıda bulunmak isterseniz, aşağıdaki adımları takip edebilirsiniz:

Bu repository'yi fork'layın.
Yeni bir branch oluşturun (git checkout -b feature-xyz).
Değişikliklerinizi yapın ve commit edin (git commit -am 'Add new feature').
Branch'ınızı GitHub'a push edin (git push origin feature-xyz).
Pull request gönderin.
Lisans
Bu proje MIT Lisansı ile lisanslanmıştır.

İletişim
Proje ile ilgili her türlü soru ve geri bildirim için [İletişim Bilgileriniz] adresinden ulaşabilirsiniz.

