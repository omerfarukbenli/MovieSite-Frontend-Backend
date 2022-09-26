using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Movie.Api.Models.Entities;

namespace Movie.Api.Configurations
{
    public class Animasyon1Configuration : IEntityTypeConfiguration<Animasyon1>
    {
        public void Configure(EntityTypeBuilder<Animasyon1> builder)
        {
            builder.HasData(
                 new Animasyon1
                 {
                     Id = Guid.NewGuid(),
                     Name = "Kayıp Balık Nemo",
                     Minute = 100,
                     Url = "https://turkcealtyazi.org/images/poster/0266543.jpg",
                     Category = "Animasyon, Macera",
                     Year = 2003,
                     Country = "ABD",
                     Trailer = "https://www.youtube.com/watch?v=2zLkasScy7A",
                     Age = 6,
                     Starring = "Albert Brooks, Ellen DeGeneres, Alexander Gould",
                     Creators = "Andrew Stanton, Lee Unkrich",
                     Explane = "Bir palyaço balığı olan Marlin, belki de karısının zamansız ölümü nedeniyle küçük oğlu Nemo için fazla kaygılanmaktadır. Ancak Nemo'nun da kendi başına hareket etmesi gerektiği zamanlar gelir çatar. Deniz altı dünyasının okuluna gidip, eğitim görmek zorundadır. Nemo bu okula giderken Marlin'in korktuğu başına gelir ve oğlu arkadaşları ile oynadıkları tehlikeli bir oyun sırasında gözünün önünde kaybolur.Film Marlin'in oğlunu bulmak için harcadığı çabaları ve Nemo'nun da geri dönmek için verdiği büyük mücadeleyi anlatıyor.Filmde,çok güçlü bilgisayarların yardımıyla gerçek ve sayısal görüntüler kaynaştırılarak,insanlar gibi davranan ve konuşan tüm deniz altı canlıları inandırıcı bir şekilde canlandırılmış. 'Kayıp Balık Nemo',Pixar'ın 'Oyuncak Hikayesi' (Toy Story, 1995 ve 1999) ve Sevimli Canavarlar'dan(Monsters, Inc., 2001) sonra canlandırma sineması tarihinde başarılı bir adım sayılan üçüncü filmleri oldu.",
                     Imdb = "8.2",
                     PictureSource = "turkcealtyazi.org",
                     TextMovieSource = "wikipedia.org"
                 },
                 new Animasyon1
                 {
                     Id = Guid.NewGuid(),
                     Name = "İnanılmaz Aile",
                     Minute = 123,
                     Url = "https://upload.wikimedia.org/wikipedia/tr/thumb/f/fe/%C4%B0nan%C4%B1lmaz_Aile_afi%C5%9F.jpg/330px-%C4%B0nan%C4%B1lmaz_Aile_afi%C5%9F.jpg",
                     Category = "Animasyon, Macera",
                     Year = 2004,
                     Country = "ABD",
                     Trailer = "https://www.youtube.com/watch?v=-UaGUdNJdRQ",
                     Age = 6,
                     Starring = "Jason Lee, Brad Bird, Sarah Vowell",
                     Creators = "Brad Bird",
                     Explane = "Animasyon kahramanı Mr Incredible adı altında dünyada var olan kötülüklerle mücadele eden ve insanları kötücül şeylerden korumaya çalışan Bob Parr, dünyaca meşhurdur. Bir süre sonra hayatının bu denli yorucu olmasından yana şikayetçi olup emekliye ayrılmak ister. Eşi ve çocukları ile beraber daha sakin ve sıradan bir yaşam düzenine geçer. Çok geçmeden bu düzenden de sıkılır çünkü sigortacılık gibi bir iş onu pek kesmemektedir. Evren niyet ve isteklerini duyar ve ona bir mesaj iletilir. Bir adada artık gizli bir görevin sahibidir.",
                     Imdb = "8.0",
                     PictureSource = "wikipedia.org",
                     TextMovieSource = "wikipedia.org"
                 },
                 new Animasyon1
                 {
                     Id = Guid.NewGuid(),
                     Name = "Shrek",
                     Minute = 89,
                     Url = "https://upload.wikimedia.org/wikipedia/tr/3/39/Shrek.jpg",
                     Category = "Animasyon, Macera",
                     Year = 2001,
                     Country = "ABD",
                     Trailer = "https://www.youtube.com/watch?v=CwXOrWvPBPk",
                     Age = 6,
                     Starring = "Mike Myers,Eddie Murphy,Cameron Diaz",
                     Creators = "Andrew Adamson",
                     Explane = "Şrek bataklıkta yalnız yaşayan ve yakındaki köy halkının korktuğu yeşil bir devdir.[Not 1] Bir gün evine döndüğünde bütün masal kahramanlarının bataklığına toplandığını görür. Onları kovmaya çalışsa da beceremez. Sonunda pes edip niye buraya geldiklerini ve ne yaparsa gideceklerini sorar. Onlar da Duloc kralı Lord Farquaad'ın kendilerini öldürmek istediğini ve ancak Şrek'in onu vazgeçirebileceğini söylerler. Şrek, bunun üzerine o gün hayatını kurtardığı ve o andan itibaren hep peşinde dolanan geveze Eşek'le birlikte Lord Farquaad'ın bulunduğu Duloc Krallığı'na doğru yola koyulur.Oraya vardığında hayatında görmediği kadar büyük bir şehirle karşılaşır; fakat ortalıkta kimse yoktur. Uzaktan gelen sesleri takip ederler ve kendilerini bir gladyator gösterisinin içinde bulurlar. Shrek iyi niyetle krala durumu anlatmaya çalışır fakat kral onu öldürme emri verir.Shrek ve eşek de üzerlerine saldıran herkesi bir yere fırlatırlar. Kral da mecburen dinlemek zorunda kalır. Kral, o günlerde ancak evlenirse gerçek bir kral olabileceğini duyduğu için prenses arayışına girmiştir.Bu arada Farquaad Zencefil Adam'a işkence yaparak kalan masalın yerini belirledi. Sihirli Ayna ona gerekli bilgileri vermek zorunda kalır. Ayna ona prensesle evleneceği halde kral olabileceğini söyledi. Farquadd bir prenses beğendi, fakat beğendiği prenses olan Prenses Fiona'nın ejderhayla korunan bir kalenin en yüksek kulesinin en tepesindeki odada olduğunu öğrenmiştir.Bunun üzerine Shrek'e istediklerinin olması için o prensesi ona getirmesini söyler. Shrek de kabul eder.Şrek ve Eşek Prenses Fiona'yı bulurlar. Prenses yıllardır hayatının aşkını beklediği için kafasındaki zırhı çıkarmasını ister. Şrek de çıkarır ve prenses hayal kırıklığına uğrar. Prenses eğer onu gerçekten seviyorsa onu kendisinin gelip kurtarması gerektiğini söyler ve geri dönmek ister, fakat Shrek izin vermez.Uzun bir yolculuğun sonunda Şrek, Fiona'ya karşı bir şeyler hissettiğini fark eder fakat ertesi gün saraya varacaklarından ne yapacağını şaşırır. Prenses Shrek'ten geceleri çirkin bir hale dönüştüğünü gizlemek için güneş kararmadan yatmaktadır.Eşek bunu şans eseri görür ve prenses olanları ona anlatırken Shrek elinde çiçekle ona aşkını itiraf etmeye gelecektir. Kapıdayken olanları duyar fakat prensesin çirkin diye bahsettiği kişinin kendisi olduğunu düşünür ve çok üzülür.Şrek bu üzüntüyle tüm gece boyunca kaleye kadar yürür ve güneş doğduğunda kralla beraber gelir.Fiona da aslında Shrek'i sevmektedir. Fakat Shrek ona kızgın olduğu için onu sevmediğini ve gitmesini istediğini söyleyince prenses de üzülüp gider.Şrek Eşek'le konuşurken gerçekleri öğrenir fakat Fiona'nın evlenmesine çok az zaman kalmıştır. Ama Eşek Şrek'e sürpriz yapar. Ve ejderha ile evliliklerine yetişirler.Şrek tam içeri girmek için kapıya yaklaştığı anda Eşek Şrek'in önüne geçer. Ona Rahibin sözünü söylemesi için beklemesini ister ama rahip o sözü çoktan söylemiştir.Tam Lord Farquaad Fionayı öperken Şrek 'İtiraz ediyorum.' der.Fionayla Lord Farquaad'ın birbirini öpmesini engeller. Lord Farquaad için bu durum komik aynı zamanda sinir bozucudur. Bir devin prensese aşık olamayacağını söyleyerek alay eder ve Şrek'i uzaklaştırmak ister.Fiona bu duruma karşı çıkacağı sırada güneş batar ve Fiona deve dönüşür. Lord Farquaad çileden çıkar ve askerlerini Şrek ile Fionaya saldırmalarını söyler.O sırada Eşek ile Ejderha gelir. Ejderha Lord Farquaadı yer. Daha sonra Şrek ile Fiona, Eşek ile Ejderha evlenirler. Ve sonsuza dek mutlu yaşamaya başlarlar.",
                     Imdb = "7.9",
                     PictureSource = "wikipedia.org",
                     TextMovieSource = "wikipedia.org"
                 },
                 new Animasyon1
                 {
                     Id = Guid.NewGuid(),
                     Name = "Tenten'in Maceraları",
                     Minute = 107,
                     Url = "https://upload.wikimedia.org/wikipedia/tr/0/0a/The_Adventures_of_Tintin_Secret_of_the_Unicorn.jpg",
                     Category = "Animasyon, Macera",
                     Year = 2011,
                     Country = "ABD",
                     Trailer = "https://www.youtube.com/watch?v=fE5IQybGRPc",
                     Age = 6,
                     Starring = " Jamie Bell, Andy Serkis, Daniel Craig",
                     Creators = "Steven Spielberg",
                     Explane = "Tenten ve köpeği Milu çıktıkları bir gezi esnasında maket bir gemi bulurlar ve beğenip alırlar. Ancak bu gemi zannettikleri kadar sıradan değildir. Geminin Tenten'in evine gelmesiyle birlikte etraflarında bir sürü kötü adam belirmeye başlar. Bu kötü adamlar, geminin değil geminin içerisindeki bir notun peşindedirler. Tenten geminin ve geminin getirdiklerinin sırrını çözmeye fazlasıyla kararlıdır.",
                     Imdb = "7.3",
                     PictureSource = "wikipedia.org",
                     TextMovieSource = "wikipedia.org"
                 },
                 new Animasyon1
                 {
                     Id = Guid.NewGuid(),
                     Name = "Karlar Ülkesi",
                     Minute = 102,
                     Url = "https://upload.wikimedia.org/wikipedia/tr/0/05/Frozen_%282013_film%29_poster.jpg",
                     Category = "Animasyon, Macera",
                     Year = 2013,
                     Country = "ABD",
                     Trailer = "https://www.youtube.com/watch?v=FLzfXQSPBOg",
                     Age = 6,
                     Starring = "Kristen Bell, Idina Menzel, Jonathan Groff (II)",
                     Creators = " Chris Buck, Jennifer Lee",
                     Explane = "Arendelle Prensesi olan Elsa, buz ve karı kontrol edebileceği sihirli güçlere sahiptir ve genellikle bu gücünü küçük kız kardeşi Anna ile oynamak için kullanır. Ancak bir gün Elsa yanlışlıkla Anna'yı sihriyle yaralar, anne ve babası iki kardeşi de Grand Pabbie liderliğindeki bir trol kolonisine götürür. Grand Pabbie Anna'yı iyileştirir fakat anılarını değiştirir, bu yüzden Anna, Elsa'nın sihirli güçleri olduğunu unutur. Grand Pabbie, Elsa'yı güçlerini kontrol etmeyi öğrenmesi gerektiği ve korkunun onun en büyük düşmanı olacağı konusunda uyarır. Kral ve Kraliçe, her iki kız kardeşi de saray içinde izole eder ve saray kapılarını kapatır. Elsa, Anna'yı giderek artan güçlerinden korumak için onunla olan tüm temasını keser. Bu şekilde yıllar geçer ve kız kardeşler büyürler, Kral ve Kraliçe denize açıldıklarında fırtına ortasında kalırlar ve ölürler.Elsa 21.yaş gününün ardından Arendelle'nin kraliçesi olarak taç giyecektir. Ama Elsa buna sevinmek yerine halkın güçlerini öğrenmeleri ve kendisinden korkmaları ihtimalini düşünerek endişelenir. Ve sonunda saray kapıları yıllar sonra ilk kez halka ve ziyarete gelenlere açılır. Ziyaretçilerin arasında, Anna'nın ilk görüşte aşık olduğu Güney Adaları'nın yakışıklı Prensi Hans ve entrikacı Weselton Dükü de vardır. Elsa'nın taç giyme töreni olaysız gerçekleşir,ancak Elsa Anna'dan hala uzak durmaktadır. Anna ve Hans, taç giyme şenlikleri sırasında romantik bir bağ kurarlar ve Anna düşünmeden Hans'a evlenme teklifi eder,evlenmek için Elsa'nın onayını istediklerinde Elsa buna karşı çıkar. Canı yanmış ve kafası karışmış olan Anna, Elsa'ya neden yıllardır kendisini dışladığını açıklaması için yalvarır.Bu duygusal gerginlik,Elsa'nın güçlerini kontrol edememesine neden olur. Weselton Dükü tarafından canavar olarak damgalanan Elsa, Kuzey Dağı'na kaçar ve yanlız bir hayat yaşamak için kendine buzdan bir saray inşa eder.Bu süreçte,büyüsü istemeden Arendelle'i sonsuz bir kışa sokar.Anna,Elsa'yı bulmak ve sonsuz kışı sona erdirmek için dışarı çıkar, krallığı Hans'a emanet eder.Wandering Oaken'ın dükkanından malzeme alır ancak dışarda kaybolduğunu farkeder. Kristoff ve ren geyiği Sven ile tanışır ve onları kendisini dağlara götürmeleri için ikna eder. Kurtların saldırısı, Kristoff'un kızağının yok olmasına neden olur.Anna'nın atı korktuğu için onsuz Arendelle'e döndüğünde Hans,Elsa'yı öldürmek için gizli emirleri olan Dük'ün yardımcılarıyla birlikte Anna ve Elsa'yı bulmaya koyulur. O sırada Kristoff ve yolda tanıştığı kardan adam Olaf yardımıyla buzdan saraya ulaşan Anna, Elsa'yı bulur.Anna,Arendelle'e ne olduğunu söyleyince dehşete düşen Elsa, sihrini nasıl geri alacağını bilmediğini itiraf eder. Bu korkusu, güçlerinin bir kez daha ortaya çıkmasına neden olur ve yanlışlıkla Anna'nın kalbini dondurarak onu ciddi bir şekilde yaralar.Anna'yı güvende tutmak için çaresiz kalan Elsa, onları kovalaması için Marshmallow adında dev bir kar canavarı yaratır. Elsa'nın büyüsünün Anna üzerindeki etkilerini fark eden Kristoff,kendisini evlat edinen ailesi olan trollere götürür.Grand Pabbie,ancak gerçek aşkın Anna'yı iyileştirebileceğini söyler.Kristoff,Anna'nın ölmemesi için onu Hans'ın yanına,saraya hızla götürmeye çalışır.Bu sırada Hans ve adamları Elsa'nın sarayına ulaşır, Marshmallow'u uçuruma düşürerek Elsa'yı yakalarlar. Anna, Hans'ın yanına gitmeyi başarır ancak Hans,onu öpmez ve aslında her iki kız kardeşi de ortadan kaldırarak Arendelle'nin tahtını ele geçirmeyi planladığını gülerek Anna'ya anlatır onu ölmesi için bir odaya kilitler ve ardından herkesi Elsa'nın onu öldürdüğüne inandırır ayrıca krallığın başına geçmek için ölmeden önce evlendikleri yalanını söyler. Kraliçenin idamını emreder ama Elsa tutulduğu yerden kaçar.Anna'nın imdadına kardan adam arkadaşı Olaf yetişir ve aslında Kristoff'un kendisine aşık olduğunu anlamasını sağlar,Kristoff'u bulmak için dışarıdaki kar fırtınasına girerler. Hans, Anna'yı öldürdüğünü iddia ederek Elsayı öldürmek ister,Elsa karşı gelmeyi bırakıp teslim olunca fırtına aniden durur.Anna,Hans'ın Elsa'yı öldürmek üzere olduğunu görür,Elsa'nın önüne atlar ve tam bu sırada vücudu donar bu yüzden Hans'ın kılıcı kırılır.Yıkılan Elsa,donmuş olan kız kardeşine sarılarak ağlar ve bu gerçek aşk eylemini oluşturan şey olur.Sevginin,sihrini kontrol etmenin anahtarı olduğunu anlayan Elsa kışı bitirir.Hans,ihaneti ve suikast girişimi nedeniyle tutuklanarak ve krallıktan sürgün edilirken,Weselton Dükü'nün Arendelle ile ticari bağlantıları kesilir. Anna, Kristoff'a yeni bir kızak ve ayrıca birde öpücük verir.Kız kardeşler tekrar bir araya gelir ve Elsa bir daha asla sarayın kapılarını kapatmayacağına söz verir.",
                     Imdb = "7.4",
                     PictureSource = "wikipedia.org",
                     TextMovieSource = "wikipedia.org"
                 },
                 new Animasyon1
                 {
                     Id = Guid.NewGuid(),
                     Name = "Ejderhanı Nasıl Eğitirsin",
                     Minute = 93,
                     Url = "https://upload.wikimedia.org/wikipedia/tr/9/99/How_to_Train_Your_Dragon_Poster.jpg",
                     Category = "Animasyon, Macera",
                     Year = 2010,
                     Country = "ABD",
                     Trailer = "https://www.youtube.com/watch?v=oKiYuIsPxYk",
                     Age = 6,
                     Starring = " Jay Baruchel, Gerard Butler, America Ferrera",
                     Creators = " Chris Sanders, Dean DeBlois",
                     Explane = "Berk adasında yaşayan Vikingler geçimlerini balıkçılık, avcılık gibi işler yaparak sağlamaktadır. Tek sorunları geceleri Berk'e saldırıp evleri ateşe veren, koyunları ve çeşitli yiyecekleri çalan, insanları öldüren ejderhalardır. Bunca saldırıya rağmen inatçılıkları yüzünden adadan gitmemişler ve Berk'te kalıp ejderhalarla savaşmaktadırlar.Bir gece yine Berk adasına ejderha saldırısı olur.Adada yaşayan Vikingler ejderhalara karşılık verirler.Bu sırada adada yaşayan küçük Hıçkıdık da ejderhalarla savaşmak için dışarıdadır.Çünkü bir ejderha öldürmek Berk'te her şeye bedeldir. Bir ejderha öldürürse şöhret ve hatta bir kız arkadaş bile bulabileceğini düşünmektedir. Dışarıda koşuştururken onu Geğirik yakalar. Geğirik bir demircidir, Hıçkıdık da onun çırağı... Onu dışarıdaki saldırıdan korumak için dükkâna götürür. Ama Hıçkıdık bundan memnun olmamıştır, çünkü dışarıda kalıp ejderha öldürmek istiyordur. Bu sayede bir kızla çıkabileceğini düşünmektedir. Ama Geğirik izin vermez, Hıçkıdık'ın kılıçları bilemesini ister.Daha sonra Geğirik ejderhalarla savaşmak için dışarı çıkar.Bunu fırsat bilen Hıçkıdık kimseler yokken dışarı çıkar.Elinde ise ip fırlatan bir alet vardır.Daha sonra ortaya Gecenin Öfkesi isimli bir ejderha çıkar.Bu ejderha,diğer ejderhalardan farklı olarak,kendini göstermez,yiyecek çalmaz ve asla ıskalamazdı.Daha önce hiç Gecenin Öfkesi gören olmadı, çünkü daha önce kimse Gecenin Öfkesini yakalayamamıştı.Hıçkıdık insanlardan uzak bir yerde durup avını beklemektedir.Daha sonra Gecenin Öfkesinin sesi gelir.Gecenin Öfkesi bir yere ateş ettiği sırada Hıçkıdık silahını kullanır ve ejderha uzakta olmasına rağmen onu vurur.Ama Hıçkıdık'ın ejderhayı vurduğunu gören olmaz. Hıçkıdık ilk ejderhasını vurduğu için sevinir ama sevinci yarıda kalır. Çünkü arkasından korkunç kâbus cinsi bir ejderha gelir. Ancak en iyi Vikingler o ejderha ile baş edebilir. Bunu Berk adasının reisi aynı zamanda Hıçkıdık'ın babası olan Kayıtsız Zebella görür ve ejderha ile savaşarak onu kurtarır.Daha sonra saldırı biter.Hıçkıdık babasına bir ejderha vurduğunu ve onu aramaları gerektiğini anlatır.Hıçkıdık'ın babası Kayıtsız Zebella, Hıçkıdık'ı dinlemez ve saldırı sırasında dışarıda olduğu için çok kızar.Daha sonra Hıçkıdık'tan eve gitmesini ister.Günün erken saatlerinde Hıçkıdık ormanda dolaşırken uzakta bir şey fark eder.Yanına yaklaşınca bunun dün akşamki saldırı sırasında vurduğu Gecenin Öfkesi olduğunu fark eder.Ejderhanın yanına yaklaşır,bıçağını çeker ejderhaya onu öldüreceğini söyler.Daha sonra ejderhaya acır ve ejderhanın iplerini keser.İpleri kesilir kesilmez Gecenin Öfkesi hemen Hıçkıdık'ın üzerine atlar. Ejderha, üzerinde durduğu Hıçkıdık'a kükrer.Hıçkıdık korkar ama ejderha onun canını bağışlar.Bu sırada Kayıtsız Zebella,Berk adasındaki Viking savaşçılarıyla ejderhaların yuvasını bulup yok etmek üzere toplantı yapar.Toplantıdan ejderha yuvasını bulmak için sefer yapma kararı çıkar.Ancak Zebella Hıçkıdık'ı yokluğunda nasıl zaptedeceğini bilemez. Geğirik ise Hıçkıdık'ı ejderhalar akademisine yazdırmayı önerir.Kayıtsız Zebella,Geğirik'in tavsiyesiyle Hıçkıdık'ı ejderhalar akademisine yazdırır.Zebella akşam eve döndüğünde Hıçkıdık'a bu haberi verir. Hıçkıdık babasına artık ejderha öldürmek istemediğini söyler. Ama babası bunu kabul etmez.Ertesi gün Zebella askerlerle birlikte deniz seferine çıkar.Hıçkıdık ise akademideki ilk gününe başlamıştır.Hıçkıdık ile beraber Astrid,Südüklü,Balık Ayak,ikizler Ters Ceviz ve Sert Ceviz de eğitim için akademiye gelmiştir.Akademide eğitim veren kişi ise Geğirik'tir. İlk olarak Gronckle cinsi bir ejderha ile eğitime başlarlar. Eğitimin sonlarına doğru ejderha Hıçkıdık'a ateş atmak üzereyken Geğirik yetişir ve Hıçkıdık'ı ölmekten kurtarır.Yine bir gün ormana giden Hıçkıdık ormanda Gecenin Öfkesini görür.Ama neden uçup adadan hâlâ gitmediğini anlamaz.Günler sonra ejderhanın kuyruğunun zarar gördüğünü anlar.Ejderhaya yiyecek balık getirerek yaklaşmaya başlar.Ejderhaya balığı uzattığı sırada dişlerinin olmadığını görür.Daha sonra ejderha ağzında gizlediği dişlerini çıkarır ve balığı yer.Gecenin Öfkesi dişlerini gizleyebildiği için Hıçkıdık ona Dişsiz adını verir.Hıçkıdık Dişsiz ile gitgide iyi vakit geçirir.Ama bunu herkesten saklar,çünkü Berk halkı ejderhayı fark ederse onu öldürebileceklerini düşünüyordur.Dişsiz fark edilmesin diye onunla her gün gizli gizli buluşur.Hıçkıdık bir gün Dişsiz'in zarar gören kuyruğuna uyduruk bir kanat yapar. Kanat bir düzenekle Hıçkıdık'ın ayağına bağlıdır.Bu sayede kanadı,dolayısıyla da ejderhayı ayak hareketleriyle kontrol edebiliyordur.Ancak kanat Dişsiz'in vücudunun bir parçası olmadığı için Dişsiz kanadı tek başına kullanamaz. Bunun için Hıçkıdık'ın ejderhanın sırtına binip kuyruk kanadını kendisi kontrol etmesi gerekir.Hıçkıdık ejderhanın sırtına binmek için bir de eyer yapmıştır.Bir zaman sonra artık ejderhayı havada kontrol etmeyi öğrenmiştir.Hıçkıdık boş zamanlarda ormana gidip Dişsiz ile vakit geçirdiği için ejderhalar hakkında bilgiler öğrenir.Bu bilgileri ejderha akademisinde kullanarak testleri geçer herkesin dikkatini üzerine çeker.Astrid ise dikkatlerin Hıçkıdık'ta olmasından rahatsızdır. Astrid neler olup bittiğini öğrenmek için Hıçkıdık'ın ejderhayı sakladığı yere gelir.Hıçkıdık,Astrid'i fark ettiği zaman Astrid Dişsiz'i görmesin diye onu oylamaya çalışır.Ama Dişsiz Astrid'in Hıçkıdık'a zarar verdiğini düşünerek saklandığı yerden çıkarak Astrid'in üzerine doğru koşar. Hıçkıdık Dişsiz'in önüne atılır ve onu durdurur.Astrid panik içinde kaçmaya başlar.Dişsiz sırtında Hıçkıdık ile uçarak Astrid'i yakalar ve onu bir ağacın tepesine bırakır. Hıçkıdık olanları açıklamak için Astrid'in kendisine izin vermesini ister.Astrid gönülsüz bir şekilde kabul eder ve Dişsiz'in sırtına biner. Dişsiz huysuzluk yaparak Astrid'i korkutur.Astrid Hıçkıdık'tan özür dinleyince Dişsiz sakinleşir. Hıçkıdık Astrid ile akşama kadar turlar. Astrid ise gördüğü manzaradan etkilenir ve Hıçkıdık'a ısınmaya başlar.O sırada Dişsiz kendi ejderha grubunu fark eder.Grubun içine girer ve grubundaki ejderhalarla birlikte uçmaya başlar.Diğer ejderhalar üzerlerinde yiyecek taşımaktadır.Daha sonra ejderhalar yuvaya varır.Hıçkıdık ve Astrid korkarlar ve buradan ayrılmak isterler.Dişsiz ise onlara bir şeyler göstermek istiyordur.Dişsiz'in gösterdiği şey karşısında Hıçkıdık ve Astrid şaşırır. Dişsiz'in gösterdiği şeyden sonra Hıçkıdık ve Astrid,ejderhaların neden Berk'e saldırıp yiyecek çaldıklarını anlamış olurlar.",
                     Imdb = "8.1",
                     PictureSource = "wikipedia.org",
                     TextMovieSource = "wikipedia.org"
                 },
                 new Animasyon1
                 {
                     Id = Guid.NewGuid(),
                     Name = "Ratatuy",
                     Minute = 110,
                     Url = "https://upload.wikimedia.org/wikipedia/tr/b/b9/RatatouillePoster2.jpg",
                     Category = "Animasyoni Macera, Komedi",
                     Year = 2007,
                     Country = "ABD",
                     Trailer = "https://www.youtube.com/watch?v=Ro8g2fA7gJk",
                     Age = 6,
                     Starring = "Patton Oswalt, Brad Garrett, Lou Romano",
                     Creators = " Brad Bird",
                     Explane = "işman fare Remy, yemeğe olan düşkünlüğü nedeniyle tek bir hayale sahiptir: Aşçı olabilmek! Bu idealini gerçekleştirmek için Paris'in yolunu tutan sevimli fare kaza eseri kendisini şehrin en iyi restoranının kanalizasyonunda bulur. Restoranın yeni çöpçüsüyle ilginç bir anlaşma yapan Remy, tüm hünerlerini sergileyebileceği büyülü mutfağa ulaşmaştır. Ancak bu tek hayalini gerçekleştirmek, farelerden iğrenen bir insanlığın var olduğu bir dünyada pek kolay olmayacaktır.Walt Disney'den çıkan film, Kayıp Balık Nemo, Yukarı Bak, Oyuncak Hikayesi gibi animasyon türünün en yaratıcı örneklerinin üretildiği Pixar stüdyolarının ürünü. Yönetmenlik ve senaryo yazımını Brad Bird ve Jan Pinkava ikilisinin üstlendiği Ratatuy, gösterime girdiği yıl Akademi Ödülleri'nde 'En İyi Animasyon Film' Oscar'ını kazanmıştı.",
                     Imdb = "8.1",
                     PictureSource = "wikipedia.org",
                     TextMovieSource = "beyazperde.com"
                 },
                 new Animasyon1
                 {
                     Id = Guid.NewGuid(),
                     Name = "Yukarı Bak",
                     Minute = 95,
                     Url = "https://upload.wikimedia.org/wikipedia/tr/thumb/e/e8/Yukar%C4%B1_Bak.jpg/330px-Yukar%C4%B1_Bak.jpg",
                     Category = "Animasyon, Macera",
                     Year = 2009,
                     Country = "ABD",
                     Trailer = "https://www.youtube.com/watch?v=HWEW_qTLSEE",
                     Age = 6,
                     Starring = "Edward Asner, Jordan Nagai, Bob Peterson",
                     Creators = "Pete Docter, Bob Peterson",
                     Explane = "Yukarı Bak'ta rastlantı eseri yolları kesişen iki çocuk, yıllarca sürecek tatlı ve dokunaklı bir hikayenin başkahramanlarıdır. Maceracı doğan ve hayattaki her şeye dair çocuksu saf meraklar barındıran Ellie’nin tek hayali dünyayı gezebilmektir. Carl ise sessizliği ve dinginliğiyle örttüğü maceraperestliği ve kocaman kalbiyle Ellie’nin tek isteğini gerçekleştirebilmeyi dilemektedir. İki küçük çocuk büyür, evlenir, yaşlanır... Ölüm Ellie’nin kapısını çalar, Carl ise sevdiğinden kalan tek şeyi, bu çocuksu hayali gerçekleştirmeye koyulur.Pixar stüdyolarının yaratıcılığın zirve yaptığı anlardan biri olan film,animasyonun her yaştan izleyiciye hitap ettiği gerçeğini bir kez daha kanıtlıyor.Her haliyle masum ve dokunaklı olabilen bu öykü,senesinin en iyi animasyon Oscar’ına layık görülmüştü.",
                     Imdb = "8.3",
                     PictureSource = "wikipedia.org",
                     TextMovieSource = "beyazperde.com"
                 },
                 new Animasyon1
                 {
                     Id = Guid.NewGuid(),
                     Name = "Luka",
                     Minute = 100,
                     Url = "https://filmhafizasi.com/wp-content/uploads/2021/09/Luca.jpg",
                     Category = "Animasyon, Macera",
                     Year = 2021,
                     Country = "ABD",
                     Trailer = "https://www.youtube.com/watch?v=mYfJxlgR2jw",
                     Age = 6,
                     Starring = "Jacob Tremblay, Jack Dylan Grazer, Emma Berman",
                     Creators = "Enrico Casarosa",
                     Explane = "Luka, arkadaşı ALberto ile macera dolu bir yaz geçiren Luka'nın hikayesini konu ediyor. Küçük bir çocuk olan Luka, yaz aylarını İtalyan Rivierası’nda makarna yiyip, tüm gün scooterla gezerek geçirir. Luka bu macera dolu yazını, yeni edindiği arkadaşı Alberto paylaşır. Ancak çok geçmeden ikili hayatlarıyla ilglili önemli bir sırrı keşfeder. Luka ve Alberto, okyanus yüzeyinin hemen altında bulunan başka bir dünyadan gelen deniz canavarlarıdır.",
                     Imdb = "7.4",
                     PictureSource = "wikipedia.org",
                     TextMovieSource = "beyazperde.com"
                 },
                 new Animasyon1
                 {
                     Id = Guid.NewGuid(),
                     Name = "Enkanto: Sihirli Dünya",
                     Minute = 103,
                     Url = "https://tr.web.img3.acsta.net/pictures/21/09/30/08/12/5485896.jpg",
                     Category = "Animasyon, Macera",
                     Year = 2021,
                     Country = "ABD",
                     Trailer = "https://www.youtube.com/watch?v=TV9QcLLeEFw",
                     Age = 6,
                     Starring = "Stephanie Beatriz, John Leguizamo, Wilmer Valderrama",
                     Creators = " Charise Castro Smith, Byron Howard, Jared Bush",
                     Explane = "Encanto, Kolombiya dağlarında, sihirli bir evde yaşayan, özel güçleri olan bir ailenin hikayesini konu ediyor. Encanto adı verilen sihirli yerde yaşayan Madrigal ailesinde bir kişi hariç her bir çocuk, endisine özgü sihirli bir hediye ile kutsanır. Yalnızca Mirabel'in sihirli güçleri yoktur. Ancak Encanto'yu çevreleyen sihir tehlikedir ve ailenin yuvası tehdit edildiğinde onların tek umudu Mirabel olur.",
                     Imdb = "7.2",
                     PictureSource = "beyazperde.com",
                     TextMovieSource = "beyazperde.com"
                 },
                 new Animasyon1
                 {
                     Id = Guid.NewGuid(),
                     Name = "Rio",
                     Minute = 96,
                     Url = "https://upload.wikimedia.org/wikipedia/tr/5/5d/Rio_filmi_posteri.jpg",
                     Category = "Animasyon, Macera",
                     Year = 2011,
                     Country = "ABD",
                     Trailer = "https://www.youtube.com/watch?v=P1GRO31ve5Q",
                     Age = 6,
                     Starring = "	Jesse Eisenberg,Anne Hathaway,George Lopez,Jemaine Clement",
                     Creators = "Carlos Saldanha",
                     Explane = "Rio filmi, Blu adında bir mavi papağanın hayatını anlatmaktadır.Blu, daha yavru iken Rio de Janeiro yakınlarındaki bir ormanda tuzağa düşer ve ABD'ye getirilir. Daha sonra Amerikalı bir kız olan Linda, Blu'ya bakmaya başlar.Bir gün,Brezilyalı bir kuşbilimci olan Túlio Monteiro gelir ve makav türünden sadece Blu ve Jewel'in kaldığını, bu yüzden Blu'nun Rio de Janeiro'ya gitmesi gerektiğini söyler. Blu, Rio de Janeiro'da kuş kaçakçıları tarafından kaçırılır.Kaçakçılar Rio'dan kaçmak için Rio Karnavalı'na katılır.Linda ve Túlio da Blu'yu kurtarmak için karnavala katılırlar, ancak karnavalda Blu'yu kurtaramazlar.Daha sonra kaçakçılar uçakla kaçmaya çalışır,ancak Blu ve Jewel kurtulur.O zamana kadar uçamayan Blu,uçaktan atlayınca ilk kez uçar.Daha sonra Linda ve Túlio,Blu ve Jewel'i bulur.Daha sonra Blu ile Jewel'in 3 yavrusu olur. Kaçakçılar ise hapse gönderilir.",
                     Imdb = "6.9",
                     PictureSource = "wikipedia.org",
                     TextMovieSource = "wikipedia.org"
                 },
                 new Animasyon1
                 {
                     Id = Guid.NewGuid(),
                     Name = "Arabalar",
                     Minute = 96,
                     Url = "https://upload.wikimedia.org/wikipedia/tr/thumb/0/00/Cars_Poster.jpg/330px-Cars_Poster.jpg",
                     Category = "Animasyon, Macera",
                     Year = 2006,
                     Country = "ABD",
                     Trailer = "https://www.youtube.com/watch?v=SbXIj2T-_uk",
                     Age = 6,
                     Starring = " Owen Wilson, Paul Newman, Bonnie Hunt",
                     Creators = "John Lasseter",
                     Explane = "Piston Kupa'sını almayı hedefleyen çaylak bir yarışçı olan Şimşek McQueen, son yarışta liderliği 3 yarışçı ile paylaşmıştır. bu yarışcılar Kral lakaplı Strip Weathers ve Chick Hicks'dir. Son bir yarış için California'ya doğru yola çıkan Şimşek McQueen, yolda onu taşıyan araçtan düşer ve kaybolur. Onu taşıyan aracı ararken yolu Radyatör kasabasına düşer. Porsche marka bir araba olan Sally'ye aşık olur ve art arda 3 tane Piston Kupası almış yarışçı Hudson Hornet (Doc) ile tanışır. Kasaba'da yaşayan Çekici Mater ile dostluk kurar. Burda geçirdiği sürede hayatı değişir.California'ya tam vaktinde yetişen Şimşek McQueen, geride bıraktığı anılar yüzünden yarışa odaklanamaz. Yarışın kendisi için bittiğini düşünürken Radyatör kasabasında ki arkadaşları ona yardıma gelir ve Pit lideri Hudson Hornet (Doc) olur. Tam yarışı kazanıcakken Kral (Strip Weathers) bir kaza geçirir. Ona yardım etmek isteyen Şimşek McQueen, Kral'ın yarışını bitirebilmesini sağlar ve bu yüzden yarışı kaybeder.Bundan dolayı saygı gören Şimşek McQueen,mutlu olur ve Radyatör kasabasına geri döner ve yarış üssünü buraya kurar.",
                     Imdb = "7.2",
                     PictureSource = "wikipedia.org",
                     TextMovieSource = "wikipedia.org"
                 },
                  new Animasyon1
                  {
                      Id = Guid.NewGuid(),
                      Name = "Örümcek-Adam: Örümcek Evreninde",
                      Minute = 117,
                      Url = "https://tr.web.img2.acsta.net/pictures/18/12/10/12/17/4139319.jpg",
                      Category = "Animasyon, Aksiyon, Aile",
                      Year = 2018,
                      Country = "ABD",
                      Trailer = "https://www.youtube.com/watch?v=qsQBr46fJMc",
                      Age = 6,
                      Starring = " Bob Persichetti, Peter Ramsey, Rodney Rothman",
                      Creators = "John Lasseter",
                      Explane = "Örümcek-Adam: Örümcek Evreninde, dünyayı kurtarmaya çalışan Brooklyn’li genç Miles Morales’in hikayesini konu ediyor. Polis memuru bir baba ve kendisini işine adamış bir annenin çocuğu olan Miles, yeni okuluna uyum sağlamakta zorlanır. Anne ve babası, sadece yetenekli öğrencilerin bulunduğu bir özel okula giden oğullarının başarısını görmeyi arzulamaktadır. Ancak Miles’ın okulla pek ilgisi yoktur. O daha çok arkadaşları ve kendisini grafiti konusunda cesaretlendiren amcası Aaron ile zaman geçirmek ister. Miles, hayatındaki ufak sorunlarla boğuşurken radyoaktif bir örümcek tarafından ısırılmasıyla bambaşka bir dünyaya adım atar. O artık özel yeteneklere sahip olan bir süper kahramandır. Zehir atma, kamuflaj, nesnelere yapışabilme, çok gelişmiş duyma pek çok güç kazana Miles, gerçek bir süper kahraman olabilmek için Peter Parker, Spider-Gwen, Spider-Man Noir, Spider-Ham’dan yardım alır. Süper kahraman olmanın sorumluluklarını öğrenen Miles artık maskesini takıp kötülüğe karşı savaşmak için harekete geçmelidir.",
                      Imdb = "8.4",
                      PictureSource = "beyazperde.com",
                      TextMovieSource = "beyazperde.com"
                  },
                  new Animasyon1
                  {
                      Id = Guid.NewGuid(),
                      Name = "Raya ve Son Ejderha",
                      Minute = 107,
                      Url = "https://tr.web.img2.acsta.net/pictures/20/10/21/16/18/0351928.jpg",
                      Category = "Animasyon, Fantastik, Macera",
                      Year = 2021,
                      Country = "ABD",
                      Trailer = "https://www.youtube.com/watch?v=JurTPgO9DKo",
                      Age = 6,
                      Starring = " Kelly Marie Tran, Awkwafina, Gemma Chan",
                      Creators = "Paul Briggs, Don Hall, John Ripa",
                      Explane = "Raya and The Last Dragon, Lumandra’yı kurtarmak için son ejderhanın izini süren yalnız bir savaşçı olan Raya’nın hikayesini konu ediyor. Yıllar boyu Lumandra'nın fantastik dünyasında insanlar ve ejderhalar huzur içinde yaşar. Druun adındaki canavarlar ülkeyi tehdit edince, ejderhalar insanlığın kurtulması için kendisini feda eder. Aradan geçen 500 yılın ardından canavarlar ülkeye geri döner. Onları sonsuza dek durdurmanın tek yolu ise son ejderhanın bulunmasıdır. Yalnız bir savaşçı olan Raya, ülkeyi kurtarmak için sonra ejderhayı bulmak üzere yola koyulur. Bu süreçte Raya, dünyayı kurtarmak için ejderha sihrinden çok daha fazlasının gerekli olduğunu fark eder.",
                      Imdb = "7.3",
                      PictureSource = "beyazperde.com",
                      TextMovieSource = "beyazperde.com"
                  },
                  new Animasyon1
                  {
                      Id = Guid.NewGuid(),
                      Name = "Güzel ve Çirkin",
                      Minute = 129,
                      Url = "https://tr.web.img3.acsta.net/pictures/17/01/11/14/43/594707.jpg",
                      Category = "Animasyon, Fantastik, Macera",
                      Year = 2017,
                      Country = "ABD",
                      Trailer = "https://www.youtube.com/watch?v=LWyQXL2Z6Ts",
                      Age = 6,
                      Starring = "Emma Watson, Dan Stevens, Luke Evans",
                      Creators = " Bill Condon",
                      Explane = "Disney masalından beyazperdeye uyarlanan filmde, tüccar olan bir adamyolculuğu sırasında fırtınaya yakalanır. Ailesine dönüş yolunda gece konaklayacak bir yer ararken yakınlardaki bir şatoyu görür. Ev sahibi ortada görünmese de her şey konuğun rahatı için ayarlanmıştır. Gitmek üzereyken, gözü bir güle ilişir ve kızının kendisinden bir gül istediği aklına gelir. Gülü kopan adam şatonun sahibi olan canavarla yüz yüze gelir ve hayatına karşılık kızını canavara teslim etmek zorunda kalır. Tüccarın en küçük kızı olan Belle anlaşmayı kabul ederek canavarın şatosuna yerleştiğinde hiç beklemediği bir aşkın kucağına atıldığından habersizdir...Bill Condon'ın yönetmenliğini üstlendiği filmin başrollerinde Emma Watson, Ewan McGregor, Luke Evans, Ian McKellen gibi oyuncular yer alıyor.",
                      Imdb = "7.1",
                      PictureSource = "beyazperde.com",
                      TextMovieSource = "beyazperde.com"
                  }
                  );
        }
    }
}
