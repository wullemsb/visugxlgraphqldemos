using HotChocolate.Types;
using StarWars.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarWars.Types
{
    public class CharacterType : InterfaceType<ICharacter>
    {
        protected override void Configure(IInterfaceTypeDescriptor<ICharacter> descriptor)
        {
            descriptor.Field("friends")
                .Type<ListType<CharacterType>>();
        }
    }
}
