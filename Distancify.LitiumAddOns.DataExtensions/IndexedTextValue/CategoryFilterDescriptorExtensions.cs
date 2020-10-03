using Litium.Data.Queryable;
using Litium.Data.Queryable.Internal;
using Litium.Products;

namespace Distancify.LitiumAddOns.DataExtensions.IndexedTextValue
{
    public static class CategoryFilterDescriptorExtensions
    {
        public static FilterDescriptor<Category> IndexedTextField(
          this FilterDescriptor<Category> self,
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
