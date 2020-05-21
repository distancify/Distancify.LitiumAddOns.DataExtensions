using Litium.Data.Queryable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distancify.LitiumAddOns.DataExtensions.IndexedTextValue
{
    public class IndexedTextValueQueryExpressionInfo : QueryExpressionInfo
    {
        public string FieldId { get; set; }
        public string Value { get; set; }
    }
}
