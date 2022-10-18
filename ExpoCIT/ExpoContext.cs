using ExpoCIT.Models;
using Microsoft.EntityFrameworkCore;

namespace ExpoCIT
{
    public class ExpoContext : DbContext
    {
        public ExpoContext(DbContextOptions<ExpoContext> options) : base (options) { }

        public DbSet<Juez> Jueces { get; set; }
        public DbSet<Proyecto> Proyectos { get; set; }
        public DbSet<RPEI> RPEIs { get; set; }
        public DbSet<RTEEI> RTEIs { get; set; }
        public DbSet<RPEJ> RTEJs { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var instertedEntries = this.ChangeTracker.Entries()
                .Where(x => x.State == EntityState.Added)
                .Select(x => x.Entity);

            foreach (var insertedEntry in instertedEntries)
            {
                var auditableEntity = insertedEntry as Auditable;

                if (auditableEntity != null)
                {
                    auditableEntity.FechaCreado = DateTime.Now;
                    auditableEntity.FechaModificado = DateTime.Now;
                }
            }

            var modifiedEntries = this.ChangeTracker.Entries()
                .Where(x => x.State == EntityState.Modified)
                .Select(x => x.Entity);

            foreach (var modifiedEntry in modifiedEntries)
            {
                var auditableEntity = modifiedEntry as Auditable;

                if (auditableEntity != null)
                    auditableEntity.FechaModificado = DateTime.Now;
            }

            return base.SaveChangesAsync(cancellationToken);
        }

        public override int SaveChanges()
        {
            var instertedEntries = this.ChangeTracker.Entries()
                .Where(x => x.State == EntityState.Added)
                .Select(x => x.Entity);

            foreach (var insertedEntry in instertedEntries)
            {
                var auditableEntity = insertedEntry as Auditable;

                if (auditableEntity != null)
                {
                    auditableEntity.FechaCreado = DateTime.Now;
                    auditableEntity.FechaModificado = DateTime.Now;
                }
            }

            var modifiedEntries = this.ChangeTracker.Entries()
                .Where(x => x.State == EntityState.Modified)
                .Select(x => x.Entity);

            foreach (var modifiedEntry in modifiedEntries)
            {
                var auditableEntity = modifiedEntry as Auditable;

                if (auditableEntity != null)
                    auditableEntity.FechaModificado = DateTime.Now;
            }

            return base.SaveChanges();
        }
    }
}
