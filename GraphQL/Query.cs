using ApiAudaces.Context;
using ApiAudaces.Models;
using HotChocolate;
using HotChocolate.Types;
using System.Linq;

namespace ApiAudaces.GraphQL
{
    public class Query
    {
        [UsePaging(SchemaType = typeof(ApiType))]
        [UseFiltering]
        public IQueryable<ApiModel> Calls([Service] DatabaseContext context)
        {
            return context.Calls;
        }
    }
}
