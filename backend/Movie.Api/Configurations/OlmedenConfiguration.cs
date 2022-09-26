using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Movie.Api.Models.Entities;

namespace Movie.Api.Configurations
{
    public class OlmedenConfiguration : IEntityTypeConfiguration<Olmeden>
    {
        public void Configure(EntityTypeBuilder<Olmeden> builder)
        {

            builder.HasData(
                new Olmeden
                {
                    Id = Guid.NewGuid(),
                    Name = "Full Metal Jacket",
                    Minute = 114,
                    Url = "https://upload.wikimedia.org/wikipedia/tr/thumb/5/56/Full_Metal_Jacket-_1987.jpg/330px-Full_Metal_Jacket-_1987.jpg",
                    Category = "Dram, Savaş",
                    Year = 1987,
                    Country = "ABD",
                    Trailer = "https://www.youtube.com/watch?v=n2i917l5RFc",
                    Age = 18,
                    Starring = "Matthew Modine, Arliss Howard, Vincent D'Onofrio",
                    Creators = "Stanley Kubrick",
                    Explane = "Full Metal Jacket'de bir grup acemi asker kendilerini nasıl bir eğitimin beklediğinden ve nasıl bir işin içine girdiklerinden habersiz bir biçimde üslerinin önünde dikilmektedirler. Askerlik ve savaş kavramlarının ciddiyetlerini fark etmeleri için savaşa gitmeleri gerekmeyecektir.İlk bölümünde savaş için antrenman yapan bir grup deniz piyadesinin Parris Island’da edindiği tecrübelere odaklanan Full Metal Jacket ani bir geçişle savaşın en ağır biçimde cereyan ettiği tarihlere taşıyor seyircisini.Full Metal Jacket,fazlasıyla detaycı ve dokunaklı bir anlatımla askerlerin ve askerliğin,Vietnam savaşı esnasındaki zihnini peliküle döküyor.",
                    Imdb = "8.3",
                    PictureSource = "wikipedia.org",
                    TextMovieSource = "beyazperde.com"
                },
                new Olmeden
                {
                    Id = Guid.NewGuid(),
                    Name = "Akıl Oyunları",
                    Minute = 135,
                    Url = "https://upload.wikimedia.org/wikipedia/en/b/b8/A_Beautiful_Mind_Poster.jpg",
                    Category = "Dram",
                    Year = 2001,
                    Country = "ABD",
                    Trailer = "https://www.youtube.com/watch?v=EajIlG_OCvw",
                    Age = 12,
                    Starring = "Russell Crowe,Ed Harris,Jennifer Connelly,Paul Bettany,Christopher Plummer",
                    Creators = "Ron Howard",
                    Explane = "Nash, öğrencilik yıllarından itibaren hayaller görmeye başlar. Mezuniyetinden sonra, zamanla paranoid şizofreni olur; fakat hasta olduğunun farkına varamaz. Bir konferans sırasında aniden bir psikiyatristin karşısına çıkması ile olaylar zinciri değişir. Hastaneye yatar ve bu nedenle akademik çalışmalarından uzaklaşır.Hastalığı kendi çocuğuna zarar vermesine neden olacak noktaya gelince eşi yeniden hastaneye gitmesi gerektiğini düşünür.Uzun süre hasta olduğunu kabul edemese de sürekli gördüğü kız çocuğunun hiç büyümediğini fark eder.Bu durum onun hastalığını kabul etmesini sağlar.Nash,yaşadığı hayali gerçekleri görmezden gelerek onlarla yaşamaya çalışacaktır.Gördüğü tedaviler etkili olmasa da eşi ve eski iş arkadaşlarının desteğiyle her şeye yeniden başlar.Kendi akıl hastalığını yine kendi aklı ile dizginleyerek akademik çalışmalarına yeniden hız verir.Tekrar üniversitede ders vermeye başlar.Sonunda gösterdiği sıra dışı mücadeleyle şizofreni ile birlikte yaşamına devam eder.Ve tarih bu müthiş dehaya,akıl hastalığını yine aklıyla yenerek hayatının geri kalanını bilime adamasından ve hastalığının başlamasından evvel yaptığı buluşlardan dolayı Nobel Ekonomi Ödülünü armağan eder.",
                    Imdb = "8.2",
                    PictureSource = "wikipedia.org",
                    TextMovieSource = "wikipedia.org"
                },
                new Olmeden
                {
                    Id = Guid.NewGuid(),
                    Name = "Can Dostum",
                    Minute = 126,
                    Url = "https://upload.wikimedia.org/wikipedia/tr/1/17/Good_Will_Hunting_%28film%2C_1997%29.jpg",
                    Category = "Dram",
                    Year = 1997,
                    Country = "ABD",
                    Trailer = "https://www.youtube.com/watch?v=hIdsjNGCGz4",
                    Age = 12,
                    Starring = "Robin Williams,Matt Damon,Ben Affleck,Stellan Skarsgård,Casey Affleck,Minnie Driver",
                    Creators = "Gus Van Santk",
                    Explane = "Will Hunting (Matt Damon) Massachusetts Üniversitesi'nde çalışan bir hademedir. Aynı zamanda çok zeki ve öğrenmeyi seven biridir. En yakın çocukluk arkadaşları ile birlikte zaman zaman mahalledeki diğer genç gruplar ile kavga ederler. Bu yüzden başı kanunla derttedir ve son yaptığı kavgadan dolayı hapise gönderilir. Daha önce Will'in yeteneğini fark edip araştıran üniversite profesörü bir şartla Will'e kefil olup hapishaneden çıkarılmasını sağlar. Tek şart Will'in bir terapist tarafından tedavi edilip içindeki öfkenin dindirilp iyileşmesini sağlamaktır. Will terapist Robin Williams ile birlikte hayatını yeniden yönlendirmeye başlayacak, en yakın arkadaşı Ben Affleck ve yeni tanıştığı kız arkadaşı bu konuda ona destek olacaklardır.",
                    Imdb = "8.3",
                    PictureSource = "wikipedia.org",
                    TextMovieSource = "wikipedia.org"
                },
                new Olmeden
                {
                    Id = Guid.NewGuid(),
                    Name = "Forrest Gump",
                    Minute = 142,
                    Url = "https://upload.wikimedia.org/wikipedia/tr/b/bb/Forrest_Gump_%28film%2C_1994%29.jpg",
                    Category = "Dram",
                    Year = 1994,
                    Country = "ABD",
                    Trailer = "https://www.youtube.com/watch?v=bLvqoHBptjg",
                    Age = 12,
                    Starring = "Tom Hanks, Robin Wright Penn,Gary Sinise,Mykelti Williamson,Sally Field",
                    Creators = "Robert Zemeckis",
                    Explane = "Forrest Gump, düşük I.Q. sahibi genç bir adamdır. Jenny ile tanıştığında ona aşık olur. Gump aralarında Elvis Presley, Kennedy, Nixon’ın da olduğu tarihsel kişilerle kaza eseri tanışır ve 50’lerden 70’lerin sonuna kadar gelen bir süre zarfında olaylar gelişir. Gump tamamen tesadüf olarak Vietnam savaşına ve Amerikan yakın tarihinin önemli olaylarına şahitlik eder ve hatta rol alır. Ancak bilmeden yaptıklarının ne kadar önemli sonuçları olduğundan da haberi yoktur. ",
                    Imdb = "8.8",
                    PictureSource = "wikipedia.org",
                    TextMovieSource = "beyazperde.com"
                },
                new Olmeden
                {
                    Id = Guid.NewGuid(),
                    Name = "Guguk Kuşu",
                    Minute = 125,
                    Url = "https://upload.wikimedia.org/wikipedia/tr/thumb/2/22/Guguk_kusu.jpg/330px-Guguk_kusu.jpg",
                    Category = "Dram",
                    Year = 1975,
                    Country = "ABD",
                    Trailer = "https://www.youtube.com/watch?v=OXrcDonY-B8",
                    Age = 18,
                    Starring = "Jack Nicholson, Louise Fletcher, William Redfield,Michael Berryman,Peter Brocco, Dean R.Brooks, Alonzo Brown, Scatman Crothers,Mwako Cumbuka,Danny DeVito,William Duell",
                    Creators = "Milos Forman",
                    Explane = "Orijinal adı 'One Flew Over the Cuckoo's Nest' ile aynı isimli kitaptan sinemaya uyarlanan film, akıl hastası numarası yaparak güvenlik önlemleri daha az olan bir akıl hastanesine sevkedilen bir mahkûmun (Jack Nicholson) geçirdiği zamanı konu alıyor. Mahkûm, bu süre içerisinde hem kaçma planları yapıyor hem de akıl hastanesindeki diğer hastalarla farklı bir diyalog kuruyor. Terapilerdeki kendi başına buyruk hareketleri ve özgürlüğe olan düşkünlüğü nedeniyle diğer hastalara kötü örnek olduğunu düşünen baş hemşire Mildred (Louise Fletcher) ile de büyük sorunlar yaşıyor. Milos Forman tarafından yönetilen film, tüm zamanların en iyi filmlerinden biri olarak gösterilmiştir.",
                    Imdb = "8.7",
                    PictureSource = "wikipedia.org",
                    TextMovieSource = "wikipedia.org"
                }
                );
        }
    }
}
