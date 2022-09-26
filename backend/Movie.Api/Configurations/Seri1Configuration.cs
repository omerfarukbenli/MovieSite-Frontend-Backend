using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Movie.Api.Models.Entities;

namespace Movie.Api.Configurations
{
    public class Seri1Configuration : IEntityTypeConfiguration<Seri1>
    {
        public void Configure(EntityTypeBuilder<Seri1> builder)
        {
            builder.HasData(
                 new Seri1
                 {
                     Id = Guid.NewGuid(),
                     Name = "Grease",
                     Minute = 110,
                     Url = "https://upload.wikimedia.org/wikipedia/en/e/e2/Grease_ver2.jpg",
                     Category = "Müzikal, Komedi",
                     Year = 1978,
                     Country = "ABD",
                     Trailer = "https://www.youtube.com/watch?v=qDKo8DNpwOw",
                     Age = 18,
                     Starring = "John Travolta,Olivia Newton - John,Stockard Channing,Jeff Conaway",
                     Creators = "Randal Kleiser",
                     Explane = "1958 yazında Danny Zuko (John Travolta) ve Sandra Olsson (Olivia Newton-John) bir yaz aşkı yaşamıştır. Yaz biterken Sandy Danny'e Avustralya'da okula devam edeceğini söyler ve çift ayrılmak zorunda kalır.Danny,okuduğu okul olan Rydell Lisesi'deki ilk gününde, deri ceketli serseri çetesi T-Birds'ün başına yeniden geçer.En yakın arkadaşları Kencikie,Doody,Sonny ve Putzie ile yaz tatilinde ne kadar eğlendiğini ve çapkınlığını anlatırken,Avustralya'ya gitmeyen ve tesadüfen aynı okula kaydolmuş olan Sandy ile karşılaşır. Sandy, Betty Rizzo'nun(Channing) başını çektiği Pink Ladies'e katılmıştır.Danny,Sandy'e deli gibi aşık olsa da tavırlarından vazgeçmeyecektir. Danny, okuldaki popülaritesini yitirmekten korkmaktadır. Sandy ve Danny aşkları sayesinde tekrar bir araya gelirler. Bu arada Betty de Kenickie (Jeff Conaway) ile çıkmaya başlar.",
                     Imdb = "7.2",
                     PictureSource = "wikipedia.org",
                     TextMovieSource = "wikipedia.org"
                 },
                 new Seri1
                 {
                     Id = Guid.NewGuid(),
                     Name = "Batman Başlıyor",
                     Minute = 140,
                     Url = "https://upload.wikimedia.org/wikipedia/tr/6/6d/BatmanBegins.jpg",
                     Category = "Aksiyon, Macera",
                     Year = 2005,
                     Country = "ABD",
                     Trailer = "https://www.youtube.com/watch?v=neY2xVmOfUM",
                     Age = 13,
                     Starring = "Christian Bale,Michael Caine,Liam Neeson",
                     Creators = "Christopher Nolan",
                     Explane = "Batman Başlıyor'da, ailesi öldürülen playboy Bruce Wayne, Henri Ducard ve Ra’s Al Ghul’ın yol göstericiliğinde Asya’ya taşınır. Gotham adeta şeytanlarla, kötü hesapların peşinde olan adamlarla kuşatılmış bir yerdir. Suç olayları bitmek bilmez. Bruce Wayne’in amacı bu şehre adaleti getirerek insanların ruhundaki korkuları ortadan kaldırmakve onları huzurlu kılmaktır.Yol göstericisi Ra’s al Ghul her ne kadar ona çok şey öğreten insan olsa da bir başka açıdan yoluna engel de teşkil etmektedir. Christopher Nolan’dan gelen bir Batman üçlemesinin ilk filmidir.",
                     Imdb = "8.2",
                     PictureSource = "wikipedia.org",
                     TextMovieSource = "beyazperde.com"
                 },
                  new Seri1
                  {
                      Id = Guid.NewGuid(),
                      Name = "Harry Potter ve Felsefe Taşı",
                      Minute = 152,
                      Url = "https://upload.wikimedia.org/wikipedia/tr/e/e0/Harry_Potter_and_the_Sorcerer%27s_Stone_%28film%2C_2001%29.jpg",
                      Category = "Fantastik, Macera, Aile",
                      Year = 2001,
                      Country = "İngiltere",
                      Trailer = "https://www.youtube.com/watch?v=VyHV0BRtdxo",
                      Age = 12,
                      Starring = " Daniel Radcliffe, Rupert Grint, Emma Watson",
                      Creators = " Chris Columbus",
                      Explane = "1981'in sonlarında, Hogwarts Cadılık ve Büyücülük Okulu profesörleri Albus Dumbledore ve Minerva McGonagall ile okul çalışanı Rubeus Hagrid, Harry Potter adlı yetim kalmış bir bebeği, geriye kalan son akrabaları olan Dursley ailesinin yanına bırakırlar. On yıl sonra Harry, kendisini sevmeyen Dursleylerle birlikte yaşamaya çalışmaktadır. Ailecek gittikleri hayvanat bahçesinde istemeden bir kazaya neden olduktan sonra baykuşların getirdiği mektuplar almaya başlar. Dursleyler daha fazla mektup gelmemesi için ıssız bir adaya kaçtıktan sonra, Hagrid ortaya çıkar ve Harry'ye aslında bir büyücü olduğunu ve Dursleylerin isteğinin aksine Hogwarts'a kabul edildiğini söyler. Büyücü üniforması, asa ve baykuş gibi okul ihtiyaçlarını alması için Diagon Yolu'na götürdüğü Harry'ye geçmişi hakkında bilgi verir; Harry, kötü niyetli ve çok güçlü bir büyücü olan Lord Voldemort'un yaptığı Ölüm Laneti nedeniyle ölen bir büyücü ve bir cadının oğludur. Bu büyüden sağ kurtulan tek kişi olan Harry, büyücü dünyasında 'Sağ Kalan Çocuk' olarak tanınır.Harry daha sonra Hagrid'le birlikte King's Cross Tren İstasyonu'na gider ve Hogwarts'a giden trene biner.Trende kısa sürede yakınlaştığı Ron Weasley,anne babası muggle olan zeki cadı Hermione Granger ve okula vardığında zengin bir büyücü aileye mensup olan ve ilk görüşte tartışma yaşadığı Draco Malfoy ile tanışır. (Muggle büyücü olmayan anlamına gelen bir kelimedir.) Okula gelen öğrenciler Büyük Salon'da toplanır ve tüm birinci sınıflar Seçmen Şapka tarafından dört binaya ayrılır: Gryffindor, Hufflepuff, Ravenclaw ve Slytherin. Seçmen Şapka, Harry'yi önce Draco ile birlikte Slytherin'e yerleştirmeyi düşünse de daha sonra Ron ve Hermione ile birlikte Gryffindor'a yerleştirir.Harry,Hogwarts'ta büyüler öğrenmeye başlar ve geçmişi ve ailesi hakkındaki gerçekleri keşfeder. Draco ile girdiği bir mücadele sonucunda Gryffindor'un sakar öğrencisi Neville Longbottom'a ait olan Hatırlatıcı'yı yakalar ve birinci sınıf öğrencileri için alışılmış bir durum olmamasına rağmen Gryffindor'un Quidditch takımına arayıcı olarak kabul edilir. Bir gece arkadaşları ile birlikte okulu keşfederken okulun yasaklı bir bölgesinde Fluffy adlı üç başlı dev bir köpeğe rastlar. Ron, Profesör Flitwick'in tılsım dersinde kendisini utandıran Hermione'nin kalbini kırar ve kendisini kızlar tuvaletine kitlemesine neden olur. Hermione, tuvalette bir trolün saldırısına uğrar ancak Harry ve Ron tarafından kurtarılır ve ikiliyle arkadaş olur.Harry,Ron ve Hermione daha sonra Fluffy'nin sahibine ölümsüzlük veren bir nesne olan Felsefe Taşı'nı koruduğunu anlarlar.Harry,iksir dersi öğretmeni ve Slytherin başkanı Severus Snape'in Voldemort'u bir bedene kavuşturmak için taşı ele geçirmeye çalıştığından şüphelenir.Hagrid,Fluffy'nin müzik çalındığında uykuya daldığını istemeden üçlüye söyler. Harry, Ron ve Hermione, o gece Snape'ten önce taşı bulmaya karar verirler ancak Fluffy'nin uykuda olduğunu görürler. Fluffy'yi geçen üçlü,bir dizi koruyucuyla yüzleşir.Bunlar arasında Şeytan Kapanı olarak bilinen ölümcül bir bitkiden kurtulmak,Harry'yi yaralayan bir oda dolusu saldırgan uçan anahtar arasından doğru anahtarı bulmak ve neredeyse Ron'un ölümüne neden olan insan boyutundaki taşlarla oynanan tehlikeli satrançta kazanmak yer alır.Harry,bu görevleri geçtikten sonra taşı ele geçirmeye çalışanın karanlık sanatlara karşı savunma dersi öğretmeni Profesör Quirrell olduğunu ve Snape'in aslında kendisini koruduğunu anlar. Quirrell türbanını çıkarır ve güçsüz durumdaki Voldemort'un kendi başının arkasında yaşadığını gösterir.Dumbledore tarafından yapılan bir büyü nedeniyle Harry,taşı cebinde bulur.Voldemort taşı almak için Harry'nin anne ve babasını diriltmeyi teklif eder ancak Harry'nin teklifi reddetmesi üzerine Quirrell saldırıya geçer.Harry,cildini yakıp toz hâline getirdiği Quirrell'ı öldürür. Daha sonra Voldemort'un ruhu Quirrell'ın küllerinden çıkar ve Harry'nin içinden geçerek bayılmasına neden olur.Harry okulun revirinde uyanır ve yanında Dumbledore'u görür. Dumbledore, taşın yok edildiğini ve Ron ile Hermione'nin güvende olduklarını söyler.Ayrıca Harry'nin Quirrell'ı nasıl yenebildiğini açıklar: annesi Harry'yi korumak için öldüğünde, onun ölümü Harry'ye Voldemort'a karşı sevgi temelli bir koruma vermiştir. Harry, Ron ve Hermione kahramanlıkları nedeniyle bina puanıyla ödüllendirilince Gryffindor ile Slytherin birincilik için eşit puanda kalır. Dumbledore daha sonra arkadaşlarını durdurmaya çalışan Neville'a on puan verir ve Gryffindor yeterli puana ulaşarak Bina Kupası'nı kazanır. Harry, Hogwarts'ta gerçek bir evi olmasının verdiği mutlulukla yaz tatili için evine döner.",
                      Imdb = "7.6",
                      PictureSource = "wikipedia.org",
                      TextMovieSource = "wikipedia.org"
                  },
                   new Seri1
                   {
                       Id = Guid.NewGuid(),
                       Name = "Zor Ölüm",
                       Minute = 132,
                       Url = "https://upload.wikimedia.org/wikipedia/tr/7/7e/Die_hard.jpg",
                       Category = "Aksiyon, Gerilim",
                       Year = 1988,
                       Country = "ABD",
                       Trailer = "https://www.youtube.com/watch?v=jaJuwKCmJbY",
                       Age = 12,
                       Starring = "  Bruce Willis, Alan Rickman, Alexander Godunov",
                       Creators = "  John McTiernan",
                       Explane = "Zor Ölüm'de Noel gecesi New York polis departmanı dedektifi John McClane günden güne uzaklaştığı karısı Holly’le arasını düzeltmek ve tekrar barışmak için Los Angeles’a gelir. Holly şirketinin yılbaşı partisi için Nakatomi Plaza’dadır ve McClane bu binaya doğru yola çıkar. McClane plazaya vardığında kıyafetlerini değiştirmek için bir odaya girer. Bu esnada bir grup Alman terörist binayı kuşatarakk içindeki insanları rehin alır. Ellerinden kurtulabilen tek kişii McClane’dir. Şimdi McClane’e düşen görev içerisinde eşinin de bulunduğu bu kalabalığı kurtarmak olacaktır.Aksiyonun sinemasının en önemli örneklerinden biri olan Die Hard kendisinden sonra çekilen üç devam filmiyle bir seri haline getirilmiştir.Bruce Willis’in dünya çapında tam anlamıyla tanınmasını sağlayan film Akademi Ödülleri’nde dört kategoride Oscar’a layık görülmüştür.",
                       Imdb = "8.2",
                       PictureSource = "wikipedia.org",
                       TextMovieSource = "beyazperde.com"
                   },
                   new Seri1
                   {
                       Id = Guid.NewGuid(),
                       Name = "Kutsal Hazine Avcıları",
                       Minute = 116,
                       Url = "https://upload.wikimedia.org/wikipedia/tr/a/a9/Raiders_of_the_lost_ark_poster_B.jpg",
                       Category = "Macera, Fantastik",
                       Year = 1981,
                       Country = "ABD",
                       Trailer = "https://www.youtube.com/watch?v=szF9QyDP0ww",
                       Age = 12,
                       Starring = "Harrison Ford,Karen Allen, Denholm Elliott,Paul Freeman",
                       Creators = "	Steven Spielberg",
                       Explane = "Kutsal Hazine Avcıları'nda Amerikan Hükümeti Ark of the Conenant’ı bulması için Arkeolog Dr. Indiana Jones'u görevlendirir. Ark’ta ünlü 10 Emir’in varolduğuna ve kutsal güçler olduğuna inanılmaktadır. Üstelik Hitler’in ajanları da Ark’ın peşindedirler. Jones, eski aşkı Marion’la birlikte Nepal’den Kahire’ye kadar tuzak ve tehlikeyle dolu bir maceraya atılır.George Lucas'ın 1930'lu yılların maceraperest aksiyon kahramanlarından ilham alarak yarattığı Indiana Jones karakterinin ilk filmi olan Kutsal Hazine Avcıları'ndan sonra, 1984'te Kamçılı Adam,1989'da Son Macera, 1992 ve 1996 yıllarında Genç Indiana Jones Günlükleri ve 2008 yılında Kristal Kafatası Krallığı çekildi",
                       Imdb = "8.4",
                       PictureSource = "wikipedia.org",
                       TextMovieSource = "beyazperde.com"
                   },
                     new Seri1
                     {
                         Id = Guid.NewGuid(),
                         Name = " James Bond Dr. No",
                         Minute = 110,
                         Url = "https://upload.wikimedia.org/wikipedia/tr/0/04/007DrNoposter.jpg",
                         Category = "Macera",
                         Year = 1963,
                         Country = "İngiltere",
                         Trailer = "https://www.youtube.com/watch?v=pw61uyA0F8A",
                         Age = 12,
                         Starring = "Sean Connery,Ursula Andress,Joseph Wiseman,Jack Lord",
                         Creators = "Terence Young",
                         Explane = "Film Jamaika'da başlar. İngiliz Ajan John Strangways ve sekreteri aniden ortadan kaybolmuştur. Bunu araştırmak için James Bond M tarafından Jamaika'ya gönderilir. Buraya geldikten sonra yaptığı araştırmalar sonucunda organize bir suç örgütünün Jamaika'ya yakın bir adada bulundugunu fark eder. Bu ada halk tarafından kötü canavarların yaşadığına inanılan ve yaklaşmaya dahi korkulan bir yerdir. Adadaki örgütün lideri Dr. No, Amerikan Hükümeti'nin uzaya fırlatacağı füzeyi düşürme planları içindedir. Amerikan Hükûmeti'ni de fidye vermesi için tehdit etmektedir. James Bond adaya çıkarak Dr. No'nun başarılı olmasını engellemeye çalışır.",
                         Imdb = "7.2",
                         PictureSource = "wikipedia.org",
                         TextMovieSource = "wikipedia.org"
                     },
                      new Seri1
                      {
                          Id = Guid.NewGuid(),
                          Name = "Superman",
                          Minute = 143,
                          Url = "https://turkcealtyazi.org/images/poster/0078346.jpg",
                          Category = "Aksiyoni, Macera",
                          Year = 1978,
                          Country = "ABD",
                          Trailer = "https://www.youtube.com/watch?v=grO4OcJ6cgY",
                          Age = 12,
                          Starring = "Marlon Brando,Terence Stamp,Gene Hackman,Christopher Reeve",
                          Creators = "	Richard Donner",
                          Explane = "Krypton gezegeni yok olmak üzeredir. Gezegeni terk edecek kadar aracı olmayan sakinleri çaresizce beklemektedirler. Kal-El isimli küçük bir bebeği anne ve babası bir kapsüle koyup uzaya yollarlar. Kapsül ve içindeki bebek üç yıl süren bir yolculuktan sonra Dünya gezegeninde, Smallville, Kansas'a iner. Tarih 1951'dir. Şimdi üç yaşında olan Kal-El isimli bebeği yaşlı ve çocuksuz bir çift olan Kent'ler bulur. Onu çiftliklerine götürerek yetiştirmeye karar verirler. Clark adını verdikleri ve kendi öz çocukları gibi sevdikleri bu çocuğun büyüdükçe inanılmaz güçlere sahip olduğunu keşfederler.18 yaşındayken,babası olarak gördüğü Jonathan'ın kalp krizinden ölümünden sonra, Clark bir 'çağrı' duyar ve uzay aracının kalıntılarında parlayan yeşil bir kristal keşfeder. Onu Kripton'un mimarisine benzeyen ve sonradan Yalnızlık Kalesi'ni inşa ettiği Arktika bölgesine gitmeye zorlar. İçeride, babası Jor-El'in bir hologramı ortaya çıkar ve Clark'ın gerçek kökenlerini açıklar, 12 yıl sonra onu Dünya'ya ve güçlerine gönderilme nedeni hakkında bilgi verdikten sonra,Kaleyi kırmızı pelerinli ve mavi ve kırmızı bir takım elbise ile uçarak terk eden Kal - El,10 yıl kadar sonra Metropolis'teki Daily Planet'ta muhabir olur,iş arkadaşı Lois Lane ile tanışır ve ilişkileri romantik bir şekilde gelişir.Clark,kısa zamanda kendini dünyayı ele geçirmekle ilgili kötü emelleri olan Lex Luthor'la mücadele içinde bulur.",
                          Imdb = "7.4",
                          PictureSource = "turkcealtyazi.org",
                          TextMovieSource = "wikipedia.org"
                      },
                       new Seri1
                       {
                           Id = Guid.NewGuid(),
                           Name = "X-Men",
                           Minute = 144,
                           Url = "https://upload.wikimedia.org/wikipedia/tr/6/63/XMen_film_posteri.jpg",
                           Category = "Aksiyon, Macera",
                           Year = 2000,
                           Country = "ABD",
                           Trailer = "https://www.youtube.com/watch?v=VNxwlx6etXI",
                           Age = 12,
                           Starring = "	Patrick Stewart, Hugh Jackman,Ian McKellen,Halle Berry",
                           Creators = "	Bryan Singer",
                           Explane = "Rogue sevgilisi ile öpüşürken sevgilisinin yaşam enerjisini çeker ve neredeyse onu öldürür. Bunun üzerine evden kaçar. Wolverine ise kafes dövüşleri yapmaktadır. Yolları bir dövüş sonrasına bir barda kesişir. Rogue Wolverine’nin aracına gizlice biner. Wolverine isteksizce de olsa onu yanına alır. Yolda Sabretooth onlara saldırır. Wolverine, Sabretooth'la dövüşürken patlamak üzere olan araçta mahsur kalan Rogue’yi Cyclops ve Strom'dan kurtarır. Birlikte Prof.X'in okuluna gelirler. Bu sırada Mystique bir senatörü kaçırır. Magneto, senatör üzerinde bir deney yaparak onu mutanta çevirir. Rogue istemeden Wolverine’nin gücünü emer. Mystique’nin Bobby’nin (Iceman) kılığına girerek onu okuldan ayrılması için yönlendirmesi ile Rogue okuldan kaçar. Wolverine peşine düşer. Tren garında Magneto ve ekibi onlara saldırır. Amaçları Wolverine değil Rogue’yi kaçırmaktır. Magneto’nun planı dünya liderlerinin Amerika’da bir arada toplandıkları sırada Rogue’nin gücünü kullanarak liderleri mutanta çevirecek bir saldırı düzenlemektir. X-Men bunu durdurmak için oraya giderler. Özgürlük Heykeli içinde dövüşürler. Enerji dalgası liderlere doğru giderken Xmen, Magneto’yu durdurur, cihazı patlatırlar. Rogue ölmek üzere iken Wolverine ona dokunarak yenilenme gücünü verir ve Rogue’yi kurtarır.",
                           Imdb = "7.3",
                           PictureSource = "wikipedia.org",
                           TextMovieSource = "wikipedia.org"
                       },
                       new Seri1
                       {
                           Id = Guid.NewGuid(),
                           Name = "The Godfather",
                           Minute = 175,
                           Url = "https://upload.wikimedia.org/wikipedia/tr/7/7c/1972_yap%C4%B1m%C4%B1_Baba_film_afi%C5%9Fi.jpg",
                           Category = "Polisiye, Dram",
                           Year = 1972,
                           Country = "ABD",
                           Trailer = "https://www.youtube.com/watch?v=UaVTIH8mujA",
                           Age = 12,
                           Starring = "	Marlon Brando, Al Pacino,James Caan,Robert Duvall",
                           Creators = "Francis Ford Coppola",
                           Explane = "Corleone ailesi, Don Vito Corleone'nin başında olduğu, suça dayalı bir örgüt kurmuş olan İtalyan asıllı meşhur bir ailedir. Aile, New York'taki diğer dört aileyle birlikte New York'un yeraltı işlerini yönetmektedir. Ancak Corleone ailesini diğerlerinden ayıran özelliği, Don Corleone'nin cebinde bozuk para gibi taşıdığı politikacılar ve yargıçlardır. Politikacılar ve yargıçlarla olan bu yakın ilişkileri diğer ailelerin açamadığı kapıları açabilmesini sağlamaktadır.İtalya ve New York'un en meşhur uyuşturucu üreticisi ve dağıtıcısı olan 'Türk' lakaplı Solozzo, Don Corleone'den,ilişkilerini kullanarak kendisine yasal koruma sağlamasını ve 1 milyon dolar nakit para vermesini ister,karşılığında,elde edilecek kârdan pay teklif eder.Teklife göre,ilk yıl Corleone ailesine kalacak olan para 3 - 4 milyon dolar civarında olacaktır.Ancak Don Corleone teklifi reddeder.Gerekçesi,iyi ilişkileri olsa da,Don Corleone'nin uyuşturucu işi ile bağlantısı olduğunu öğrenen siyasetçilerin ilişkilerini gözden geçirme gereği duyacak olmalarıdır. Don Corleone'ye göre politikacılar kumarı bir zaaf olarak görüyorlardır ama uyuşturucu pis iştir.Bunun üzerine arkasına Tattaglia ailesini ve New York'ta polis şefi olan McClusky'i alan Solozzo,Don Corleone'yi vurdurtur. Ölümden son anda kurtulan Don Corleone'yi ve tüm aileyi kötü günler beklemektedir.Bu süreçte,fevri hareketleriyle bilinen,Don Corleone'nin en büyük oğlu Sonny ölecek, II. Dünya Savaşı'ndan kahraman olarak dönen en küçük oğlu Michael ise,daha önce aile işleriyle hiç ilgilenmediği ve bunu istemediği hâlde,olayların akışı onu hikâyenin merkezine doğru itecektir.Ve New York'ta suç aileleri arasındaki savaş başlayacaktır.",
                           Imdb = "9.2",
                           PictureSource = "wikipedia.org",
                           TextMovieSource = "wikipedia.org"
                       },
                       new Seri1
                       {
                           Id = Guid.NewGuid(),
                           Name = "Jurassic Park",
                           Minute = 127,
                           Url = "https://upload.wikimedia.org/wikipedia/tr/4/49/Jurassic_Park_film_posteri.jpg",
                           Category = "Bilimkurgu, Macera, Gerilim",
                           Year = 1993,
                           Country = "ABD",
                           Trailer = "https://www.youtube.com/watch?v=lc0UehYemQA",
                           Age = 13,
                           Starring = "Sam Neill, Laura Dern,Jeff Goldblum",
                           Creators = "Steven Spielberg",
                           Explane = "Mağaralarda yapılan bazı kazı çalışmaları sonucunda dinozorların yaşadığı tarih öncesi çağa ait bazı sivrisinek fosilleri bulunur. Milyarder John Hammond öncülüğündeki bilim adamları, son derece ilginç ve karmaşık testler deneyerek bu sivrisinek fosillerindeki kan örneklerini almayı başarırlar. Dinozorların DNA zinciri, bir Afrika kurbağasıyla birleştirilerek 65 milyon yıl önce yaşamış olan bu korkunç yaratıklar yeniden yaratılır. Hammond, hükümetten kiraladığı ve Kosta Rika açıklarında bulunan bir adada klonladıkları bu vahşi hayvanlar için, elektrikli tellerle çevrili bir hayvanat bahçesi kurmuştur.İhtiyar Hammond,bir hafta sonunda Dr.Alan gibi bazı işinde uzman bilim adamlarını Jurassic Park adını verdiği bu hayvanat bahçesini test ettirmek için adaya getirir.Ancak dinozor embriyolarını ele geçirmek isteyen ve rakip firmadan rüşvet alan bir görevli,güvenlik sistemini devre dışı bırakınca,serbest kalan dinozorlar adada dehşet saçmaya başlar...",
                           Imdb = "8.2",
                           PictureSource = "wikipedia.org",
                           TextMovieSource = "wikipedia.org"
                       },
                       new Seri1
                       {
                           Id = Guid.NewGuid(),
                           Name = "Rocky ",
                           Minute = 120,
                           Url = "https://upload.wikimedia.org/wikipedia/tr/3/3b/Rocky_film_posteri.jpg",
                           Category = "Dram, Spor",
                           Year = 1976,
                           Country = "ABD",
                           Trailer = "https://www.youtube.com/watch?v=3VUblDwa648",
                           Age = 12,
                           Starring = "Sylvester Stallone, Talia Shire,Burt Young, Carl Weathers, Burgess Meredith",
                           Creators = "	John G. Avildsen",
                           Explane = "1975'te, Dünya ağır siklet boks şampiyonu Apollo Creed, yaklaşmakta olan ABD'nin kuruluşunun ikiyüzüncü yılında Philadelphia'da Dünya Ağır Siklet Boks Şampiyonluğu unvan maçı düzenlemeyi planladığını duyurur. Ancak, dövüş tarihinden beş hafta sonra, dövüşeceği rakibinin elini sakatlaması nedeniyle dövüşemeyeceği konusunda bilgilendirilir. Creed, diğer tüm olası yedek boksörlerin elendiği ve başka müsait boksör bulunamaması yüzünden adı-sanı hiç duyulmamış yerel bir boksöre kendisine meydan okuma şansını vererek maçı renklendirmeye karar verir.Creed, öncelikle küçük spor salonlarında dövüşen ve bir tefeci için tahsildar olarak çalışan İtalyan Aygırı lakaplı boksör olan Rocky Balboa'yı seçer çünkü unvanı çok hoşuna gitmiş, ilgisini çekmiştir. Başta bu maç için isteksiz olan Rocky, sonunda kendisine 150.000 dolar ödenecek olan mücadeleyi kabul eder. Rocky, sığır etlerinin kenarlarını kum torbası olarak kullanmak gibi birkaç haftalık alışılmışın dışında bir eğitimden geçer.Rocky'yi daha sonra eski boksör ve şimdi bir boks antrenörü olan Mickey Goldmill ziyaret eder. Yaşlı, ufak tefek ve spor salonu sahibi olan bu adam Rocky'i başlangıçta çalıştırmaya istekli değildir,çünkü Mickey daha önce ona yardım etmeye pek ilgi göstermemiş ve onu boşa giden bir yetenek olarak görmüştür ancak Rocky'nin Creed ile maç yapacağını öğrendikten sonra onu çalıştırmayı ve menajeri olmayı teklif eder fakat Rocky ilk başta kabul etmez. Bağırır çağırır ama dayanamaz ve uzaklaşıp gitmekte olan Mickey'nin yanına koşar ve teklifini kabul eder.Bu arada Rocky,bir evcil hayvan dükkanında yarı zamanlı çalışan Adrian Pennino ile romantik bir ilişki kurmaya başlar.Adrian'ın erkek kardeşi ve Rocky'nin en iyi arkadaşı Paulie,Rocky'nin kız kardeşiyle buluşmasına yardım eder ve dövüş için onunla köşe adam olarak çalışmayı teklif eder. Fakat Paulie, Rocky'nin başarısını içten içe kıskanmaktadır ancak Rocky,Paulie'nin yaklaşmakta olan dövüşün bir parçası olarak çalıştığı et paketleme işinin reklamını yapmayı kabul ederek onu yatıştırır. Dövüşten önceki gece, uykuları kaçan Rocky, Philadelphia Spectrum'u ziyaret eder ve güvenini kaybetmeye başlar.Adrian'a maçı kazanabileceğine inanmadığını itiraf eder ancak Creed'e karşı mesafe katetmeye çalışır,başka bir dövüşçünün yapamadığını yaparak kendini herkese kanıtlamak zorundadır.Creed,yeni yılın ilk gününde George Washington ve sonra Sam Amca gibi giyinmiş bir şekilde show yaparak ringe giriş yapar ve mücadele başlar.Creed'in kendine aşırı güveninden yararlanan Rocky, ilk round da onu ilk kez yere serer. Creed hayatında ilk kez yere serilmiştir. Endişelenen Creed'in egosu tamamen kaybolmasa da Rocky'yi dövüşün geri kalanında daha ciddiye almaya başlar.Dövüş,on beş round boyunca devam eder ve her iki dövüşçü de çeşitli yaralanmalara maruz kalır.On beşinci rounda girerken Rocky,kafasına darbe almış ve şişmiş göz kapakları yüzünden görüşünü geri kazanmak için sağ göz kapağına kesik atılmasını ister.İç kanaması olan ve kaburgası kırılan Apollo nefes almakta zorlanır,buna rağmen mücadele etmeye devam etmek ister.Dövüş sona erdiğinde,son zil çalarken,her iki dövüşçü de birbirlerinin kollarına kilitlenir ve birbirlerine bir rövanş maçı olmayacağına dair söz verirler.Dövüşten sonra sporcular ve seyirciler çıldırır, herkes ringe koşar.George Jergens,hoparlör üzerinden dövüşün 'ring tarihindeki en büyük cesaret ve dayanıklılık sergisi' olduğunu duyurur ve Rocky,Paulie'nin arena güvenliğinin dikkatini dağıtmasıyla ringe çıkan Adrian'a tekrar tekrar seslenir.George Jergens'in Creed'i,bölünmüş bir hakem kararı(8: 7, 7: 8, 9: 6) sayesinde maçı kazandığını ilan eder ama Adrian ve Rocky,maçın sonucunu umursamadan birbirlerine olan sevgiyle kucaklaşırlar.",
                           Imdb = "8.1",
                           PictureSource = "wikipedia.org",
                           TextMovieSource = "wikipedia.org"
                       },
                       new Seri1
                       {
                           Id = Guid.NewGuid(),
                           Name = "Star Trek",
                           Minute = 128,
                           Url = "https://upload.wikimedia.org/wikipedia/tr/7/76/Startrekfilm_posteri.jpg",
                           Category = "Aksiyon, Macera, Fantastik",
                           Year = 2009,
                           Country = "ABD",
                           Trailer = "https://www.youtube.com/watch?v=pKFUZ10Wmbw",
                           Age = 12,
                           Starring = "Chris Pine, Zachary Quinto, Eric Bana",
                           Creators = " J.J. Abrams",
                           Explane = "Bir zamanların çok sevilen kahramanları bu kez gençlik yılları ile karşımızda. Güç ve cesaret, Atılgan ve ekibinin elindedir elbette. Evren tehdit altındadır ve geleceği parlak görünmez. Bu durum ile mücadele vermesi beklenen de elbette Atılgan ve ekibidir. Türlü tehlikelere göğüs germeleri gerekecek olan Kaptan Kirk ve Spock arasında mücadele de en keskin hali ile sürecektir. Dünya ile derdi olup da intikamın izini süren kötü ruhlu güçler karşında Atılgan ve ekibi ne kadar başarılı olacaklardır? Star Trek macerasının kahramanlarının gençlik yıllarından dem vuran film, Oscar ödüllü olup J.J. Abrams’ın emeği.",
                           Imdb = "7.9",
                           PictureSource = "wikipedia.org",
                           TextMovieSource = "beyazperde.com"
                       },
                        new Seri1
                        {
                            Id = Guid.NewGuid(),
                            Name = "Transformers",
                            Minute = 144,
                            Url = "https://upload.wikimedia.org/wikipedia/tr/3/34/Transformers_film_posteri.jpg",
                            Category = "Aksiyon, Macera",
                            Year = 2007,
                            Country = "ABD",
                            Trailer = "https://www.youtube.com/watch?v=v8ItGrI-Ou0",
                            Age = 18,
                            Starring = "	Shia LaBeouf,Megan Fox,Josh Duhamel,Tyrese Gibson",
                            Creators = "Michael Bay",
                            Explane = "Cybertron gezegeni farklı mekanizmalara dönüşebilme yetenekleri olan robotların yaşadığı gezegendir ve iki farklı cepheye bölünmüştür. Bir tarafta Autobotlar denen İyi robotlar ve Decepticonlar adlı kötü robotlar olarak farklı hedeflerin peşinde koşan bu Transformer'lar, gezegenlerindeki Energon Küpleri adı verilen yakıt stoklarının azalması sonucu, uzayda farklı yakıt kaynaklarının arayışı içine girerler. Ve tabii ki bu arayış, kimyasallar ve gerekli yakıt mineralleri açısından son derece zengin olan dünyamıza düşürecektir yollarını. Kolaylıkla otomobillere, uçaklara, deniz taşıtlarına, kamyonlara dönüşebilme yeteneği olan bu robotlar, dünyaya gelerek bu kaynakları ele geçirebilmek için bir savaş başlatacaklardır. Kötü ruhlu robotlar Decepticonlar'ın tek isteği kendi isteklerini elde edebilmek için dünyayı yok etmektir. Tabi yine karşılarında iyi robotlar ve onların başı Optimus Prime'ı bulacaklardır.",
                            Imdb = "7.0",
                            PictureSource = "wikipedia.org",
                            TextMovieSource = "wikipedia.org"
                        },
                        new Seri1
                        {
                            Id = Guid.NewGuid(),
                            Name = "Terminatör",
                            Minute = 108,
                            Url = "https://upload.wikimedia.org/wikipedia/tr/e/ed/Terminator-film_Posteri.jpg",
                            Category = "Aksiyon, Gerilim",
                            Year = 1984,
                            Country = "ABD",
                            Trailer = "https://www.youtube.com/watch?v=k64P4l2Wmeg",
                            Age = 18,
                            Starring = "Arnold Schwarzenegger,Michael Biehn",
                            Creators = "	James Cameron",
                            Explane = "1984 yılında Los Angeles'ta, Terminatör (Arnold Schwarzenegger) olarak bilinen bir cyborg suikastçısı, 2029 yılından gönderilmiştir. Kısa bir süre sonra, aynı yıldan geriye gönderilen bir insan asker olan Kyle Reese (Michael Biehn) gönderilir. Terminatör, adreslerini telefon rehberinde bulduğu Sarah Connor adlı kadınları sistematik olarak öldürmeye başlar. Son Sarah Connor'ı (Linda Hamilton) bir gece kulübüne kadar takip eder, ancak Kyle onu kurtarır. İkili, bir araba çalar ve Terminatör onları bir polis arabasında takip eder.Bir otoparkta saklanırlarken Kyle,Sarah'ya Cyberdyne Systems tarafından oluşturulan Skynet olarak bilinen yapay zeka savunma ağının yakın gelecekte kendi bilincinin farkında olacağını ve insanlığı ortadan kaldırmak için küresel bir nükleer savaşı tetikleyeceğini açıklar. Sarah'nın doğacak olan oğlu John,hayatta kalanları toplayıp organize edecek ve Skynet'e ve onun makineler ordusuna karşı bir direniş hareketine liderlik edecektir. İnsan direnişi zafere yakınken Skynet, direniş'in oluşmasını önlemek için John doğmadan önce Sarah'yı öldürmek için zamanda geriye bir Terminatör göndermiştir. Bir Cyberdyne Systems Model 101 olan Terminatör, güçlü bir metal iç iskelete ve onu insan kılığına sokan dış canlı doku katmanına sahip bir ölüm makinesidir.Kyle ve Sarah,Terminatör ile bir kez daha karşılaştıktan sonra polis tarafından yakalanırlar.Terminatör,polis karakoluna saldırır ve Sarah'ı bulmaya çalışırken polis memurlarını tek tek öldürür. Kyle ve Sarah karakoldan kaçarlar, başka bir araba çalarlar ve bir motele sığınırlar, burada boru bombaları yaparlar ve bir sonraki hareketlerini planlarlar. Kyle, John ona bir fotoğrafını verdiğinden beri Sarah'ya hayran olduğunu ve sadece onu kurtarmak için değil,aynı zamanda fotoğraftan ona aşık olduğu için zamanda yolculuk ettiğini itiraf eder; Duygularına karşılık veren Sarah, Kyle'ı öper ve seks yaparlar.",
                            Imdb = "8.1",
                            PictureSource = "wikipedia.org",
                            TextMovieSource = "wikipedia.org"
                        },
                        new Seri1
                        {
                            Id = Guid.NewGuid(),
                            Name = "Iron Man",
                            Minute = 126,
                            Url = "https://tr.web.img4.acsta.net/pictures/bzp/01/53751.jpg",
                            Category = "Aksiyon, Bilimkurgu",
                            Year = 2008,
                            Country = "ABD",
                            Trailer = "https://www.youtube.com/watch?v=8ugaeA-nMTc",
                            Age = 18,
                            Starring = "Robert Downey Jr., Terrence Howard, Gwyneth Paltrow",
                            Creators = "Jon Favreau",
                            Explane = "Tony Stark, hem bir mühendislik dahisi hem de tam bir playboydur. Kendi ülkesinde teknoloji harikası füzeler ve silahlar üretmektedir. Afganistan’da yeni bir füzeyi tanıtırken esir düşer ve yaralanır. Onu kaçıranlar, kendileri için bir füze yapmasını isterler. Tony ise bunun yerine zırhlı bir giysi yapar. Bunu yapmaktaki amacı zekasını kullanarak farklı bir kurtuluş yöntemini planlamaktır. Boş zamanlarını kadınlarına ayıran Tony’nin hayatı artık tamamen farklı bir şekle bürünmüştür. Onun bununla nasıl baş edeceği ise esas konudur",
                            Imdb = "7.9",
                            PictureSource = "beyazperde.com",
                            TextMovieSource = "beyazperde.com"
                        },
                        new Seri1
                        {
                            Id = Guid.NewGuid(),
                            Name = "İlk Yenilmez: Kaptan Amerika",
                            Minute = 124,
                            Url = "https://tr.web.img4.acsta.net/medias/nmedia/18/83/68/89/19771403.jpg",
                            Category = "Aksiyon, Bilimkurgu",
                            Year = 2011,
                            Country = "ABD",
                            Trailer = "https://www.youtube.com/watch?v=W4DlMggBPvc",
                            Age = 18,
                            Starring = " Chris Evans, Hayley Atwell, Sebastian Stan",
                            Creators = "Joe Johnston",
                            Explane = "Marvel Comics tarafından yaratılan çizgi roman karakteri Kaptan Amerika, yani Steve Rogers, bu filmde Kaptan Amerika olarak bilinen süper askere dönüşeceği deneysel bir programa katılmaya gönüllü olduğu zamanlardaki Marvel Evreni’nin ilk günlerine dönüyor. Kaptan Amerika , kötü Red Skull’ın liderliğindeki HYDRA organizasyonuyla savaşmak için Bucky Barnes ve Peggy Carter’la güçlerini birleştiriyor.İlk Yenilmez: Kaptan Amerika,ilk kez 1997 yılında bir konsept olarak Artisan Entertainment tarafında hayata geçirilmek üzere tasarlandı.Fakat proje 2003 yılına kadar bir gelişme gösteremedi.Bu tarihten sonra proje Paramount Pictures'e geçti. Ana karakterler 2010'da belirlendi ve filmin çekimleri 2010 Haziran'ında başladı. Çekimler Londra, Manchester ve Liverpool'da gerçekleşti,post prodüksiyon aşamasında 3D'ye dönüştürüldü.Filmin premiyeri 19 Temmuz 2001'de Hollywood'da yapıldı ve dünyada ilk kez 22 Temmuz 2011'de vizyona girdi.",
                            Imdb = "6.9",
                            PictureSource = "beyazperde.com",
                            TextMovieSource = "beyazperde.com"
                        }


                        );
        }
    }
}
