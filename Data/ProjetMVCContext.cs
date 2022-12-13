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
    }
}
