using StarWars.Models;
using StarWars.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarWars
{
    public class Query
    {
        private readonly CharacterService _characterService;
        private readonly SearchService _searchService;

        public Query(CharacterService characterService, SearchService searchService)
        {
            _characterService = characterService;
            _searchService = searchService;
        }

        public Human GetHuman(string id)
        {
            return _characterService.GetHuman(id);
        }

        public Droid GetDroid(string id)
        {
            return _characterService.GetDroid(id);
        }

        public IEnumerable<ICharacter> GetHeros(Episode episode)
        {
            return _characterService.GetHeros(episode);
        }

        public IEnumerable<object> Search(string text)
        {
            return _searchService.Search(text);
        }
    }
}
