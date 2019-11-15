using StarWars.Data;
using StarWars.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarWars.Services
{
    public class StarshipService
    {
        private readonly StarshipRepository _repository;

        public StarshipService(StarshipRepository repository)
        {
            _repository = repository
                ?? throw new ArgumentNullException(nameof(repository));
        }

        public Starship GetStarship(string id)
        {
            return _repository.GetStarship(id);
        }

        public IEnumerable<Starship> Search(string text)
        {
            return _repository.Search(text);
        }
    }
}
