using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1
{
    public class MyDbContext : DbContext
    {



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-552STJ0M\\DATACAMP_SQL;Database=Plan;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"); //conn
        }

        public DbSet<PozycjePlanu> PozycjePlanu { get; set; }
        public DbSet<Grupy> Grupy { get; set; }
        public DbSet<RealizacjaPlanu> RealizacjaPlanu { get; set; }
        public DbSet<Studenci> Studenci { get; set; }
        public DbSet<Frekwencja> Frekwencja { get; set; }
        public DbSet<ObsadaGrup> ObsadaGrup { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PozycjePlanu>()
            .HasOne(u => u.realizacjaPlanu)
            .WithOne(u => u.pozycjePlanu)
            .HasForeignKey<PozycjePlanu>(u => u.pp_ID);

            modelBuilder.Entity<PozycjePlanu>()
                .HasOne(u => u.przedmioty)
                .WithOne(u => u.pozycjePlanu)
                .HasForeignKey<PozycjePlanu>(u => u.pp_ID)
                .OnDelete(DeleteBehavior.NoAction)
                .HasConstraintName("FK_PozycjePlanu_Przedmioty_pp_ID");

            modelBuilder.Entity<RealizacjaPlanu>()
            .HasOne(u => u.grupy)
            .WithOne(u => u.realizacjaPlanu)
            .HasForeignKey<RealizacjaPlanu>(u => u.re_ppID);

            modelBuilder.Entity<RealizacjaPlanu>()
            .HasMany(u => u.frekwencja)
            .WithOne(u => u.realizacjaPlanu)
            .HasForeignKey(u => u.fr_stID)
            .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Frekwencja>()
            .HasOne(u => u.studenci)
            .WithMany(u => u.frekwencja)
            .HasForeignKey(u => u.fr_stID)
            .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Studenci>()
               .HasOne(u => u.obsadaGrup)
               .WithMany(u => u.Studenci)
               .HasForeignKey(u => u.st_ID)
               .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<ObsadaGrup>()
               .HasOne(u => u.grupy)
               .WithOne(u => u.obsadaGrup)
               .HasForeignKey<ObsadaGrup>(u => u.ob_ID);
        }
    }
}

