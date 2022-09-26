using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Movie.Api.Models.Entities;

namespace Movie.Api.Configurations
{
    public class AnimasyonConfiguration : IEntityTypeConfiguration<Animasyon>
    {
        public void Configure(EntityTypeBuilder<Animasyon> builder)
        {
            builder.HasData(
                new Animasyon
                {
                    Id = Guid.NewGuid(),
                    Name = "Vol.i",
                    Minute = 98,
                    Url = "https://haruncan.com/wp-content/uploads/2022/07/WALL%C2%B7E.jpg",
                    Category = "Animasyon, Macera, Bilimkurgu",
                    Year = 2008,
                    Country = "ABD",
                    Trailer = "https://www.youtube.com/watch?v=Eb4sMcyzCeg",
                    Age = 7,
                    Starring = " Ben Burtt, Elissa Knight, Jeff Garlin",
                    Creators = " Andrew Stanton",
                    Explane = "Harap edilmiş, kirli ve kuru bir dünyada hikâye başlar. Yüz yıllar önce bütün insanlar, çevrenin kesintisiz kötü kullanımı yüzünden yaşanamaz hale gelen dünyayı BnL (Buy n Large) isimli bir mega şirketin inşa ettiği uzay gemileri ile terk etmiştir. Vol-İ dünyayı temizlemek için üretilmiş bir robottur. İnsanlar bir gün dünyayı terk etmek zorunda kalırlar ancak giderken tüm robotları kapatmışlardır, Vol-İ dışında. Gezegende bir başına kalan Vol-İ yüzyıllar boyunca gezinir durur. Ancak bir gün gezegene Eve adında bir arama robotu gönderilir. Vol-İ Eve'e âşık olur; 700 yıl öncesinden kalma plazma televizyonunda 1969 yapımı Cici Kız (Hello, Dolly!) filmini izlerken yaşadığı hislerinin aynısını duyar. Vol-İ ile Eve galaksiler arası bir macera yaşarlar.Filmdeki insanlarsa Axiom adlı gemilerde yaşarlar ve küçük çocuklara harfler öğretilirken 'A is for AXIOM Your Sweet Home' (A harfi AXIOM'un A'sıdır, Sizin Güzel Eviniz) olarak öğretilmektedir.Axiom adlı geminin ilk kaptanı Captain Reardon'dur (2105-2248); en son kaptanı ise Captain B. McCrea (2775 - ) olmuştur. Bir koltukta, yıllarca hareketsiz duran tembel ve obez insanlar yan yana otururken dahi birbirlerinin yüzüne bakmadan bir ekran aracılığıyla iletişim kurarlar. Burası insanların yiyecekleri yemekten giyecekleri renge kadar her şeyin yönetildiği otomatik bir gemidir. Burada insanlar obezite sorunu yaşamaktadırlar.Geleceğin daha önce hiç hayal edilmemiş vizyonlarını içeren bu filmde Vol - İ'ye, aralarında bir hamamböceği ile bozuk robotlardan oluşan kahraman ruhlu bir topluluğun da yer aldığı ilginç karakterler eşlik eder.",
                    Imdb = "8.4",
                    PictureSource = "https://haruncan.com/",
                    TextMovieSource = "wikipedia.org"
                },
                new Animasyon
                {
                    Id = Guid.NewGuid(),
                    Name = "Köfte Yağmuru",
                    Minute = 90,
                    Url = "https://tr.web.img4.acsta.net/c_310_420/pictures/bzp/03/133535.jpg",
                    Category = "Animasyon, Komedi",
                    Year = 2009,
                    Country = "ABD",
                    Trailer = "https://www.youtube.com/watch?v=onTvWbP9Dkg",
                    Age = 7,
                    Starring = "Cloudy With A Chance Of Meatballs",
                    Creators = "  Phil Lord, Christopher Miller",
                    Explane = "Alice Harikalar Diyarında'yı aratmayacak kertede fantastik maceralar içeren müthiş bir çocuk kitabından uyarlanan destansı boyutlardaki bu komik film, yiyeceğin gökten yağmur gibi yağdığı bir kasabanın köfteler ve makarnalarla dolu öyküsünü anlatıyor. Hevesli bir mucit olan Flint Lockwood, dünyanın en beceriksiz mucididir. Çünkü şimdiye kadar üretilmiş en tuhaf cihazlardan bazılarının ardındaki çekingen dahi olmasına rağmen elle tutulur hiç bir fayda sağlayamamıştır. Ama Flint'in inadı inattır ve sprey ayakkabılardan, maymun düşüncesi çevirmenine tüm icatları yaşadığı küçük kasabanın başına dert açan büyük başarısızlıklar olsa da Flint insanları mutlu edecek bir şey yaratmakta kararlıdır. Flint'in suyu yiyeceğe dönüştürmek için tasarladığı yeni makinesi kazayla kasaba meydanını yok edip bir roket gibi bulutlara doğru fırladığında, Flint mucitlik kariyerinin sona erdiğini düşünür. Ta ki şaşırtıcı bir şey olana kadar: Gökten çizburger yağmaya başlar. Makinesi gerçekten çalışıyordur! Yemekli hava durumu anında başarı kazanır ve Flint kasabaya kendi deyimiyle 'tarihin en büyük hava fenomeni'ni incelemeye gelen hava durumu sunucusu Sam Sparks'la arkadaş olur. Ama insanlar büyük bir açgözlülükle daha çok yemek istediklerinde, makine garip davranmaya başlar ve makarna kasırgaları ve dev köfteler üretir. Şekerleme dağlarının ve kavun dalgalarının altında gömülmek üzere olan kasabanın kaderi, Flint ve Sam'in uzmanlık alanlarını birleştirerek makineyi durdurup her şeyi yoluna koymalarına bağlıdır.",
                    Imdb = "6.9",
                    PictureSource = "beyazperde.com",
                    TextMovieSource = "beyazperde.com"
                },
                new Animasyon
                {
                    Id = Guid.NewGuid(),
                    Name = "Hayvanlar Şehri",
                    Minute = 108,
                    Url = "https://upload.wikimedia.org/wikipedia/en/9/96/Zootopia_%28movie_poster%29.jpg",
                    Category = "Animasyon, Aile, Komedi",
                    Year = 2016,
                    Country = "ABD",
                    Trailer = "https://www.youtube.com/watch?v=jWM0ct-OLsM",
                    Age = 7,
                    Starring = "  Aysun Topar, Ginnifer Goodwin, Cem Yılmaz",
                    Creators = "  Byron Howard, Jared Bush, Rich Moore",
                    Explane = "Karmakarışık ve Bolt gibi sevilen animasyon filmlerinin yönetmeni Byron Howard'ın perdeye taşıdığı Zootopia, medenileşmiş ve teknoloji kullanabilen hayvanların bir arada yaşadığı bir şehirde yaşanan ilginç bir polisiye öyküsünü perdeye taşıyor. Alışıldık Disney havasının solunacağı filmde; konuşkan tilki Nick'in, üzerine yığılmaya çalışan bir suçtan sıyrılma çabası anlatılıyor. Modern memelilerin yaşadığı Zootropolis adındaki metropolis, lüks Sahra Meydanı’ndan, soğuk Tundra Kasabası’na kadar bir çok farklı doğal ortamın ve hayvanın bir arada yaşadığı benzersiz bir şehirdir. Burası bir fil kadar büyük ya da bir arı kadar küçük olanların bile istediği her şeyi yapabileceği türden bir yerdir. İyimser Polis Memuru Judy Hopps buraya geldiğinde, büyük ve sert mizaçlı hayvanların olduğu bir yerde polis olmanın hiç de kolay olmadığını fark eder. Kendini ispatlayabilme fırsatını elde edebilmek için, geveze ve numaracı tilki Nick Wilde ile ortak olma pahasına önemli ve gizemli bir olayı çözmeye çalışacaktır. Filmin seslendirme kadrosunda Ginnifer Goodwin, Jason Bateman, Idris Elba, J.K. Simmons, Octavia Spencer yer alıyor.",
                    Imdb = "8.0",
                    PictureSource = "wikipedia.org",
                    TextMovieSource = "beyazperde.com"
                },
                new Animasyon
                {
                    Id = Guid.NewGuid(),
                    Name = "6 Süper Kahraman",
                    Minute = 102,
                    Url = "https://upload.wikimedia.org/wikipedia/tr/4/4b/Big_Hero_6_%28film%29_poster.jpg",
                    Category = "Macera, Animasyon, Aile, Aksiyon",
                    Year = 2015,
                    Country = "ABD",
                    Trailer = "https://www.youtube.com/watch?v=kt_0Z_UJbK8",
                    Age = 7,
                    Starring = "Scott Adsit, Ryan Potter, T.J. Miller",
                    Creators = "Don Hall, Chris Williams (II)",
                    Explane = "Oldukça zeki bir robot tasarımcısı olan Hiro Hamada kendisini bir anda bir suç örgütünün içinde bulacaktır. Kötü adamların amacı yüksek teknolojili “San Fransokyo” kentini yerle bir etmektir. En yakın arkadaşı Baymax ‘ın yardımıyla Hiro, şehri kurtarmak için oluşturulan gönüllüler ordusuna katılır. Onları Hiro'nun diğer arkadaşları da yalnız bırakmayacaktır:  Hiro gibi macera bağımlısı olan Gogo Tamaga, oldukça düzenli, sistemli ve sevimli Wasabi No-Ginger, kimya konusunda uzmanlaşmış Honey Lemon ve fanatik Fred. Disney’in yapımcılığını üstlendiği aile animasyonunda yönetmenler animasyonun mutfağından gelen ödüllü isimler olan Don Hall ve Chris Williams ikilisi.",
                    Imdb = "7.8",
                    PictureSource = "wikipedia.org",
                    TextMovieSource = "beyazperde.com"
                },
                 new Animasyon
                 {
                     Id = Guid.NewGuid(),
                     Name = "Ölü Gelin",
                     Minute = 77,
                     Url = "https://upload.wikimedia.org/wikipedia/tr/2/27/Corpse_Bride2.jpg",
                     Category = "Animasyon, Fantastik, Aile, Romantik",
                     Year = 2005,
                     Country = "ABD",
                     Trailer = "https://www.youtube.com/watch?v=AGACeWVdFqo",
                     Age = 7,
                     Starring = "Johnny Depp, Helena Bonham Carter, Emily Watson",
                     Creators = "Mike Johnson, Tim Burton",
                     Explane = "1800’lerin sonlarına doğru bir Victorian kasabasında bir adam ve bir kadın Victor Van Dort ile Victoria Everglot nişanlanırlar. Everglotlar’ın paraya ihtiyacı vardır aksi takdirde sokaklarda uyumak üzeredirler. Van Dortlar ise sosyetede adlarının geçmesini seven insanlardır. Yalnız düğün provası esnasında bir şey yanlış gider. Victor, koruluğa girer ve orada bulduğu bir iskeletin parmağındaki yüzüğü kendi parmağına geçirir. O anda da kendisini ölü gelin Emily ile evlenmiş bulur. Öteki tarafta Victoria onu beklerken, Victoria’nın yerini alacak zengin bir başka kişi vardır. Bu durumda ortada iki gelin ve bir damat varken Victor’u hangisinin elde edeceği bir muammadır.",
                     Imdb = "7.3",
                     PictureSource = "wikipedia.org",
                     TextMovieSource = "wikipedia.org"
                 }
                );
        }
    }
}
