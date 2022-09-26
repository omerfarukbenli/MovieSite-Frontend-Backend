using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Movie.Api.Models.Entities;

namespace Movie.Api.Configurations
{
    public class OscarConfiguration : IEntityTypeConfiguration<Oscar>
    {
        public void Configure(EntityTypeBuilder<Oscar> builder)
        {
            builder.HasData(
          new Oscar
          {
              Id = Guid.NewGuid(),
              Name = "Ölümcül Tuzak",
              Minute = 131,
              Url = "https://prdaficalmjediwestussa.blob.core.windows.net/images/2022/04/AFIMC22_THE-HURT-LOCKER_4.jpeg",
              Category = "Savaş, Aksiyon, Dram",
              Year = 2009,
              Country = "ABD",
              Trailer = "https://www.youtube.com/watch?v=AIbFvqFYRT4",
              Age = 12,
              Starring = "Jeremy Renner, Anthony Mackie, Brian Geraghty",
              Creators = "Kathryn Bigelow",
              Explane = "Batılı eleştirmenler tarafından olumlu karşılanan bu filmin en büyük dezavantajı Ortadoğu'daki savaşın diğer tarafına tepeden bakan ve oryantalist bir bakış açısını taşıması gösterilebilir. Herkesin potansiyel düşman ve her objenin de ölümcül bomba olduğu Irak’ta, elit askerler dünyanın en zor görevlerinden birinde yer alır. Sıcak savaşın ortasında bombaları imha etmekle yükümlüdürler. Takım lideri William James, hem bu yaygın bombalardan hem de psikolojik ve duygusal etkilenmelerle uğraşmaktadır. James’in iki askeri kendini cürretkarca savaşın ortasına atar. James ise ölümü aldırmadığı için askerlerine yardıma gider. Yeni vahşi liderini korumaya çabalayan adamlar, şehri kaosa sürekler. Mark Boald, Irak savaşındaki askerlerin yaşadığı deneyimlerin ilk defa bir filmde yer aldığını, görüntülerin CNN’deki gibi gerçekçi olduğunu ve birçok savaş filminin savaş bitmeden gösterilmediğini belirtiyor. Günümüzde de devam eden savaş dolayısıyla, filmin güçlü oyuncu kadrosunun savaşı hissederek sergilediği etkileyici performans, eleştirmenler tarafından tam not aldı. Film ilk kez 65. Venedik Film Festivalinde seyirciyle buluştu. Film SIGNIS ödülü dahil birçok ödüle layık görüldü. Yine de entelektüel sinema yazarlarının bir kısmının 'işgalci unsur' meselesine pek değinilmeden filmde işlenen şiddetin tek yanlı ele alınmasını eleştirmesi de unutulmamalı.",
              Imdb = "7.5",
              PictureSource = "afi.com",
              TextMovieSource = "beyazperde.com"
          },
          new Oscar
          {
              Id = Guid.NewGuid(),
              Name = "İhtiyarlara Yer Yok",
              Minute = 122,
              Url = "https://static1.colliderimages.com/wordpress/wp-content/uploads/2021/09/no-country-for-old-men-ending.jpg",
              Category = "Dram, Western",
              Year = 2007,
              Country = "ABD",
              Trailer = "https://www.youtube.com/watch?v=38A__WT3-o0",
              Age = 18,
              Starring = "Tommy Lee Jones, Javier Bardem, Josh Brolin",
              Creators = " Joel Coen, Ethan Coen",
              Explane = "İhtiyarlara Yer Yok, Coen kardeşler yapımıdır ve dört Oscar kazanmalarını sağlamıştır. Bir başyapıt olarak kabul görmektedir. Llewelyn Moss, bir olay yerinde bulduğu çantayı alır ve başını hiç ummadığı bir belaya sokar. Artık peşinde bir kiralık katil vardır. Moss bir Vietnam gazisidir ve bir şekilde uyuşturucu olaylarının ortasında soruna dönüşen bir meseleye karışır. Peşindeki katil Anton Chigurh planı konusunda kararlıdır çünkü işini yarım bıramak niyetinde değildir. İşin için çok sayıda masum insanın ve suçluların da karışacağı soluk soluğa bir takip başlayacaktır.",
              Imdb = "8.2",
              PictureSource = "collider.com",
              TextMovieSource = "beyazperde.com"
          },
          new Oscar
          {
              Id = Guid.NewGuid(),
              Name = "Artist",
              Minute = 140,
              Url = "https://i.f1g.fr/media/figarofr/orig/2012/02/22/f8db9518-5d7e-11e1-b170-b72124fbbea9-493x328.jpg",
              Category = "Dram, Romantik",
              Year = 2011,
              Country = "Fransa",
              Trailer = "https://www.youtube.com/watch?v=YB9Oq0hn5KY",
              Age = 12,
              Starring = "Jean Dujardin, Bérénice Bejo, John Goodman",
              Creators = " Michel Hazanavicius",
              Explane = "1920'li yılların sonunda Hollywood sinema sektörünü kökünden değiştirecek 'teknolojik' bir devrim yaşandı. Ses, 'henüz hiçbir şey duymadınız' repliği ile film pelikülüne bir daha hiç ayrılmamak üzere girdi. Fakat sinema sektöründe yaşanan bu devrim boyutundaki bu değişim pek çok insanın mesleğini ve kariyerini de derinden sarstı.Dönemin en karizmatik aktörleri arasında yer alan George Valentin(Jean Dujardin) de sesin beklenmedik biçimde sinema perdesine yansımasından payına düşeni alıyor.yanı başında boy gösteren taze ve güzel oyuncu Peppy Miller'ın ise aklı fikri şöhrette.2011 Cannes Film Festivali'nin en gözde yapımlarından olan The Artist, başrol oyuncusu Jean Dujardin'e George Valentin performansı ile 'En İyi Erkek Oyuncu' ödülünü kazandırdı.Film sinema sanatının sessiz dönemine bir saygı duruşu niteliğinde diyalogsuz,sessiz,siyah - beyaz ve saniyede 22 kare ile çekildi.Altın Palmiye adayları arasında da olan filmin yazarlığını ve yönetmenliğini ise Michel Hazanavicius üstleniyor.",
              Imdb = "7.9",
              PictureSource = "lefigaro.fr",
              TextMovieSource = "beyazperde.com"
          },
          new Oscar
          {
              Id = Guid.NewGuid(),
              Name = "Parazit",
              Minute = 132,
              Url = "https://pbs.twimg.com/media/EckSb0VWsAA5KbH.jpg",
              Category = "Gerilim",
              Year = 2019,
              Country = "Kore",
              Trailer = "https://www.youtube.com/watch?v=AXn4Will3aU",
              Age = 12,
              Starring = "Song Kang-Ho, Woo-sik Choi, Park So-Dam",
              Creators = " Bong Joon Ho",
              Explane = "Park Ailesi'yle tanışın: soyla gelen servetin klasik bir tablosu. Diğer yanda ise Kim Ailesi, sokak zekası bakımından zengin ama başka hiçbir zenginliğe sahip değil. Şans veya kader olsun, bu iki ev halkı bir şekilde bir araya gelir ve Kim ailesi altın bir fırsatın varlığını hemen sezer. Kolej çağındaki Ki-woo tarafından manipülasyon konusunda yetiştirilen Kim çocukları, öğretmen ve sanat terapisti görevleriyle kendilerini Park ailesinin arasına çabucak yerleştirir. Kim'ler “vazgeçilmez” lüks hizmetler sunarken, Parklar ise habersizce evlerindeki her şeyi Kim ailesine kaybetmektedir. Ancak kısa sürede bu düzen bir tehditle karşılaşır. Asalak bir misafir Kim ailesinin yeni keşfettikleri konforu tehdit eder hale geldiğinde, vahşi ve zorlayıcı bir üstünlük mücadelesi patlak verir. Bu mücadele Kim ve Park aileleri arasındaki kırılgan ekosistemi yıkmakla tehdit etmektedir.",
              Imdb = "8.5",
              PictureSource = "twitter.com/moviegrafmg",
              TextMovieSource = "beyazperde.com"
          },
          new Oscar
          {
              Id = Guid.NewGuid(),
              Name = "Zoraki Kral",
              Minute = 118,
              Url = "https://images-na.ssl-images-amazon.com/images/S/pv-target-images/a3c6dde6684d7ef66558395e19db0af911b5c1c6062d5411598255e11b28ef83._UY500_UX667_RI_V_TTW_.jpg",
              Category = "Dram",
              Year = 2010,
              Country = "İngiltere, ABD",
              Trailer = "https://www.youtube.com/watch?v=EcxBrTvLbBM",
              Age = 12,
              Starring = "Colin Firth, Helena Bonham Carter, Derek Jacob",
              Creators = " Tom Hooper",
              Explane = "Zoraki Kral (orijinal adı: The King's Speech), Tom Hooper tarafından yönetilen ve David Seidler tarafından senaryosu yazılan 2010 tarihsel drama. Film, 2010 Toronto Uluslararası Film Festivali, People's Choice Ödülü kazandı ve on dört BAFTA (yedisini kazandı), on iki Akademi (dördünü kazandı) ve yedi Altın Küre ödülüne aday gösterildi.Rolüyle Altın Küre kazanan Colin Firth'in canlandırdığı VI. George, kekemeliğinin üstesinden gelmek için alışılmışın dışında bir konuşma terapisti Lionel Logue'a(canlandıran: Geoffrey Rush) gider.Birlikte çalışma sürecinde iki adam,arkadaş olurlar ve kardeşinin tahttan çekilmesinden sonra Kral,II.Dünya Savaşı'nın başında radyo yayını yapması konusunda Logue'a bel bağlar.David Seidler,gençliği boyunca kendi kekemeliğinin üstesinden gelmesinden sonra VI.George'u okumaya ve bilgili hayal gücünü kullanmaya başladı, erkeklerin ilişkisi hakkında yazdı. Filmin çekilmesinden dokuz hafta önce Logue'un not defteri keşfedildi ve buradaki alıntılar senaryoya dahil edildi.Ana çekimler, Aralık 2009 ile Ocak 2010'un başında Londra ile Birleşik Krallık'taki diğer mekânlarda gerçekleşti.Film,Amerika Birleşik Devletleri'nde 10 Aralık 2010 tarihinde ve Birleşik Krallık'ta 7 Ocak 2011 tarihinde gösterildi.Ağır dili nedeniyle başlarda Birleşik Krallık'ta '15' reyting ile sınıflandırıldı fakat eleştirilerden sonra bu reyting düşürüldü.Zoraki Kral,Birleşik Krallık gişesinde üst üste üç haftada en yüksek kazanan film oldu ve günümüze kadar 100 milyon İngiliz sterlininden fazla kazanç elde etti.Film,yaygın olarak görsel stil, sanat yönetmenliği ve oyunculuk alanında film eleştirmenlerinden beğeni topladı.Diğer yorumcular,filmin anlattığı tarihsel olayların temsil edilişini tartıştı.",
              Imdb = "8.0",
              PictureSource = "amazon.com",
              TextMovieSource = "wikipedia.org"
          }
          );
        }
    }
}
