using ApiAudaces.Models;
using HotChocolate.Types;

namespace ApiAudaces.GraphQL
{
    public class ApiType:ObjectType<ApiModel>
    {
        protected override void Configure(IObjectTypeDescriptor<ApiModel> descriptor)
        {
            descriptor.Field(x => x.Sequence).Type<StringType>();
            descriptor.Field(x => x.FoundSequence).Type<StringType>();
            descriptor.Field(x => x.Target).Type<IntType>();
            descriptor.Field(x => x.Date).Type<DateType>();
        }
    }
}
