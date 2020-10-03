using Litium.Application.Data.Queryable;
using Litium.Application.Products.Data;
using Litium.Data.Queryable;
using Litium.Products;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Distancify.LitiumAddOns.DataExtensions.IndexedTextValue
{
    internal class VariantQueryExpressionInfoBuilder : QueryExpressionInfoBuilder<Variant, VariantEntity, IndexedTextValueQueryExpressionInfo>
    {
        public override Expression<Func<VariantEntity, bool>> Build(
            DbContext dbContext,
            QueryOptions<Variant> options,
            IndexedTextValueQueryExpressionInfo queryExpressionInfo)
        {
            return p => p.FieldDatas.Any(r => r.Id == queryExpressionInfo.FieldId && r.IndexedTextValue == queryExpressionInfo.Value.ToLower());
        }
    }
}
