using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Movie.Api.Models.Entities;

namespace Movie.Api.Configurations
{
    public class DiziConfiguration : IEntityTypeConfiguration<Dizi>
    {
        public void Configure(EntityTypeBuilder<Dizi> builder)
        {
            builder.HasData(
              new Dizi
              {
                  Id = Guid.NewGuid(),
                  Name = "Peaky Blinders",
                  Minute = 6,
                  Url = "https://m.media-amazon.com/images/I/61aPzScmLoS._AC_SY741_.jpg",
                  Category = "Dram, Tarihi, Polisiye",
                  Year = 2013,
                  Country = "İngiltere",
                  Trailer = "https://www.youtube.com/watch?v=oVzVdvGIC7U",
                  Age = 18,
                  Starring = "Cillian Murphy,Sam Neill,Helen McCrory,Paul Anderson",
                  Creators = "Otto Bathurst,Tom Harper",
                  Explane = "Çete yaptıkları son soygunla Müfettiş Chester Campbell'in (Sam Neill tarafından canlandırılan) dikkatini çeker ve dönemin Dışişleri Bakanı Winston Churchill tarafından bu soygunu araştırmak üzere Birmingham'a gönderilir. Hedefinde çeteler, gangsterler, komünistler ve müşterek suçlular vardır. Chester, şehri bu yasa dışı örgütlerden temizlemek için yemin eder ve bunun üzerine daha önce görev yaptığı Belfast’tan kendi ekibini de getirip çalışmalara başlar.[7][8] Winston Churchill ilk seride Andy Nyman, ikinci seride Richard McCabe tarafından canlandırılmıştır. İkinci seri,ilk seriden iki yıl sonrasını konu alır.Shelby ailesi,'Kuzey ve Güney Londra' bölgesinde kendi suç örgütünü genişletmiş olarak görür.[9] İkinci seri,1921 yılında başlar ve Haziran 1922'deki Epsom Derby'si ile son bulur.Üçüncü seri ise yine iki yıl sonrasını konu alır ve 1924 yılında başlar.Tommy ve ailesi daha tehlikeli bir dünyayı giriş yapar ve örgütü daha da genişletir fakat bu sefer genişleme uluslararasıdır.İnternet tabanlı film ve televizyon haberleri şirketi Screen Rant'a göre 'Sezon toplumsal sınıflar ve imparatorluk kavramları etrafında dönmektedir. Bu durumları öngörülebilir olmasına rağmen şaşırtarak sıralar.'Dizi anlaşılacağı üzere zamanla büyüyen imparatorlukların,bozulmasını,karmaşık bir hale gelmesini ve bu şekilde sürdüremeyerek çöküşlerini anlatır.Sezon Tommy'ye, kirli sularda yüzerken nasıl genişleyeceği ve diğer köpekbalıklarına – özellikle hükûmet üzerinde büyük etkisi olanlar - nasıl dikkat edeceğini öğretmiştir. Peaky Blinders esas olarak, kendi konforlu bölgesi dışında hızlı hareket eden ve riskli bir şekilde çok fazla genişleyen balığın hikâyesini anlatır. Bazı zamanlar vardır, riski önceden ödenmiştir.`Father John Hughes rolünde Paddy Considine, Ruben Oliver rolünde Alexander Siddig, Grand Duchess Tatiana Petrovna rolünde Gaite Jansen ve Linda Shelby rolünde Kate Phillips - Arthur'un karısı - üçüncü sezonda eklenen oyunculardan bazılarıdır.Dizinin yayınlanan dördüncü sezonunda Oscar ödüllü ünlü oyuncu Adrien Brody,Luca Changretta rolünü canlandırırken 2019 yılında yayınlanan beşinci sezonunda ise Sam Claflin İngiliz politikacı Oswald Mosley'e hayat vermiştir.",
                  Imdb = "8.8",
                  PictureSource = "amazon.com",
                  TextMovieSource = "wikipedia.org"
              },
              new Dizi
              {
                  Id = Guid.NewGuid(),
                  Name = "The Queen's Gambit",
                  Minute = 1,
                  Url = "https://upload.wikimedia.org/wikipedia/en/1/12/The_Queen%27s_Gambit_%28miniseries%29.png",
                  Category = "Dram",
                  Year = 2020,
                  Country = "ABD",
                  Trailer = "https://www.youtube.com/watch?v=oZn3qSgmLqI",
                  Age = 12,
                  Starring = "Anya Taylor-Joy,Bill Camp,Moses Ingra,Isla Johnston",
                  Creators = "Scott Frank,Allan Scott",
                  Explane = "Walter Tevis’in 1983 tarihli aynı adlı romanından uyarlanan The Queen’s Gambit, Soğuk Savaş döneminde geçen bir hikayeyi işliyor. Dünyanın en iyi satranç oyuncularından biri olan Beth Harmon’ın hayatına odaklanılan dizinin başrolünü Anya Taylor-Joy üstleniyor. Ailesini kaybetmesinin ardından kurum tarafından büyütülen Beth, burada çalışan bir görevliden satranç oynamayı öğrenir. Satranç'ta olağanüstü bir yetenek sergileyen Beth, önüne çıkan tüm rakipleri yenmeyi başarır.",
                  Imdb = "8.6",
                  PictureSource = "wikipedia.org",
                  TextMovieSource = "beyazperde.com"
              },
              new Dizi
              {
                  Id = Guid.NewGuid(),
                  Name = "Perry Mason",
                  Minute = 1,
                  Url = "https://upload.wikimedia.org/wikipedia/en/4/49/Perry_mason.jpg",
                  Category = "Dram, Suç",
                  Year = 2020,
                  Country = "ABD",
                  Trailer = "https://www.youtube.com/watch?v=_5O3cMmg3JQ ",
                  Age = 18,
                  Starring = "Matthew Rhys,Juliet Rylance, Chris Chalk,Shea Whigham",
                  Creators = "Tim Van Patten,Deniz Gamze Ergüven",
                  Explane = "azar Erle Stanley Gardner’ın Perry Mason adlı çok satan romanından uyarlanıyor. Hikayesi 1932 yılının Los Angeles’ında, Büyük Buhran’ın hemen sonrasında geçen dizi, evliliği yeni bitmiş ve savaş zamanından kalma psikolojik hasarların etkisini atlatamamış ünlü savunma avukatı Perry Mason’a ve Mason’ın bir soruşturmanın gizemini çözmeye çalışmasına odaklanıyor. Gardner’in romanlarından gelen karakterlere dayanan kökenine ve hikayesine odaklanacak. Düşük ücretli bir özel müfettiş olarak hayatını yaşamaya çalışan Mason, Fransa’daki savaş zamanı deneyimleri ve kırık bir evliliğin etkilerinden muzdarip bir ruh halindedir. Ülkenin geri kalanı büyük ekonomik buhrandan kurtulurken Los Angeles kaosa sürüklenir. Bir kaçırılma olayının üzerine giden Mason, suçun gerçekliğini ortaya çıkarmaya çalışırken, aslında bir şehrin tüm gerçeklerinin açığa çıkarmasına neden olur.",
                  Imdb = "7.5",
                  PictureSource = "wikipedia.org",
                  TextMovieSource = "yorumguncel.com"
              },
              new Dizi
              {
                  Id = Guid.NewGuid(),
                  Name = "The Flash",
                  Minute = 8,
                  Url = "https://upload.wikimedia.org/wikipedia/tr/thumb/a/a3/The_flash_sezon_3.jpg/375px-The_flash_sezon_3.jpg",
                  Category = "Aksiyon",
                  Year = 2014,
                  Country = "ABD",
                  Trailer = "https://www.youtube.com/watch?v=drQWopZDEEY",
                  Age = 12,
                  Starring = "Grant Gustin, Danielle Panabaker,Rick Cosnett,Candice Patton",
                  Creators = "David Nuttern,Jesse Warn",
                  Explane = "Küçük yaşta annesinin ölümüne tanık olarak bir trajedi yaşamış Barry Allen, Central City polis merkezinde suçluların arkalarında bıraktıkları izleri toplayan bir adli tıp görevlisidir. S.T.A.R Laboratuvarları'nın parçacık hızlandırıcısı, hata nedeniyle bir patlamaya sebep olur. Bu patlama hava durumunu değiştirir ve Barry Allen'a bir şimşek çarpar. Bu şimşek onda aşırı hızlı hücre yenilenmesine sebep olur. Kırılan kolu 3 saat içinde iyileşmiştir. Kalbi o kadar hızlı atmaktadır ki hastanedeki makineler ölçemez. Fakat en önemlisi süpersonik bir hıza ulaşmıştır. İlk bölümde saatte 720 km hızda koşmuştur. İmkânsızı kovalarken kendisi imkânsız olan Barry bu gücünü insanları kurtarmak için kullanır. Central City'de adaleti sağlamanın yanındaki hedefi ise annesinin katilini bulmaktır ve en sonunda annesinin katilini bulur (Eboard Thawne) ve ona yenilecekken Eddie Thawne'nın kendisini öldürmesi sonucu Eboard Thawne (Reverse Flash) zamandan silinir. Daha sonra 2. Sezonda Earth-2'dan (İkinci Dünya) gelen Zoom'la olağanüstü bir savaşları olacaktır ve babası (Henry Allen) Zoom tarafından öldürülür. Zoom'la olan savaşında pek şansı olmayan Barry Allen'a yardım eden Earth-2'dan gelen ve kızı Zoom'un elinde olan Dr.Wells ve Earth-2' dan gelen Jay Garrick (The Flash) yardımcı olmaktadır.",
                  Imdb = "7.5",
                  PictureSource = "amazon.com",
                  TextMovieSource = "wikipedia.org"
              }
              );
        }
    }
}
