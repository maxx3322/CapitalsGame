using CapitalsGame.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapitalsGame.Services.Data
{
    public interface ICapitalsGameRepository
    {
        IEnumerable<Country> GetCountries();
        Country GetCountry(int countryId);

        IEnumerable<Capital> GetCapitals();
        Capital GetCapital(int capitalId);

        IEnumerable<Continent> GetContinents();
        Continent GetContinent(int continentId);

        
    }
}
