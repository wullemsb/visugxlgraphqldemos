using StarWars.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarWars.Services
{
    public class SearchService
    {
        private readonly CharacterRepository _characterRepository;
        private readonly StarshipRepository _starshipRepository;

        public SearchService(CharacterRepository characterRepository, StarshipRepository starshipRepository)
        {
            _characterRepository = characterRepository;
            _starshipRepository = starshipRepository;
        }

        public IEnumerable<object> Search(string text)
        {
            foreach (var character in _characterRepository.Search(text))
            {
                yield return character;
            }
            foreach (var starship in _starshipRepository.Search(text))
            {
                yield return starship;
            }
        }
    }
}
