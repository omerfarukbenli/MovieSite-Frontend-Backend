using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Movie.Api.Models.Entities;

namespace Movie.Api.Configurations
{
    public class Hollywood1Configuration : IEntityTypeConfiguration<Hollywood1>
    {
        public void Configure(EntityTypeBuilder<Hollywood1> builder)
        {
            builder.HasData(
                  new Hollywood1
                  {
                      Id = Guid.NewGuid(),
                      Name = "Nedimeler",
                      Minute = 125,
                      Url = "https://upload.wikimedia.org/wikipedia/tr/4/4e/NedimelerPoster.jpg",
                      Category = "Komedi, Romantik",
                      Year = 2011,
                      Country = "ABD",
                      Trailer = "https://www.youtube.com/watch?v=FNppLrmdyug",
                      Age = 12,
                      Starring = "Kristen Wiig, Rose Byrne, Maya Rudolph",
                      Creators = "Paul Feig",
                      Explane = "Kadınların ilişkide dertleri asla bitmez. Hatta nişanlansalar ve düğün arifesinde dahi olsalar! Annie (Kristen Wiig) hayatı karman çorman giden, erkeklerle ilişkilerinde dikiş tutturamayan bir kadındır. Bir gün en yakın arkadaşı Lillian (Maya Rudolph)nişanlanır ve düğününde Annie’ye baş nedime olmasını teklif eder. Annie deli dolu bir kadındır ama diğer nedimelerin de, Helen (Rose Byrne), Megan (Melissa McCarthy), Rita (Wendi McLendon-Covey) ve Becca (Ellie Kemper), ondan geri kalır yanı yoktur!Kaza Kurşunu ve Kırk Yıllık Bekar gibi romantik komedilerle tanıdığımız yönetmen Judd Apatow'un yapımcılığında kotarılan Nedimeler, Amerikalı bekarlarının bitmek bilmeyen evlilik öncesi sendromuna ve bu sendromun en iyi arkadaşlar üzerindeki travmalarına komedi çerçevesinden yaklaşıyor.Yönetmenliğini Nurse Jackie,The Office gizi dizilerin de bazı bölümlerini çeken Paul Feig'in üstlendiği filmin senaristleri ise Annie Mumolo ile başrolde seyrettiğimiz Kristen Wiig. Amerika'da 2011 Mayısında vizyona giren film seyircilerden ve eleştirmenlerden aldığı yüksek puanlarla da dikkat çekiyor...",
                      Imdb = "6.8",
                      PictureSource = "wikipedia.org",
                      TextMovieSource = "beyazperde.com"
                  },
                  new Hollywood1
                  {
                      Id = Guid.NewGuid(),
                      Name = "Sosyal Ağ",
                      Minute = 120,
                      Url = "https://upload.wikimedia.org/wikipedia/tr/0/09/Sosyal_A%C4%9F_%28afi%C5%9F%29.jpg",
                      Category = "Komedi, Romantik",
                      Year = 2010,
                      Country = "ABD",
                      Trailer = "https://www.youtube.com/watch?v=lB95KLmpLR4",
                      Age = 12,
                      Starring = " Jesse Eisenberg, Justin Timberlake, Andrew Garfield",
                      Creators = " David Fincher",
                      Explane = "Tüm dünyada olduğu kadar Türkiye’de de bir fenomene dönüşmüş, milyonların sosyal paylaşım sitesi Facebook’un kurucusu Mark Zuckerberg ve arkadaşlarının öyküsü.Bir Ekim gecesi,yıl 2003.Mark Zuckerberg,sarhoş kafayla Harvard Üniversitesi'nin sistemine sızar. Kız arkadaşı tarafından terk edilmiştir ve bunun acısını kampüsteki tüm kızların bilgisinin olduğu bir veritabanında birleştirmek ister. Yazdığı uygulamada ekranın iki yanındaki kızların fotoğraflarını oylayarak hangisinin daha güzel olduğu seçilebilmektedir. Mark sayfanın adına Facemash adını verir. Sitenin başarısı hızla yayılır fakat Mark'ın kadınlara olan nefreti ve bu yolda gizlilik kurallarını ihlal etmiş olması Harvard Üniversitesi'nin de tepkisi çeker. Bu durum sitenin evrilerek Facebook'a dönüşmesine olanak sağlar.Öncelikle yalnızca Harvard'da kullanılan Facebook, daha sonra diğer üniversitelerde de açılır ve Ivy League'den Silikon Vadisi'ne tüm dünyada yayılmaya başlar. Sosyal medya denince günümüzde akla gelen ilk uygulamalardan olan Facebook'un arkasında yatan gerçekler,oluşumunun öyküsü ve günümüz dünyasına sunduğu artı ve eksiler Mark Zuckerberg'in hikayesinden yola çıkılarak ele alınıyor.",
                      Imdb = "7.8",
                      PictureSource = "wikipedia.org",
                      TextMovieSource = "beyazperde.com"
                  },
                  new Hollywood1
                  {
                      Id = Guid.NewGuid(),
                      Name = "Bir Yıldız Doğuyor",
                      Minute = 136,
                      Url = "https://upload.wikimedia.org/wikipedia/tr/c/c5/Bir_Y%C4%B1ld%C4%B1z_Do%C4%9Fuyor_afi%C5%9F.jpg",
                      Category = "Dram, Romantik",
                      Year = 2018,
                      Country = "ABD",
                      Trailer = "https://www.youtube.com/watch?v=nSbzyEJ8X9E",
                      Age = 12,
                      Starring = "Lady Gaga, Bradley Cooper, Sam Elliott",
                      Creators = "Bradley Cooper",
                      Explane = "Bir Yıldız Doğuyor, yetenekli ancak bilinmeyen Ally'yi keşfedince düşüşün eşiğine gelen bir country müzik yıldızı olan Jackson Maine'i konu alıyor. Jackson Maine, kariyerinde düşüş gösteren bir müzisyendir. Henüz keşfedilmemiş genç bir yetenek olan Ally ile tanışır ve ikili birbirlerinden hemen etkilenir. İkili tutkulu bir aşk yaşamaya başlar ve Ally'nin yeteneğinin farkedilmesi için çalışan Jackson onu sahnenin büyülü dünyası ile tanıştırır. Jack Ally'yi şöhrete kavuşturduktan kısa süre sonra ise Ally artık ünlü bir müzisyen olmuştur. Jack, Ally'nin kariyerinin hızla kendisininkini gölgede bıraktığını fark eder. Kaybolan ihtişamını geri kazanmaya çalışan Jack bu süreçte içsel şeytanlarıyla da yüzleşmek zorunda kalacaktır. İkilinin kariyerlerindeki ayrım büyüdükçe, ilişkileri de hasar almaya başlar... 4 Oscar adayı başarılı oyuncu Bradley Cooper ve Lady Gaga’nın başrollerini paylaştığı filmde Bradley Cooper, ilk kez yönetmen koltuğuna geçiyor. Kadrosunda Sam Elliott, Andrew Dice Clay, Rafi Gavron, Michael Harney gibi oyuncuların da yer aldığı filmin senaryosunda Eric Roth, Will Fetters ve Bradley Cooper’ın imzası bulunuyor.",
                      Imdb = "7.6",
                      PictureSource = "wikipedia.org",
                      TextMovieSource = "beyazperde.com"
                  },
                  new Hollywood1
                  {
                      Id = Guid.NewGuid(),
                      Name = "Wonder Woman",
                      Minute = 141,
                      Url = "https://upload.wikimedia.org/wikipedia/tr/b/b0/Wonder_Woman_%282017_film%29_poster.jpg",
                      Category = "Aksiyon, Macera, Fantastik",
                      Year = 2017,
                      Country = "ABD",
                      Trailer = "https://www.youtube.com/watch?v=1Q8fG0TtVAY",
                      Age = 12,
                      Starring = " Gal Gadot, Chris Pine, Connie Nielsen",
                      Creators = "Patty Jenkins",
                      Explane = "Amazon prensesi Diana Price, nam-ı diğer Wonder Woman dünyayı keşfetmek için tropik topraklarını geride bırakıp demir ve camın hüküm sürdüğü dünyamıza dalar. Birçok inanüstü yetenek ve kıvrak bir zekayla donatılmış olan güzel kahraman Cennet Adası'nın medeniyete açılan kapısı olacaktır.Wonder Woman'ın yönetmen koltuğunda Patty Jenkins oturuyor. Filmin senaryosunu Allan Heinberg ve Geoff Johns kaleme alırken filmin süper kahraman kadınını Batman vs Superman: Adaletin Şafağı filminde olduğu gibi yine Gal Gadot canlandırıyor. Filmin kadrosunda Connie Nielsen, Chris Pine, Robin Wright ve David Thewlis gibi başarılı isimler bulunuyor.",
                      Imdb = "7.4",
                      PictureSource = "wikipedia.org",
                      TextMovieSource = "beyazperde.com"
                  },
                  new Hollywood1
                  {
                      Id = Guid.NewGuid(),
                      Name = "Operasyon: Argo",
                      Minute = 119,
                      Url = "https://upload.wikimedia.org/wikipedia/tr/e/e1/Argo2012Poster.jpg",
                      Category = "Gerilim, Dram, Tarih",
                      Year = 2012,
                      Country = "ABD",
                      Trailer = "https://www.youtube.com/watch?v=JW3WfSFgrVY",
                      Age = 12,
                      Starring = " Ben Affleck, Bryan Cranston, John Goodman",
                      Creators = "Ben Affleck",
                      Explane = "1979 yılında 4 Kasım tarihinde Şah'ın devrildiği İran devriminin en yoğun günlerinde, militanlar başkent Tahran’daki Amerikan Büyük Elçilik binasına girip 52 Amerikalı’yı rehin alırlar. O hengamede kaçmayı başaran 6 Amerikan vatandaşı Kanada Elçiliği’ne sığınır ve hayatları halen tehlikededir. Her an yakalanma ve öldürülme tehlikesiyle karşı karşıyadırlar. CIA uzmanı Tony Mendez bu Amerikan vatandaşlarını kurtarmak amacıyla bir film senaryosuna yakışır oldukça riskli bir plan hazırlar...Filmin hem başrolünü hem yönetmenliğini üstlenen Ben Affleck imzalı yapımda ünlü oyuncuya Alan Arkin,John Goodman,Kerry Bishé,Kyle Chandler,Rory Cochrane ve Christopher Denham gibi isimler eşlik ediyor.Senaryo ise Antonio Mendez’in 'Master In Disguise' adlı kitabının bazı bölümlerinden esinlenerek Chris Terrio tarafından kaleme alındı.",
                      Imdb = "7.7",
                      PictureSource = "wikipedia.org",
                      TextMovieSource = "beyazperde.com"
                  },
                  new Hollywood1
                  {
                      Id = Guid.NewGuid(),
                      Name = "Kapan",
                      Minute = 104,
                      Url = "https://www.filmler.com/wp-content/uploads/2021/11/kapan-600x900.jpg",
                      Category = "Korku",
                      Year = 2017,
                      Country = "ABD",
                      Trailer = "https://www.youtube.com/watch?v=Ivl9YVTgsag",
                      Age = 18,
                      Starring = " Daniel Kaluuya, Allison Williams, Catherine Keener",
                      Creators = " Jordan Peele",
                      Explane = "Chris sıradan bir siyahi gençtir. Sevgilisi Rose ile mutlu bir ilişkisi vardır. Rose bir gün Chris'i ailesinin mülküne davet eder. Avrupalı Amerikalı sevgilisinin ailesinde bir tuhaflık olduğunu sezen Chris bir süre sonra mülkte kalmakta olan siyahi kişilerin bir bir kaybolduğunu öğrenir. Bunun üzerine tuz biber olan şey ise başka bir siyahi adamın kendisine iş işten geçmeden gitmesi yönündeki uyarısı olur. Chris bir şeylerin ters gittiğini sezmeye başladığında kurtulması sandığından çok daha zor olacaktır...Jordan Peele imzalı korku türündeki yapımın başrollerini Daniel Kaluuya,Allison Williams,Bradley Whitford üstleniyor.",
                      Imdb = "7.7",
                      PictureSource = "filmler.com",
                      TextMovieSource = "beyazperde.com"
                  },
                  new Hollywood1
                  {
                      Id = Guid.NewGuid(),
                      Name = "Birdman",
                      Minute = 119,
                      Url = "https://tr.web.img4.acsta.net/r_1280_720/pictures/14/10/15/12/19/595442.jpg",
                      Category = "Komedi, Dram",
                      Year = 2015,
                      Country = "ABD",
                      Trailer = "https://www.youtube.com/watch?v=uJfLoE6hanc",
                      Age = 12,
                      Starring = " Michael Keaton, Zach Galifianakis, Edward Norton",
                      Creators = " Alejandro González Iñárritu",
                      Explane = "Bir dönemin 'Birdman' adlı süper kahraman filmleri serisiyle ünlenen oyuncusu Riggan, Broadway'de kendi yönettiği ve başrolünde yer aldığı bir oyunun son hazırlıklarını yapmaktadır. Ancak provalar esnasında oyunculardan biri beklenmedik bir biçimde yaralanır ve yerinin acil olarak doldurulması gerekir. Lesley ve onun en yakın arkadaşı olan Jake'in önerisiyle bir zamanların gözde yıldızı olan Mike Shiner ile anlaşılır. Riggan sahneye çıkma hazırlıkları yaparken en başta Mike Shiner ardından ise oyuncu olan sevgilisi Laura, kişisel asistanlığını yürüten kızı Sam ve mükemmeliyetçi eski karısı Sylvia baş etmek durumunda kalır. Riggan kendine yeniden prestij kazandırmasını beklediği bu oyunu, beklentilerin aksine olumlu tepkiler kazanması için elinden geleni yapacaktır.Başrolde Micheal Keaton'ı seyredeceğimiz filmde ünlü aktöre Edward Norton, Naomi Watts, Zach Galifianakis, Andrea Riseborough ve Emma Stone eşlik ediyor. Kara komedi türündeki bu film, Paramparça Aşklar Köpekler (2000), 21 Gram (2003), Babil (2006), Biutiful (2010) gibi farklı yapımlarla karşımıza çıkmış olan Meksikalı sinemacı Alejandro G. Iñárritu'nun imzasını taşıyor.",
                      Imdb = "7.7",
                      PictureSource = "beyazperde.com",
                      TextMovieSource = "beyazperde.com"
                  },
                   new Hollywood1
                   {
                       Id = Guid.NewGuid(),
                       Name = "Gizli Sayılar",
                       Minute = 127,
                       Url = "https://upload.wikimedia.org/wikipedia/tr/4/4f/The_official_poster_for_the_film_Hidden_Figures%2C_2016.jpg",
                       Category = "Dram, Biyografik",
                       Year = 2017,
                       Country = "ABD",
                       Trailer = "https://www.youtube.com/watch?v=WBpA0WChbDY",
                       Age = 12,
                       Starring = " Taraji P. Henson, Octavia Spencer, Janelle Monáe",
                       Creators = " Theodore Melfi",
                       Explane = "Katherine G. Johnson, Dorothy Vaughan ve Mary Jackson tarihin anlatılmayan hikayelerinden birine sahiptir. 3 siyahi kökenli kadın NASA'da büyük işlere imza atmaktalardır. Uzay ve bilimlerinin derinliklerindeki sorunları müthiş zekalarıyla çözmeye çalışan bu kadınlar gelmiş geçmiş en önemli NASA operasyonlarından birinde de büyük rol oynayacaklardır. Dünya yörüngesine çıkan ilk Amerikalı astronot John Glenn'in bütün dünyayı heyecana boğan operasyondaki her adımı bu 3 zeki bilim kadınının yardımıyla olacaktır.Yönetmen koltuğunda Theodore Melfi'nin oturduğu Gizli Sayılar filmi dramatik-biyografik yapımların bir örneği. Filmin başrollerini Taraji P. Henson, Octavia Spencer ve Janelle Monáe üstlenirken filmin kadrosunda ise Kevin Costner, Kirsten Dunst, Jim Parsons, Mahershala Ali, Aldis Hodge ve Glen Powell gibi başarılı isimler yer alıyor.",
                       Imdb = "7.8",
                       PictureSource = "wikipedia.org",
                       TextMovieSource = "beyazperde.com"
                   },
                   new Hollywood1
                   {
                       Id = Guid.NewGuid(),
                       Name = "Harry Potter ve Ölüm Yadigarları: Bölüm 1",
                       Minute = 145,
                       Url = "https://upload.wikimedia.org/wikipedia/tr/1/10/Harry_Potter_and_the_Deathly_Hallows_Part_1_%28film%2C_2010%29.jpg",
                       Category = "Fantastik, Macera",
                       Year = 2010,
                       Country = "ABD",
                       Trailer = "https://www.youtube.com/watch?v=MxqsmsA8y5k",
                       Age = 12,
                       Starring = " Daniel Radcliffe, Rupert Grint, Emma Watson",
                       Creators = "David Yates",
                       Explane = "Hogwarts'ın maceraperest talebeleri Harry, Ron ve Hermione; Voldemort'un ölümsüzlük sırrını barındıran Hortkuluklar'ın izini sürmek amacındadırlar. Bu şer odağını yoketmek görevini üstlenerek yola çıkan kahramanlarımız, profesörlerinin yönlendirmelerinden uzak ve Dumbledore'un korumasından muaf, tek başlarına yola çıkmışlardır. Üç can dost şimdi herzamankinden daha fazla birbirlerine güvenmek zorundadır. Ancak, onları tehdit ederek ayrı düşmelerini sağlamak isteyen Karanlık Güçler de fitne çıkarmak için peşlerindedir. Bu arada, büyücülük dünyası Karanlık Lord'un tüm düşmanları için tehlikeli bir yer haline dönüşmüştür. Uzun zamandır korkulan savaş başlamış ve Voldemort'un Ölüm Yiyicileri Büyü Bakanlığı'nın kotrolünü zorla ele geçirerek terör estirmektedir. Kendilerinden olmayan herkesi tutuklamaktadırlar. Ama, Voldemort için en değerli olan ganimeti; Harry Potter'i bir türlü ele geçiremezler. Seçilmiş kişi artık aranan kişidir ve Ölüm Yiyiciler Voldemort'a canlı olarak teslim etmek üzere onu aramaktadırlar. Harry'nin tek umudu Voldemort onu bulmadan önce Hortkuluklar'ı bulmaktır. Ama, ipuçlarını araştırdıkça neredeyse unutulmuş olan eski bir efsaneyi ortaya çıkartır. Ölüm Yadigarları'nın efsanesi. Eğer bu efsane gerçekleşirse, Voldemort aradığı üstün güce erişebilecektir. Aslında Harry'nin geleceği, geçmişte yaşadığı ve tüm geleceğini etkileyen sağ kalan çocuk olduğu kader günü de belirlenmiştir. O, artık sadece bir çocuk değildir, Harry Potter, Hogwarts'a ilk adımını attığı günden beri hazırlanmakta olduğu Voldemort'la nihai mücadelesine giderek daha da yaklaşmaktadır.",
                       Imdb = "7.7",
                       PictureSource = "wikipedia.org",
                       TextMovieSource = "beyazperde.com"
                   },
                   new Hollywood1
                   {
                       Id = Guid.NewGuid(),
                       Name = "Aşıklar Şehri",
                       Minute = 128,
                       Url = "https://upload.wikimedia.org/wikipedia/tr/thumb/2/20/La_La_Land_%28film%29.jpg/330px-La_La_Land_%28film%29.jpg",
                       Category = "Müzikal, Romantik",
                       Year = 2016,
                       Country = "ABD",
                       Trailer = "https://www.youtube.com/watch?v=0pdqf4P9MB8",
                       Age = 12,
                       Starring = " Ryan Gosling, Emma Stone, John Legend",
                       Creators = "Damien Chazelle",
                       Explane = "Aşıklar Şehri, yolları kesişen iki insanın hikayesini anlatıyor. Hayatlarında yön bulmaya çalışan iki tutkulu insan Sebastian ve Mia'nın yolları, Los Angeles'ta trafiğin sıkışık olduğu bir gün kesişir. Her ikisi de sanat tutkunu olan bu iki insan, hayallerini gerçekleştirme yolunda düşe kalka ilerlemektedir. Sebastian gelenekseksel jazzın kolonlardan yükseldiği bir kulüp açma hayalinde,Mia ise kafesinde çalıştığı film platosunda kendine uygun tüm oyunculuk seçmelerine katılarak bir rol kapma telaşındadır.Bu iki insanın kalpleri birbiri için atmaya başladığında ortaya çıkan manzarayı hayat şartları bozacak,onları yavaş yavaş hayallerinden uzaklaştırmaya başlayacaktır.Oscar ödüllü Whiplash’in yazarı Damien Chazelle’in yazıp yönettiği bu romantik müzikal,modern zamana adanmış bir Hollywood masalı.",
                       Imdb = "8.0",
                       PictureSource = "wikipedia.org",
                       TextMovieSource = "beyazperde.com"
                   },
                   new Hollywood1
                   {
                       Id = Guid.NewGuid(),
                       Name = "12 Yıllık Esaret",
                       Minute = 133,
                       Url = "https://upload.wikimedia.org/wikipedia/tr/thumb/5/5c/12_Years_a_Slave_film_poster.jpg/330px-12_Years_a_Slave_film_poster.jpg",
                       Category = "Dram",
                       Year = 2014,
                       Country = "ABD",
                       Trailer = "https://www.youtube.com/watch?v=MCBtgwM-baw",
                       Age = 12,
                       Starring = " Chiwetel Ejiofor, Michael Fassbender, Benedict Cumberbatch",
                       Creators = " Steve McQueen (II)",
                       Explane = "12 Yıllık Esaret, özgürlüğünü geri kazanmaya çalışan bir adamın hikayesini anlatıyor. 1841'de New York'ta yaşayan Solomon Northup, kendisini müziğe adamış siyahi bir adamdır. Ailesiyle birlikte yaşayan Solomon, özgür yaşayan ve istediği şeyleri yapabildiği için mutlu bir adamdır. Fakat bir gün bir müzik işi için 2 adam ile tanışır ve çalışmak için Washington'a gider. İnandığı medeni dünya alt üst olur çünkü kendisini kaçırıp Güney'de bir çiflikte köle olarak çalışması için satarlar. Özgürlüğünü korumak için verdiği tüm emekler ve mücadele yerle bir olmuş, hayatı kabusa dönmüştür. Bu cehennemde Solomon acıyı, şiddeti, küçük düşürülmeyi yeniden öğrenecek ve isyan etmeye cesareti olmayan br grup insanın umutsuzluğuna şahit olacaktır. Sevdiklerini ve hayatını geri almak için ne yapması gerektiğini kesinlikle bulmuştur...İngiliz sinemacı Steve McQueen'in yönetmenliğini ve John Ridley ile birlikte senaristliğini üstlendiği filmin oyuncu kadrosunda Michael Fassbender'ın yanı sıra Brad Pitt,Benedict Cumberbatch,Paul Giamatti gibi yıldızlar da yer alıyor.",
                       Imdb = "8.1",
                       PictureSource = "wikipedia.org",
                       TextMovieSource = "beyazperde.com"
                   },
                   new Hollywood1
                   {
                       Id = Guid.NewGuid(),
                       Name = "Avengers: Endgame",
                       Minute = 181,
                       Url = "https://upload.wikimedia.org/wikipedia/en/0/0d/Avengers_Endgame_poster.jpg",
                       Category = "Aksiyon, Fantastik, Macera",
                       Year = 2019,
                       Country = "ABD",
                       Trailer = "https://www.youtube.com/watch?v=TcMBFSGVi1c",
                       Age = 12,
                       Starring = " Robert Downey Jr., Chris Evans, Mark Ruffalo",
                       Creators = "Joe Russo, Anthony Russo",
                       Explane = "'Avengers Infinity War'un ardından pek çok süper kahraman küle dönüşmüştür. Doktor Strange, Gamora, Drax, Mantis, genç Örümcek Adam, Black Panther, Bucky Barnes, Groot, Scarlet Witch, Vision, Star Lord, Maria Hill, The Wasp ve Nick Fury gibi pek çok kahraman, Thanos'un Sonsuzluk Eldiveni'ni ele geçirmesi ve kendi dengesini kurması yüzünden yok olmuştur ve dünya umutsuz haldedir. Dünya üzerinde kalan Black Widow, Kaptan Amerika, Thor ve Hulk kendi yaslarını tutmaktayken, Iron ve Nebula ise kontrol edemedikleri bir uzay gemisinin içinde, uzay boşluğunda sürüklenmektedirler. Süper kahramanlar takımı için işler pek de iyi görünmemektedir. Ancak Kuantum Bölgesi'nden çıkmanın bir yolunu bularak Avengers ekibinin kalan üyelerine giden Ant-Man, yeni bir umut ışığı olacaktır. Daha önce var olduğunu bilmedikleri bölgeler, kahramanlar ve evrenlerin varlığını öğrenen ekip, Thanos'un kurduğu bu çarpık dengeyi değiştirmek ve kendilerinden alınanı geri getirmek için hayatlarının en büyük mücadelesine girişeceklerdir. Hepsi kişisel olarak önem verdikleri şeyleri kaybetmiş olan kahramanlarımız için intikam vakti gelmiştir.",
                       Imdb = "8.4",
                       PictureSource = "wikipedia.org",
                       TextMovieSource = "beyazperde.com"
                   }
                  );
        }
    }
}
