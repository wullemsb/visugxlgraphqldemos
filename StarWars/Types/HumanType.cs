using HotChocolate.Types;
using StarWars.Models;
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
        }
    }
}
