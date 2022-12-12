using Microsoft.EntityFrameworkCore;
using Projet_Jeu_Role.Models;

namespace Projet_Jeu_Role.Data
{
    public class ProjetMVCContext : DbContext
    {
        public ProjetMVCContext (DbContextOptions<ProjetMVCContext> options)
            : base(options)
        {
        }

        public DbSet<Users> Users { get; set; } = default!;
								public DbSet<Player> Player { get; set; } = default!;
								public DbSet<Situation> Situation { get; set; } = default!;
								public DbSet<Answer> Answer { get; set; } = default!;
				}
}
