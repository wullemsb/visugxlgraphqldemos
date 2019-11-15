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

        public Query(CharacterService characterService)
        {
            _characterService = characterService;
        }

        public Human GetHuman(string id)
        {
            return _characterService.GetHuman(id);
        }

        public Droid GetDroid(string id)
        {
            return _characterService.GetDroid(id);
        }
    }
}
