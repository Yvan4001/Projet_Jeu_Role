using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
								public DbSet<Awnser> Awnser { get; set; } = default!;
				}
}
