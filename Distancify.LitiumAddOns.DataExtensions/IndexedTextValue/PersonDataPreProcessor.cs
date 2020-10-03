using Litium.Application.Customers.Data;
using Litium.Application.Data;
using System.Collections.Generic;

namespace Distancify.LitiumAddOns.DataExtensions.IndexedTextValue
{
    internal class PersonDataPreProcessor : BaseDataPreProcessor<PersonEntity>, IDataPreProcessor<FieldEntityBase<PersonEntity>.FieldDataEntity>
    {
        public PersonDataPreProcessor(IReadOnlyCollection<IIndexedTextField> fields)
            : base(fields)
        {
        }
    }
}
