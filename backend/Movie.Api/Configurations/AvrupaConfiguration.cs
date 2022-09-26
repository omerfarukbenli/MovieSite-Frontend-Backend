using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Movie.Api.Models.Entities;

namespace Movie.Api.Configurations
{
    public class AvrupaConfiguration : IEntityTypeConfiguration<Avrupa>
    {
        public void Configure(EntityTypeBuilder<Avrupa> builder)
        {
            builder.HasData(
               new Avrupa
               {
                   Id = Guid.NewGuid(),
                   Name = "Kara Kitap",
                   Minute = 145,
                   Url = "https://tr.web.img4.acsta.net/pictures/bzp/03/58127.jpg",
                   Category = "Dram, Savaş",
                   Year = 2007,
                   Country = "Almanya",
                   Trailer = "https://www.youtube.com/watch?v=Nm2IJkU6I-o",
                   Age = 12,
                   Starring = " Carice van Houten, Sebastian Koch, Thom Hoffman",
                   Creators = "Paul Verhoeven",
                   Explane = "Yahudiler için Almanya’da yaşamanın kabusa eş değer olduğu yıllarda Yahudi şarkıcı Rachel Steinn, bu korkunç baskıdan kurtulabilmek için ülkeyi terketmeye karar verir. Fakat ne yazık ki, Hollanda’ya gitmek için kaçak olarak bindiği bot, Almanlar tarafından durdurulacaktır.Bottaki herkesin öldürülmesine rağmen Rachel,şans eseri kurtulur.Ülkeyi terkedemeyen Rachel için yapacak tek bir şey kalmıştır: direnişçilere katılmak! Ellis de Vries adı ile direniş gruplarının önemli isimlerinden biri haline gelecektir.RoboCop,Temel İçgüdü gibi filmlerin de yönetmeni olan Paul Verhoeven,şimdi de İkinci Dünya Savaşı’nda yaşanan gerçek trajedilerden birine el atıyor.",
                   Imdb = "7.7",
                   PictureSource = "beyazperde.com",
                   TextMovieSource = "beyazperde.com"
               },
               new Avrupa
               {
                   Id = Guid.NewGuid(),
                   Name = "Mandalina Bahçesi",
                   Minute = 86,
                   Url = "https://upload.wikimedia.org/wikipedia/tr/e/ee/Mandalina_Bah%C3%A7esi_film_posteri.jpg",
                   Category = "Dram, Savaş",
                   Year = 2013,
                   Country = "Gürcistan",
                   Trailer = "https://www.youtube.com/watch?v=WdHwowSRRcs",
                   Age = 12,
                   Starring = "Lembit Ulfsak,Giorgi Nakashidze,Misha Meskhi,Elmo Nüganen",
                   Creators = "	Zaza UrushadzeL",
                   Explane = "1992 yılında Gürcü - Abhaz Savaşı'nın başlamasıyla bölgedeki bir köyde yaşayan Estonyalılar atalarının ülkesi Estonya'ya kaçmışlardır. Ancak köyde mandalina işiyle uğraşan sadece Ivo ve Margus adındaki iki Estonyalı kalmıştır. Arazilerinde biri Gürcü biri Çeçen birbirlerine düşman iki yaralı asker bulurlar ve onları iyileşinceye kadar evlerinde misafir ederler.",
                   Imdb = "8.1",
                   PictureSource = "wikipedia.org",
                   TextMovieSource = "beyazperde.com"
               },
               new Avrupa
               {
                   Id = Guid.NewGuid(),
                   Name = "Onur Savaşı",
                   Minute = 111,
                   Url = "https://upload.wikimedia.org/wikipedia/tr/thumb/3/33/Onur_Sava%C5%9F%C4%B1_-_afi%C5%9F.jpg/330px-Onur_Sava%C5%9F%C4%B1_-_afi%C5%9F.jpg",
                   Category = "Dram",
                   Year = 2012,
                   Country = "Danimarka",
                   Trailer = "https://www.youtube.com/watch?v=ieLIOBkMgAQ",
                   Age = 18,
                   Starring = " Mads Mikkelsen, Thomas Bo Larsen, Annika Wedderkopp",
                   Creators = " Thomas Vinterberg",
                   Explane = "Birbirine sıkı sıkıya bağlı olan bir Danimarka kasabasında yaşayan Lucas, yerel bir anaokulunda çalışmaktadır. Anaokulundaki çocuklarla sağlıklı bir etkileşime sahiptir ancak ergenlik çağında olan ve eski karısıyla beraber yaşayan oğluyla ilişkisini sürdürmekte zorluklar yaşar. İş arkadaşı Nadja ise ona yakınlaşır ve bir süre sonra sevgili olurlar.Anasınıfındaki öğrencilerden biri olan Klara, Lucas'ın en yakın arkadaşı olan Theo'nun kızıdır.Abisinin Klara'ya gösterdiği pornografik fotoğraf, küçük kızın aklına kazınır ve bir gün anaokulundayken yaptığı yorumlar, anaokulu müdürünün küçük kızın Lucas tarafından cinsel tacize mağruz kaldığını düşünmesine yol açar. Daha sonra Klara ile yönlendirmeli bazı sorularla tekrar konuşulduğunda, küçük kız Lucas'a karşı açık olmayan ifadeler verir.Kasabadaki yetişkinler ise anasınıfı müdürünün Klara'nın sonraki çelişkili ifadelerini görmezden gelen istismar hikâyesine inanmaktadır.Lucas toplum tarafından pedofil olarak suçlanarak dışlanır.Arkadaşı Theo ile olan dostluğu biter.Artan baskı,Nadja ile ayrılmalarına sebep olur.Ayrıca oğlu da alenen dışlanır.Anaokulu çalışanları diğer çocuklara da yönlendirmeli sorular sorarlar ve anasınıfındaki diğer çocuklar da Lucas tarafından istismar edildiklerini söyler.Ancak çocukların ifadelerinde bahsettikleri Lucas'ın bodrumundaki detaylar, Lucas'ın masumiyetini destekler çünkü Lucas'ın evinde bodrum yoktur. Bunun üzerine Lucas, duruşmadan sonra herhangi bir suçlama olmadan serbest bırakılır.Toplum hala Lucas hakkında şüphelidir.Ancak toplumdan dışlama,bir süre sonra şiddete dönüşür.Lucas'ın köpeği Fanny öldürülür, evinin camından içeri bir kaya parçası atılır ve gıda almak için marketteyken, market çalışanları tarafından dövülür. Lucas, Noel arifesinde bir kilise ayini sırasında, Theo ile yüzleşir. Daha sonra Theo, Klara'nın uyumak üzereyken mırıldandığı özür dilerim Lucas sözünden sonra,Lucas'ın masumiyeti hakkındaki şüphelerini giderir ve Noel günü elinde yiyecek ve alkol ile barışmak için Lucas'ı ziyarete gider.Bir yıl sonra, toplumdaki gerginlikler azalmıştır.Lucas ve Nadja tekrar birliktedirler.Lucas'ın oğlu ise yerel bir avcılık topluluğuna bir yetişkin olarak kabul edilmiştir. Bu olayı kutlamak için düzenlenen bir av seferinde, görülmeyen bir kişi Lucas'a ateş eder ve onu ıskalar.Batan güneş gözüne çarparken,Lucas saldırganını teşhis edemez ve tüfeğini tekrar dolduran saldırgan gözden kaybolur.Birbirine sıkı sıkıya bağlı olan bir Danimarka kasabasında yaşayan Lucas,yerel bir anaokulunda çalışmaktadır.Anaokulundaki çocuklarla sağlıklı bir etkileşime sahiptir ancak ergenlik çağında olan ve eski karısıyla beraber yaşayan oğluyla ilişkisini sürdürmekte zorluklar yaşar.İş arkadaşı Nadja ise ona yakınlaşır ve bir süre sonra sevgili olurlar.Anasınıfındaki öğrencilerden biri olan Klara,                  Lucas'ın en yakın arkadaşı olan Theo'nun kızıdır.Abisinin Klara'ya gösterdiği pornografik fotoğraf, küçük kızın aklına kazınır ve bir gün anaokulundayken yaptığı yorumlar, anaokulu müdürünün küçük kızın Lucas tarafından cinsel tacize mağruz kaldığını düşünmesine yol açar. Daha sonra Klara ile yönlendirmeli bazı sorularla tekrar konuşulduğunda, küçük kız Lucas'a karşı açık olmayan ifadeler verir.Kasabadaki yetişkinler ise anasınıfı müdürünün Klara'nın sonraki çelişkili ifadelerini görmezden gelen istismar hikâyesine inanmaktadır.Lucas toplum tarafından pedofil olarak suçlanarak dışlanır.Arkadaşı Theo ile olan dostluğu biter.Artan baskı,Nadja ile ayrılmalarına sebep olur.Ayrıca oğlu da alenen dışlanır.Anaokulu çalışanları diğer çocuklara da yönlendirmeli sorular sorarlar ve anasınıfındaki diğer çocuklar da Lucas tarafından istismar edildiklerini söyler.Ancak çocukların ifadelerinde bahsettikleri Lucas'ın bodrumundaki detaylar, Lucas'ın masumiyetini destekler çünkü Lucas'ın evinde bodrum yoktur. Bunun üzerine Lucas, duruşmadan sonra herhangi bir suçlama olmadan serbest bırakılır.Toplum hala Lucas hakkında şüphelidir.Ancak toplumdan dışlama,bir süre sonra şiddete dönüşür.Lucas'ın köpeği Fanny öldürülür, evinin camından içeri bir kaya parçası atılır ve gıda almak için marketteyken, market çalışanları tarafından dövülür. Lucas, Noel arifesinde bir kilise ayini sırasında, Theo ile yüzleşir. Daha sonra Theo, Klara'nın uyumak üzereyken mırıldandığı özür dilerim Lucas sözünden sonra,Lucas'ın masumiyeti hakkındaki şüphelerini giderir ve Noel günü elinde yiyecek ve alkol ile barışmak için Lucas'ı ziyarete gider.Bir yıl sonra,toplumdaki gerginlikler azalmıştır.Lucas ve Nadja tekrar birliktedirler.Lucas'ın oğlu ise yerel bir avcılık topluluğuna bir yetişkin olarak kabul edilmiştir. Bu olayı kutlamak için düzenlenen bir av seferinde, görülmeyen bir kişi Lucas'a ateş eder ve onu ıskalar.Batan güneş gözüne çarparken,Lucas saldırganını teşhis edemez ve tüfeğini tekrar dolduran saldırgan gözden kaybolur..",
                   Imdb = "8.3",
                   PictureSource = "wikipedia.org",
                   TextMovieSource = "wikipedia.org"
               },
               new Avrupa
               {
                   Id = Guid.NewGuid(),
                   Name = "Başkalarının Hayatı",
                   Minute = 137,
                   Url = "https://upload.wikimedia.org/wikipedia/tr/thumb/5/5a/Ba%C5%9Fkalar%C4%B1n%C4%B1n_Hayat%C4%B1_film_afi%C5%9Fi.jpg/330px-Ba%C5%9Fkalar%C4%B1n%C4%B1n_Hayat%C4%B1_film_afi%C5%9Fi.jpg",
                   Category = "Dram, Gerilim",
                   Year = 2006,
                   Country = "Almanya",
                   Trailer = "https://www.youtube.com/watch?v=YsShZNHmpGE",
                   Age = 18,
                   Starring = "Ulrich Mühe, Sebastian Koch, Martina Gedeck",
                   Creators = " Florian Henckel von Donnersmarck",
                   Explane = "Başkalarının Hayatı, Alman sinemasının son döneminin en önemli filmlerinden biri olarak kabul görmüştür. Film iktidarın meşrutiyetini devam ettirebilmek için ülke genelinde kurduğu istihbarat servisini ve bu birim içerisinde önemli bir pozisyonda çalışan ve Bakan tarafından bir sanatçıyı takip etme görevine atanan Yüzbaşı Gerd Wiesler’in karşılaştığı oyunları konu edinir. Wiesler, gözetlediği tiyatro yazarının rejime karşı gelmediğini, şüpheli herhangi bir harekette bulunmadığını görür ve bu görevin altında başka bir amaç yattığını fark eder. Yazarın hayatına her gün daha bir fazla giren Wiesler, zamanla yazara kendisinin bile fark etmediği yardımlarda bulunur; böylece aralarında gizli bir dostluk kurulur.",
                   Imdb = "8.4",
                   PictureSource = "wikipedia.org",
                   TextMovieSource = "beyazperde.com"
               },
               new Avrupa
               {
                   Id = Guid.NewGuid(),
                   Name = "Gir Kanıma",
                   Minute = 114,
                   Url = "https://upload.wikimedia.org/wikipedia/tr/thumb/0/02/Gir_Kan%C4%B1ma_afi%C5%9F.jpg/330px-Gir_Kan%C4%B1ma_afi%C5%9F.jpg",
                   Category = "Korku, Fantastik, Romantik",
                   Year = 2008,
                   Country = "İsveç",
                   Trailer = "https://www.youtube.com/watch?v=ICp4g9p_rgo",
                   Age = 12,
                   Starring = "Kåre Hedebrant, Lina Leandersson, Per Ragnar",
                   Creators = "Tomas Alfredson",
                   Explane = "Sürekli hor görülen bir ergenin kankası vasıtasıyla hayattan, kaderden ve berbat okul arkadaşlarından hesap sormasının hikayesi 'Gir Kanıma'. Son dönem korku sineması örneklerinden klişe kullanmaması ve bir hayli özgün içeriğe sahip olmasıyla öne çıkan 'Låt den rätte komma in', Stockholm'ün varoşlarında annesiyle birlikte yaşayan küçük Oskar'ın tuhaf hikayesini anlatıyor. Kahramanımız Oskar, sık sık da şehir dışında yaşayan babasını ziyarete gitmektedir. Arkadaşları tarafından çoğu zaman aşağılanan ve sürekli alay edilen bir çocuk olan Oskar öc alacağı günlerin hayalleriyle yaşamaktadır. Bir gece soluk benizli bir kızla tanışan Oskar, Eli adındaki bu 'değişik' kızla çok yakın arkadaş olur. Birlikte güzel zaman geçirseler de Eli'ın bir sırrı vardır. Bir vampir olan Eli, Oskar'la arasındaki arkadaşlığa bunu yansıtmasa da zamanla ikilinin başına büyük dertler açılır. Son dönem Kuzey Avrupa sinemasından çıkan en çarpıcı yapıtlardan biri olan 'Gir Kanıma', sanat sinemasıyla vampir filmleri janrının başarıyla harmanlandığı yapımlardan biri.",
                   Imdb = "7.9",
                   PictureSource = "wikipedia.org",
                   TextMovieSource = "beyazperde.com"
               }
               );
        }
    }
}
