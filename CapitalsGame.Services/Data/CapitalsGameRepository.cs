using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapitalsGame.Model;
using CapitalsGame.Services.Data;

namespace CapitalsGame.Services.Data
{
    public class CapitalsGameRepository : ICapitalsGameRepository
    {
        private readonly CapitalsGameContext _dbContext;

        public CapitalsGameRepository(CapitalsGameContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public IEnumerable<Country> GetCountries()
        {
            return _dbContext.Country.ToList();
        }

        public Country GetCountry(int countryId)
        {
            return _dbContext.Country.FirstOrDefault(c => c.CountryId == countryId);
                
                
        }

        public IEnumerable<Capital> GetCapitals()
        {
            return _dbContext.Capital.ToList();
        }

        public Capital GetCapital(int capitalId)
        {
            return _dbContext.Capital.FirstOrDefault(c => c.CapitalId == capitalId);


        }
        public IEnumerable<Continent> GetContinents()
        {
            return _dbContext.Continent.ToList();
        }

        public Continent GetContinent(int continentId)
        {
            return _dbContext.Continent.FirstOrDefault(c => c.ContinentId == continentId);


        }
    }
}

