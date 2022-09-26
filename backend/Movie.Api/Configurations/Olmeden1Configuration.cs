using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Movie.Api.Models.Entities;

namespace Movie.Api.Configurations
{
    public class Olmeden1Configuration : IEntityTypeConfiguration<Olmeden1>
    {
        public void Configure(EntityTypeBuilder<Olmeden1> builder)
        {
            builder.HasData(
                    new Olmeden1
                    {
                        Id = Guid.NewGuid(),
                        Name = "CODA",
                        Minute = 111,
                        Url = "https://upload.wikimedia.org/wikipedia/en/thumb/8/89/Coda_poster.jpeg/220px-Coda_poster.jpeg",
                        Category = "Komedi, Drama",
                        Year = 2021,
                        Country = "ABD",
                        Trailer = "https://www.youtube.com/watch?v=0pmfrE1YL4I",
                        Age = 12,
                        Starring = "Emilia Jones, Eugenio Derbez,Troy Kotsur,Ferdia Walsh - Peelo",
                        Creators = "Sian Heder",
                        Explane = "Geçimini balıkçılık yaparak kazanan bir ailenin hikayesini anlatan CODA (2021), teknede babası ve erkek kardeşiyle birlikte çalışan Ruby’nin radyoda çalan şarkıya eşlik ettiği bir sahneyle açılıyor. Bu neşeli şarkı ve enerjik açılış sahnesi son derece tanıdık; hemen Ruby’nin sürekli bir işten diğerine koştuğunu, çok sevdiği ailesine yardımcı olduğunu, balığa düşük fiyat veren toptancılarla uğraştığını anlıyoruz. Ruby bütün sorumluluklarıyla baş etmekte o kadar zorlanıyor ki tekneden ayrılıp okula gittiği zaman sınıfta uyuyakalıyor, arkadaşlarına ve hobilerine ayıracak vakit bulamıyor. Okulda hoşlandığı çocuğu uzaktan izleyip duruyor ama popüler olmadığı ve özgüven sıkıntısı yaşadığı için gidip onunla konuşamıyor. Yani kısacası daha ilk beş dakikada fark ediyoruz ki Ruby yüzlerce Amerikan filminde gördüğümüz klişe liseli karakterlere hayli benziyor. Ama Ruby’yi yaşıtlarından ayıran ve filme belli bir ilginçlik ya da önem kazandıran bir nokta var: O, işitme engelli bir anne babanın duyma yetisine sahip tek çocuğu ve ailesinin daimi işaret dili tercümanı.",
                        Imdb = "8.0",
                        PictureSource = "wikipedia.org",
                        TextMovieSource = "altyazi.net"
                    },
                    new Olmeden1
                    {
                        Id = Guid.NewGuid(),
                        Name = "Nomadland",
                        Minute = 107,
                        Url = "https://upload.wikimedia.org/wikipedia/en/thumb/a/a5/Nomadland_poster.jpeg/220px-Nomadland_poster.jpeg",
                        Category = "Dram",
                        Year = 2020,
                        Country = "ABD",
                        Trailer = "https://www.youtube.com/watch?v=6sxCFZ8_d84",
                        Age = 12,
                        Starring = "Frances McDormand, David Strathairn, Linda May",
                        Creators = "Chloé Zhao",
                        Explane = "Nomadland Chloé Zhao'nun senaryosunu yazdığı, yapımcılığını üstlendiği ve yönettiği 2020 Amerikan drama filmidir. Filmde Frances McDormand, kocası öldükten sonra memleketi Nevada'dan ayrılan ve 'evsiz' kalıp, Amerika Birleşik Devletleri'ni dolaşan bir kadın olarak rol alıyor. Aynı zamanda yardımcı rolde David Strathairn'in yanı sıra gerçek hayattaki göçebe Linda May, Swankie ve Bob Wells'i kendilerinin kurgulanmış versiyonları olarak gösteriyor. Film, Jessica Bruder tarafından yazılan 2017 yılı kurgusal olmayan Nomadland: Surviving America in the Twenty-First Century adlı kitabına dayanıyor.Nomadland,11 Eylül 2020'de Altın Aslan'ı kazandığı Venedik Film Festivali'nde prömiyer yaptı. Ayrıca Toronto Uluslararası Film Festivali'nde Halkın Seçimi Ödülü'nü kazandı. 4 Aralık 2020'de bir haftalık sınırlı yayını vardı ve Searchlight Pictures tarafından 29 Ocak 2021'de Amerika Birleşik Devletleri'nde seçilen IMAX sinemalarında ve aynı anda 19 Şubat 2021'de Hulu'da sinemalarda ve dijital olarak gösterime girdi.Film,yönetmenliği,senaryosu,kurgusu,sinematografisi ve performansları,özellikle de McDormand'ın performansından dolayı evrensel övgü ile eleştirel beğeni topladı ve Metacritic'te 2020'nin üçüncü en yüksek puanı alan filmi oldu.[6] 2020'nin en iyi filmlerinden biri olarak eleştirmenler ve yayıncılar tarafından en çok derecelendirilen film oldu.Film 93.Akademi Ödülleri'nde En İyi Film, En İyi Yönetmen ve En İyi Kadın Oyuncu McDormand dahil olmak üzere altı adaylık kazandı.[7] Ayrıca 78. Altın Küre Ödüllerinde En İyi Film - Drama ve En İyi Yönetmen ödüllerinde dört aday; Zhao ikinci ödülü kazanan ikinci kadın ve bunu yapan ilk Asyalı kadın oldu.[8]",
                        Imdb = "7.3",
                        PictureSource = "wikipedia.org",
                        TextMovieSource = "wikipedia.org"
                    },
                    new Olmeden1
                    {
                        Id = Guid.NewGuid(),
                        Name = "Don’t Look Up",
                        Minute = 142,
                        Url = "https://upload.wikimedia.org/wikipedia/tr/thumb/5/53/Don%27t_Look_Up_%28film%2C_2021%29.jpg/330px-Don%27t_Look_Up_%28film%2C_2021%29.jpg",
                        Category = "Komedi",
                        Year = 2021,
                        Country = "ABD",
                        Trailer = "https://www.youtube.com/watch?v=1oUfDr2R54Y",
                        Age = 12,
                        Starring = " Leonardo DiCaprio, Jennifer Lawrence, Meryl Streep",
                        Creators = " Adam McKay",
                        Explane = "Don’t Look Up, dev bir göktaşının gezegeni yok edeceği konusunda insanları uyarmak için çalışan iki gökbilimcinin hikayesini konu ediyor. İnsanlık büyük bir tehlike ile karşı karşıyadır. Everest Dağı büyüklüğünde bir kuyruklu yıldız hızla Dünya'ya yaklaşmaktadır ve oluşacak çarpışma Dünya'nın yok olmasına neden olacaktır. Astronomi yüksek lisans öğrencisi olan Kate Dibiasky'nin yaptığı bu keşif, insanlığın kurtulmasını sağlayacaktır. Kate ve Dr. Randall Mindy, insanlığı yaklaşmakta olan tehlikeye karşı uyarlamak için bir medya turuna çıkmaya karar verir. Kare ve Randall, insanları yaklaşan felaketten haberdar etmek için büyük çaba harcarken kendilerini beklenmedik durumların içinde bulur.",
                        Imdb = "7.2",
                        PictureSource = "wikipedia.org",
                        TextMovieSource = "beyazperde.com"
                    },
                    new Olmeden1
                    {
                        Id = Guid.NewGuid(),
                        Name = "Snowpiercer",
                        Minute = 126,
                        Url = "https://upload.wikimedia.org/wikipedia/tr/6/65/Snowpiercer_film_posteri.jpg",
                        Category = "Dram, Bilimkurgu",
                        Year = 2013,
                        Country = "ABD",
                        Trailer = "https://www.youtube.com/watch?v=nX5PwfEMBM0",
                        Age = 12,
                        Starring = " Chris Evans, Jamie Bell, Tilda Swinton",
                        Creators = "Bong Joon Ho",
                        Explane = "Gelecekte başarısızlığa uğrayan bir deney büyük bir felaketle sonuçlanır ve yeryüzündeki yaşamı büyük ölçüde bitiren bir küresel ısınma olur. Dünyanın çevresinde kesintisiz bir güçle dönen bir tren hayatta kalan insanların son sığınağı olacaktır. Fakat güç bela yaşamın sürdüğü bu yeni dünyada sınıfsal farklılıklar halen en büyük silahtır... Yönetmenliğini Koreli sinemacı Joon-ho Bong'un üstlendiği 'kıyamet sonrası' temalı filmin kadrosu, Chris Evans, Jamie Bell, Tilda Swinton, John Hurt, Ed Harris ve Octavia Spencer gibi yıldız isimler oluşuyor.",
                        Imdb = "7.1",
                        PictureSource = "wikipedia.org",
                        TextMovieSource = "beyazperde.com"
                    },
                    new Olmeden1
                    {
                        Id = Guid.NewGuid(),
                        Name = "Kazı",
                        Minute = 112,
                        Url = "https://upload.wikimedia.org/wikipedia/tr/9/97/The_Dig_poster.jpg",
                        Category = "Dram, Tarihi",
                        Year = 2021,
                        Country = "ABD",
                        Trailer = "https://www.youtube.com/watch?v=zLXUKQu_fb0",
                        Age = 12,
                        Starring = " Ralph Fiennes, Carey Mulligan, Lily James",
                        Creators = "Simon Stone",
                        Explane = "Zengin bir dul olan Edith Pretty, İkinci Dünya savaşının yaklaştığı dönemde, arazinin içinde yer alan mezar höyüklerinde kazı yapılmasını ister. Pretty bunun için Basil Brown adında bir arkeologla anlaşır. Çok geçmeden kazı sırasında insanlık tarihini etkileyecek bir keşif yaparlar. Geçmişe dair yaptıkları bu keşifte elde ettikleri bulgular, geleceği muallakta olan Britanya'da büyük ses getirir.",
                        Imdb = "7.1",
                        PictureSource = "wikipedia.org",
                        TextMovieSource = "beyazperde.com"
                    },
                    new Olmeden1
                    {
                        Id = Guid.NewGuid(),
                        Name = "Tenet",
                        Minute = 150,
                        Url = "https://upload.wikimedia.org/wikipedia/tr/thumb/2/20/Tenet_filminin_g%C3%BCncel_T%C3%BCrk%C3%A7e_afi%C5%9Fi.jpg/607px-Tenet_filminin_g%C3%BCncel_T%C3%BCrk%C3%A7e_afi%C5%9Fi.jpg?20200827101807",
                        Category = "Aksiyon",
                        Year = 2020,
                        Country = "ABD",
                        Trailer = "https://www.youtube.com/watch?v=LdOM0x0XDMo",
                        Age = 12,
                        Starring = "John David Washington, Kenneth Branagh, Robert Pattinson",
                        Creators = " Christopher Nolan",
                        Explane = "Tenet, dünyayı büyük bir tehlikeden kurtarmak için savaşan bir kahramanın hikayesini konu ediyor. Gerçek zamanın ötesinde bir yerde uluslararası bir casusluk görevini yerine getirmeye çalışan kahraman, dünyayı kurtarabilmek için savaşmak zorunda kalır. Üçüncü Dünya Savaşı’ndan daha büyük bir tehlikeyi durdurmaya çalışan kahraman, casusun alacakaranlık dünyasında zorlu bir yolculuğa çıkar.",
                        Imdb = "7.3",
                        PictureSource = "wikipedia.org",
                        TextMovieSource = "beyazperde.com"
                    },
                    new Olmeden1
                    {
                        Id = Guid.NewGuid(),
                        Name = "Zodiac",
                        Minute = 157,
                        Url = "https://upload.wikimedia.org/wikipedia/en/thumb/3/3a/Zodiac2007Poster.jpg/220px-Zodiac2007Poster.jpg",
                        Category = "Suç, Dram",
                        Year = 2007,
                        Country = "ABD",
                        Trailer = "https://www.youtube.com/watch?v=yNncHPl1UXg",
                        Age = 12,
                        Starring = " Jake Gyllenhaal, Mark Ruffalo, Anthony Edwards",
                        Creators = " David Fincher",
                        Explane = "San Francisco’da bir seri katil, farklı gazetelere mesajlar göndererek işlediği cinayetleri itiraf eder. Katil, gönderdiği mesajların yayınlanmasını ister; aksi taktirde daha fazla insanı öldürecektir. Genç ve utangaç bir gazete karikatüristi olan Robert Graysmith, gazetesine gönderilen mesajların ardından katil ile ilgili araştırmalara başlar. Zodiac olarak adlandırılan katilin peşine düşen muhabir Paul Avery, müfettiş David Toschi ve William Armstron katilin ayak izlerini takip etseler de bir sonuca varamaz. Yetkililer yavaş yavaş davadan çekilseler de Robert Graysmith, katili yakalamayı takıntı haline getirir.",
                        Imdb = "7.7",
                        PictureSource = "wikipedia.org",
                        TextMovieSource = "beyazperde.com"
                    },
                    new Olmeden1
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rüzgârı Dizginleyen Çocuk",
                        Minute = 113,
                        Url = "https://www.netflixfullizle.com/wp-content/uploads/2020/02/the-boy-who-harnessed-the-wind-ruzgari-dizginleyen-cocuk-2019.jpg",
                        Category = "Dram",
                        Year = 2021,
                        Country = "ABD",
                        Trailer = "https://www.youtube.com/watch?v=nPkr9HmglG0",
                        Age = 12,
                        Starring = "Chiwetel Ejiofor, Maxvell Simba, Felix Lemburo",
                        Creators = "Chiwetel Ejiofor",
                        Explane = "Film, 5 Ağustos 1987 de doğan ve üç çocuğu olan yoksul bir ailenin ikinci çocuğu olan William Kamkwamba’nın hayatındaki zorluklarla baş ederek bir başarıya imza atmasını konu edinmektedir. Evin terk erkek çocuğu olan William’ın 2 kız kardeşinden büyük olan kardeşi Annie üniversiteye gitmeye hazırlanmakta diğer kardeşi ise henüz kundakta bir bebektir. William ise ilköğretim okulunda 8. Sınıfı tamamladıktan sonra Kachokolo lisesine kabul edilmiştir fakat okula kabul edilişinin ardından ülkede büyük bir kıtlık hüküm süremeye başlar. Okula her ay para ödemek zorunda kalan Kamkwambaa ailesi kıtlık başlangıcıyla birlikte okul ücretini ödeyemeyecek duruma düşer ve bu esnada Willam okul ücretinin ödenmemesi sonucu okulu bırakmak zorunda kalır.Kıtlıkla birlikte ülkede ölümün ve açlığın kol gezmeye başlamasıyla birlikte şehir halkı bunun için bir direniş göstermek ister ve şehirdeki ağaçların kesilerek ağaçların satılmasını isterler.William’ın babası Trywell,ağaçlar giderse sele yakalanırız diyerek buna her ne kadar karşı çıkmaya çalışsa da insanlara engel olamaz.Ağaçların kesilip satılması,sele yakalanmaları,mahsullerinin yarısından fazlasını kaybetmeleri,ellerinde kalan son mahsulün de çalınması gibi olaylarla burun buruna gelen aile bitap düşer ve son çare olarak devletin tahıllarından bir çuval alarak bununla bir yıl idare etmenin eşiğine gelir.Bu olayların yaşandığı esnada William sürekli okuluna gidip fen derslerine girmek ve yaşadığı şehir için bir şeyler yapmak ister.Bunun üzerine bir gün Fen öğretmeniyle konuşarak eski okulunun kütüphanesinden faydalanmak ister ve kütüphaneye gittiğinde “Enerjiyi Kullanmak” adlı kitap ile tanışır.Kitap ile tanışmasının ardından William,kitaptaki bilgileri pratiğe dökmeye başlar ve bir rüzgar tribünü yapmaya karar verir.İlk olarak “Rüzgar tribünü nasıl yapılır ?” sorusuna cevap arayan William,çalışmasında ilk adımı  atarak tribünü yapmaya başlar.Rüzgar tribünün suyu tekrar şehirlerine getireceğinin inancıyla arkadaşlarından yardım isteyen William, babasının da bu çalışmalarına katkı sağlamasını ister fakat babası ilk aşamada William’ın bu çağrısına kulak vermez.Sonrasında anne Kamkwamba,Trywell’e artık bu saatten sonra ellerinden bir şey gelmeyeceğini William’ın son çaresine kulak vermeleri gerektiğini açıklar açıklamaz Trywell ve şehirdeki tüm rüzgar tribünü yapmak için göreve koyulurlar.Tam bu esnada hayatlarını değiştirecek o sesi duyarlar ve bu ses “su” sesidir.Tüm şehir halkı için her şey o zaman daha başka hal alacaktır.Ayrıca izleyiciyi gözyaşlarına boğacak ve o masumane duygusal bakışı kazandıracak anları belki de bu sahnelerde şahit olacaksınız.Gerçek Kahramanımız William Kamkwamba bu yaşadıklarını şöyle dile getirir;“Okulu bıraktıktan sonra, kütüphaneye gittim, bir kitap aldım ve okudum. Bu kitaptan rüzgar tribünü yapmak için bilgiler edindim. Denedim ve yaptım.”Kahramanımız, ailesiyle birlikte yaşadığı eve elektrik getirebilmek için rüzgar tribünü yaparak evlerine bu elektriği getirmeyi başarmıştır.Yaptığı tribün ile ilk zamanlarda 12 W elektrik enerjisi üretmiş ve bu elektrik onun 4 ampul ile 2 radyoyu çalıştırabilmesine yetecek kadardı.",
                        Imdb = "7.6",
                        PictureSource = "netflixfullizle.com",
                        TextMovieSource = "ozetivar.com"
                    },
                    new Olmeden1
                    {
                        Id = Guid.NewGuid(),
                        Name = "Minari",
                        Minute = 116,
                        Url = "https://upload.wikimedia.org/wikipedia/en/8/8a/Minari_%28film%29.png",
                        Category = "Dram",
                        Year = 2020,
                        Country = "ABD",
                        Trailer = "https://www.youtube.com/watch?v=RyRA75xnoBM",
                        Age = 12,
                        Starring = "Steven Yeun, Ye-Ri Han, Alan S. Kim",
                        Creators = " Lee Isaac Chung",
                        Explane = "Minari, kırsal bir bölgeye taşınan bir ailenin hayatına odaklanıyor. 1980’li yıllarda 7 yaşındaki Kore kökenli Amerikalı David, babası Jacob’un isteği üzerine annesi ve kardeşi ile birlikte Arkansas’ta kırsal bir bölgeye taşınır. Aile, burada yeni bir çevre ve yaşam tarzı ile karşı karşıya kalır. David’in annesi Monica, hiçliğin ortasındaki bu mobil evde yaşamaktan dolayı korkulara kapılırken, David ve kız kardeşi yeni hayatlarından eper sıkılır. Bu sırada aileye, onlarla birlikte yaşamak için Kore’den gelen büyükanne de katılır. Jakob, dokunulmamış toprakta bir çiftlik yaratmaya çalışırken, ailesini ve evliliğini tehlikeye atmaya başlar.",
                        Imdb = "7.4",
                        PictureSource = "wikipedia.org",
                        TextMovieSource = "beyazperde.com"
                    },
                    new Olmeden1
                    {
                        Id = Guid.NewGuid(),
                        Name = "Sessiz Bir Yer",
                        Minute = 90,
                        Url = "https://upload.wikimedia.org/wikipedia/tr/a/a0/A_Quiet_Place_film_poster.png",
                        Category = "Gerilim, Korku",
                        Year = 2018,
                        Country = "ABD",
                        Trailer = "https://www.youtube.com/watch?v=7QFMIPRs2Lc",
                        Age = 12,
                        Starring = "Emily Blunt, John Krasinski, Millicent Simmonds",
                        Creators = "John Krasinski",
                        Explane = "2 çocuklu bir aile, izole bir kırsalda sakin bir yaşam sürmektedir. Henüz büyüme çağlarında olan çocuklar da, ebeveynleri de hiçbir şekilde konuşmamakta, işaret diliyle anlaşmaktadır. Ancak bunun sebebi konuşamıyor olmaları değildir. Aile gıcırtı çıkaracak her türlü adımdan, ses yapacak her türlü hareketten uzak durmaktadır. Ancak günün birinde bu sakin hayat, küçük çocukların oyun oynarken bir lambayı devirmeleri ile tepetaklak olur. Durgun sessizliğin içinde çıkan bu ses, ailenin peşindeki varlığın dikkatini hemen çekecek ve aile sessizliklerini bozmanın bedelini ağır ödeyecektir...",
                        Imdb = "7.5",
                        PictureSource = "wwikipedia.org",
                        TextMovieSource = "beyazperde.com"
                    },
                    new Olmeden1
                    {
                        Id = Guid.NewGuid(),
                        Name = "Belfast",
                        Minute = 98,
                        Url = "https://upload.wikimedia.org/wikipedia/en/thumb/4/4a/Belfast_poster.jpg/220px-Belfast_poster.jpg",
                        Category = "Drama, Biyografi",
                        Year = 2021,
                        Country = "ABD",
                        Trailer = "https://www.youtube.com/watch?v=ONeJcNDIFEk",
                        Age = 12,
                        Starring = "Caitríona Balfe,Judi Dench,Jamie Dornan,Ciarán Hinds",
                        Creators = "Kenneth Branagh",
                        Explane = "Belfast,1960’ların sonunda çalkantılı olaylar yaşayan bir çocuk ve işçi sınıfı ailesinin hayatına odaklanıyor. Dokuz yaşındaki Buddy, tipik bir işçi sınıfı ailesinin oğludur. Belfast'taki sosyo-politik gerilimler tırmandığında ve yaşadıkları barışçıl mahallede bile şiddet patlak verdiğinde, Buddy'nin pastoral çocukluğu kabusa dönüşür. Ailesi geleceklerini güvence altına almak için mücadele ederken Buddy, bu kaos ortamında çok çabuk büyümek zorunda kalır. Ancak her şeye ragmen Buddy, yaşama sevincini, sinemaya ve televizyona olan tutkusunu kaybetmemeye çalışır.",
                        Imdb = "7.3",
                        PictureSource = "wikipedia.org",
                        TextMovieSource = "beyazperde.com"
                    },
                    new Olmeden1
                    {
                        Id = Guid.NewGuid(),
                        Name = "Kelebek Etkisi",
                        Minute = 113,
                        Url = "https://tr.web.img3.acsta.net/pictures/13/12/09/17/40/163759.jpg",
                        Category = "Dram, Fantastik",
                        Year = 2004,
                        Country = "ABD",
                        Trailer = "https://www.youtube.com/watch?v=B8_dgqfPXFg",
                        Age = 12,
                        Starring = " Ashton Kutcher, Amy Smart, Elden Henson",
                        Creators = "Eric Bress, J. Mackye Gruber",
                        Explane = "Yıl 2002... Evan Treborn, özellikle yoğun strese yaşadığı anlarda baygınlık geçirmektedir. Bunun nedeni ise karanlık geçmişidir... Treborn çocukluğunda cinsel tacizlere maruz kalmış ve kuvvetli psikolojik travmalar yaşamıştır. Treborn tesadüf eseri zamanda yolculuk yapıp geçmişe dönebildiğini fark eder ve geçmişinin bu bölümlerini silmek için uğraşmaya başlar. Çocukluğuna geri dönmeyi başaran genç adam geçmişini yeniden kurgulamaya başlar.'Kelebek Etkisi' iki genç yönetmen Eric Bress ve J.Mackye Gruber'ın imzasını taşıyor. Bilim kurgu ve gerilim öğelerini birbirine harmanlayan yapıt gösterime girdiği dönem büyük bir ilgiyle karşılanmıştı.",
                        Imdb = "7.6",
                        PictureSource = "beyazperde.com",
                        TextMovieSource = "beyazperde.com"
                    },

                    new Olmeden1
                    {
                        Id = Guid.NewGuid(),
                        Name = "Otomatik Portakal",
                        Minute = 136,
                        Url = "https://upload.wikimedia.org/wikipedia/tr/0/0f/Aclockwork.jpg",
                        Category = "Suç",
                        Year = 1971,
                        Country = "İngiltere",
                        Trailer = "https://www.youtube.com/watch?v=IoT5mKyT8Ik",
                        Age = 18,
                        Starring = "Malcolm McDowell,Patrick Magee",
                        Creators = "Stanley Kubrick",
                        Explane = "Britanya'da endüstri sonrası bir şehirdeki, ahlaki değerlerin birbirine karıştığı, iyi ve kötünün ayırt edilemez hale geldiği bir toplumda, gençlerden oluşan bir çetenin insanlara uyguladıkları şiddeti ve Alex üzerinden insan doğası ve toplumsal değerlerin çatışmasını konu eder.Bir holigan olan Alex(Malcolm McDowell) adlı gencin zaman geçirmek için üyesi olduğu sokak çetesi ile beraber işledikleri birçok suçtan sonra çete ile ayrılığa düşünce onlar tarafından ihbar edilmesini ve polis tarafından beyninin yıkanarak topluma kazandırılma metodu ve sonrasını anlatır.Olayları büyük bir ifade gücü ile o günlerden bugüne değişen dünya düzeni ve bu değişimin insanların üzerindeki farklı etkilerini,suça ve şiddete eğilimi ustaca yansıtmıştır.Film ve bu filme ait ögeler yarattığı etki ile popüler kültürdeki yerini almıştır.",
                        Imdb = "8.3",
                        PictureSource = "wikipedia.org",
                        TextMovieSource = "wikipedia.org"
                    },
                    new Olmeden1
                    {
                        Id = Guid.NewGuid(),
                        Name = "Bisiklet Hırsızları",
                        Minute = 89,
                        Url = "https://tr.web.img2.acsta.net/pictures/bzp/01/2570.jpg",
                        Category = "Dram",
                        Year = 1948,
                        Country = "İtalya",
                        Trailer = "https://www.youtube.com/watch?v=H2P4xo9kmPM",
                        Age = 12,
                        Starring = "Lamberto Maggiorani, Enzo Staiola, Lianella Carell",
                        Creators = "Vittorio De Sica",
                        Explane = "Bisiklet Hırsızları'nda, savaş sonrası yaşanan iki senelik işsizlik döneminin ardından nihayet iş bulabilen Antonio mutluluktan havalara uçmaktadır. İşi için kendisine lazım olan bisikleti almak için yataklarını satmaları gerekmiştir; ancak Antonio en sonunda para kazanabileceği için mutludur. Yeni işinin ilk gününde bisikleti çalınan Antonio neye uğradığını şaşırır. Yaşadığı ailevi ve dünyevi problemleri çözebilmesi için acilen bisikletine yeniden kavuşması gerekmektedir.İtalyan Yeni Gerçekçiliği’nin mimarlarından Vittorio De Sica’nın imzasını taşıyan Bisiklet Hırsızları,bir savaş sonrası toplumunun portresini oldukça geniş bir perspektiften çiziyor.",
                        Imdb = "8.3",
                        PictureSource = "beyazperde.com",
                        TextMovieSource = "beyazperde.com"
                    },
                    new Olmeden1
                    {
                        Id = Guid.NewGuid(),
                        Name = "Amerikan Rüyası",
                        Minute = 142,
                        Url = "https://tr.web.img4.acsta.net/pictures/bzp/03/5733.jpg",
                        Category = "Dram, Komedi, Fantastik",
                        Year = 1993,
                        Country = "ABD",
                        Trailer = "https://www.youtube.com/watch?v=xR4Aq-p8thE",
                        Age = 12,
                        Starring = " Johnny Depp, Jerry Lewis, Faye Dunaway",
                        Creators = " Emir Kusturica",
                        Explane = "Axel Blackman, ailesi ölünce New York’a yerleşip büyük bir balıkçılık şirketinde tuhaf bir işe girmiştir. İşi balıkları saymaktır! Arizona’da araba satıcısı olan Leo Amca birden ortaya çıkar ve onu memleketine çağırır. Çünkü evlenecektir ve Axel’in nikahta sağdıcı olmasını, sonrasında da işini devralmasını istemektir.Genç adam New York’un antitezi olan Arizona’ya vardığında onu bambaşka renkler beklemektedir.Leo Amca’nın,iki ayrı kadının ve kendisinin hayalleri arasında sıkışıp kalacak mı yoksa çıkış yolunu bulabilecek mi ?Avrupa’daki başarılı kariyeri ardından Amerika topraklarında,Amerikanın usta oyuncularıyla çektiği Arizona Dream,Kustirica’ya 1993 Berlin’inde hem Altın Ayı hem de Jüri Özel Ödülü’nü getirdi.David Atkins’le birlikte yazdıkları öykünün merkezindeki Axel karakteriyle Johnny Depp’in bir kez daha yıldızlaştığını da ekleyelim.",
                        Imdb = "7.2",
                        PictureSource = "beyazperde.com",
                        TextMovieSource = "beyazperde.com"
                    },
                     new Olmeden1
                     {
                         Id = Guid.NewGuid(),
                         Name = "Perde Açılıyor",
                         Minute = 138,
                         Url = "https://upload.wikimedia.org/wikipedia/tr/thumb/2/22/AllAboutEve.jpeg/330px-AllAboutEve.jpeg",
                         Category = "Dram",
                         Year = 1950,
                         Country = "ABD",
                         Trailer = "https://www.youtube.com/watch?v=uRjKPLH2OaQ",
                         Age = 12,
                         Starring = "Bette Davis,Anne Baxter,George Sanders,Celeste Holm",
                         Creators = " 	Joseph L. Mankiewicz",
                         Explane = "Margo Channing, (Bette Davis) ilerleyen yaşını yavaş yavaş belli etmeye başlamış, ününün doruğunda bir Broadway yıldızdır. Sevildiğini bilse de kendisinden sekiz yaş genç olan yönetmen sevgilisi Bill (Gary Merrill) ile olan ilişkisinin geleceğinden endişe etmektedir. En yakın dostları ise Margo'nun oynadığı pek çok oyunun da yazarı olan Lloyd Richards (Hugh Marlowe) ve karısı Karen (Celeste Holm)'dır.Karen,Margo'nun hayranı olan ve onun bütün oyunlarını izlediğini söyleyen Eva Harrington (Anne Baxter) adlı genç bir kızla tanışır. Bir pilot olan kocasını bir kazada kaybettiğini ve hayata yeniden bağlanmasını Margo'nun oyunlarının sağladığını iddia eden bu masum ve alçakgönüllü genç kız,Margo için her şeyi yapmaya hazırdır.Karen tarafından Margo ile tanıştırılan Eve,kısa bir süre içinde Margo'nun evine taşınır ve ona her konuda yardımcı olmaya başlar. Margo'nun yıllardır yanında çalışan yardımcısı Birdie(Thelma Ritter),sinsi ve kurnaz bulduğu Eve'den hiçbir zaman hoşlanmaz; fakat Eve, Birdie dışında herkesin sevgisini kazanmış gibidir.Bette Davis Margo Channing rolündeEve kısa bir süre sonunda kurnazlığı ile Margo'nun yedek oyuncusu olur ve ardından onun yokluğundan faydalanıp dolu bir salonda onun yerine başrol oynar. Kendisini öven tiyatro eleştirmenleri dışında Margo'nun sevgilisini de ele geçirmeye çalışır.Doymak bilmez hırsı ile Margo'nun sahip olduğu her şeye sahip olmaya niyetlidir. Bunun için yalan söylemekte ya da şantaj yapmakta bir an olsun tereddüt etmez. Bu sayede Lloyd Richards'ı ele geçirir,yıllar önce Margo için yazılmış bir oyunun başrolünü alır.Tüm bu olaylar sırasında ondan ilk şüphelenen kişi eleştirmen Addison DeWitt(George Sanders) olur.Onun geçmişini araştıran Addison,Eve'in anlattığından çok farklı biri olduğunu fark eder ve onu köşeye sıkıştırır. Bu esnada Eve başarılı oyunculuğu ile önemli bir ödül almayı başarır.Eve,ir gece dairesine geri döndüğünde içeriye gizlice sızmış genç bir hayranı ile karşılaşır.Phoebe adlı bu genç kız,Eve için her şeyi yapmaya hazırdır.Eve'in görmediği bir anda -Eve'in daha önce Margo'ya yaptığı gibi - onun elbisesi ve ödülü ile aynanın karşısında geçip kendini izler. Phoebe'nin aynada çoğalan görüntüsü ile filmin sonlandığı bu noktada,Margo'nun başına gelenlerin Eve'in başına da geleceğini ve Broadway'de bu akışın hep sürüp gideceğini anlarız.",
                         Imdb = "8.2",
                         PictureSource = "beyazperde.com",
                         TextMovieSource = "beyazperde.com"
                     }

                    );
        }
    }
}
