using HotChocolate;
using HotChocolate.Types;
using StarWars.Models;
using StarWars.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarWars.Types
{
    public class DroidType : ObjectType<Droid>
    {
        protected override void Configure(IObjectTypeDescriptor<Droid> descriptor)
        {
            descriptor.Interface<CharacterType>();

            descriptor.Field(d=> d.Friends)
                .Resolver(ctx=> ctx.Service<CharacterService>()
                                   .GetCharacter(ctx.Parent<ICharacter>()
                                                    .Friends.ToArray()))
                .Type<ListType<CharacterType>>()
                .Name("friends");
        }
    }
}
