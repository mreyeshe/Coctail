using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfwork.Interfaces;

namespace Service
{
    public interface ICoctailServiceEF
    {
        IEnumerable<Drinks> GetAll();

        IEnumerable<Drinks> SearchDrinkByName(string name);

        IEnumerable<Drinks> SearchDrinkByIngredient(string ingredient);

    }

    public class CoctailServiceEF : ICoctailServiceEF
    {
        private readonly IUnitOfWorkEF _unitOfWorkEF;

        public CoctailServiceEF(IUnitOfWorkEF unitOfWork)
        {
            _unitOfWorkEF = unitOfWork;
        }

        public IEnumerable<Drinks> SearchDrinkByName(string name)
        {
            return _unitOfWorkEF.RepositoryEF.CoctailRepositoryEF.GetAll(predicate: i => i.StrDrink == name);
        }

        public IEnumerable<Drinks> SearchDrinkByIngredient(string ingredient)
        {
            return _unitOfWorkEF.RepositoryEF.CoctailRepositoryEF.GetAll();
            //return _unitOfWorkEF.RepositoryEF.CoctailRepositoryEF.GetAll(predicate: i => i.supplies.All(c => c.Ingredient == ingredient));
        }

        public IEnumerable<Drinks> GetAll()
        {
            return _unitOfWorkEF.RepositoryEF.CoctailRepositoryEF.GetAll();
        }


    }
}
