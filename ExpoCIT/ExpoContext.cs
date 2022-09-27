using ExpoCIT.Models;
using Microsoft.EntityFrameworkCore;

namespace ExpoCIT
{
    public class ExpoContext : DbContext
    {
        public ExpoContext(DbContextOptions<ExpoContext> options) : base (options) { }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var instertedEntries = this.ChangeTracker.Entries()
                .Where(x => x.State == EntityState.Added)
                .Select(x => x.Entity);

            foreach (var insertedEntry in instertedEntries)
            {
                var auditableEntity = insertedEntry as Auditable;

                if (auditableEntity != null)
                    auditableEntity.FechaCreado = DateTime.Now;
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
    }
}
