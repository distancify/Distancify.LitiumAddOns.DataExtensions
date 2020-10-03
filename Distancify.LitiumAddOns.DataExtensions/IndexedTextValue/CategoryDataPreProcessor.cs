using Litium.Application.Data;
using Litium.Application.Products.Data;
using System.Collections.Generic;

namespace Distancify.LitiumAddOns.DataExtensions.IndexedTextValue
{
    internal class CategoryDataPreProcessor : BaseDataPreProcessor<CategoryEntity>, IDataPreProcessor<FieldEntityBase<CategoryEntity>.FieldDataEntity>
    {
        public CategoryDataPreProcessor(IReadOnlyCollection<IIndexedTextField> fields)
            : base(fields)
        {
        }
    }
}
