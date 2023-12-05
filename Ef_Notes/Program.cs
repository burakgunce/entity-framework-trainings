namespace Ef_Configuration_Notes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region EF Core'da Neden Yapılandırmalara İhtiyacımız Olur?
            //Default davranışları yeri geldiğinde geçersiz kılmak ve özelleştirmek isteyebiliriz. Bundan dolayı yapılandırmalara ihtiyacımız olacaktır.
            #endregion

            #region OnModelCreating Metodu
            //EF Core'da yapılandırma deyince akla ilk gelen metot OnModelCreating metodudur.
            //Bu metot, DbContext sınıfı içerisinde virtual olarak ayarlanmış bir metottur.
            //Bizler bu metodu kullanarak model'larımızla ilgili temel konfigürasyonel davranışları(Fluent API) sergileyeibliriz.
            //Bir model'ın yaratılışıyla ilgili tüm konfigürasyonları burada gerçekleştirebilmekteyiz.

            #region GetEntityTypes
            //EF Core'da kullanılan entity'leri elde etmek, programatik olarak öğrenmek istiyorsak eğer GetEntityTypes fonksiyonunu kullanabiliriz.
            #endregion

            #endregion

            #region Configurations | Data Annotations & Fluent API

            #region Table - ToTable
            //Generate edilecek tablonun ismini belirlememizi sağlayan yapılandırmadır.
            //Ef Core normal şartlarda generate edeceği tablonun adını DbSet property'sinden almaktadır. Bizler eğer ki bunu özelleştirmek istiyorsak Table attribute'unu yahut ToTable api'ını kullanabilriiz.
            #endregion

            #region Column - HasColumnName, HasColumnType, HasColumnOrder
            //EF Core'da tabloların kolonları entity sınıfları içerisindeki property'lere karşılık gelmektedir. 
            //Default olarak property'lerin adı kolon adıyken, türleri/tipleri kolon türleridir.
            //Eğer ki generate edilecek kolon isimlerine ve türlerine müdahale etmek sitiyorsak bu konfigürasyon kullanılır.
            #endregion

            #region ForeignKey - HasForeignKey
            //İlişkisel tablo tasarımlarında, bağımlı tabloda esas tabloya karşılık gelecek verilerin tutulduğu kolonu foreign key olarak temsil etmekteyiz.
            //EF Core'da foreign key kolonu genellikle Entity Tnaımlama kuralları gereği default yapılanmalarla oluşturulur.
            //ForeignKey Data Annotations Attribute'unu direkt kullanabilirsiniz. Lakin Fluent api ile bu konfigürasyonu yapacaksanız iki entity arasındaki ilişkiyide modellemeniz gerekmektedir. Aksi taktirde fluent api üzerinde HasForeignKey fonksiyonunu kullanamnazsınız!
            #endregion

            #region NotMapped - Ignore
            //EF Core, entity sınıfları içerisindeki tüm proeprtyleri default olarak modellenen tabloya kolon şeklinde migrate eder.
            //Bazn bizler entity sınıfları içerisinde tabloda bir kolona karşılık gelmeyen propertyler tanımlamak mecburiyetinde kalabiliriz.
            //Bu property'lerin ef core tarafından kolon olarak map edilmesini istemediğimizi bildirebilmek için NotMapped ya da Ignore kullanabiliriz.
            #endregion

            #region Key - HasKey
            //EF Core'da, default convention olarak bir entity'nin içerisinde Id, ID, EntityId, EntityID vs. şeklinde tanımlanan tüm proeprtylere varsayılan olarak primary key constraint uygulanır.
            //Key ya da HasKey yapılanmalarıyla istediğinmiz her hangi bir proeprty'e default convention dışında pk uygulayabiliriz.
            //EF Core'da bir entity içerisinde kesinlikle PK'i temsil edecek olan property bulunmalıdır. Aksi taktirde EF Core migration olutşurken hata verecektir. Eğer ki tablonun PK'i yoksa bunun bildirilmesi gerekir. 
            #endregion

            #region Timestamp - IsRowVersion
            //İleride/sonraki derlerde veri tutarlılığı ile ilgili bir ders yapacağız.
            //Bu derste bir satırdaki verinin bütünsel olarak değişikliğini takip etmemizi sağlayacak olan verisyon mantığını konuşuyor olacağız.
            //İşte bir verinin verisyonunu oluşturmamızı sağlayan yapılanma bu konfigürasyonlardır.
            #endregion

            #region Required - IsRequired
            //Bir kolonun nullable ya da not null olup olmamasını bu konfigürasyonla belirleyebiliriz.
            //EF Core'da bir property default oalrak not null şeklinde tanımlanır. Eğer ki property'si nullable yapmak istyorsak türü üzerinde ?(nullable) operatörü ile bbildirimde bulunmamız gerekmektedir.
            #endregion

            #region MaxLenght | StringLength - HasMaxLength
            //Bir kolonun max karakter sayısını belirlememizi sağlar.
            #endregion

            #region Precision - HasPrecision
            //Küsüratlı sayılarda bir kesinlik belirtmemizi ve noktanın hanesini bildirmemizi sağlayan bir yapılandırmadır.
            #endregion

            #region Unicode - IsUnicode
            //Kolon içerisinde unicode karakterler kullanılacaksa bu yapılandırmadan istifade edilebilir.
            #endregion

            #region Comment - HasComment
            //EF Core üzerinden oluşturulmuş olan veritabanı nesneleri üzerinde bir açıkalama/yorum yapmak istiyorsanız Comment'i kullanblirsiniz.
            #endregion

            #region ConcurrencyCheck - IsConcurrencyToken
            //İleride/sonraki derlerde veri tutarlılığı ile ilgili bir ders yapacağız.
            //Bu derste bir satırdaki verinin bütünsel olarak tutarlılığını sağlayacak bir concurrency token yapılanmasından bahsececeğiz.
            #endregion

            #region InverseProperty
            //İki entity arasında birden fazla ilişki varsa eğer bu ilişkilerin hangi navigation property üzerinden oılacağını ayarlamamızı sağlayan bir konfigrasyondur.
            #endregion

            #endregion
        }
    }
}