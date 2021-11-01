using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfwork.Interfaces;

namespace Service
{

    public interface ICoctailServiceMockService
    {
        Task<IEnumerable<Drink>> SearchDrinksByName(string name);

        Task<IEnumerable<Drink>> SearchDrinksByIngredient(string ingredient);


        Task<Drink> GetDrinkById(long idDrink);
        
    }

    public class CoctailServiceMockService : ICoctailServiceMockService
    {
        private IUnitOfWorkMockService _unitOfWorkMockService;

        public CoctailServiceMockService(IUnitOfWorkMockService unitOfWork)
        {
            _unitOfWorkMockService = unitOfWork;
        }

        public async Task<IEnumerable<Drink>> SearchDrinksByName(string name)
        {
            var records = await _unitOfWorkMockService.RepositoryMS.CoctailRepositoryMockService.GetDrinksByName(name);

            return records;
        }

        public async Task<IEnumerable<Drink>> SearchDrinksByIngredient(string ingredient)
        {
            var records = await _unitOfWorkMockService.RepositoryMS.CoctailRepositoryMockService.GetDrinksByIngredient(ingredient);

            return records;
        }

        public async Task<Drink> GetDrinkById(long idDrink)
        {
            var record = await _unitOfWorkMockService.RepositoryMS.CoctailRepositoryMockService.GetDrinkById(idDrink);

            return record;
        }
    }
}
