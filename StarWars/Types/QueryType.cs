using HotChocolate.Types;
using StarWars.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarWars.Types
{
    public class QueryType: ObjectType<Query>
    {
        protected override void Configure(IObjectTypeDescriptor<Query> descriptor)
        {
            descriptor.Field(t => t.GetHuman(default))
                .Argument("id", a => a.Type<NonNullType<IdType>>());

            descriptor.Field(t => t.GetDroid(default))
                .Argument("id", a => a.Type<NonNullType<IdType>>());
        }
    }
}
