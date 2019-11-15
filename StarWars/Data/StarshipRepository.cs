using StarWars.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarWars.Data
{
    public class StarshipRepository
    {
        private Dictionary<string, Starship> _starships;

        public StarshipRepository()
        {
            _starships = CreateStarships().ToDictionary(t => t.Id);
        }

        public Starship GetStarship(string id)
        {
            return _starships[id];
        }

        public IEnumerable<Starship> Search(string text)
        {
            foreach (Starship starship in _starships.Values
                .Where(t => t.Name.Contains(text,
                    StringComparison.OrdinalIgnoreCase)))
            {
                yield return starship;
            }
        }

        private static IEnumerable<Starship> CreateStarships()
        {
            yield return new Starship
            {
                Id = "3000",
                Name = "TIE Advanced x1",
                Length = 9.2
            };
        }
    }
}
