using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Movie.Api.Models.Entities;

namespace Movie.Api.Configurations
{
    public class AnasayfaConfiguration : IEntityTypeConfiguration<Anasayfa>
    {
        public void Configure(EntityTypeBuilder<Anasayfa> builder)
        {

            builder.HasData(
                new Anasayfa { 
                    Id = Guid.NewGuid(), 
                    Name = "The Fabelmas", 
                    Minute = 151, 
                    Url = "https://amblin.com/wp-content/uploads/2019/06/westsidestory_2020_photo_hero-827x465.jpg", 
                    Category = "Dram", 
                    Year = 2022, 
                    Country = "ABD", 
                    Trailer = "https://www.youtube.com/watch?v=D1G2iLSzOe8&t=1s", 
                    Age = 7, 
                    Starring = "Gabriel LaBelle, Michelle Williams,Paul DanoSeth Rogen,Judd Hirsch",                
                    Creators = "Steven Spielberg",
                    Explane = "Universal Pictures, Steven Spielberg'ün yarı-otobiyografik yeni filmi The Fabelmans'ın ilk fragmanını yayınladı. Pulitzer ödüllü oyun yazarı Tony Kushner (Lincoln, Münih) tarafından kaleme alınan film, Arizona'da büyüyen ve film yapma tutkusu kazanan bir genci konu alıyor.İkinci Dünya Savaşı sonrası Arizona'da büyüyen Sammy Fabelman adında genç bir adam, ailesini sarsan bir sırrı keşfeder ve filmlerin gücünün gerçeği görmesine nasıl yardımcı olabileceğini araştırır. Sammy karakterine Gabriel LeBelle hayat verirken; Sammy'nin sanatla ilgilenen annesini Michelle Williams,bir bilim insanı olan babasını ise Paul Dano canlandırıyor.Oyuncu kadrosunda ayrıca,Sammy'nin hayatında önemli bir yeri olan Bennie amca rolüyle Seth Rogen de var. Filmdeki tüm karakterler Spielberg'ün gerçek aile üyelerinden izler taşıyor.Hafta sonunda,47.Toronto Uluslararası Film Festivali'nde ilk kez görücüye çıkan film eleştirmenler tarafından övgüyle karşılandı. Filmin şimdiden En İyi Film Oscar'ı için güçlü bir aday olduğu konuşuluyor.Spielberg son olarak geçtğimiz Oscar töreninde,senaryosu yine Tony Kushner'in imzasını taşıyan 'West Side Story' filmiyle En İyi Film dahil olmak üzere 6 dalda Oscar adaylığı elde etmişti." ,
                    Imdb = "9.2", 
                    PictureSource = "amblin.com", 
                    TextMovieSource = "www.beyazperde.com"
                }
                );
        }
    }
}
