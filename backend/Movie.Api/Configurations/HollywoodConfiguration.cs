using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Movie.Api.Models.Entities;

namespace Movie.Api.Configurations
{
    public class HollywoodConfiguration : IEntityTypeConfiguration<Hollywood>
    {
        public void Configure(EntityTypeBuilder<Hollywood> builder)
        {

            builder.HasData(
                new Hollywood
                {
                    Id = Guid.NewGuid(),
                    Name = "Cehennem",
                    Minute = 122,
                    Url = "https://upload.wikimedia.org/wikipedia/tr/6/66/Inferno_%282016_film%29.png",
                    Category = "Gerilim, Macera",
                    Year = 2016,
                    Country = "ABD",
                    Trailer = "https://www.youtube.com/watch?v=RH2BD49sEZI",
                    Age = 18,
                    Starring = " Tom Hanks, Felicity Jones, Ben Foster",
                    Creators = " Ron Howard",
                    Explane = "Venedik'teki bir otel odasında uyanan Robert Langdon neler olduğunu ve oraya nasıl geldiğini hatırlamamaktadır. Kendisine neler olduğunu hatırlayabilmek için ona yardım etmeye çalışan doktor Sienna Brooks'la birleşirler. Langdon ve Brooks cevapları aramak için Avrupa'yı dolaşmak zorunda kalırlar. Bu kez de İtalyan ozan ve politikacı Dante'nin İlahi Komedya kitabıyla bağlantılar bulmaya başlar. Zamanla ortaya çıkan ipuçları bir felaketi işaret etmektedir. Çok zengin bir işadamı kısa bir süre içinde dünyaya veba salgınını yayacaktır. Dünyanın başına gelebilecek bu felaketi engellemenin tek yolu Landgdon'ın neler olduğunu hatırlamasıdır...Dan Brown'ın aynı adlı romanından uyarlanan filmin başrolünde Tom Hanks yer alıyor. Daha önce Brown'un Da Vinci Şifresi,Melekler ve Şeytanlar kitaplarının da uyarlamalarında ana karakter Robert Langdon'ı canlandıran oyuncuya başrolde Felicity Jones eşlik ediyor. Filmin yönetmenliği Ron Howard üstleniyor. Uyarlamanın senaryosu ise David Koepp'e ait.",
                    Imdb = "6.2",
                    PictureSource = "wikipedia.org",
                    TextMovieSource = "beyazperde.com"
                },
                new Hollywood
                {
                    Id = Guid.NewGuid(),
                    Name = "Yerçekimi",
                    Minute = 91,
                    Url = "https://mir-s3-cdn-cf.behance.net/project_modules/disp/a41b4b11636617.560fb0d69096d.jpg",
                    Category = "Gerilim, Macera",
                    Year = 2013,
                    Country = "ABD",
                    Trailer = "https://www.youtube.com/watch?v=OiTiKOy59o4",
                    Age = 12,
                    Starring = "Sandra Bullock, George Clooney, Ed Harris",
                    Creators = "Alfonso Cuarón",
                    Explane = "Dr. Ryan Stone zeki bir tıp mühendisidir ve emekliliğinden önce son görevine çıkan yetenekli ve deneyimli astronot Matt Kowalsky'nin yönetimindeki mekikte ilk uzay yolculuğuna çıkar. Herşey yolunda gibi görünürken rutin bir keşif yürüyüşü sırasında bir felaket yaşanır. Mekik çarpan bir cisim sonucu paramparça olur. İki bilim insanı uzay boşluğunda yapayalnız kalırlar. Yeryüzü ile iletişimleri tamamen kopmuştur ve sonsuz karanlıkla başbaşadırlar. Şimdi korkunun yerini panik alır, üstelik var olan sınırlı oksijenleri de gitgide tükenmektedir. İkili eve, dünyaya dönüş yolunu bulabilecek midir?Y Tu Mamá También,Son Umut,Harry Potter ve Azkaban Tutsağı gibi filmlerin yönetmeni ve ortak senaristi olarak tanıdığımız Meksikalı sinemacı Alfonso Cuarón'ın yönetmenliğini üstlendiği bilim-kurgu geriliminin başrollerini ise Sandra Bullock ve George Clooney paylaşıyor.",
                    Imdb = "7.7",
                    PictureSource = "behence.com",
                    TextMovieSource = "beyazperde.com"
                },
                 new Hollywood
                 {
                     Id = Guid.NewGuid(),
                     Name = "Mad Max",
                     Minute = 120,
                     Url = "https://tr.web.img4.acsta.net/pictures/15/04/27/14/48/596979.jpg",
                     Category = "Aksiyon, Bilimkurgu",
                     Year = 2015,
                     Country = "ABD",
                     Trailer = "https://www.youtube.com/watch?v=hEJnMQG9ev8",
                     Age = 18,
                     Starring = " Tom Hardy, Charlize Theron, Zoë Kravitz",
                     Creators = "George Miller",
                     Explane = "Mad Max: Fury Road'da, zorlu geçmişi Mad Max’i hayatta kalmak için en iyi yolun yalnız olmak gerektiğine inandırmıştır. Yine de bir şekilde kendini Furiosa adlı liderlerinin peşinde çorak topraklardaki savaş ortamından, sürekli kaçarak hayatta kalmaya çalışan bir grubun arasında bulur. Yaşadıkları ortamı zalimce yöneten Immortan Joe’dan kaçmaktadırlar ve Joe kendisinden çalınan ve yeri doldurulamayacak derecede önemli kaybının peşindedir. Post-apokaliptik türünün yaratıcısı ve efsanevi “Mad Max” filmlerinin ardındaki usta yönetmen George Miller'ın bir kez daha yönetmen koltuğunda oturduğu Mad Max: Fury Road geri dönüyor! Charlize Theron ve Tom Hardy'nin rol aldığı film, serinin dördüncü bölümü. Filmin diğer başrollerinde; Nicholas Hoult, Hugh Keays-Byrne, Nathan Jones, Josh Helman, Rosie Huntington-Whiteley, Riley Keough, Zoë Kravitz yer alıyor.",
                     Imdb = "8.1",
                     PictureSource = "beyazperde.com",
                     TextMovieSource = "beyazperde.com"
                 },
                 new Hollywood
                 {
                     Id = Guid.NewGuid(),
                     Name = "Sktfall",
                     Minute = 143,
                     Url = "https://upload.wikimedia.org/wikipedia/tr/thumb/e/e9/Skyfall_film_posteri.jpg/330px-Skyfall_film_posteri.jpg",
                     Category = "Aksiyon, Casusluk, Gerilim",
                     Year = 2012,
                     Country = "İngiltere",
                     Trailer = "https://www.youtube.com/watch?v=6kw1UVovByw",
                     Age = 18,
                     Starring = "Daniel Craig, Judi Dench, Javier Bardem",
                     Creators = " Sam Mendes",
                     Explane = "MI6 ciddi bir saldırıya uğrar ve kurumun değerleri temelden sarsılır. M’e karşı sadakat testinden geçen ajan James Bond kişisel bedelleri ağır olsa da, tehdidi bulup her ne pahasına olursa olsun yok etmelidir. Zira MI6’yı ciddi riske sürükleyen isim Silva adında gözü kara, gizemli bir adamdır...Sinema tarihinin en uzun soluklu aksiyon film serisi olan gizli ajan 007 James Bond'un nefes kesen macerası bu sefer Türkiye, Çin ve İngiltere ekseninde geçiyor.Serinin 23.filmi olan Skyfall'da 2000'li yılların son Bond'u olarak Daniel Craig'i izlerken ünlü aktöre M rolünde seyircinin alıştığı üzere Judi Dench,Silva rolünde Javier Bardem,hukümet görevlisi Mallory olarak Ralph Fiennes, seksi Bond kadınları olarak ajan Eve rolünde Naomie Harris ve Severine rolünde Bérénice Marlohe eşlik ediyor.Yönetmen koltuğunda Sam Mendes'in oturduğu filmin Türkiye dışındaki diğer çekim mekanları arasındaysa Şangay, Londra ve İskoçya’nın kuzey bölgeleri yer alıyor.",
                     Imdb = "7.1",
                     PictureSource = "wikipedia.org",
                     TextMovieSource = "beyazperde.com"
                 },
                 new Hollywood
                 {
                     Id = Guid.NewGuid(),
                     Name = "Ucuz Roman",
                     Minute = 154,
                     Url = "https://upload.wikimedia.org/wikipedia/en/3/3b/Pulp_Fiction_%281994%29_poster.jpg",
                     Category = "Polisiye, Gerilim",
                     Year = 1994,
                     Country = "ABD",
                     Trailer = "https://www.youtube.com/watch?v=s7EdQ4FqbhY",
                     Age = 18,
                     Starring = " John Travolta, Samuel L. Jackson, Uma Thurman",
                     Creators = " Quentin Tarantino",
                     Explane = "Venedik'teki bir otel odasında uyanan Robert Langdon neler olduğunu ve oraya nasıl geldiğini hatırlamamaktadır. Kendisine neler olduğunu hatırlayabilmek için ona yardım etmeye çalışan doktor Sienna Brooks'la birleşirler. Langdon ve Brooks cevapları aramak için Avrupa'yı dolaşmak zorunda kalırlar. Bu kez de İtalyan ozan ve politikacı Dante'nin İlahi Komedya kitabıyla bağlantılar bulmaya başlar. Zamanla ortaya çıkan ipuçları bir felaketi işaret etmektedir. Çok zengin bir işadamı kısa bir süre içinde dünyaya veba salgınını yayacaktır. Dünyanın başına gelebilecek bu felaketi engellemenin tek yolu Landgdon'ın neler olduğunu hatırlamasıdır...Dan Brown'ın aynı adlı romanından uyarlanan filmin başrolünde Tom Hanks yer alıyor. Daha önce Brown'un Da Vinci Şifresi,Melekler ve Şeytanlar kitaplarının da uyarlamalarında ana karakter Robert Langdon'ı canlandıran oyuncuya başrolde Felicity Jones eşlik ediyor. Filmin yönetmenliği Ron Howard üstleniyor. Uyarlamanın senaryosu ise David Koepp'e ait.",
                     Imdb = "8.9",
                     PictureSource = "wikipedia.org",
                     TextMovieSource = "beyazperde.com"
                 }
                );
        }
    }
}
