using GreenDonut;
using HotChocolate;
using HotChocolate.Resolvers;
using HotChocolate.Types;
using StarWars.Models;
using StarWars.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarWars.Types
{
    public class HumanType:ObjectType<Human>
    {
        protected override void Configure(IObjectTypeDescriptor<Human> descriptor)
        {
            descriptor.Interface<CharacterType>();
            descriptor.Field(d => d.Friends)
                 .Resolver(ctx => {
                     var service = ctx.Service<CharacterService>();

                     IDataLoader<string, ICharacter[]> characterDataLoader =
                       ctx.GroupDataLoader<string, ICharacter>(
                           "charactersByFriends",
                           service.GetFriendsByCharacters);

                     return characterDataLoader.LoadAsync(ctx.Parent<ICharacter>().Id);
                 }) 
                 .Type<ListType<CharacterType>>()
                 .Name("friends");
        }
    }
}
