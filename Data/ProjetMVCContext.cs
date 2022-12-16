using Microsoft.EntityFrameworkCore;
using Projet_Jeu_Role.Models;

namespace Projet_Jeu_Role.Data
{
    public class ProjetMVCContext : DbContext
    {
        public ProjetMVCContext(DbContextOptions<ProjetMVCContext> options)
            : base(options) { }

        public DbSet<User> Users { get; set; } = default!;
        public DbSet<Player> Players { get; set; } = default!;
        public DbSet<Situation> Situations { get; set; } = default!;
        public DbSet<Answer> Answers { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Situation>().HasMany(s => s.Answers).WithOne(a => a.SituationEnter).HasForeignKey(s => s.SituationEnterId);
            modelBuilder.Entity<Answer>()
                .HasOne(a => a.SituationEnter)
                .WithMany(s => s.AnswerEnter)
                .HasForeignKey(s => s.SituationEnterId);

            modelBuilder.Entity<Answer>()
                .HasOne(a => a.SituationExit)
                .WithMany(s => s.AnswerExit)
                .HasForeignKey(s => s.SituationExitId)
                .OnDelete(DeleteBehavior.NoAction);

            
            modelBuilder.Entity<Situation>()
                .HasData(
                new Situation { Id = 1, SituationName = "Place du village", SituationDescription = "Place du village" },
                new Situation { Id = 2, SituationName = "Boulangerie", SituationDescription = "Boulangerie" },
                new Situation { Id = 3, SituationName = "Mairie", SituationDescription = "Mairie" },
                new Situation { Id = 4, SituationName = "Maison Johnny", SituationDescription = "Maison Johnny" },
                new Situation { Id = 5, SituationName = "Maison", SituationDescription = "Maison" }
                
            );
        }
    }
}
