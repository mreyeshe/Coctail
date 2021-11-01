using Microsoft.Extensions.Configuration;
using Models;
using Newtonsoft.Json;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.MockService
{
    public class CoctailRepositoryMockService: RepositoryMockService<Root>, ICoctailRepositoryMockService
    {

        private IConfiguration _configuration;
        public CoctailRepositoryMockService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<IEnumerable<Drink>> GetDrinksByName(string name)
        {

            this._urlService = _configuration.GetValue<string>("SearchByNameUrl");
            var parameters = new Dictionary<string, string>() { { "s", name } };
            var data=await GetAsync(parameters);
            IEnumerable<Drink> resultGet = data != null ? data.drinks : new List<Drink>();
            return resultGet;
        }

        public async Task<IEnumerable<Drink>> GetDrinksByIngredient(string ingredient)
        {
            this._urlService = _configuration.GetValue<string>("SearchByIngredientUrl");
            var parameters = new Dictionary<string, string>() { { "i", ingredient } };

            var data = await GetAsync(parameters);
            IEnumerable<Drink> resultGet = data!=null? data.drinks:new List<Drink>();
            return resultGet;
        }

        public async Task<Drink> GetDrinkById(long idDrink)
        {
            this._urlService = _configuration.GetValue<string>("SearchByIdUrl");
            var parameters = new Dictionary<string, string>() { { "i", idDrink.ToString() } };

            var data = await GetAsync(parameters);
            Drink resultGet = data != null ? data.drinks.FirstOrDefault() : new Drink();
            return resultGet;
        }
    }
}
