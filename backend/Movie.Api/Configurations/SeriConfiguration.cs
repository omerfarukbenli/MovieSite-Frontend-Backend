using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Movie.Api.Models.Entities;

namespace Movie.Api.Configurations
{
    public class SeriConfiguration : IEntityTypeConfiguration<Seri>
    {
        public void Configure(EntityTypeBuilder<Seri> builder)
        {
            builder.HasData(
              new Seri
              {
                  Id = Guid.NewGuid(),
                  Name = "Yüzüklerin Efendisi  1",
                  Minute = 178,
                  Url = "https://upload.wikimedia.org/wikipedia/tr/e/e6/Y%C3%BCz%C3%BCklerinEfendisi%27Y%C3%BCz%C3%BCkKarde%C5%9Fli%C4%9Fi-film.jpg",
                  Category = "Bilimkurgu",
                  Year = 2001,
                  Country = "ABD",
                  Trailer = "https://www.youtube.com/watch?v=V75dMMIW2B4",
                  Age = 12,
                  Starring = " Elijah Wood, Sean Astin, Ian McKellen",
                  Creators = "Peter Jackson",
                  Explane = "Yüzüklerin Efendisi: Yüzük Kardeşliği, dünyanın kaderini değişterecek olan yüzükten kurtulmak için verilen mücadeleyi konu ediyor. Yıllar önce üretilen ve Orta Dünya topraklarına kandan başka hiçbir şey getirmeyen yüzüklerin sonuncusu, üretiminden yüz yıllar sonra ortaya çıkar. Amcasının kendisine emanet ettiği yüzüğün nelere kadir olduğundan habersiz olan Frodo, büyücü Gandalf'ın anlattıkları sonrasında dehşete kapılır. Bu yüzükten ve müstakbel savaşlardan kurtulmanın tek yolu, gücünü toplamaya çalışan Sauron'u da engellemek için bu yüzüğü yok etmektir. Yüzüğü yok edilebileceği tek yer olan Mordor'a götürmek için kendini feda eden savaşçılardan oluşan bir ekip oluşturulur. Çok uzun ve çetin geçecek olan yolculuk başlar. Orta Dünya'nın kaderi, bu insanların ellerindedir.",
                  Imdb = "8.8",
                  PictureSource = "wikipedia.org",
                  TextMovieSource = "beyazperde.com"
              },
               new Seri
               {
                   Id = Guid.NewGuid(),
                   Name = "Karayıp Korsanları 1",
                   Minute = 143,
                   Url = "https://upload.wikimedia.org/wikipedia/tr/thumb/0/0e/Pirates_of_the_Caribbean_movie.jpg/330px-Pirates_of_the_Caribbean_movie.jpg",
                   Category = "Aksiyon, Fantastik",
                   Year = 2003,
                   Country = "ABD",
                   Trailer = "https://www.youtube.com/watch?v=naQr0uTrH_s",
                   Age = 12,
                   Starring = "Johnny Depp, Geoffrey Rush, Keira Knightley",
                   Creators = " Gore Verbinski",
                   Explane = "Karayip Korsanları: Siyah İnci’nin Laneti, genç bir kızı kurtarmaya çalışan korsan Jack Sparrow ile demirci Will Turner'ın maceralarını anlatıyor. Yerel vali Weatherby Swann'ın 12 yaşındaki kızı Elizabeth, Jamaica'ya yaptığı deniz yolculuğu esnasında bir gemi enkazıyla karşılaşırlar. Bu enkazdan kurtulabilen tek kişi küçük Will'dır. Elizabeth küçük çocuğun boynundaki altın madalyondan onun bir korsan olduğunu anlar, bu yüzden madalyonu alarak saklar. Yıllar sonra Elizabeth, azılı bir korsan olan Barbossa tarafından kaçırılır. Çılgın ve iyi yürekli bir korsan olan Jack Sparrow ise Elizabeth'in çocukluk arkadaşı Will Turner'la bir olur ve kızı kurtarmaya çalışırlar. Ancak bu gizemli madalyon hayalet gemiyi harete geçirerek gizemli incinin lanetini canlandıracaktır.",
                   Imdb = "8.1",
                   PictureSource = "wikipedia.org",
                   TextMovieSource = "beyazperde.com"
               },
               new Seri
               {
                   Id = Guid.NewGuid(),
                   Name = "Çığlık 1",
                   Minute = 111,
                   Url = "https://upload.wikimedia.org/wikipedia/en/8/86/Scream_%281996_film%29_poster.jpg",
                   Category = "Korku, Gerilim",
                   Year = 1996,
                   Country = "ABD",
                   Trailer = "https://www.youtube.com/watch?v=AWm_mkbdpCA",
                   Age = 18,
                   Starring = "Neve Campbell, Courteney Cox, David Arquette",
                   Creators = "Wes Craven",
                   Explane = "Bir lise öğrencisi olan Casey tuhaf bir telefon alır. Telefonun öteki ucundaki sesi tanımamaktadır. Bir süre sonra yaşanan bir cinayet üzerine polis ve medya olayın üzerine gitmeye başlar. ‘Hayalet surat’ adı verilen bir katil, çevresinde gördüğü gençleri birer birer öldürmektedir. Korku filmlerinin belli klişelerle örüldüğünü düşünen bir grup genç ise, naklen yaşadıkları bir korku filminin içerisinde hayatta kalmaya çalışacaktır. Katille bir kedi-fare oyununa tutuşacaklardır. Wes Craven’ın kendi filmografisiyle ve korku türüyle inceden alay ettiği ancak buna müteakip korkutmayı da başardığı filminin başrollerinde Drew Barrymore, Roger Jackson ve Neve Campbell gibi oyuncuları görmek mümkün.",
                   Imdb = "7.4",
                   PictureSource = "wikipedia.org",
                   TextMovieSource = "beyazperde.com"
               },
               new Seri
               {
                   Id = Guid.NewGuid(),
                   Name = "Matrix 1",
                   Minute = 135,
                   Url = "https://upload.wikimedia.org/wikipedia/tr/thumb/3/36/Matrix-film.jpg/330px-Matrix-film.jpg",
                   Category = "Aksiyon, Bilimkurgu",
                   Year = 1999,
                   Country = "ABD",
                   Trailer = "https://www.youtube.com/watch?v=m8e-FF8MsqU",
                   Age = 18,
                   Starring = "Keanu Reeves, Laurence Fishburne, Carrie-Anne Moss",
                   Creators = "Lana Wachowski, Lilly Wachowski",
                   Explane = "Saygın bir yazılım şirketinde çalışan Thomas Anderson (Keanu Reeves), gecelerini 'Neo' adı altında program kırarak ve Matrix'i araştırarak geçirir. Esrarengiz şekilde Trinity ve Morpheus ile tanışan Neo, yaşadığı dünyanın aslında beyninde gerçekleşen bir simülasyondan ibaret olduğunu öğrenir ve kendini bu durumdan kurtarmak için Morpheus'un önderliğindeki ekibe katılır. Neo gerçek dünyada ilk nefesini aldıktan sonra simülasyona tekrar girerek Matrix'in ne olduğunu kavrayacak ve kurtarılma nedenini öğrenerek gelişen olaylar çerçevesinde yeni kimliğini tanımaya çalışacaktır.Filmdeki olaylar çok ileri bir tarihte teknolojinin son derece gelişmiş olduğu,yapay zekaya sahip makinelerin yaratılmış olduğu bir dünyada geçmektedir.Bu dünyada makineler ve insanlar arasında ortaya çıkmış,savaş sonucunda insan ırkı makineleri yenebilmek için onların enerji kaynağı olan güneş ışınlarının dünyaya inmesini engellemek adına,gökyüzünü kimyasal silahlarla siyah bulutlar oluşturmak suretiyle kapatmıştır.Bunun sonucunda enerji ihtiyacını karşılayamayan makineler yeni enerji kaynakları bulmaya yönelir ve insan vücudunun çok iyi bir enerji motoru olduğunu fark ederler.Böylece insanları köle olarak enerji üretimi için kullanmaya başlarlar ve herhangi bir isyan durumundan kaçınmak için insanların zihinlerini meşgul edecek bir program tasarlarlar.Bunun sonucunda köle insanlar aslında bilinçsiz bir şekilde uyurken zihinleri makinelere bağlı bir şekilde Matrix programının içerisinde her şeyden habersiz sanal bir dünyada yaşamaya devam ederler.Filmin başkahramanı Neo bu insan tarlalarında uyanır ve gerçek dünyada insanların yaşadığı tek yer altı şehri olan Zion'a götürülür ve gerçek dünyaya alıştıktan sonra Morpheus'un ekibiyle beraber makinelere karşı savaşmaya başlar..",
                   Imdb = "8.7",
                   PictureSource = "wikipedia.org",
                   TextMovieSource = "wikipedia.org"
               },
                new Seri
                {
                    Id = Guid.NewGuid(),
                    Name = "Geleceğe Dönüş 1",
                    Minute = 116,
                    Url = "https://upload.wikimedia.org/wikipedia/tr/3/33/Back_to_the_Future_%28film%2C_1985%29.jpg",
                    Category = "Bilimkurgu, Komedi",
                    Year = 1985,
                    Country = "ABD",
                    Trailer = "https://www.youtube.com/watch?v=qvsgGtivCgs",
                    Age = 12,
                    Starring = "Michael J. Fox,Christopher Lloyd,Lea Thompson,Crispin Glover,Thomas F.Wilson",
                    Creators = "Robert Zemeckis",
                    Explane = "Doktor Emmett Brown'un evine gelen Marty McFly, gitarını dev bir hoparlöre bağlar. Gitarının teline dokunduğunda hoparlörün büyüklüğünden kaynaklanan sesten dolayı geriye zıplar. Ardından telefon çalar. Arayan Dr. Emmett Brown'dur. Marty'ye geceleyin yanına gelmesini söyler. Okula geç kaldığını fark eden Marty, kaykayına binip okula gider. Müdürden azar işitip geç kağıdı alır. Grubuyla birlikte okulun müzik seçmelerine katılır. Ancak jüri üyeleri onları, müziklerinin çok gürültülü olduğu gerekçesiyle reddeder. Çıkışta sevgilisi Jennifer ile, babasının arabası ile dolaşacaklarını söyler. Evine gider. Arabayı ödünç alan Biff Tanen, (Thomas F. Wilson) Marty'nin babası George McFly'ın (Crispin Glover) arabası ile kaza yapmıştır. Marty buna çok sinirlenir. Uyanıp Dr. Brown'un yanına kamera ile giden Marty, Brown'un Delorean DMC-12 model bir arabadan zaman makinesi yaptığını görür. Zamanda yolculuk yapabilmesi için plütonyum gereken araba, saatte 88 mil hıza ulaşınca geçmişe veya geleceğe gider. Brown, köpeği Einstein'i geleceğe gönderir. Araba geri gelir, Einstein de içindedir ve Einstein yolculuğa çıkmadan önce Dr. Brown'un onun boynuna taktığı saatle Dr. Brown'un kolundaki saat arasında 1 dakikalık bir fark vardır, böylece ilk zaman yolculuğu denemesi başarı ile gerçekleşmiştir. Ardından Brown'un plütonyumdan bomba yapma vaâdiyle kandırdığı Libyalı teröristler gelir, Brown'u vururlar. Marty arabaya binip oradan kaçar, fakat o sırada 88 mil hıza çıkan Marty kendini 1955 yılında bulur. İlk olarak arabayı bir reklam tabelasının arkasına saklar. Şehre ulaştığında, 1955 yılına geldiğini anlar. Bir restauranta gider. Orada babası ile karşılaşır. Biff, arkadaşları ile George'a sataşır. Marty dolaşırken George'un Lorraine'i gözetlediğini görür. George ağaçtan düşer ve ona tam araba çarpacakken, Marty onu kurtarır. Araba ona çarpar ve bayılır. Ayıldığında kendisini annesinin yanında bulur, kötü bir rüya gördüğünü söyler. Gözlerini açtığında kendisini annesinin gençliğinin yanında bulur. Annesi odadan çıkar ve Marty pantolonunu giyer. Aşağıya inip Lorraine'nin ailesi ile yemek yer. Annesi ona romantik bir ilgi gösterir. Marty bu durumdan çok utanır. Doktor Brown'ın yanına gider. Brown en başta Marty'ye inanmaz. Ancak Marty onu ikna eder. Elindeki bir fotoğrafa bakar. Bir bölümü silinmiştir. Brown ona durumu açıklar. Marty, babasını arabanın çarpmasından kurtararak, anne ve babasının tanışmasını engellemiştir. Eğer babası ve annesini birleştirmeyi başaramazsa yok olacaktır. 1985 yılına geri dönebilmesi için gereken plütonyum yerine de saat kulesine düşecek yıldırımın gücüne ihtiyaç vardır.Marty, George ile buluşarak onun Lorraine ile tanışmasını sağlamaya çalışır.Ancak George'un belalısı Biff Tanen da Lorraine'i istiyordur.Marty,George'un Lorraine'i okuldaki dans gecesine davet etmesini söyler.Ancak George bunun mümkün olmadığını söyleyince,Marty çareyi George'u kandırmakta bulur. Plütonyumdan korunmak için tasarlanmış kıyafeti giyip George'un yanına gider.Ona Darth Vader olduğunu ve Lorraine'i partiye davet etmesi gerektiğini söyler. Çok korkan George bunu kabul etmek zorunda kalır. George, tam Lorraine'i davet edecekken Biff çıkagelir ve ona sataşmaya başlar.Marty,Biff'i onlardan uzak tutmaya çalışır. Biff'e bir yumruk atar.Biff ve arkadaşları arabalarına binip onun peşine düşerler.Marty kaykaya binip onlardan kaçar.Biff ve arkadaşları,Marty'i ellerinden kaçırdıklarında bir gübre kamyonuna çarparlar. Bu olay ile birlikte Lorraine'nin Marty'e ilgisi daha çok artmıştır. Marty yeni bir plan yapar. O Lorraine'i partiye götürecektir,ardından da zarar vermeye çalışacaktır.Bu sırada George gelip Marty'i durduracak ve Lorraine ona aşık olacaktır. Parti günü geldiğinde Marty araba ile Lorraine'ni alır.Okulun dışında Lorraine ile arabada oturan Marty'nin planı Biff yüzünden bozulur. Biff'in arkadaşları Marty'i bir arabaya kilitlerler. Biff de Lorraine'ne taciz etmeye çalışır.Plana uygun olarak arabada Marty'nin olduğunu sanan George, Biff'e Lorraine'nin yanından çekilmesini söyler. Biff, George'un kolunu kıvırır ve onunla dalga geçer.Bu sırada bir arabada kilitli kalan Marty'e, partide çalacak olan müzisyenler yardım eder. Marty hemen George'a yardım etmeye gider.Biff'in kolunu kavradığı George, onun Lorraine'e tokat atmasına sinirlenir.Yumruğunu sıkar ve Biff'in suratına en sert yumruğunu atar. Biff oracıkta yere yığılır. Artık George'un Marty'e ihtiyacı yoktur. Marty, Biff'in arkadaşlarının kendisini aradıklarını görür.Marty'yi arabadan çıkaran müzisyenlerden birinin eli zarar görmüştür ve bu da gitar çalmasına engel olur. Bu yüzden Marty gitar çalmayı kabul eder. Partide Rock'n roll çalan Marty'nin eli yavaşça yok olmaya başlar. Çünkü sınıf arkadaşlarından biri George'u itip,yanındaki Lorraine'i almıştır. İlk önce oradan uzaklaşan George geri gelip çocuğu itip Lorraine ile dans eder. Marty de sorunun hallolduğuna sevinip Johnny B. Goode şarkısını çalar. İlk başta bu şarkı çok beğenilse de Marty'nin yapmaya başladığı garip hareketler insanların bunu garipsemesine neden olur.Marty oradan uzaklaşıp Dr.Brown'un yanına gider. Ona bir mektup vermeye çalışır ama Brown bunu kabul etmez. Arabanın geleceğe gidebilmesi için, saat kulesine düşecek yıldırıma ihtiyaç vardır. Marty arabaya elektrik kablosuna değeceği bir çubuk takıp beklemeye başlar. Araba biraz geç çalışır, fakat saat kulesinin tepesindeki Dr. Brown bu sırada yıldırımı çekecek olan kabloyu yanlışlıkla koparır. Marty'nin sürdüğü araba tam gelecekken aşağıya iner ve sorunu çözer.Yıldırım düşer ve Marty 1985'e geri döner. Hemen Dr. Brown'ın yanına gidip ölmesine engel olmaya çalışır ancak Libyalılar,Brown'ı yine vurur. Marty koşarak Brown'ın yanına gider.Bu duruma çok üzülen Marty'nin yanındaki Brown kendine gelir. Marty'nin yazdığı mektubu okumuştur ve kurşunlardan korunmak için yelek giymiştir.Ardından Marty evine gider.Babası ünlü bir yazardır.Biff de onların hizmetçisidir.Kız kardeşinin peşinde bir sürü erkek vardır ve erkek kardeşi de saygın bir işte çalışıyordur.Marty ayrıca hayalindeki arabaya da sahip olmuştur.Marty arabasının yanındayken sevgilisi Jennifer gelir.İkisi konuşurlarken Dr.Brown gelir ve onları gelecekte büyük bir sorunun beklediğini söyleyip tekrar zamanda yolculuğa çıkarlar.",
                    Imdb = "8.5",
                    PictureSource = "wikipedia.org",
                    TextMovieSource = "wikipedia.org"
                }
              );
        }
    }
}
