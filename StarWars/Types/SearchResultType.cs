using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarWars.Types
{
    public class SearchResultType: UnionType
    {
        protected override void Configure(IUnionTypeDescriptor descriptor)
        {
            descriptor.Name("SearchResult");
            descriptor.Type<StarshipType>();
            descriptor.Type<HumanType>();
            descriptor.Type<DroidType>();
        }
    }
}
