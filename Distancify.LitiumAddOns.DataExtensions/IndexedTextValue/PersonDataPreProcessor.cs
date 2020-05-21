using Litium.Application.Customers.Data;
using Litium.Application.Data;
using Litium.FieldFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distancify.LitiumAddOns.DataExtensions.IndexedTextValue
{
    internal class PersonDataPreProcessor : IDataPreProcessor<FieldEntityBase<PersonEntity>.FieldDataEntity>
    {
        private ISet<string> fields;

        public PersonDataPreProcessor(IReadOnlyCollection<IIndexedTextField> fields)
        {
            this.fields = fields.Select(r => r.FieldDefinitionId).Distinct().ToHashSet();
        }

        public void PreSaveAction(DbContext dbContext, EntityEntry entityEntry, FieldEntityBase<PersonEntity>.FieldDataEntity item)
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
