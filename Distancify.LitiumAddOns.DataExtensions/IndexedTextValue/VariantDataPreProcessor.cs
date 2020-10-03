using Litium.Application.Data;
using Litium.Application.Products.Data;
using System.Collections.Generic;

namespace Distancify.LitiumAddOns.DataExtensions.IndexedTextValue
{
    internal class VariantDataPreProcessor : BaseDataPreProcessor<VariantEntity>, IDataPreProcessor<FieldEntityBase<VariantEntity>.FieldDataEntity>
    {
        public VariantDataPreProcessor(IReadOnlyCollection<IIndexedTextField> fields)
            : base(fields)
        {
        }
    }
}
