using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfwork.Interfaces;

namespace Service
{

    public interface ICoctailServiceAdoNet
    {
        IEnumerable<Drinks> SearchDrinkByName(string name);

        IEnumerable<Drinks> SearchDrinkByIngredient(string ingredient);
    }

    public class CoctailServiceAdoNet: ICoctailServiceAdoNet
    {
        private IUnitOfWorkAdoNet _unitOfWorkAdoNet;

        public CoctailServiceAdoNet(IUnitOfWorkAdoNet unitOfWork)
        {
            _unitOfWorkAdoNet = unitOfWork;
        }
        public IEnumerable<Drinks> SearchDrinkByName(string name)
        {
            using (var context = _unitOfWorkAdoNet.Create())
            {
                var records = context.RepositoriesAdoNet.CoctailRepositoryAdoNet.SearchDrinkByName(name);

                return records;
            }
        }

        public IEnumerable<Drinks> SearchDrinkByIngredient(string ingredient)
        {
            using (var context = _unitOfWorkAdoNet.Create())
            {
                var records = context.RepositoriesAdoNet.CoctailRepositoryAdoNet.SearchDrinkByCategory(ingredient);

                return records;
            }
        }

    }
}
