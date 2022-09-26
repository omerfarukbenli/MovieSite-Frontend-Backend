using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Movie.Api.Models.Entities;

namespace Movie.Api.Configurations
{
    public class Oscar1Configuration : IEntityTypeConfiguration<Oscar1>
    {
        public void Configure(EntityTypeBuilder<Oscar1> builder)
        {
            builder.HasData(
                    new Oscar1
                    {
                        Id = Guid.NewGuid(),
                        Name = "Kanunun kuvveti",
                        Minute = 104,
                        Url = "https://upload.wikimedia.org/wikipedia/tr/6/65/Kanunun_Kuvveti_1971_afi%C5%9F.jpg",
                        Category = "Suç",
                        Year = 1971,
                        Country = "ABD",
                        Trailer = "https://www.youtube.com/watch?v=3qg7lmarM-M",
                        Age = 12,
                        Starring = " Gene Hackman, Roy Scheider, Tony Lo Bianco",
                        Creators = " William Friedkin",
                        Explane = "New York şehri dedektifleri 'Popeye' Doyle (Gene Hackman) ve Buddy Russo (Roy Scheider) narkotik kaçakçı yüzüğünü kırıp öyle veya böyle French Connection’ı ortaya çıkarmak isterler. Fakat suçlulardan biri Doyle’u öldürmeye çalışınca, kendisini şehirin sınırlarının dışına taşıyacak ölümcül bir takibe başlar.Gerçek bir hikayeden uyarlanan bu aksiyon yüklü korku filmi,yenilenmiş kovalama sahnesiyle,1971 yılında En İyi Film,En İyi Yönetmen ve En İyi Erkek Oyuncu filmleri dahil olmak üzere toplam 5 Oscar aldı.1971 yılı yapımı filmde,Gene Hackman’ın performansı göz kamaştırıyor.Şu ana kadar yapılmış en iyi dedektif filmlerinden biri olan Kanunun Kuvveti,Fransa’dan gelecek olan bir eroin şebekesini yakalamak için kolları sıvayan New Yorklu iki polisin maceralarını anlatıyor...",
                        Imdb = "7.7",
                        PictureSource = "wikipedia.org",
                        TextMovieSource = "beyazperde.com"
                    },
                    new Oscar1
                    {
                        Id = Guid.NewGuid(),
                        Name = "Casablanca",
                        Minute = 102,
                        Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b3/CasablancaPoster-Gold.jpg/220px-CasablancaPoster-Gold.jpg",
                        Category = "Romantik, Gerilim",
                        Year = 1942,
                        Country = "ABD",
                        Trailer = "https://www.youtube.com/watch?v=BkL9l7qovsE",
                        Age = 12,
                        Starring = "Humphrey Bogart, Ingrid Bergman, Paul Henreid",
                        Creators = " Michael Curtiz",
                        Explane = "Kasablanka, hem unutulmaz bir aşk filmi klasiği olarak hem de Humphrey Bogart ve Ingrid Bergman’ın unutulmaz oyunculukları ile kült olmuş bir yapımdır. 2. Dünya Savaşı sırasında Fas’ın Kazablanka kenti, Hitler’den kaçan Avrupa’lılarla rengarenk, çeşitli bir görünüm kazanmıştır. Rick Blaine karakteri, şehrin en popüler barını işletmektedir. Bir gün eski aşkı Ilsa, direniş lideri kocası Victor Laszlo ile birlikte gelir. Rick, Ilsa ve Victor’un şehirden kaçmalarını sağlayabilecek tek kişidir.",
                        Imdb = "8.5",
                        PictureSource = "wikipedia.org",
                        TextMovieSource = "beyazperde.com"
                    },
                    new Oscar1
                    {
                        Id = Guid.NewGuid(),
                        Name = "Suyun Sesi",
                        Minute = 123,
                        Url = "https://upload.wikimedia.org/wikipedia/tr/5/58/Suyun_Sesi.jpg",
                        Category = "Fantastik, Dram, Romantik",
                        Year = 2018,
                        Country = "ABD",
                        Trailer = "https://www.youtube.com/watch?v=XFYWazblaUA",
                        Age = 12,
                        Starring = "Sally Hawkins, Michael Shannon, Richard Jenkins",
                        Creators = " Guillermo del Toro",
                        Explane = "Soğuk savaş döneminin Amerika'sında yaşayan Elisa yalnız bir kızdır. Sessiz, rutin bir hayatı olan Elisa, gizli ve yüksek güvenlikli bir devlet laboratuvarında temizlikçi olarak çalışır. Ancak günün birinde Elisa'nın hayatı, iş arkadaşı Zelda ile devletin yaptığı gizli bir deneyi keşfetmesi ile değişir. Suda hapsedilen insansı bir yaratığın acımasız bir deneyde kullanıldığını fark eden Elisa, onunla iletişim kurmaya başlar. Aynı dili bilmeyen, aynı hayatlara sahip olmayan, hatta aynı genetikleri bile olmayan bu ikili, aralarında kurdukları tarifsiz bağ ile birbirlerinin hayatını değiştirecektir...Guillermo del Toro'nun yönetmenliğini üstlendiği filmin oyuncu kadrosunda Sally Hawkins, Michael Shannon, Richard Jenkins, Doug Jones, Michael Stuhlbarg, Octavia Spencer yer alıyor. ",
                        Imdb = "7.3",
                        PictureSource = "wikipedia.org",
                        TextMovieSource = "beyazperde.com"
                    },
                    new Oscar1
                    {
                        Id = Guid.NewGuid(),
                        Name = "Schindler'in Listesi",
                        Minute = 195,
                        Url = "https://upload.wikimedia.org/wikipedia/tr/3/38/Schindler%27s_List_movie.jpg",
                        Category = "Dram, Savaş",
                        Year = 1993,
                        Country = "ABD",
                        Trailer = "https://www.youtube.com/watch?v=gG22XNhtnoY",
                        Age = 18,
                        Starring = "Liam Neeson,Ben Kingsley,Ralph Fiennes",
                        Creators = "Steven Spielberg",
                        Explane = "II. Dünya Savaşı, Nazi Almanyası. Oskar Schindler Almanya'ya iş kurmak amacı ile gelir. Fakat beş kuruşu yoktur. Kendi deyişiyle sunum yeteneği sayesinde birçok üst düzey Alman SS subayı ile dost olur. Bu sırada Yahudi Soykırımı başlamıştır. Schindler'in fabrikası artık getto kamplarındakilerin cennet kapısı olmaya başlamıştır. Schindler´in yardımcısı Itzhak Stern de bir Yahudi'dir. Stern, Schindler'in fabrikasının idaresini yürütürken, bir yandan da belgelerde yaptığı değişikliklerle birçok Yahudi'yi Alman savaş gücü için gerekli göstererek, fabrikaya alır ve toplama kamplarına gönderilmekten kurtarır.Sonrasında, gettolardaki Yahudiler,Kraków'un güneyinde inşa edilen Plaszow Toplama Kampına sürülür ve bu sırada Alman askerlerinin gettoları boşaltmasını bölgeye hakim bir tepeden izleyen Schindler, birçok Yahudi'nin öldürülmesine tanık olur.Fakat,Stern'in de uyarılarıyla, özellikle Plaszow kampının komutanı Amon Göth başta olmak üzere, Alman subaylarıyla işbirliğine devam eder. Fabrika bir yandan kâr amacıyla çalışırken, Schindler bir yandan da mümkün olduğunca çok Yahudi'nin kurtarılması için çabalamaktadır.Bu esnada,Berlin'den gelen emirle, kamp tasfiye edilip, tüm esirler Auschwitz'e sürülmeye başlanır.Schindler,her işçi için verdiği yüklü miktardaki rüşvetle,Amon Göth'ü kendi Yahudileri'ni,eski evinin bulunduğu Zwittau - Brinnlitz'de (Çekoslovakya) kuracağı fabrikaya götürmeye ikna eder. Gene de sorunlar devam eder ve Schindler'in fabrikasına götürülmek üzere trene bindirilen erkeklerin fabrikaya ulaşmasına rağmen,ahudi kadınlar bir yanlışlık sonucu Auschwitz'e götürülür. Fakat, Schindler kampın komutanı Rudolf Höß'e verdiği rüşvet ile kadınları tekrar kurtarır ve sonunda listesinde bulunan tüm Yahudileri kendi fabrikasına aldırmayı başarır.Almanya'nın teslim olması ile beraber, hâlen bir Nazi partisi üyesi ve kendi deyişiyle köle işçilerden kazanç sağlayan bir kimse olduğu için Schindler, Sovyet askerlerinden kaçmak zorundadır. SS korumalarına, evlerine bir katil veya insan olarak dönmenin ellerinde olduğunu söyler ve askerler esirlere dokunmadan fabrikayı terk ederler. Gece, işçileri ile vedalaşması esnasında, işçiler Schindler'e gerekirse delil olarak sunması için her birinin imzaladığı ve onlar için bir katil olmadığını izah ettikleri bir mektup ile üzerine Talmud'dan 'Kim ki bir insanın hayatını kurtarır, o tüm Dünya'yı kurtarır' sözünün işli olduğu, bir işçinin altın dişinden dövdükleri bir yüzük verirler. Schindler, duygulanır ve ağlayarak tüm bunların yeterli olmadığını, elinden gelenden daha fazlasını yapmış, daha fazla insan kurtarmış olabileceğini söyler.Ertesi sabah,Schindler Yahudileri,doğan güneş ile uyanırlar ve gelen bir Sovyet askeri tarafından artık özgür oldukları söylenir.Birlikte,iyecek bulmak adına yürüyen işçiler,sahnenin değişmesi ile birlikte,Oskar Schindler'in Kudüs'te bulunan mezarına doğru yürüyen,günümüz Schindler Yahudileri'ne dönüşür.Filmde son olarak, Schindler'in kurtardığı yaklaşık 1100 kişinin soyundan gelenlerin,filmin çekildiği tarihte yaklaşık 6000 kişi olduğu ve bir zamanlar milyonlarla ifade edilen Polonya Yahudileri'nin artık 4000'den daha az bir sayıyla ifade edildiği seyirciye yansıtılır.",
                        Imdb = "9.0",
                        PictureSource = "wikipedia.org",
                        TextMovieSource = "beyazperde.com"
                    },
                     new Oscar1
                     {
                         Id = Guid.NewGuid(),
                         Name = "Bir Gecede Oldu",
                         Minute = 74,
                         Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/dc/It-happened-one-night-poster.jpg/330px-It-happened-one-night-poster.jpg",
                         Category = "Komedi, Romantik",
                         Year = 1934,
                         Country = "ABD",
                         Trailer = "https://www.youtube.com/watch?v=Kd509cLN-9U",
                         Age = 12,
                         Starring = " Ward Bond, Blanche Friderici, Clark Gable",
                         Creators = "Frank Capra",
                         Explane = "Bir Gecede Oldu'da Ellie Andrews, kocasıyla arasındaki ilişkiye girmeye çabalayan zengin babasından kaçmaktadır. Kaçışı esnasında New York yolunda işsiz ve hikâye peşindeki bir haberciyle tanışır. İkilinin bundan sonraki amaçları, otostop çekerek varmak istedikleri yere ulaşmak olacaktır.Döneminin ve sinemanın kült yönetmenlerinden biri olarak addedilen Frank Capra’nın It’s A Wonderful Night ve Mr.Smith Goes to Washington’dan önce kotardığı It Happened One Night,romantik komedi türünün fitilini ateşleyen filmlerden biri olarak gösteriliyor.Filmin başrolünü ise Clark Gable ile Claudette Colbert paylaşıyorlar.",
                         Imdb = "7.7",
                         PictureSource = "wikipedia.org",
                         TextMovieSource = "beyazperde.com"
                     },
                     new Oscar1
                     {
                         Id = Guid.NewGuid(),
                         Name = "Affedilmeyen",
                         Minute = 131,
                         Url = "https://upload.wikimedia.org/wikipedia/tr/6/6d/Unforgiven_1992_afi%C5%9F.jpg",
                         Category = "Western, Dram",
                         Year = 1992,
                         Country = "ABD",
                         Trailer = "https://www.youtube.com/watch?v=ftTX4FoBWlE",
                         Age = 18,
                         Starring = " Clint Eastwood, Gene Hackman, Morgan Freeman",
                         Creators = " Clint Eastwood",
                         Explane = "Affedilmeyen'de Little Bill Dagett, sadistik eğilimleri olan, tavizsiz ve diktatör bir şeriftir. Egemen olduğu küçük bir kasabayı yaşanmaz bir hale getirmektedir. Bir gün adaleti uygulamayı bütünüyle reddettiğinde, eski bir silahlı soyguncu olan Will Munny, artık sessiz kalamayacağını ortaya koyacaktır. İntikam Will, Will’in eski partneri ve genç bir adamın ellerinden gelecektir.Clint Eastwood’un Western türünün hala yaşadığını ispatlarcasına çektiği Affedilmeyen,90’lı yılların en önemli filmlerden biri olarak kabul edilmektedir.Ustanın yönetmenlik kariyerine damgasını vuran film,Eastwood’a bir de yönetmenlik Oscar’ı getirmiştir.",
                         Imdb = "8.2",
                         PictureSource = "wikipedia.org",
                         TextMovieSource = "beyazperde.com"
                     },
                     new Oscar1
                     {
                         Id = Guid.NewGuid(),
                         Name = "Yüzüklerin Efendisi: Kralın Dönüşü",
                         Minute = 201,
                         Url = "https://upload.wikimedia.org/wikipedia/tr/thumb/2/28/Y%C3%BCz%C3%BCklerinEfendisi%27Kral%C4%B1nD%C3%B6n%C3%BC%C5%9F%C3%BC-film.jpg/800px-Y%C3%BCz%C3%BCklerinEfendisi%27Kral%C4%B1nD%C3%B6n%C3%BC%C5%9F%C3%BC-film.jpg",
                         Category = "Fantastik, Savaş",
                         Year = 2003,
                         Country = "ABD",
                         Trailer = "https://www.youtube.com/watch?v=r5X-hFf6Bwo",
                         Age = 18,
                         Starring = "Sean Astin, Elijah Wood, Viggo Mortensen",
                         Creators = " Peter Jackson",
                         Explane = "Yüzüklerin Efendisi: Kralın Dönüşü, Tek Yüzük'ün yok edilmesi için verilen mücadeleyi konu ediyor. Sauron'un orduları büyüdükçe büyümektedirler. Frodo ve onun can dostu Sam, korku dolu bir yolculuğun göbeğinde, korkunç Mordor'a adım adım yaklaşmaktadırlar. Tek yüzük yok edilmelidir ve iyilik bunun için savaşmaya hazırdır. Arka planda ise insan, elf ve cüce orduları, karanlık güçlerin karşısında tüm eski düşmanlıklarına rağmen bir araya gelmişlerdir. Hepsi birden küçücük bir Hobbit'in eline ve onun yeteneklerine bakmaktadırlar. Orta Dünya'nın kaderi belli olmak üzeredir. Ancak Tek Yüzük'ü sahiplenmek, kimi zaman taşıyanına daha cazip gelebilir.",
                         Imdb = "9.0",
                         PictureSource = "wikipedia.org",
                         TextMovieSource = "beyazperde.com"
                     },
                     new Oscar1
                     {
                         Id = Guid.NewGuid(),
                         Name = "Annie Hall",
                         Minute = 93,
                         Url = "https://upload.wikimedia.org/wikipedia/en/thumb/e/e6/Anniehallposter.jpg/220px-Anniehallposter.jpg",
                         Category = "Dramatik, Komedi, Romantik",
                         Year = 1977,
                         Country = "ABD",
                         Trailer = "https://www.youtube.com/watch?v=OqVgCfZX-yE",
                         Age = 12,
                         Starring = " Woody Allen, Diane Keaton, Tony Roberts",
                         Creators = "  Woody Allen",
                         Explane = "Annie Hall, komedyen Alvy Singer'ın ünlü şarkıcı Annie Hall ile olan ilişkini konu ediyor. New York’un tanınan komedyenlerinden Alvy Singer’ın anlatıcılığı eşliğinde işlenen film, komedyenin Annie Hall isimli ünlü şarkıcıyla olan ilişkisinin neden sonlandığını sorgulamasıyla başlar. Alvy, uzunca bir süre aşk hayatında başarısız olmuş, aradığı kadını sahte entelektüel ortamlarda bulmanın imkansızlığına kanaat getirmiştir. Ancak Annie ile tanışması adamın talihini bir anda döndürecek, garip bir ilişkinin başlamasına neden olacaktır. Yüzyılın gördüğü en ilginç beyinlerden biri olan müzisyen, yönetmen, senarist ve oyuncu Woody Allen’ın, bol yapıtlı filmografisinin en başarılı filmi olan Annie Hall sinema tarihinin en özgün komedilerinden biri.",
                         Imdb = "8.0",
                         PictureSource = "wikipedia.org",
                         TextMovieSource = "beyazperde.com"
                     },
                     new Oscar1
                     {
                         Id = Guid.NewGuid(),
                         Name = "Rıhtımlar Üzerinde",
                         Minute = 106,
                         Url = "https://upload.wikimedia.org/wikipedia/tr/thumb/d/d4/Waterf.jpg/330px-Waterf.jpg",
                         Category = "Dram, Polisiye, Romantik",
                         Year = 1954,
                         Country = "ABD",
                         Trailer = "https://www.youtube.com/watch?v=vOdYAXOfLMc",
                         Age = 12,
                         Starring = " Marlon Brando, Karl Malden, Eva Marie Saint",
                         Creators = "Elia Kazan",
                         Explane = "Terry Mallon zor şartlarda liman işçisi olarak çalışan eski bir boksördür. Ringlerdeki başarılı kariyerinden liman işçiliğine kadar düşen adam bir nevi bunalımdadır. Çalıştığı limanın ve civar limanların patronu Johnny Friendly görünürde liman işletmeciliği yapsa da kimi illegal işlere karışmaktadır. Bunlardan biri Terry’nin başını derde sokacaktır. Çocukluk arkadaşının Friendly’nin emriyle öldürülmesine tanık olan Terry, hiçbir suçu olmamasına rağmen suçlu konumuna düşmüştür. Friendly için çalışan ağabeyi de ona sırt çevirince liman işçilerini bir araya getirip büyük bir ayaklanma başlatacaktır.Usta yönetmen Elia Kazan imzalı film,New York Sun yazarlarından birine ait bir öykü dizisinden sinemaya uyarlanmıştır.Başrolündeki Marlon Brando ve Karl Malden’in unutulmaz performanslarına ev sahipliği yapan film sekiz dalda Oscar kazanarak büyük bir başarı elde etmiştir.",
                         Imdb = "8.1",
                         PictureSource = "wikipedia.org",
                         TextMovieSource = "beyazperde.com"
                     },
                     new Oscar1
                     {
                         Id = Guid.NewGuid(),
                         Name = "İngiliz Hasta",
                         Minute = 160,
                         Url = "https://upload.wikimedia.org/wikipedia/tr/8/8f/%C4%B0ngilizHastaposter.jpg?20070623101654",
                         Category = "Dramatik Komedi",
                         Year = 1996,
                         Country = "ABD",
                         Trailer = "https://www.youtube.com/watch?v=Xk_LRcOFT0c",
                         Age = 12,
                         Starring = " Ralph Fiennes, Juliette Binoche, Willem Dafoe",
                         Creators = " Anthony Minghella",
                         Explane = "Micheal Ondaatje’ nin aynı adlı romanından sinemaya uyarlanan film, II. Dünya Savaşı İtalya’sından Kuzey Afrika’nın savaş öncesi çöllerine kadar aşk, benlik ve savaşın öyküsünü anlatıyor.Minghelle, film boyunca aşkın farklı türlerini getiriyor karşımıza; Hana’nın hastasına duyduğu şefkat, Kip ile yaşadığı yoğun aşk, Almasy ile Katherine’in ilişkisi ve Almasy’nin milliyetçi tutkular yüzünden mahvedilen çöle duyduğu sevgi...Tüm bu farklı hikayeleri başarılı senaryo geçişleri ile gerçekleştiren film, yönetmen Anthony Minghelle ile Juliette Binoche’un ilk ortak çalışması. 1996 yılında Oscar Ödülleri’nde de En İyi Film, En İyi Yönetmen ve En İyi Yardımcı Kadın Oyuncu da dahil pek çok ödül kazanandı.",
                         Imdb = "7.4",
                         PictureSource = "wikipedia.org",
                         TextMovieSource = "beyazperde.com"
                     },
                     new Oscar1
                     {
                         Id = Guid.NewGuid(),
                         Name = "Amadeus",
                         Minute = 160,
                         Url = "https://upload.wikimedia.org/wikipedia/tr/2/2f/Amadeusmov.jpg",
                         Category = "Dramatik, Komedi, Tarihi",
                         Year = 1984,
                         Country = "ABD",
                         Trailer = "https://www.youtube.com/watch?v=r7kWQj9FCGY",
                         Age = 12,
                         Starring = " Tom Hulce, F. Murray Abraham, Simon Callow",
                         Creators = " Milos Forman",
                         Explane = "Amadeus'da, dünya müzikal tarihine yön veren deha Mozart, gündelik yaşamında gerçek bir arıza karakter olarak yaşamdan bir hayli kopuk bir hayat tarzı sürdürmektedir. Yeteneğini dışa vurmak için ilginç bir yol seçen sanatçı tutarsız davranışlarda bulunmayı bir alışkanlık edinmiştir. Yaşamı ile müziği zıt kutuplarda ilerleyen Mozart, yeteneğini sergilemek için mantıksız hareketlerde bulunur. Adeta bir 'tutunamayan' profili çizen Mozart, bu sağlıksız yaşamı yüzünden Antonio Salieri'yi endişelendirmektedir. Diğerine göre çok daha disiplinli ve müzik konusunda hırslı olan Antonio, müziğin tanrısı kadar başarılı olamamaktadır. Bu düşünceler zamanla farklı bir ilişki kurmalarına neden olur... Müzik konusunda yüce bir yeteneğe sahip olan Amadeus Mozart ile Antonio Salieri’nin ilişkisine odaklı bir başyapıt. Sanat ile sanatçının kişiliği arasındaki ilişkiye odaklanan ve usta müzisyenin yaşamını, Salieri üzerinden anlatan bir klasik.",
                         Imdb = "8.4",
                         PictureSource = "wikipedia.org",
                         TextMovieSource = "beyazperde.com"
                     },
                     new Oscar1
                     {
                         Id = Guid.NewGuid(),
                         Name = "Rebeka",
                         Minute = 130,
                         Url = "https://upload.wikimedia.org/wikipedia/tr/0/0d/Rebeca.gif",
                         Category = "Dram, Gerilim",
                         Year = 1940,
                         Country = "ABD",
                         Trailer = "https://www.youtube.com/watch?v=7a3tRl8wwNo",
                         Age = 12,
                         Starring = " Joan Fontaine, Dame Judith Anderson, Melville Cooper",
                         Creators = " Alfred Hitchcock",
                         Explane = "Rebecca'da, esrarengiz bir şekilde hayata veda eden Rebecca’nın ölümünün altındaki giz de kendisiyle birlikte toprağa gömülmüştür. Kocası Maxim de Winter birkaç ay sonra yeniden evlendiğinde yeni eşi Rebecca’dan bihaberdir. Genç kadın Maxim’e deliler gibi aşıktır ve kocasından da aynı şekilde karşılık bulduğuna inanmaktadır. Ta ki Rebecca’yı ve başına gelenleri öğrenene kadar... Rebecca’nın varlığının, evden ve kocasının zihninden silinmediğini gören kadın evin hizmetçisi tarafından bile kabul edilmeyecek, yabancı muamelesine maruz kalacaktır.Rebecca; The Birds, Don’t Look Now ve Jamaica Inn gibi eserleri de sinemaya uyarlanan ünlü İngiliz yazar Daphne du Maurier'in aynı isimli romanından beyaz perdeye aktarılmıştır.En İyi Film ve En İyi Sinematografi dallarında Oscar kazanan minimal film, yönetmeni Alfred Hitchcock’un incelikli dehasını en iyi yansıtan yapıtlarından biridir.",
                         Imdb = "8.1",
                         PictureSource = "wikipedia.org",
                         TextMovieSource = "beyazperde.com"
                     },

                      new Oscar1
                      {
                          Id = Guid.NewGuid(),
                          Name = "Kuzuların Sessizliği",
                          Minute = 118,
                          Url = "https://upload.wikimedia.org/wikipedia/tr/thumb/7/70/Kuzular%C4%B1n_Sessizli%C4%9Fi_film_afi%C5%9Fi.jpg/330px-Kuzular%C4%B1n_Sessizli%C4%9Fi_film_afi%C5%9Fi.jpg",
                          Category = "Gerilim, Dram",
                          Year = 1991,
                          Country = "ABD",
                          Trailer = "https://www.youtube.com/watch?v=SGR05ypBMmo",
                          Age = 18,
                          Starring = "  Anthony Hopkins, Jodie Foster, Scott Glenn",
                          Creators = "Jonathan Demme",
                          Explane = "Kuzuların Sessizliği, 1992 yılında 7 dalda Oscar’a aday olmuş, yönetmeni ve başrol oyuncularına altın heykelciği getirirken en iyi film ve en iyi senaryo uyarlaması dalında da ödüle hak kazanmıştı.Akademiden mezun olmuş genç FBI ajanı Clarice Starling,FBI ajanı kurbanlarının derilerini yüzen sapık bir katilin elinden bir kadını kurtarmaya çalışır.Clarice,katila ulaşmak için başka bir psikopat olan ünlü doktor Hannibal Lecter ile yakınlaşır.Lecter’dan bilgi alması için önce onun güvenini kazanması gerekmektedir.",
                          Imdb = "8.6",
                          PictureSource = "wikipedia.org",
                          TextMovieSource = "beyazperde.com"
                      },
                      new Oscar1
                      {
                          Id = Guid.NewGuid(),
                          Name = "The Apartment",
                          Minute = 125,
                          Url = "https://upload.wikimedia.org/wikipedia/tr/thumb/8/83/Apartment_afi%C5%9F.jpg/330px-Apartment_afi%C5%9F.jpg",
                          Category = "Dram, Komedi, Romantik",
                          Year = 1960,
                          Country = "ABD",
                          Trailer = "https://www.youtube.com/watch?v=OcslkrBMLGc",
                          Age = 12,
                          Starring = "  Jack Lemmon, Shirley MacLaine, Fred MacMurray",
                          Creators = "  Billy Wilder",
                          Explane = "The Apartment'da C.C. Baxter sıradan bir ofis çalışanıdır. Sıradan olmayan tek yanı ise kendi evinin anahtarını kendinden daha üst mertebedeki yöneticilere verip onlara bir şekilde yardım etmektir. Bir gün Baxter’ın da aşık olduğu asansör operatörü Miss Kubelik’in patronu Sheldrake yatmak üzere evine geldiğini fark eden Baxter oldukça şaşırır. Sheldrake tarafından bir anda terk edilen Kubelik intihara kalkışır; ancak Baxter’ın müdahalesi ile hayatta kalır. Buradan sonra Kubelik’in iyileşme olayların ise karışma süreci başlayacaktır.Hollywood’un gelmiş geçmiş en değerli yönetmenlerinden biri olan Billy Wilder’ın ustalık yapıtlarından olan The Apartment’ın en iyi film ve en iyi yönetmen Oscar’ları da var.",
                          Imdb = "8.3",
                          PictureSource = "wikipedia.org",
                          TextMovieSource = "beyazperde.com"
                      },
                      new Oscar1
                      {
                          Id = Guid.NewGuid(),
                          Name = "Karanlıkla Karşı Karşıya",
                          Minute = 136,
                          Url = "https://tr.web.img4.acsta.net/pictures/18/09/04/11/10/2545452.jpg",
                          Category = "Biyografi, Polisiye",
                          Year = 2018,
                          Country = "ABD",
                          Trailer = "https://www.youtube.com/watch?v=HALno0TVTJc",
                          Age = 12,
                          Starring = "   John David Washington, Adam Driver, Topher Grace",
                          Creators = "  Spike Lee",
                          Explane = "Karanlıkla Karşı Karşıya, kenti ele geçirmeyi planlayan bir örgütü durdurmaya çalışan bir dedektifin hikayesini anlatıyor. Ron Stallworth, Colorado'da yaşayan Afro-Amerikan bir polis memurudur. Ortağı Flip Zimmerman ile birlikte çalışmaktadır. İkili Ku Klux Klan'ı durdurmak için mücadele vermektedir. Ron, örgütün şehri ele geçrime girişimlerini engellemek için gizlice örgütün içine sızmaya çalışır. Grupla iletişime geçen ve aşırı ırkçı biri gibi davranan Ron sonunda amacına ulaşır. Grubun toplantılarına katılmaya başlayan Ron, Klan’ın büyük kurucusu ile yakın ilişki kurar. Genç adam Ku Klux Klan'ına başarıyla sızmakla kalmayıp, yerel bölümün de başına geçer. Bu sırada Stallworth’un kimliğine geçen ortağı Zimmerman, ölümcül bir komployla ilgili bilgilere ulaşır. Peki Afro-Amerikan bir polis memuru, beyaz üstünlüğünü savunan bir örgütün içinde kimliğini gizli tutmayı nasıl başaracaktır?Gerçek bir hikayeden uyarlanan filmin yönetmen koltuğunda Malcolm X”, “25.Saat” ve “İçerideki Adam” gibi filmlerle tanınan 2 Oscar adayı Spike Lee oturuyor.Star Wars evreninin Kylo Ren’i Adam Driver ve “Ballers” dizisiyle tanıdığımız John David Washington başrolü paylaştığı filmin kadrosunda Topher Grace,Laura Harrier,Ryan Eggold,Jasper Pääkkönen gibi isimler yer alıyor.",
                          Imdb = "7.5",
                          PictureSource = "beyazperde.com",
                          TextMovieSource = "beyazperde.com"
                      },
                      new Oscar1
                      {
                          Id = Guid.NewGuid(),
                          Name = "Umut Işığım",
                          Minute = 122,
                          Url = "https://tr.web.img4.acsta.net/medias/nmedia/18/93/42/46/20392248.jpg",
                          Category = "Dramatik, Komedi",
                          Year = 2012,
                          Country = "ABD",
                          Trailer = "https://www.youtube.com/watch?v=kVS-6k2tQAA",
                          Age = 12,
                          Starring = "Bradley Cooper, Jennifer Lawrence, Robert De Niro",
                          Creators = "David O. Russell",
                          Explane = "Eski bir tarih öğretmeni olan Pat Salitano (Bradley Cooper), yaşamında değer verdiği her şeyi bir günde yitirmiş bir adamdır. yaşadığı ciddi bir travma sonrası patlar ve ardından mahkeme kararı ile 8 ay rehabilitasyon merkezinde tedavi görür. Çıktıktan sonra hayatını düzene koymak şartıyla ailesinin evine geri yerleşen Pat'in yegane amacı düzgün bir adam olup, işini geri almak ve karısı Vicky'yi bu sayede geri kazanmaktır.Fakat durum Pat için sandığından daha zor olacaktır.Bir yemekte,aile dostu Tiffany ile karşılaşan Pat,genç kadınla eski eşine ulaşmak amacıyla yakınlaşır.Bir 'iyilik' karşılığı Pat'e yardım teklif eden Tiffany, her ikisi içinde umut ışığı olacak yeni bir kapı açacaktır...Uyarlama senaryosunu ve yönetmenliğini David O.Russell'ın üstlendiği film dram ve komedinin iç içe geçtiği bir film. Dünya prömiyerini 2012 Toronto Film Festivali'nde yapan film,gösterildiği her festivalde seyirci ve eleştirmenlerden yüksek not alan favori bir yapım.",
                          Imdb = "7.7",
                          PictureSource = "beyazperde.com",
                          TextMovieSource = "beyazperde.com"
                      }
                   
                     
                     
                     );
        }
    }
}
