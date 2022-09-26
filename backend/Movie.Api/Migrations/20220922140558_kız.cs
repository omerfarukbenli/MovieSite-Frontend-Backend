using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Movie.Api.Migrations
{
    public partial class kız : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Anasayfas",
                columns: new[] { "Id", "Age", "Category", "Country", "Creators", "Explane", "Imdb", "Minute", "Name", "PictureSource", "Starring", "TextMovieSource", "Trailer", "Url", "Year" },
                values: new object[] { new Guid("90572339-f3cc-443a-97b6-f386892745fe"), 7, "Dram", "ABD", "Steven Spielberg", "Universal Pictures, Steven Spielberg'ün yarı-otobiyografik yeni filmi The Fabelmans'ın ilk fragmanını yayınladı. Pulitzer ödüllü oyun yazarı Tony Kushner (Lincoln, Münih) tarafından kaleme alınan film, Arizona'da büyüyen ve film yapma tutkusu kazanan bir genci konu alıyor.İkinci Dünya Savaşı sonrası Arizona'da büyüyen Sammy Fabelman adında genç bir adam, ailesini sarsan bir sırrı keşfeder ve filmlerin gücünün gerçeği görmesine nasıl yardımcı olabileceğini araştırır. Sammy karakterine Gabriel LeBelle hayat verirken; Sammy'nin sanatla ilgilenen annesini Michelle Williams,bir bilim insanı olan babasını ise Paul Dano canlandırıyor.Oyuncu kadrosunda ayrıca,Sammy'nin hayatında önemli bir yeri olan Bennie amca rolüyle Seth Rogen de var. Filmdeki tüm karakterler Spielberg'ün gerçek aile üyelerinden izler taşıyor.Hafta sonunda,47.Toronto Uluslararası Film Festivali'nde ilk kez görücüye çıkan film eleştirmenler tarafından övgüyle karşılandı. Filmin şimdiden En İyi Film Oscar'ı için güçlü bir aday olduğu konuşuluyor.Spielberg son olarak geçtğimiz Oscar töreninde,senaryosu yine Tony Kushner'in imzasını taşıyan 'West Side Story' filmiyle En İyi Film dahil olmak üzere 6 dalda Oscar adaylığı elde etmişti.", "9.2", 151, "The Fabelmas", "amblin.com", "Gabriel LaBelle, Michelle Williams,Paul DanoSeth Rogen,Judd Hirsch", "www.beyazperde.com", "https://www.youtube.com/watch?v=D1G2iLSzOe8&t=1s", "https://amblin.com/wp-content/uploads/2019/06/westsidestory_2020_photo_hero-827x465.jpg", 2022 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Anasayfas",
                keyColumn: "Id",
                keyValue: new Guid("90572339-f3cc-443a-97b6-f386892745fe"));
        }
    }
}
