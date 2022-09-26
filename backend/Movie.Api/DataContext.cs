using Microsoft.EntityFrameworkCore;
using Movie.Api.Configurations;
using Movie.Api.Models.Entities;

namespace Movie.Api
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);
        //    optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=moviesite;Trusted_Connection=True;");
        //}
        public DbSet<Anasayfa> Anasayfas { get; set; }
        public DbSet<Animasyon> Animasyons { get; set; }
        public DbSet<Avrupa> Avrupas { get; set; }
        public DbSet<Dizi> Dizis { get; set; }
        public DbSet<Hollywood> Hollywoods { get; set; }
        public DbSet<Olmeden> Olmedens { get; set; }
        public DbSet<Oscar> Oscars { get; set; }
        public DbSet<Seri> Seris { get; set; }
        public DbSet<Anasayfa1> Anasayfas1 { get; set; }
        public DbSet<Animasyon1> Animasyons1 { get; set; }
        public DbSet<Avrupa1> Avrupas1 { get; set; }
        public DbSet<Dizi1> Dizis1 { get; set; }
        public DbSet<Hollywood1> Hollywoods1 { get; set; }
        public DbSet<Olmeden1> Olmedens1 { get; set; }
        public DbSet<Oscar1> Oscars1 { get; set; }
        public DbSet<Seri1> Seris1 { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new AnasayfaConfiguration());
            builder.ApplyConfiguration(new AvrupaConfiguration());
            builder.ApplyConfiguration(new AnimasyonConfiguration());
            builder.ApplyConfiguration(new DiziConfiguration());
            builder.ApplyConfiguration(new HollywoodConfiguration());
            builder.ApplyConfiguration(new OlmedenConfiguration());
            builder.ApplyConfiguration(new OscarConfiguration());
            builder.ApplyConfiguration(new SeriConfiguration());

          
            builder.ApplyConfiguration(new Avrupa1Configuration());
            builder.ApplyConfiguration(new Animasyon1Configuration());
            builder.ApplyConfiguration(new Dizi1Configuration());
            builder.ApplyConfiguration(new Hollywood1Configuration());
            builder.ApplyConfiguration(new Olmeden1Configuration());
            builder.ApplyConfiguration(new Oscar1Configuration());
            builder.ApplyConfiguration(new Seri1Configuration());


        }
    }
}
