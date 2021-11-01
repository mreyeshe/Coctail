using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    public interface ICoctailRepositoryMockService
    {
        Task<IEnumerable<Drink>> GetDrinksByName(string name);

        Task<IEnumerable<Drink>> GetDrinksByIngredient(string ingredient);

        Task<Drink> GetDrinkById(long ingredient);
    }
}
