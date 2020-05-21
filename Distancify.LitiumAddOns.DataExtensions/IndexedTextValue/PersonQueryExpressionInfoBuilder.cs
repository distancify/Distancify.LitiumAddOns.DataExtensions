using Litium.Application.Customers.Data;
using Litium.Application.Data.Queryable;
using Litium.Customers;
using Litium.Data.Queryable;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Distancify.LitiumAddOns.DataExtensions.IndexedTextValue
{
    internal class PersonQueryExpressionInfoBuilder : QueryExpressionInfoBuilder<Person, PersonEntity, IndexedTextValueQueryExpressionInfo>
    {
        public override Expression<Func<PersonEntity, bool>> Build(
            DbContext dbContext,
            QueryOptions<Person> options,
            IndexedTextValueQueryExpressionInfo queryExpressionInfo)
        {
            return p => p.FieldDatas.Any(r => r.Id == queryExpressionInfo.FieldId && r.IndexedTextValue == queryExpressionInfo.Value.ToLower());
        }
    }
}
