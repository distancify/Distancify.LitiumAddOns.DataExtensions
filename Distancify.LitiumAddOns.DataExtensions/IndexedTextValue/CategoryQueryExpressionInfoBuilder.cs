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
    internal class CategoryQueryExpressionInfoBuilder : QueryExpressionInfoBuilder<Category, CategoryEntity, IndexedTextValueQueryExpressionInfo>
    {
        public override Expression<Func<CategoryEntity, bool>> Build(
            DbContext dbContext,
            QueryOptions<Category> options,
            IndexedTextValueQueryExpressionInfo queryExpressionInfo)
        {
            return p => p.FieldDatas.Any(r => r.Id == queryExpressionInfo.FieldId && r.IndexedTextValue == queryExpressionInfo.Value.ToLower());
        }
    }
}
