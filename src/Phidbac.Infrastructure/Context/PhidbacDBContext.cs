using Microsoft.EntityFrameworkCore;
using Phidbac.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phidbac.Infrastructure.Context
{
    public class PhidbacDBContext : DbContext
    {
        public PhidbacDBContext(DbContextOptions options) : base (options) { }

        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // S'assure que les string soient de type varchar(150) si on a oublié de les définir
            foreach (var property in builder.Model.GetEntityTypes()
                .SelectMany(e => e.GetProperties()
                    .Where(p => p.ClrType == typeof(string))))
                property.SetColumnType("varchar(150)");

            // Permet de lier les mappings aux modeles
            builder.ApplyConfigurationsFromAssembly(typeof(PhidbacDBContext).Assembly);

            // Désactiver la suppression en cascade par défaut
            foreach (var relationship in builder.Model.GetEntityTypes()
                .SelectMany(e => e.GetForeignKeys())) relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;

            base.OnModelCreating(builder);

        }
    }
}
