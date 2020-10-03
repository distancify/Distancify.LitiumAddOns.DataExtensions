using Litium.Data.Queryable;
using Litium.Data.Queryable.Internal;
using Litium.Products;

namespace Distancify.LitiumAddOns.DataExtensions.IndexedTextValue
{
    public static class VariantFilterDescriptorExtensions
    {
        public static FilterDescriptor<Variant> IndexedTextField(
          this FilterDescriptor<Variant> self,
          string fieldId,
          string value)
        {
            ((IFilterDescriptorExpression)self).AddExpression(new IndexedTextValueQueryExpressionInfo()
            {
                FieldId = fieldId,
                Value = value
            });
            return self;
        }
    }
}
