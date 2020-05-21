using Litium.Customers;
using Litium.Data.Queryable;
using Litium.Data.Queryable.Internal;

namespace Distancify.LitiumAddOns.DataExtensions.IndexedTextValue
{
    public static class PersonFilterDescriptorExtensions
    {
        public static FilterDescriptor<Person> IndexedTextField(
          this FilterDescriptor<Person> self,
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
