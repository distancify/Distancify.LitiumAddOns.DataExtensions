using Litium.Application.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Collections.Generic;
using System.Linq;

namespace Distancify.LitiumAddOns.DataExtensions.IndexedTextValue
{
    internal class BaseDataPreProcessor<TEntity>
    {
        private ISet<string> fields;

        public BaseDataPreProcessor(IReadOnlyCollection<IIndexedTextField> fields)
        {
            this.fields = fields.Select(r => r.FieldDefinitionId).Distinct().ToHashSet();
        }

        public void PreSaveAction(DbContext dbContext, EntityEntry entityEntry, FieldEntityBase<TEntity>.FieldDataEntity item)
        {
            if (fields.Contains(item.Id)
                && (entityEntry.State == EntityState.Added || entityEntry.State == EntityState.Modified))
            {
                item.IndexedTextValue = (item.TextValue.Length > 250 ? item.TextValue.Substring(0, 250) : item.TextValue).ToLower();
                entityEntry.Property("IndexedTextValue").IsModified = true;
            }
        }
    }
}
