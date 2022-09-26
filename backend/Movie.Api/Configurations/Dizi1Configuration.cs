using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Movie.Api.Models.Entities;

namespace Movie.Api.Configurations
{
    public class Dizi1Configuration : IEntityTypeConfiguration<Dizi1>
    {
        public void Configure(EntityTypeBuilder<Dizi1> builder)
        {
            builder.HasData(
                  new Dizi1
                  {
                      Id = Guid.NewGuid(),
                      Name = "Star Trek: The Next Generation",
                      Minute = 7,
                      Url = "https://m.media-amazon.com/images/M/MV5BOWFhYjE4NzMtOWJmZi00NzEyLTg5NTctYmIxMTU1ZDIxMDAyXkEyXkFqcGdeQXVyNTE1NjY5Mg@@._V1_.jpg",
                      Category = "Bilimkurgu",
                      Year = 1987,
                      Country = "ABD",
                      Trailer = "https://www.youtube.com/watch?v=jtmsI07AMsE",
                      Age = 12,
                      Starring = "Patrick Stewart,Jonathan Frakes,LeVar Burton,Denise Crosby",
                      Creators = "Gene Roddenberry, Gene Roddenberry",
                      Explane = "Star Trek: The Next Generation, Gene Roddenberry tarafından yaratılmış bilim kurgu televizyon dizisidir. (Star Trek: The Next Generation) Uzay Yolu: Yeni Nesil yaklaşık olarak Orijinal Seri'den bir yüzyıl sonra geçmekte, gene Atılgan adında fakat daha yeni ve gelişmiş (Atılgan-D) yeni bir yıldız gemisi içermekte ve Kaptan Jean Luc Picard'ın (Patrick Stewart) emri altındaki yeni bir mürettabatın maceralarını anlatmaktadır. İnsanların galakside diğer bilinçli canlılarla birleşerek Birleşik Gezegenler Federasyonu'nu kurdukları, kurgusal bir 3. Dünya Savaşı sonrası bir geleceği tasvir eder. Evrende yalnız olmadıklarını anlayınca insanlık kendilerine özg birçok zayıflık ve kötü alışkanlıklarını geride bırakır. Kahramanlar genelde fedakardır ama zaman zaman sonuç almak için başka yollara baş vurabilirler. 1960'larda Orijinal Seri'de ve diğer seriler de olduğu gibi hikâyelerdeki çatışmalar ve politik boyutlar günümüz olaylarını yansıtırlar. Dizilerdeki emperyalizm, sınıf kavgası, ırkçılık, insan hakları ve teknolojinin etkileri gibi konular ilk yayınladıkları zaman olduğu gibi bugünde yankılanmaktadırlar.",
                      Imdb = "8.7",
                      PictureSource = "imdb.com",
                      TextMovieSource = "dizigom1.com"
                  },
                  new Dizi1
                  {
                      Id = Guid.NewGuid(),
                      Name = "This is Us",
                      Minute = 6,
                      Url = "https://tr.web.img4.acsta.net/pictures/20/10/27/03/06/5088182.jpg",
                      Category = "Dram, Komedi",
                      Year = 2016,
                      Country = "ABD",
                      Trailer = "https://www.youtube.com/watch?v=hfu7vf8kvjA",
                      Age = 12,
                      Starring = " Milo Ventimiglia, Mandy Moore, Sterling K. Brown",
                      Creators = " Dan Fogelman",
                      Explane = "This is Us dizisinin konusu, üçüz bebeklri olan Jack ve Rebecca çiftine odaklanıyor. Alkolik bir baba olan Jack’in bu durumu, ailesi tarafından çekilmez hal alınca evin en zeki çocuğu Randall; bu sorunu çözmek için çabalar. Jack ve Rebecca’nın evlatlık oğlu Randall; beyaz yakalı bir işe, bir evliliğe ve çocuğa sahip olan çocuklar arasındaki tek kişidir.",
                      Imdb = "8.7",
                      PictureSource = "beyazperde.com",
                      TextMovieSource = "dizziy.com"
                  },
                   new Dizi1
                   {
                       Id = Guid.NewGuid(),
                       Name = "The Walking Dead",
                       Minute = 8,
                       Url = "https://pbs.twimg.com/media/FYeImCxXwAIXgq2.jpg",
                       Category = "Dram, Korku",
                       Year = 2010,
                       Country = "ABD",
                       Trailer = "https://www.youtube.com/watch?v=sfAc2U20uyg",
                       Age = 18,
                       Starring = "Norman Reedus, Andrew Lincoln, Melissa McBride",
                       Creators = "Glen Mazzara, Frank Darabont, Scott M. Gimple",
                       Explane = "Yaşayan ölüler diyarına hoş geldiniz!Kasabanın polis şefi Rick Grimes bir gün vurularak hastaneye kaldırılır; fakat o komadayken geçen sürede bildiği yaşam altüst olmuştur.Artık dünya, insan etiyle beslenen zombilerin insafına kalacak! Tabii birazcık insani duyguları kaldıysa... Atlanta'da kaostan sonra sessizce hayatta kalmaya çalışan küçük bir grup insanınsa, birbirlerinden başka tutunacak kimseleri yok...Robert Kirkman'ın aynı isimli çizgi romanından uyarlama olan bu zombi hikayesinin yönetmeni ise Esaretin Bedeli (The Shawshank Redemption) ve Yeşil Yol (The Green Mile) filmleri ile hafızalara kazınan Frank Darabont...",
                       Imdb = "8.1",
                       PictureSource = "twitter.com",
                       TextMovieSource = "beyazperde.com"
                   },
                   new Dizi1
                   {
                       Id = Guid.NewGuid(),
                       Name = "Succession",
                       Minute = 4,
                       Url = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/yi3RiM3tAsn14iSUXmi3q1kGkCu.jpg",
                       Category = "Dram, Komedi",
                       Year = 2018,
                       Country = "ABD",
                       Trailer = "https://www.youtube.com/watch?v=OzYxJV_rmE8",
                       Age = 12,
                       Starring = " Nicholas Braun, Brian Cox, Jeremy Strong",
                       Creators = "Jesse Armstrong",
                       Explane = "Jesse Armstrong’un yaratıcısı olduğu dizide New York’ta yaşayan, dünyanın en büyük medya şirketlerinden birini yöneten Logan Roy ve dört çocuğunun hikayesi para, güç, siyaset ve aile değerleri ekseninde ele alınıyor. Dizinin oyuncu kadrosunda Brian Cox, Jeremy Strong, Hiam Abbass, Sarah Snook, Kieran Culkin, Alan Ruck, Nicholas Braun, Matthew Macfadyen gibi isimler yer alıyor",
                       Imdb = "8.8",
                       PictureSource = "themoviedb.org",
                       TextMovieSource = "beyazperde.com"
                   },
                   new Dizi1
                   {
                       Id = Guid.NewGuid(),
                       Name = "Game of Thrones",
                       Minute = 8,
                       Url = "https://m.media-amazon.com/images/M/MV5BYTRiNDQwYzAtMzVlZS00NTI5LWJjYjUtMzkwNTUzMWMxZTllXkEyXkFqcGdeQXVyNDIzMzcwNjc@._V1_.jpg",
                       Category = "Aksiyon, Macera, Dram",
                       Year = 2011,
                       Country = "İngiltere",
                       Trailer = "https://www.youtube.com/watch?v=gcTkNV5Vg1E",
                       Age = 18,
                       Starring = "Peter Dinklage, Nikolaj Coster-Waldau, Lena Headey, Emilia Clarke ",
                       Creators = "D.B. Weiss, David Benioff",
                       Explane = "Yazların onlarca yıl, kışların ise bir ömür sürebildiği bir diyar, içten içe nifakla kaynamaktadır. Köklerini saldıkları topraklar kadar soğuk ve sert olan Starklar'ın kalesi Kıştepesi'nin kuzeyinde, Yedi Krallık'ı koruyan Sur'un ardında tekinsiz güçler toplanmaktadır. Kuşkulu bir ölümün ardından kralı ve dostu tarafından saltanat makamı olan güneye çağrılan Eddard Stark kendisini Demir Taht'ı arzulayanların baş döndürücü entrikalarının arasında bulur. Dostuyla düşmanını, gerçekle yalanı ayırt edemez olan Eddard'ın ne kıyısında yürüdüğü uçurumdan, ne de Ejderkrallar'ın soyundan gelen sürgün Targaryen kardeşlerin taştan ejder yumurtaları ve soylu atların sırtında serpilen iktidar düşlerinden haberi vardır. Kış, Starklar ve yandaşları için olduğu kadar Yedi Krallık için de uğursuz alametlerle gelmektedir. Taht mücadeleleri her zamankinden daha sert geçecektir.",
                       Imdb = "9.2",
                       PictureSource = "imdb.com",
                       TextMovieSource = "wikipedia.org"
                   },
                 
                  new Dizi1
                  {
                      Id = Guid.NewGuid(),
                      Name = "Kayıp",
                      Minute = 6,
                      Url = "https://m.media-amazon.com/images/M/MV5BNzhlY2E5NDUtYjJjYy00ODg3LWFkZWQtYTVmMzU4ZWZmOWJkXkEyXkFqcGdeQXVyNTA4NzY1MzY@._V1_FMjpg_UX1000_.jpg",
                      Category = "Macera, Dram",
                      Year = 2004,
                      Country = "ABD",
                      Trailer = "https://www.youtube.com/watch?v=KTu8iDynwNc",
                      Age = 12,
                      Starring = " Adewale Akinnuoye-Agbaje,Naveen Andrews, Nestor Carbonell",
                      Creators = "	Jack Bender",
                      Explane = "Oceanic Havayolları’nın Sidney-Los Angeles seferini yapan 815 sefer sayılı uçağı, okyanus üzerinden geçerken, manyetik bir alana kapılarak büyük bir adaya düşer. Fakat önceleri sıradan, tropik bir ada gibi görünen bu kara parçasının, kazazedelerin her birinin hayatını farklı biçimde değiştireceğinden habersizdirler.Adada sandıklarından daha fazla zaman mahsur kalan Oceanic Havayolları yolcuları her gün yeni bir sürprizle karşılaştıkları bu gizemli adada hayatta kalabilmek ve ne olursa olsun bir yolunu bulup adadan kurtulmak ya da anakaraya haber ulaştırmak için mücadeleye girerler.Öte yandan hem ormanın derinliklerinden gelen 'Diğer ada sakinleri',kara bir duman,silahlı bir Fransız kadın,üniformalı iskeletler,terkedilmiş ambarlar adadan kurtulmak isteyenleri bekleyen cevaplanmamış sorular...En İyi Televizyon Dizisi dalında Altın Küre ve Emmy Ödüllü Lost,6 sezon boyunca televizyon seyircisini ekran başına kitlemeyi başaran,2000'li yılların kendi fenomenini yaratamış, en çok izlenen dizilerinden biri. Ayrıca oyuncu kadrosuna da kazandırdığı ödüller ve adaylıklarla da televizyon ve sinema dünyasında yeni yıldızlar yaratan LOST fenomeni, hem teknik ekibi, hem yazar ve yapımcı kadrosuyla en çok konuşulan, üzerine en çok komplo teorisi ve senaryo üretilen televizyon yapımı olma özelliğini koruyor...",
                      Imdb = "8.3",
                      PictureSource = "imdb.com",
                      TextMovieSource = "beyazperde.com"
                  },
                  new Dizi1
                  {
                      Id = Guid.NewGuid(),
                      Name = "Breaking Bad",
                      Minute = 5,
                      Url = "https://filmzal.co/wp-content/uploads/Breaking-Bad-1cf1ef5b85cc9e0b783059d953e153df-295x442.jpg",
                      Category = "Suç, Dram",
                      Year = 2008,
                      Country = "ABD",
                      Trailer = "https://www.youtube.com/watch?v=HhesaQXLuRY",
                      Age = 18,
                      Starring = " Bryan Cranston, Anna Gunn, Aaron Paul",
                      Creators = "Vince Gilligan",
                      Explane = "Lisede kimya öğretmenliği yapan Walter White bir gün doktordan ileri safhada akciğer kanseri olduğunu öğrenir. Kendisinden sonra geride kalan ailesine maddi birikim sağlamak isteyen Walter White, uyuşturucu yapımında ustalaşan eski bir öğrencisi, Jesse Pinkman ile beraber uyuşturucu işine girer. Elbetteki yasa dışı yollardan ve uyuşturucunun da eş anlamlısının bela olduğunu bilerek...Bir yanda kimya alanında önemli işlere imza atmış bir öğretmen,diğer yanda bu tehlikeli piyasayı çok iyi tanıyan,gözü pek bir 'eski öğrenci'... Yüksek kalitede ve saflıkta ürettikleri metamfetamin,onları uyuşturucu ticaretinin en riskli yollarına da bulaştıracak...Başrollerini deneyimli aktör Bryan Cranston veAaron Paul'un paylaştığı Breaking Bad, orijinal öyküsü ve sürükleyici senaryosunun yanı sıra oyuncularına kazandırdığı Altın Küre adaylıkları, Emmy ve Saturn ödülleriyle de televizyon dizileri arasında kalitesini ve farkını belli eden bir yapım...1990'lı yılların kült bilim-kurgu dizisi The X Files'ın ortak yapımcıları ve yazarları arasında yer alan Vince Gilligan'ın yapımcılığını üstlendiği dizi eleştirmenler tarafından da son yılların en başarılı yapımlarından biri olarak gösteriliyor...",
                      Imdb = "9.5",
                      PictureSource = "filmaffinity.com",
                      TextMovieSource = "beyazperde.com"
                  },
                  new Dizi1
                  {
                      Id = Guid.NewGuid(),
                      Name = "Stranger Things",
                      Minute = 4,
                      Url = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/49WJfeN0moxb9IPfGn8AIqMGskD.jpg",
                      Category = "Dram, Fantastik, Korku",
                      Year = 2016,
                      Country = "ABD",
                      Trailer = "https://www.youtube.com/watch?v=b9EkMc79ZSU",
                      Age = 12,
                      Starring = " Millie Bobby Brown, Winona Ryder, David Harbour",
                      Creators = "	 Matt Duffer, Ross Duffer",
                      Explane = "Stranger Things, 1980'lerin başında kurgusal kırsal kasaba olan Hawkins, Indiana'da geçmektedir. Hawkins Ulusal Laboratuvarı görünüşte Amerika Birleşik Devletleri Enerji Bakanlığı için bilimsel araştırma yapmaktadır ancak gizlice paranormal ve doğaüstü alanlarda insanların üzerinde deney yapmaktadır. Yanlışlıkla, 'Baş aşağı' olarak adlandırılan alternatif bir evrene açılan bir portal yaratırlar. Bunun sonucunda, Hawkins'in bu olaydan habersiz sakinleri olumsuz bir şekilde etkilenmeye başlar.[1][2]İlk sezon Kasım 1983'te Will Byers'ın Baş aşağı'ndan gelen bir yaratık tarafından kaçırıldığı tarihte başlar. Annesi Joyce ve kasabanın polis şefi Jim Hopper, Will'i aramaya başlar.Aynı zamanda,Eleven adlı psikokinetik yeteneklere sahip genç bir kız laboratuvardan kaçar ve Will'i bulmak için yaptıkları aramalarda Will'in arkadaşları Mike,Dustin ve Lucas'a yardım eder.[3] İkinci sezon Ekim 1984'ten itibaren başlar.Will kurtarılır ancak olayların ayrıntılarını çok az kimse bilmektedir.Will'in arkadaşları ve ailesi, Will'in Baş aşağı'ndaki varlıklardan hâlâ etkilendiğini öğrendiklerinde, Baş aşağı'nın kasaba ve insanlık için daha büyük bir tehlike olduğunu fark ederler.",
                      Imdb = "8.7",
                      PictureSource = "themoviedb.org",
                      TextMovieSource = "wikipedia.org"
                  },
                   new Dizi1
                   {
                       Id = Guid.NewGuid(),
                       Name = "Penny Dreadful",
                       Minute = 3,
                       Url = "https://img01.imgsinemalar.com/images/afis_dev/p/penny-dreadful-1660923446.jpg",
                       Category = "Dram, Korku",
                       Year = 2014,
                       Country = "İngiltere",
                       Trailer = "https://www.youtube.com/watch?v=YFXHfEqMcis",
                       Age = 18,
                       Starring = " Eva Green, Josh Hartnett, Timothy Dalton",
                       Creators = "John Logan",
                       Explane = "Penny Dreadful’da, Edebiyat’ın ünlü ve korkunç karakterlerinden bazıları Dr. Frankenstein ve Frankenstein Canavarı, Dorian Gray ve Dracula’nın romanındaki ikonik karakterler de dahil olmak üzere Viktorya Londra’sında yer alacaklar. Dizi bu klasik korku hikayelerini bir araya getirecek ve karakterlerin canavar yönlerini kavramalarını anlatacak. Dizi “Psikolojik Gerilim” olarak tanıtılıyor. Öncelikle Josh Hartnett, Eva Green ve Timothy Dalton’ın dizide yer aldığını yazayım. Sadece bu isimler bile konuya bakılmaksızın ilginizi çekecektir. Tabi ki sadece bu kadar değil. Dr Who dizisinden tanıdığımız Billie Piper, bir çok yapımda yab rol olarak görülen 20 yıllık tecrübe Helen McCrory, yine bir çok diziden yüzünü anımsayacağınız Rory Kinnear dizide yer alan isimler.",
                       Imdb = "8.2",
                       PictureSource = "sinemalar.com",
                       TextMovieSource = "sinemalar.com"
                   },
                   new Dizi1
                   {
                       Id = Guid.NewGuid(),
                       Name = "La Casa de Papel",
                       Minute = 5,
                       Url = "https://www.justwatch.com/images/poster/281044992/s332/sezon-5",
                       Category = "Dram, Gerilim",
                       Year = 2017,
                       Country = "İspanya",
                       Trailer = "https://www.youtube.com/watch?v=VSgm-gcP_GU",
                       Age = 18,
                       Starring = "Úrsula Corberó,Álvaro Morte, Itziar Ituño,Pedro Alonso",
                       Creators = "Álex Pina",
                       Explane = "Profesör olarak adlandırılan bir suç dehası, tarihin en büyük soygununu yapmayı planlar. Amacı İspanya Kraliyet Darphanesine girmektir. Bunun için de işlerinde uzman olan 8 suçludan oluşan bir ekip kurar. Ekip, 5 aylık bir eğitim sürecinden geçer ve bu sürede her ihtimali hesaba katarak soygunu kusursuz bir hale getirirler. Artık her şey hazırdır. 8 kişi, rehineleri de yanlarına alarak kendilerini İspanya Kraliyet Darphanesine kilitler. Fakat hiç hesaba katmadıkları olaylar gerçekleşir.",
                       Imdb = "8.2",
                       PictureSource = "justwatch.com",
                       TextMovieSource = "beyazperde.com"
                   },
                   new Dizi1
                   {
                       Id = Guid.NewGuid(),
                       Name = "Downton Abbey",
                       Minute = 6,
                       Url = "https://tr.web.img2.acsta.net/pictures/19/05/22/09/39/0032953.jpg",
                       Category = "Dram, Romantik",
                       Year = 2010,
                       Country = "İngiltere",
                       Trailer = "https://www.youtube.com/watch?v=wN0Spmq610Q",
                       Age = 12,
                       Starring = "Hugh Bonneville, Jessica Brown Findlay,Laura Carmichael,Jim Carter",
                       Creators = "	Julian Fellowes",
                       Explane = "Downton Malikanesi'nde yaşayan Crawley Ailesi ve malikanenin çalışanlarının hayatı üzerine kurulu olan dizi, bir dönem dizisi. 1912'den itibaren başlayan hikaye sezonlar içerisinde 20'lere kadar uzanıyor.Grantham Kontu Robert Crawley ailesi ile mutlu bir hayat sürdüğünü düşünürken her şey,15 Nisan 1912'de Titanik'in buzdağına çarpması ile birlikte bir daha eskisi gibi olmayacak şekilde değişir.Crawley Ailesi iki üyesini çarpışmada kaybetmiştir.",
                       Imdb = "8.7",
                       PictureSource = "beyazperde.com",
                       TextMovieSource = "beyazperde.com"
                   },
                   new Dizi1
                   {
                       Id = Guid.NewGuid(),
                       Name = "Black Mirror",
                       Minute = 5,
                       Url = "https://tr.web.img4.acsta.net/c_310_420/pictures/19/06/05/14/11/0714172.jpg",
                       Category = "Dram, Bilimkurgu",
                       Year = 2011,
                       Country = "ABD",
                       Trailer = "https://www.youtube.com/watch?v=jROLrhQkK78",
                       Age = 18,
                       Starring = "Jesse Plemons,Cristin Milioti,Jimmi Simpson",
                       Creators = "Charlie Brooker",
                       Explane = "3 bölümden oluşan mini dizinin her bir bölümü bir başka hikayeyi anlatıyor. İlk bölüm, sosyal medyanın başa bela olabileceğini gösterirken, ikinci bölüm televizyondaki yarışmaların birgün varabileceği noktaya parmak basıyor. Üçüncü bölüm ise; yakın bir gelecekte insanlar taktırdıkları hafıza çipleri sayesinde tüm hayatlarını depolayabilmektedirler. Hiçbir şey unutulmuyor, hiçbir ayrıntı atlanmıyordur. Peki ya bu, iyi bir şey midir?",
                       Imdb = "9.1",
                       PictureSource = "beyazperde.com",
                       TextMovieSource = "beyazperde.com"
                   },
                   new Dizi1
                   {
                       Id = Guid.NewGuid(),
                       Name = "Squid Game",
                       Minute = 1,
                       Url = "https://upload.wikimedia.org/wikipedia/en/d/dd/Squid_Game.jpg",
                       Category = "Aksiyon, Dram",
                       Year = 2021,
                       Country = "G. Kore",
                       Trailer = "https://www.youtube.com/watch?v=oqxAJKy0ii4",
                       Age = 18,
                       Starring = "Lee Jung-jae, Park Hae - soo,Wi Ha - joon,HoYeon Jung",
                       Creators = "	Hwang Dong-hyuk",
                       Explane = "Boşanmış ve borçlu bir şoför olan Seong Gi-hun, büyük bir nakit ödül şansı için bir dizi çocuk oyunu oynamaya davet edilir. Teklifi kabul ederek bilinmeyen bir yere götürülür ve kendisini benzer büyük borçlara sahip 455 diğer oyuncu arasında bulur. Yeşil renkli eşofman giydirilen oyuncular, Front Man tarafından denetlenen oyunlarla birlikte kırmızı tulumlu maskeli korumalar tarafından her zaman gözetim altında tutulur. Oyuncular kısa süre sonra bu oyunlarda kaybetmenin ölümleriyle sonuçlandığını keşfederler ve her ölüm potansiyel ₩45,6 milyar büyük ödüle 100 milyon₩ ekler.[a] Gi-hun, çocukluk arkadaşı Cho Sang-woo da dâhil olmak üzere diğer oyuncularla, oyunların fiziksel ve psikolojik dönüşlerinden kurtulmaya çalışmak için müttefik olur",
                       Imdb = "8.0",
                       PictureSource = "wikipedia.org",
                       TextMovieSource = "wikipedia.org"
                   },
                   new Dizi1
                   {
                       Id = Guid.NewGuid(),
                       Name = "Dexter",
                       Minute = 9,
                       Url = "https://m.media-amazon.com/images/M/MV5BZjkzMmU5MjMtODllZS00OTA5LTk2ZTEtNjdhYjZhMDA5ZTRhXkEyXkFqcGdeQXVyOTA3MTMyOTk@._V1_.jpg",
                       Category = "Dram, Gerilim",
                       Year = 2006,
                       Country = "ABD",
                       Trailer = "https://www.youtube.com/watch?v=YQeUmSD1c3g",
                       Age = 18,
                       Starring = " Michael C. Hall, Jennifer Carpenter, David Zayas",
                       Creators = "	James Manos Jr.",
                       Explane = "O, 'ince ruhlu' bir katil. O, Miami'de yaşanan cinayetleri araştıran bir 'kan' uzmanı. O, dünyaya adalet sağlamak için öldürüyor. O'nun adı Dexter ve düzenin adaletini kişisel bakışa göre sağlamak hayatta kalma amacı.Hem işinin ehli bir seri katil,hem de sosyal kişilikli bir adam portresi çizen Dexter Morgan,2006 yılından bu yana kendi ahlak anlayışına göre kötüleri yer yüzünden silmeye devam ediyor.Yayınlandığı yıldan itibaren onlarca televizyon ödülüne aday gösterilen,Emmy ve Altın Küre ödüllü Dexter,televizyon tarihinin de en sıra dışı karakterlerinden birini ekranlara taşıyor...",
                       Imdb = "8.7",
                       PictureSource = "imdb.com",
                       TextMovieSource = "beyazperde.com"
                   },
                   new Dizi1
                   {
                       Id = Guid.NewGuid(),
                       Name = "Dark",
                       Minute = 3,
                       Url = "https://tr.web.img4.acsta.net/pictures/17/11/09/13/41/0101371.jpg",
                       Category = "Suç, Dram",
                       Year = 2017,
                       Country = "Almanya",
                       Trailer = "https://www.youtube.com/watch?v=rrwycJ08PSA",
                       Age = 18,
                       Starring = " Louis Hofmann, Maja Schöne, Andreas Pietschmann",
                       Creators = "	Baran bo Odar,Jantje Friese",
                       Explane = "Dark dizisinin konusu, kurgusal Alman kasabası olan Winden’de iki çocuğun kaybolması sonrasında yaşanan gizemli olaylardır. Kasabadaki çocukların ortadan kayboluyor olması ile polis bunu bir kaçırılma olayı olarak görür ve soruşturma başlatır. Kasabadan ayrılmış olan Jonas, döndüğünde babasının ani intiharını atlatmaya çalışır. Ancak mağara yakınlarında polis memurlarından birinin oğlu Mikkel’in de ortadan kaybolması ile kaybolan çocukların aile sırları ortaya çıkmaya başlar.Dark konusu bakımından Kahnwald,Nielsen,Doppler ve Tiedemann ailelerinin kopuk ilişkilerini ve karanlık sırlarını konu alır. 3 sezonluk dizide dört ailenin 33 yılda bir tekrarlanan döngü içerisindeki konumları anlatılır.Bu döngüde aynı karakterler geçmiş,bugün ve gelecekte farklı şekillerde ortaya çıkarlar.",
                       Imdb = "8.7",
                       PictureSource = "beyazperde.com",
                       TextMovieSource = "dizziy.com"
                   },
                   new Dizi1
                   {
                       Id = Guid.NewGuid(),
                       Name = "Westworld",
                       Minute = 4,
                       Url = "https://tr.web.img4.acsta.net/pictures/16/09/01/14/52/298580.jpg",
                       Category = "Dram",
                       Year = 2016,
                       Country = "ABD",
                       Trailer = "https://www.youtube.com/watch?v=9BqKiZhEFFw",
                       Age = 18,
                       Starring = "Evan Rachel Wood, Thandiwe Newton, Jeffrey Wright",
                       Creators = "	 Jonathan Nolan, Lisa Joy",
                       Explane = "Westworld dizisinin konusu, ”Westworld” isimli ve milyarderlere hitap eden bir eğlence parkında yaşanan olaylardır. Westworld isimli fütürist parkta, zenginler robotlara istedikleri her şeyi yapabiliyorlar. Yani en gizli ve yasadışı oldukları için yapamadıkları fantezilerini, para verip robotlara Westworld’de yapabiliyorlar. Robotların tamamen insanlara amade ve itaatkar olduğu Westworld’de her şey yasal.Westworld konusu,bu eğlence parkındaki robotların bir hata sonucu bilinçlenmesiyle çok daha farklı bir yere evriliyor.Bilinçleşen bu robotlar,denklemdeki rolleri tersine çevirebilecek güce ve zekaya erişiyor ve işler çok daha farklı bir hal alıyor.Westworld parkına eğlenme amacıyla gelen milyarderler,bir anda peşlerinde silahlı robotları buluyor.",
                       Imdb = "8.5",
                       PictureSource = "beyazperde.com",
                       TextMovieSource = "dizziy.com"
                   }
                  );
        }
    }
}
