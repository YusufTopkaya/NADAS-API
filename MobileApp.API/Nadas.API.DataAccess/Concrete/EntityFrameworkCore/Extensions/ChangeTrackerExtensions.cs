using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Nadas.API.Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nadas.API.DataAccess.Concrete.EntityFrameworkCore.Extensions
{
    public static class ChangeTrackerExtensions
    {
        public static void SetAuditProperties(this ChangeTracker changeTracker)
        {
            var entries = changeTracker
                .Entries()
                .Where(e => e.Entity is EntityBase);

            foreach (var entityEntry in entries)
            {
                if (entityEntry.Entity is not EntityBase entity) continue;
                entity.UpdateDate = DateTime.Now;

                if (entityEntry.State == EntityState.Added)
                    entity.CreationDate = DateTime.Now;
                else if (entityEntry.State == EntityState.Deleted)
                {
                    entity.IsDeleted = true;
                    entityEntry.State = EntityState.Modified;
                }
            }
        }
    }
}
