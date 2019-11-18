using StarWars.Data;
using StarWars.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarWars.Services
{
    public class CharacterService
    {
        private readonly CharacterRepository _repository;

        public CharacterService(CharacterRepository repository)
        {
            _repository = repository
                ?? throw new ArgumentNullException(nameof(repository));
        }

        public IEnumerable<ICharacter> GetHeros(Episode episode)
        {
            return _repository.GetHeros(episode);
        }

        public Human GetHuman(string id)
        {
            return _repository.GetHuman(id);
        }

        public Droid GetDroid(string id)
        {
            return _repository.GetDroid(id);
        }

        public IEnumerable<ICharacter> GetCharacter(string[] characterIds)
        {
            foreach (string characterId in characterIds)
            {
                ICharacter character = _repository.GetCharacter(characterId);

                yield return character;
            }
        }

        public Task<ILookup<string, ICharacter>> GetFriendsByCharacters(
            IReadOnlyList<string> characterIds)
        {
            return Task.FromResult(_repository.GetFriendsByCharacters(characterIds));
        }

        public IEnumerable<ICharacter> Search(string text)
        {
            return _repository.Search(text);
        }
    }
}
