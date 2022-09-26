using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Movie.Api.Models.Entities;

namespace Movie.Api.Configurations
{
    public class Avrupa1Configuration : IEntityTypeConfiguration<Avrupa1>
    {
        public void Configure(EntityTypeBuilder<Avrupa1> builder)
        {
            builder.HasData(
                 new Avrupa1
                 {
                     Id = Guid.NewGuid(),
                     Name = "Yağmurdan Önce",
                     Minute = 113,
                     Url = "https://upload.wikimedia.org/wikipedia/tr/thumb/b/b2/Before_the_Rain_%281994%29_afi%C5%9F.jpg/330px-Before_the_Rain_%281994%29_afi%C5%9F.jpg",
                     Category = "Dram, Savaş",
                     Year = 1994,
                     Country = "Makedonya",
                     Trailer = "https://www.youtube.com/watch?v=wHBQ4VsQaic",
                     Age = 12,
                     Starring = " Grégoire Colin, Labina Mitevska, Katrin Cartlidge",
                     Creators = "Milcho Manchevski",
                     Explane = "Makedonya'da bir dağ manastırında yaşayan Ortodoks keşişlerden biri olan genç Kiril (Grégoire Colin) dini inançları gereği bir 'sessizlik yemini' etmiştir ve günlerini hiç konuşmadan geçirmektedir. Melankolik ve içine kapanık bir yapıya sahip bu genç adamının dışında kalan din adamlarının hepsi yaşlıdır. Kiril bir gece odasına döndüğünde saçları erkek gibi kısa kesilmiş bir Müslüman Arnavut kızı olan Zamira (Labina Mitevska)'yla karşılaşır. Kız çok korkmuş ve panik içindedir, çünkü Hristiyan bir çobanı öldürdüğü ileri sürülmektedir ve çobanın silahlı akrabaları onun peşindedir. Genç rahip kızı ele vermez. Bosna'da sürmekte olan savaş Makedonya'ya sıçramamıştır ama etnik ve dini gruplar arasında sürekli bir husumet vardır.Ertesi gün kızı yakalamak için gelen silahlı Hristiyan çeteciler,etrafı didik didik ararlar ama aradıklarını bulamazlar.Kendi kiliselerine bile saygı göstermezler,kiliseyi ablukaya alırlar.Zamira'yı Kiril'in odasında yakalayan başrahip ikisini de Manastırdan kovar.Baş rahip Kiril'e ayrılırken sıkı bir tokat atar ve sonra da sarılır. Tokat kuralları çiğnediği için, sarılma da insanca davranıp bir mazlumu koruduğu içindir. Gizlice ablukayı yaran çift Üsküp'e gitmeyi planlar.Kiril artık konuşmaya başlamıştır ama hala birbirinin dilini anlamazlar.Bir süre sonra dağlarda bu kez kızın büyükbabası ve onun silahlı adamlarına yakalanırlar.Arnavut büyükbaba Zamira'yı önce acımasızca döver, çünkü davranışının bir savaş başlatacağını düşünmüştür. Sonra da adamlarından biri Zamira'yı makineli tüfekle sırtından vurarak öldürür.İkinci Bölüm: 'Yüzler'Londra'da yaşayan Anne (Katrin Cartlidge) bir basın ajansının fotoğraf editörüdür. Aynı ajansa bağlı, Pulitzer ödüllü başarılı bir fotoğrafçı olan Makedonya'lı Aleksander(Rade Serbedzija)'la aşk hayatı yaşamaktadır. Bu arada artık hoşlanmadığı ve ayrı yaşadığı kocası Nick (Jay Villiers)'ten boşanmayı düşünmektedir.Sevgilisi ona ısrarla birlikte Makedonya'ya yerleşip orada yaşamayı teklif eder. Kocasından hamile olan Anne ise bu konuda kararsızdır. Kocasıyla buluştuğu lokantada olay çıkartan bir psikopatın silahından çıkan kurşunlardan biri de lokantadaki birçok insanın yanı sıra kocasına isabet eder. Kocasının ölümüyle sonuçlanan bu beklenmedik olay Anne'in seçim yapmasını kolaylaştırır.Üçüncü Bölüm: 'Fotoğraflar' Sürekli savaş fotoğrafları çekmekten yorulmuş olan fotoğrafçı Aleksander,16 yıldır görmediği memleketi Makedonya'daki köyüne gelir. Geçen zaman içinde doğduğu bu topraklarda çok şeyler değişmiştir, köy Müslüman ve Hristiyan kesimleri olmak üzere ikiye ayrılmıştır. Geceyi harap ve terkedelmiş olan kendi eski evinde geçirir. Ertesi sabah akrabaları ve eski arkadaşlarıyla bir araya gelir. (Onlardan biri de, ilk bölümde kiliseyi basan çetecilerin arasında olan Mitre (Ljupco Bresliski)'dir).Alex çocukluk arkadaşlarının artık birbirlerine düşman olduklarını öğrenir.Eski sevgilisi Hana(Silvija Stojanovska)'nın da Arnavut ve Müslüman olduğu için dışlanmış olduğunu öğrenir. Evlenip boşanmış, bir de kızı olmuştur (Bu kız da ilk bölümde öldürülen kızdır). Köyün Müslüman kesimine geçerek sevdiği kadın Hana'nın evine gider, Hanna'nın babası (ilk bölümde torunu Zamira'yı döven ve öldürten adam) kendisini misafir eder ama diğerleri ona soğuk hatta düşmanca davranırlar.Alex'in kuzeni Bojan'ın(Ilko Stefanovski) bir Arnavut kızı(Bu kız ilk bölümdeki Zamira'dır) tarafından öldürülmesiyle gruplar arasında çatışma resmen başlar. Hristiyan çeteciler cinayetten sorumlu tuttukları Zamira'yı yakalarlar.Hana'nın ricası üzerine Alex, Zamira'nın tutsak edildiği ağıla giderek onu kurtarır.Birlikte uzaklaşırlarken arkalarından ateş eden diğer kuzeni Zdrave'nin kurşunları Alex'i öldürür, Zamira kaçar.Alex hayatı pahasına eski aşkı Müslüman kadın Hana'nın kızını kendi akrabalarından kurtarmış olur. Olaylar çemberi kapanır, ilk bölümün başlangıcına dönülür, Zamira o civarda gördüğü bir manastıra sığınır.",
                     Imdb = "7.9",
                     PictureSource = "wikipedia.org",
                     TextMovieSource = "wikipedia.org"
                 },
            new Avrupa1
            {
                Id = Guid.NewGuid(),
                Name = "Aç Gözünü",
                Minute = 117,
                Url = "https://upload.wikimedia.org/wikipedia/tr/c/cd/A%C3%A7_G%C3%B6z%C3%BCn%C3%BC_%28Abre_los_ojos%29_1997_film.jpg",
                Category = "Dram, Gerilim",
                Year = 1997,
                Country = "İspanya",
                Trailer = "https://www.youtube.com/watch?v=cF9BRZdD9qo",
                Age = 18,
                Starring = " Eduardo Noriega, Penélope Cruz, Fele Martínez",
                Creators = "Alejandro Amenábar",
                Explane = "Cesar, kendi halinde, ne istediğini bilen genç bir adamdır. Hayata dair umutları vardır ve önünde gördüğü gelecek ışıldamaktadır. Bir gece arkadaşı olan Paleya'nın da ilgi duyduğu güzel bir kadın olan Sofia'yla tanışır. Cesar, artık, o güne kadar sahip olduğu tüm temkinli hallerini kapı dışı etmek üzeredir. Cesar, bu kadın için yaratılmıştır ve bu kadın için her şeyi yapmaya hazırdır. Suç işlemeye ve hapishanelerde sürümeye bile... İspanyol sinemasının son döneminden çıkmış en heyecan verici yönetmenlerden biri olan Alejandro Amanebar'ın Tesis'ten sonra rüşt'ünü ispatladığı filmi Abre los ojos'un başrollerinde Penelope Cruz, Eduardo Noriega ve Chete Lera var.",
                Imdb = "6.2",
                PictureSource = "wikipedia.org",
                TextMovieSource = "beyazperde.com"
            },

             new Avrupa1
             {
                 Id = Guid.NewGuid(),
                 Name = "Gizli Dünya",
                 Minute = 118,
                 Url = "https://upload.wikimedia.org/wikipedia/tr/f/f0/Room_Poster.jpg",
                 Category = "Dram, Gerilim",
                 Year = 2016,
                 Country = "İrlanda",
                 Trailer = "https://www.youtube.com/watch?v=GQhwHR-tcBk",
                 Age = 12,
                 Starring = "Brie Larson, Jacob Tremblay, Joan Allen",
                 Creators = "Lenny Abrahamson",
                 Explane = "Gizli Dünya, 5 yaşındaki oğlu ile küçük bir odaya hapsedilen annenin dramını anlatıyor. Jack ve annesi dört duvarla çevrili kutu gibi bir odada yaşamaktadırlar. Mutfak, banyo, uyku ve televizyonun aynı metrekarede hayat bulduğu bu karanlık ve kasvetli oda, Jack'in tanıdığı tek dünyadır. Televizyon ise onun en iyi arkadaşıdır. Peki ne zamana kadar?Emma Donghue'nun çok satan kitabından sinemaya uyarlanan Gizli Dünya'nın başrolünde Brie Larson yer alıyor.Gizli Dünya,kaçış için riskli bir plan yapan anne oğlun gerilimini beyazperdeye taşıyor.Çocuk oyuncu Jack'e ise Jacob Tremblay hayat veriyor.",
                 Imdb = "8.1",
                 PictureSource = "wikipedia.org",
                 TextMovieSource = "beyazperde.com"
             },
             new Avrupa1
             {
                 Id = Guid.NewGuid(),
                 Name = "Aşk Hakkında Kısa Bir Film",
                 Minute = 86,
                 Url = "https://upload.wikimedia.org/wikipedia/tr/thumb/5/59/A_Short_Film_About_Love_%28film%2C_1988%29.jpg/330px-A_Short_Film_About_Love_%28film%2C_1988%29.jpg",
                 Category = "Dram, Romantik",
                 Year = 1988,
                 Country = "Polonya",
                 Trailer = "https://www.youtube.com/watch?v=A6jFanHPcFM",
                 Age = 12,
                 Starring = "Grażyna Szapołowska, Olaf Lubaszenko",
                 Creators = "Krzysztof Kieślowski",
                 Explane = "Tomek, hayatını postanede çalışarak kazanan genç bir posta memurudur. Oldukça sıradan ve sade yansıyan hayatının derinliklerinde ise oldukça girdaplı ve takıntılı bir ruh durumu vardır. Karşı binasından komşu olduğu Magda'ya derin ve takıntılı bir aşk besleyen Tomek, kadının hayatına dair her şeyi en ince detayına kadar bilmektedir. Bir gün Magda'ya ilan-ı aşk eder ancak alacağı cevap onu oldukça üzecektir.Kieslowski'nin kısa filmografisinin en önemli noktalarından biri olan Aşk Üzerine Kısa Bir Film yönetmenin derin aşk tanımlamasına dikkat çekiyor.",
                 Imdb = "8.3",
                 PictureSource = "wikipedia.org",
                 TextMovieSource = "beyazperde.com"
             },
             new Avrupa1
             {
                 Id = Guid.NewGuid(),
                 Name = "Çingeneler Zamanı",
                 Minute = 142,
                 Url = "https://upload.wikimedia.org/wikipedia/tr/8/84/Time_of_the_Gypsies_afis.jpg",
                 Category = "Dram, Komedi",
                 Year = 1990,
                 Country = "İngiltere",
                 Trailer = "https://www.youtube.com/watch?v=jBmKrpGigDw",
                 Age = 12,
                 Starring = " Davor Dujmovic, Bora Todorovic, Ljubica Adzovic",
                 Creators = "Emir Kusturica",
                 Explane = "Çingenelerin dünyası çok farklıdır. Onların doğa ile bütünleşmiş olan kendince yaşadıkları dünyalarında farklı renkler vardır. Perhan da büyük annesi ile beraber bir yaşam sürmekte olan bir çingenedir. Bir kıza aşıktır. Son derece de duygusal biridir. Öyle ki duygu yoğunluğu aracılığı ile nesneleri hareket ettirme yeteneğine sahiptir. Tabi onun bu yeteneğinden faydalanmak isteyecek farklı niyette insanlar da vardır çevresinde. Örneğin Ahmet bunlardan biridir. Perhan’ı kendisiyle birlikte şehre gelmeye ve yaşadığı yeri terketmeye ikna eder. Perhan bu yeni hayata yeterince para biriktirmek ve geri dönüp evlenebilmek için uyum sağlamaya çalışır. Bir yandan da bacağından ameliyat olmak için onlardan ayrılan kızkardeşini bulmayı ummaktadır.Yönetmen Emir Kusturica’ya uluslararası alanda tanınmasını sağlayan bu film,Cannes’da coşkuyla karşılanmıştır.",
                 Imdb = "8.1",
                 PictureSource = "wikipedia.org",
                 TextMovieSource = "beyazperde.com"
             },
             new Avrupa1
             {
                 Id = Guid.NewGuid(),
                 Name = "Ölümcül Oyun",
                 Minute = 86,
                 Url = "https://tr.web.img4.acsta.net/pictures/14/09/02/10/46/272679.jpg",
                 Category = "Dram, Gerilim",
                 Year = 2007,
                 Country = "İngiltere",
                 Trailer = "https://www.youtube.com/watch?v=y_amGKgqf7c",
                 Age = 12,
                 Starring = " James Franco, Kate Hudson, Tom Wilkinson",
                 Creators = " Henrik Ruben Genz",
                 Explane = "Tom ve Anna çifti, yaşadıkları sıkıntıları geride bırakmak ve taze bir başlangıç yapmak için Londra'ya taşınmıştır. Peyzaj mimarı olan Tom, bir yandan oturacakları evi restore ederken, diğer yandan da irili ufaklı tadilat işlerinden para kazanmaya çalışır.  Tüm maddi birikimlerini evin tadilatında kullanan Tom, çektiği kredilerden dolayı zor durumdadır.  Öğretmen olan Anna'nın ise en çok istediği şey bir bebek sahibi olmaktır. Gelirlerine katkı olsun diye alttaki bodrum katını, Ben adında bir adama kiraya veren çiftin kaderi, Ben'in evde ölü bulunması ile değişecektir. Polis soruşturması devam ederken evde yüklü miktarda para bulan çifti, zor kararlar beklemektedir...Marcus Sakey'in aynı adlı kitabından beyazperdeye uyarlanan filmin yönetmeni Henrik Ruben Genz. Başrolleri ise James Franco ve Kate Hudson paylaşıyor.",
                 Imdb = "6.7",
                 PictureSource = "beyazperde.com",
                 TextMovieSource = "beyazperde.com"
             },
             new Avrupa1
             {
                 Id = Guid.NewGuid(),
                 Name = "Brüj'da",
                 Minute = 108,
                 Url = "https://upload.wikimedia.org/wikipedia/tr/7/7b/In_Bruges_2008_film_afi%C5%9F.jpg",
                 Category = "Dram, Komedi",
                 Year = 2008,
                 Country = "İngiltere",
                 Trailer = "https://www.youtube.com/watch?v=p-gG2qo_l_A",
                 Age = 12,
                 Starring = " Colin Farrell, Brendan Gleeson, Ralph Fiennes",
                 Creators = " Martin McDonagh",
                 Explane = "İki kiralık katil olan Ray ve Ken zor bir işin ardından patronları Harry Waters tarafından Belçika’nın romantik şehri Brugge’a tatile yollanırlar.Geldiği ilk günden beri bu şehirden nefret eden Ray’i burada pek çok sürpriz beklemektedir.Bunun sadece basit bir tatil olmadığını düşünen Ray burada yeni insanlarla tanışır ve aşkı ile kendi hayatı arasında gelgitler yaşamaya başlar.Fragmanı eğlencelik bir aksiyon filmi vaadetse de,film aynı zamanda son derece dramatik bir hikaye de sunuyor.Aynı zamanda 2008 Golden Trailer'da iki adaylığı ve bir ödülü bulunmakta.",
                 Imdb = "7.9",
                 PictureSource = "wikipedia.org",
                 TextMovieSource = "beyazperde.com"
             },
             new Avrupa1
             {
                 Id = Guid.NewGuid(),
                 Name = "İyi, Kötü ve Çirkin",
                 Minute = 180,
                 Url = "https://upload.wikimedia.org/wikipedia/tr/6/6c/%C4%B0yik%C3%B6t%C3%BCve%C3%A7irkin.jpg",
                 Category = "Western",
                 Year = 1966,
                 Country = "İtalya",
                 Trailer = "https://www.youtube.com/watch?v=WCN5JJY_wiA",
                 Age = 18,
                 Starring = " Clint Eastwood, Eli Wallach, Lee Van Cleef",
                 Creators = " Sergio Leone",
                 Explane = "Tuco (Çirkin), üzerine ödül konulmuş bir kanun kaçağıdır. Keskin nişancı Sarışın (İyi) adlı kovboyla iş birliği yaparak kasabaları dolaşmaktadırlar. Tuco'yu kanun adamlarına teslim eden Sarışın, ödülü alıp Tuco'yu asılmaktan son anda kurtarmaktadır. Bir kasabada işlerin ters gitmesi üzerine ortaklıkları bozulur. Ortaklığın bozulmasının ardından Sarışın, Tuco'yla yollarını ayırır ve Tuco'yu elleri bağlı yürüterek cezalandırır. Bunun üzerine Tuco, intikam için Sarışın'ın peşine düşer. Uzun uğraşlar sonucu yakaladıktan sonra ceza olarak Sarışın'ı çölde, susuz bir şekilde yürütür. Bu arada Melekgöz (Kötü) lakaplı Sentenza ise Bill Carson adında büyük miktarda altını ele geçirmiş eski bir askerin izini sürmektedir.Tuco'nun çölde Sarışın'ı susuzluktan öldürmek üzere olduğu bir anda ikisinin Bill Carson'la karşılaşmaları tüm planları değiştirir. Carson, altınları Amerikan İç Savaşı'nın hareketli olduğu bir cephede mezarlığa saklamıştır.Ancak Tuco mezarlığın yerini,Sarışın ise mezarın adını öğrenebilmiştir.Mecburen iş birliğine tekrar dönen ikili altınları aramaya koyulur.Cephede Güneyli üniformaları ile ilerleyen Tuco ve Sarışın,Kuzeylilere esir düşer.Melekgöz Sentenza ise adamlarıyla birlikte esir kampının Kuzeyli çavuşudur.Carson'ın altınlarının yerini öğrenmeye çalışan Melekgöz, Tuco'ya işkence yapar ve altınların yerini öğrenir.Tuco'yu trenle başka bir şehre yollar. Sarışın ile Melekgöz, mezarlığın olduğu bölgeye hareket eder. Bu sırada Tuco Kuzeyli askerlerden trenden atlayarak kurtulur. Sarışın ve Melekgöz'ü bulur.Tuco ile Sarışın tekrar iş birliği yapar ve Melekgöz'ün adamlarını öldürür. Melekgöz ise kaçar. Tuco ile Sarışın mezarlığa doğru yol almaktadırlar ancak mezarlık savaşın tüm hızıyla devam ettiği bir cephenin ortasındadır. Çarpışmayı durdurmak için iki tarafın da peşinde olduğu köprüyü havaya uçururlar. Altınlara ulaşmaya ramak kalmışken; Tuco, Sarışın'ı kandırır ve kaçar fakat Sarışın'dan kurtulamaz. Bu arada Melekgöz de mezarlığa yol almaktadır. Üçlü mezarlıkta karşılaşır fakat mezarın ismini sadece Sarışın bilmektedir.Hakimiyetin sürekli el değiştirdiği mücadelede mezarlığın ortasında yapılan üçlü bir düello kazananı belirleyecektir.Sarışın mezarın ismini taşa yazar ve düello başlar.Düello esnasında Sarışın,Melekgöz'ü vurarak öldürür. Sarışın, altınların yarısını alır ve Tuco'yu asıp ellerini bağlayarak uzağa gider.Keskin nişancılığını konuşturarak Tuco'yu düşürür ve ardından uzaklaşır. Tuco, elleri bağlı bir şekilde kalan altınlarıyla baş başa kalır.",
                 Imdb = "8.8",
                 PictureSource = "wikipedia.org",
                 TextMovieSource = "wikipedia.org"
             },
             new Avrupa1
             {
                 Id = Guid.NewGuid(),
                 Name = "Dört Nikah Bir Cenaze",
                 Minute = 117,
                 Url = "https://tr.web.img4.acsta.net/pictures/14/02/04/14/52/343965.jpg",
                 Category = "Dram, Komedi, Romantik",
                 Year = 1994,
                 Country = "İngiltere",
                 Trailer = "https://www.youtube.com/watch?v=g-HeV8Z6iXc",
                 Age = 12,
                 Starring = " Hugh Grant, Andie MacDowell, Kristin Scott Thomas",
                 Creators = "Mike Newell",
                 Explane = "Dört Nikah Bir Cenaze, doksanlar romantik-film kuşağına dair en sevimli örneklerden biri olarak, bugün birçok sinemaseverin hatırasında hala önemli yerini koruyor. Filmde, ilk başta; Charles adında, kızlarla sadece gönül eğlendirip hiç bir zaman evlilik vaadinin altına girmeyen bir 'heartbreaker' tiplemenin maceralarına şahit olacağız. Ancak kötü bir sürpriz onun da peşini bırakmaz: Bir gün bir arkadaşının düğününde hayatının kadınıyla karşılaşınca tüm hesapları alt üst olur. Zira Amerikalı Carrie’ye aşık olmuştur. Ancak Charles yiğitliğe gölge düşsün istememektedir ve işte bu yüzden bir türlü duygularını ifade edemez! İlginçtir, Charles ile Carrie sonradan bir cenazede ve üç nikahta daha karşılaşacaklardır. Her seferinde arkadaşlıkları bir kez daha yenilenecek ancak birbirlerine itiraf edemedikleri ilgilerine rağmen başka başka insanlarla nişanlanacaklardır. Bu nikahlardan iki tanesi Charles ve Carrie’nin olacaktır. En sevilen romantik komediler arasında olan bu film, belki de her zamanki formülün dışına çıkmıyor ama içerdiği mini hikaye örgüleri ve mutlu sonu çok da fazla gözümüzün içine sokmadan sunuvermesi açısından üzerine çektiği ilgiyi fazlasıyla hakediyor. TV kökenli Mike Newell’in beyazperdedeki ilk zaferlerinden biri. Yakışıklılığının zirvesindeki hovarda Hugh Grant ve gerçekten güzelliğinin doruğundaki Andie MacDowell ise büyüleyici bir performans sergilemekte...",
                 Imdb = "7.1",
                 PictureSource = "beyazperde.com",
                 TextMovieSource = "beyazperde.com"
             },
             new Avrupa1
             {
                 Id = Guid.NewGuid(),
                 Name = "Kara Kedi Ak Kedi",
                 Minute = 117,
                 Url = "https://upload.wikimedia.org/wikipedia/tr/e/e4/Poster1234.jpg",
                 Category = "Komedi, Romantik",
                 Year = 1998,
                 Country = "Avusturya",
                 Trailer = "https://www.youtube.com/watch?v=Lxw0ea_UiZ4",
                 Age = 12,
                 Starring = "  Bajram Severdzan, Srdjan Todorovic, Branka Katic",
                 Creators = "Emir Kusturica",
                 Explane = "Film, aşk ve mutluluk arayışındaki sıradan insanların, sıra dışı hayatlarını konu almaktadır. Montreal’li bir ailenin oğlu, kendi dünyasındaki bazı çelişkilerden ötürü benlik arayışı içinde savrulmaktadır. Bu süreç onu olgunlaşmaya taşırken ruhun farklı labirentlerine sürükleyecektir. Babasına hayranlık derecesinde bağlı olan Zach, onu hayal kırıklığına uğratmamak uğrunda kendi doğası ile daha derin çelişkilere de girer. Dahası bu durum onu yer yer çıldırmanın eşiğine kadar taşır. Çılgın, ruhsal bir yolculuğun, toplum baskısının ve insanın başkaldıran doğasının bir baba oğul ilişkisi dahilinde anlatıldığı harika bir film.",
                 Imdb = "8.0",
                 PictureSource = "wikipedia.org",
                 TextMovieSource = "beyazperde.com"
             },
             new Avrupa1
             {
                 Id = Guid.NewGuid(),
                 Name = "Güneşli Pazartesiler",
                 Minute = 113,
                 Url = "https://upload.wikimedia.org/wikipedia/tr/thumb/3/3c/Los_Lunes_al_Sol_%28poster%29.jpg/330px-Los_Lunes_al_Sol_%28poster%29.jpg",
                 Category = "Dram, Komedi",
                 Year = 1998,
                 Country = "İspanya",
                 Trailer = "https://www.youtube.com/watch?v=uKG8ydkfetU",
                 Age = 2003,
                 Starring = "Javier Bardem, Serge Riaboukine, Luis Tosar",
                 Creators = "Fernando León de Aranoa",
                 Explane = "Los lunes al sol (2002), İspanyol yönetmen Fernando León de Aranoa’nın, güneşin tadına doymalarına rağmen yeniden pazartesiden başlamak üzere tutsaklık arayan işsizleri işlediği bir film. Ağırbaşlılığından ödün vermeden, aktığı suyu bulandırmadan yolunu bulan tertemiz bir yapıt. Öyle ki, boşluklara şerbet gibi akan dingin müzikleri, rengini belli etmekten kaçınmayan açık sözlülüğü, tekme tokat isyan görüntüleri, dünyanın en çelimsiz hamlesi gibi görünse de hayli derinden sarsan inatçı direnişleri, yalnızlığımıza sataşan diyalogları ve arada kalmışlık sandığımız hâlimizin sıkışıp çatırdayışını efelenmeden anlatışıyla bünyemizin genişçe bir coğrafyasına hükmetmeyi başarıyor.Altı erkek,kasvet çökmüş bir barın talihsiz sandalyelerine düzensiz bir şekilde dağılmış,birbirlerine hayli baygın bakarak bir şeyler konuşuyor.Javier Bardem’in baştan sona ayarında mimikleriyle hayat verdiği Santa karakterinin yönlendiriciliğinde yolunu bulan bu konuşmalar her defasında,bir zamanlar aynı tersanede işten atılmaya direnmiş bu altı arkadaşın kendi arasında yaptığı “Neden bizden bir devrim çıkmadı ?” başlıklı bir oturuma dönüşüyor.Bu oturumlar filmin kurgu rotasını belirlerken,buluşmaların gerçekleştiği bar ise ana mekân olarak öne çıkıyor.Diyalogların,lirik havasını bir an bile yitirmediği filmde,bardan asla bir devrim çıkaramayacak olan altılıyı kavuran tıkanmışlık,filme baştan sona yayılıyor.Tıkanmışlık hissiyle kavrulan yalnızca karakterler değil,ondan da aslı bizler.Yönetmen,oturduğumuz yerden bu olgun seyir içinde komik, kasvetli yahut gergin bir an bekleyen şehvet dolu gözlerimizi,koltuğa yayılmış hazırcı zihnimizi dürtüyor.Kendi kıpırdamazlığımızı yüzümüze vurmadan edemeyen yönetmen,polislerin işçilere saldırdığı görüntülerin üzerine örtülen klasik müzikle,sıradanlaşan vahşet karşısında insanlığın hoş bir sedaya kapılmasına inceden dokunduruyor.Bunun hemen ardından izleyiciyi barda ağırladığında ise tebessümle salıverdiği gerçekliği yaşamaya davet ettiği izleyicisine özdeşleşmek üzere biri diğerinden daha da dipte olan bol bol karakter sunuyor.O barda kimin ısmarladığı meçhul içkileri yuvarlarken gerçeği konuşmayı erteledikçe dingin bir tını,şiddetin üzerinde salınmaya kaldığı yerden devam ediyor.",
                 Imdb = "7.5",
                 PictureSource = "wikipedia.org",
                 TextMovieSource = "filmhafizasi.com"
             },
             new Avrupa1
             {
                 Id = Guid.NewGuid(),
                 Name = "Pan’ın Labirenti",
                 Minute = 112,
                 Url = "https://upload.wikimedia.org/wikipedia/tr/thumb/5/56/Panslabirent.jpg/330px-Panslabirent.jpg",
                 Category = "Fantastik, Korku",
                 Year = 2007,
                 Country = "İspanya",
                 Trailer = "https://www.youtube.com/watch?v=AcHasH-nLhU",
                 Age = 12,
                 Starring = " Ivana Baquero, Sergi López, Doug Jones",
                 Creators = " Guillermo del Toro",
                 Explane = "Pan’ın Labirenti, fantastik bir dünyaya kaçan küçük bir kızın hikayesini anlatıyor. İspanya’da faşist iktidarın tüm vahşetinin gölgesinde yalnız bir kız çocuğu olan Ofelia, sadist eğilimleri olan babasının etrafındakilere yaptığı tüm eziyetleri bizzat gözlemlemektedir. Bu küçük kız çocuğunun gerçeklikten kaçabileceği tek yer kendi hayal gücüdür. Ofelia, gerçeklikte bulamadığı huzuru, hayallerinde aramaya başlayacaktır. Bu esnada vahşet ise tüm sertliğiyle Ofelia’nın çevresinde vuku bulmaya devam edecektir. Guillermo del Toro’nun gösterildiği sene Cannes’da dakikalarca ayakta alkışlanan yakın dönem başyapıtı, çocukların gözünden savaşın ne kadar sert bir fırtına olduğunu gözler önüne seriyor",
                 Imdb = "8.2",
                 PictureSource = "wikipedia.org",
                 TextMovieSource = "beyazperde.com"
             },
             new Avrupa1
             {
                 Id = Guid.NewGuid(),
                 Name = "Yasak Aşk",
                 Minute = 136,
                 Url = "https://tr.web.img4.acsta.net/medias/nmedia/18/89/46/38/20176843.jpg",
                 Category = "Tarihi, Romantik, Dram",
                 Year = 2012,
                 Country = "Danimarka",
                 Trailer = "https://www.youtube.com/watch?v=e8762G2Toeg",
                 Age = 12,
                 Starring = " Mads Mikkelsen, Alicia Vikander, Mikkel Boe Folsgaard",
                 Creators = " Nikolaj Arcel",
                 Explane = "Danimarka kralı VII. Christian akli dengesi tam da yerinde olmayan, kafasına göre hareket eden, uçuk-kaçık bir karakterdedir. Asabidir, alkolü, fahişelerle eğlenmeyi ülke yönetiminden daha önemli görmektedir; zaten kendisine bağlı olan konseyde kralın tescilli deliliğini fırsat bilerek ülkeyi istediği gibi yönetmektedir. İngiltere prensesiyle politik çıkarlar için evlendirilir; Prenses Caroline ülkeye gelirken sanatçı bir ruhlu bir kral ile evlendiğini sanarken, karşısında hala büyümemiş bir çocuk bulur.Danışmanları tüm ülkede seçkin isimler arasından krala uygun doktor ararken,sıradan bir kasaba doktoru olan Friedrich Struensee çatlak kralın gözüne girer ve sadece kraliyet doktoru olmakla kalmaz kralın en iyi dostu,danışmanı olur.Bu süreçte de kralın çoktan gözden çıkarttığı,sıkıcı bulduğu Kraliçe Caroline ile de aralarında karşı konulmaz bir çekim oluşur.Doktorun ve kraliçenin yaşadığı gizli aşk,bir ulusun da aydınlanmaya giden yoluna öncülük edecektir…",
                 Imdb = "7.5",
                 PictureSource = "beyazperde.com",
                 TextMovieSource = "beyazperde.com"
             },
             new Avrupa1
             {
                 Id = Guid.NewGuid(),
                 Name = "Kış Uykusu",
                 Minute = 196,
                 Url = "https://tr.web.img4.acsta.net/pictures/14/06/05/12/02/003302.jpg",
                 Category = "Dram",
                 Year = 2014,
                 Country = "Türkiye",
                 Trailer = "https://www.youtube.com/watch?v=Jce0Kdb96zoLL",
                 Age = 12,
                 Starring = " Haluk Bilginer, Melisa Sözen, Demet Akbağ",
                 Creators = "Nuri Bilge Ceylan",
                 Explane = "Aydın emekli bir tiyatrocudur; oyunculuğu bıraktıktan sonra Kapadokya'ya babasından yadigar kalan butik oteli işletmek için geri döner. Aydın o günden sonra başlayan kış uykusu bu gözlerden ırak otelin içerisindeki gündelikleriyle, kah yerel bir gazeteye köşe yazıları yazarak kah her zaman niyetlendiği ancak bir türlü başlayamadığı tiyatro tarihi kitabını yazmayı düşünerek geçer. Tüm bu süreçte hayatında iki kadın vardır: Kendisine her anlamda uzak ve soğuk davranan genç karısı Nihal ve boşandıktan sonra yanlarına taşınan kız kardeşi Necla... Kışın bastırması ve artan kar yağışı bu küçük taşrada en çok Aydın'ın sinirlerine dokunur ve onu uzaklara gitmeye teşvik eder... Türk sinemasının Cannes tescilli,bol ödüllü yönetmeni Nuri Bilge Ceylan'ın Bir Zamanlar Anadolu'da filminden sonra hayata geçirdiği ve Cannes'da büyük ödül Altın Palmiye'ye layık görülen son filmi olan Kış Uykusu'nun başrolünde Haluk Bilginer yer alırken kadroda kendisine Demet Akbağ, Melisa Sözen, Ayberk Pekcan, Serhat Kılıç, Tamer Levent, Nejat İşler ve Nadir Sarıbacak eşlik ediyor. ",
                 Imdb = "8.0",
                 PictureSource = "beyazperde.com",
                 TextMovieSource = "beyazperde.com"
             },
             new Avrupa1
             {
                 Id = Guid.NewGuid(),
                 Name = "Koş Lola Koş",
                 Minute = 81,
                 Url = "https://tr.web.img3.acsta.net/pictures/bzp/03/10295.jpg",
                 Category = "Gerilim, Aksiyon, Dram",
                 Year = 1998,
                 Country = "Almanya",
                 Trailer = "https://www.youtube.com/watch?v=uz2-D4lY2qg",
                 Age = 12,
                 Starring = " Franka Potente, Moritz Bleibtreu, Herbert Knaup",
                 Creators = " Tom Tykwer",
                 Explane = "Genç ve güzel bir kız olan Lola’nın sevgilisi, mafya için kuryelik yapmaktadır. Son işinde Lola (Franka Potente) onunla buluşmakta gecikince Manni (Moritz Bleibtreu) alması gereken 100.000 DM’lik parayı kaybeder. Mafyanın sevgilisini öldürmemesi için Lola’nın 20 dakika içinde o para çantasını bulması veya biryerden bu parayı temin etmesi gerekmektedir. Zamana karşı yarış başlamıştır...Berlin’den sokak manzaraları ve techno müzik eşliğinde hızlı ve sürükleyici bir macera filmi olan Lola Rennt,pek çok film festivalinden ödüllerle dönmüş başarılı bir yapım.",
                 Imdb = "7.7",
                 PictureSource = "beyazperde.com",
                 TextMovieSource = "beyazperde.com"
             },
             new Avrupa1
             {
                 Id = Guid.NewGuid(),
                 Name = "Trainspotting",
                 Minute = 93,
                 Url = "https://tr.web.img4.acsta.net/pictures/bzp/01/14788.jpg",
                 Category = "Dram, Polisiye",
                 Year = 1996,
                 Country = "İngiltere",
                 Trailer = "https://www.youtube.com/watch?v=8LuxOYIpu-I",
                 Age = 12,
                 Starring = "Ewan McGregor, Ewen Bremner, Jonny Lee Miller",
                 Creators = "Danny Boyle",
                 Explane = "Trainspotting, 20’li yaşlardaki Mark Renton ve arkadaş grubunun uyuşturu müptelalığını konu ediyor. Renton hayatta uyuşturucu dışında hiçbir amacı olmayan bir gençtir. Arkadaş grubu da Renton’dan farklı değildir. Tek amaçları daha fazla uyuşturucu almak, partilere katılmak ve gittikleri yerlerde sorun yaratmaktır. Renton her bağımlı gibi uyuşturcuyu bırakmaya defalarca denese de başaramamıştır ve bir gün tekrar bırakmayı dener. Ancak başarılı olamayan adam aksine, bir altın vuruş deneyimiyle de karşı karşıya kalmıştır. Hastaneye kaldırılan Renton, artık daha başka biri olma yolundadır.Yer altı edebiyatının en önemli yazalarından biri olan Irvine Welsh’in ünlü romanı Trainspotting’ten sinemaya uyarlanan film ünlü yönetmen Danny Boyle tarafından yönetilmiş,başrollerindeki Ewan McGregor güçlü performansıyla göz doldurmuştur.",
                 Imdb = "8.3",
                 PictureSource = "beyazperde.com",
                 TextMovieSource = "beyazperde.com"
             }


            );
        }
    }
}
